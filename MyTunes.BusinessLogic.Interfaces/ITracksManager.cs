using System.Collections.Generic;

namespace MyTunes.BusinessLogic.Interfaces
{
    public interface ITracksManager
    {
        List<TrackDto> ListTracks();
        TrackDetailsDto GetTrackDetails(int id);
        TrackDetailsDto AddTrack(TrackDetailsDto trackDetailsDto);
        void DeleteTrack(int trackId);
    }
}
