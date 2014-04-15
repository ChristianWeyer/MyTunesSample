using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using MyTunes.Bootstrapping;
using MyTunes.BusinessLogic;
using MyTunes.BusinessLogic.Interfaces;

namespace MyTunes.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //var tracksManager = new TracksManager();

            //var tracks = tracksManager.ListTracks();
            //Console.WriteLine(tracks.Count);

            //var track1 = tracksManager.GetTrackDetails(1);

            var tm = SimpleServiceLocator.CreateInstance<ITracksManager>();
        }
    }
}
