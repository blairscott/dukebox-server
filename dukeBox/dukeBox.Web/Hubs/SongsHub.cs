using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace dukeBox.Hubs
{
    public class SongsHub : Hub
    {
        public void AddSongToQueue(Song song)
        {
            Clients.All.addSongToQueue(song);
        }

        public void SwapSongs(int bottomSong, int topSong)
        {
            Clients.All.swapSongs(bottomSong, topSong);
        }

        public void RemoveSongFromQueue(int index)
        {
            Clients.All.removeSongFromQueue(index);
        }
    }
}