using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        private List<Track> tracks = new List<Track>();
        

        public List<Track> Tracks
        {
            get { return tracks; }
        }

        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }
        

        public MusicCD()
        {
        }

        public MusicCD(string artist, short released, string title, decimal price, string imageUrl, int productId) : base(title, price, imageUrl, productId)
        {
            Artist = artist;
            Released = released;
        }

        public void AddTrack(Track track)
        {
            tracks.Add(track);
        }

        public TimeSpan GetPlayingTime()
        {
            TimeSpan total = new TimeSpan(00, 00, 00);

            foreach (Track track in Tracks)
            {
                total += track.Length;
            }
            return total;
        }

    }
}