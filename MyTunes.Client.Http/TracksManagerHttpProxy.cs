using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTunes.BusinessLogic.Interfaces;

namespace MyTunes.Client.Http
{
    public class TracksManagerHttpProxy : ITracksManager
    {
        public List<TrackDto> ListTracks()
        {
            throw new NotImplementedException();
        }

        public TrackDetailsDto GetTrackDetails(int id)
        {
            throw new NotImplementedException();
        }

        public TrackDetailsDto AddTrack(TrackDetailsDto trackDetailsDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteTrack(int trackId)
        {
            throw new NotImplementedException();
        }
    }
}
