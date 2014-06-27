using dukeBox.Hubs;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace dukeBox.Controllers
{
    public class SongsController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Song> Get()
        {
            return SongQueue.Songs;
        }

        // GET api/<controller>/5
        public IEnumerable<Song> Get(string query)
        {
            var results = Subsonic.Search(query, includeArtists:false, includeAlbums:false).Cast<Song>();
            return results;
        }

        [HttpGet] 
        public void Get(int id)
        {
            SongQueue.AddSongToQueue(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void AddSongToQueue([FromBody]Song song)
        {
            SongQueue.AddSongToQueue(song);
        }

        [HttpGet]
        public void MoveSongUp(int id)
        {
            SongQueue.MoveSongUp(id.ToString());
        }

        [HttpPost]
        public void RemoveTopSong()
        {
            SongQueue.RemoveTopSong();
        }


        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}