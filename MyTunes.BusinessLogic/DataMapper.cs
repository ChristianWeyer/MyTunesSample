using MyTunes.BusinessLogic.Interfaces;
using MyTunes.DataAccess;

namespace MyTunes.BusinessLogic
{
    public static class DataMapper
    {
        public static TrackDetailsDto ToDetailsDto(this Track track)
        {
            return new TrackDetailsDto
            {
                Id = track.TrackId,
                Name = track.Name,
                Composer = track.Composer,
                Duration = track.Milliseconds,
                Size = track.Bytes
            };
        }

        public static Track ToTrack(this TrackDetailsDto trackDetailsDto)
        {
            return new Track
            {
                Name = trackDetailsDto.Name,
                Bytes = trackDetailsDto.Size,
                Milliseconds = trackDetailsDto.Duration,
                Composer = trackDetailsDto.Composer
            };
        }
    }
}
