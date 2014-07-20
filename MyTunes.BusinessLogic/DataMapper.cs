using AutoMapper;
using MyTunes.BusinessLogic.Interfaces;
using MyTunes.DataAccess;

namespace MyTunes.BusinessLogic
{
    public static class DataMapper
    {
        public static void Init()
        {
            Mapper.CreateMap<Track, TrackDto>().ForMember(m=>m.Id, c=> c.MapFrom(s=> s.TrackId));
            Mapper.CreateMap<TrackDto, Track>();

            Mapper.CreateMap<TrackDetailsDto, Track>();
            Mapper.CreateMap<Track, TrackDetailsDto>();
        }

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
