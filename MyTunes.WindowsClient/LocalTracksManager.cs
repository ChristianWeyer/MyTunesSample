using System.Collections.Generic;
using System.IO;
using MyTunes.Bootstrapping;
using MyTunes.BusinessLogic.Interfaces;
using Newtonsoft.Json;

namespace MyTunes.WindowsClient
{
    internal class LocalTracksManager
    {
        private ITracksManager tracksManager;

        public LocalTracksManager()
        {
            tracksManager = 
                SimpleServiceLocator.CreateInstance<ITracksManager>();
        }

        public List<TrackDto> LoadTracks()
        {
            const string jsonFile = "tracks.json";
            List<TrackDto> tracks;

            if (File.Exists(jsonFile))
            {
                var tracksJson = File.ReadAllText(jsonFile);
                tracks = JsonConvert.DeserializeObject<List<TrackDto>>(tracksJson);
            }
            else
            {
                tracks = tracksManager.ListTracks();

                var tracksJson = JsonConvert.SerializeObject(tracks);
                File.WriteAllText(jsonFile, tracksJson);
            }

            return tracks;
        }
    }
}
