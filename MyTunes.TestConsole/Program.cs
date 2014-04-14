using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTunes.BusinessLogic;

namespace MyTunes.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var tracksManager = new TracksManager();

            var tracks = tracksManager.ListTracks();
            Console.WriteLine(tracks.Count);

            var track1 = tracksManager.GetTrackDetails(1);
        }
    }
}
