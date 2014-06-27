using Microsoft.AspNet.SignalR;
using SignalRWithWebAPI.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRWithWebAPI.Songs
{
    public static class SongQueue
    {
        public static readonly List<Song> Songs = new List<Song>();
        

        public static void AddSongToQueue(Song song)
        {
            Songs.Add(song);
            var context = GlobalHost.ConnectionManager.GetHubContext<SongsHub>();
            context.Clients.All.addSongToQueue(song.Title);
        }
    }
}