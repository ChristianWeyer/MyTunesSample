using AutoMapper.QueryableExtensions;
using MyTunes.BusinessLogic.Interfaces;
using MyTunes.DataAccess;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MyTunes.BusinessLogic
{
    /// <summary>
    /// 
    /// </summary>
    public class TracksManager : ITracksManager
    {
        public TracksManager()
        {
            // TODO: move into Bootstrapper...
            DataMapper.Init();
        }

        public List<TrackDto> ListTracks()
        {
            using (var db = new MyTunesDatabaseContext())
            {
                // TODO: Remove hard-wired "paging"
                var tracks = db.Tracks.Take(20).Project().To<TrackDto>().ToList();

                return tracks;
            }
        }

        public TrackDetailsDto GetTrackDetails(int id)
        {
            using (var db = new MyTunesDatabaseContext())
            {
                var track = db.Tracks
                    .FirstOrDefault(t => t.TrackId == id).ToDetailsDto();

                return track;
            }
        }

        public TrackDetailsDto AddTrack(TrackDetailsDto trackDetailsDto)
        {
            using (var db = new MyTunesDatabaseContext())
            {
                var entity = trackDetailsDto.ToTrack();
                entity.MediaTypeId = 1;

                db.Entry(entity).State = EntityState.Added;
                db.SaveChanges();

                return entity.ToDetailsDto();
            }
        }

        public void DeleteTrack(int trackId)
        {
            using (var db = new MyTunesDatabaseContext())
            {
                var entity = new Track { TrackId = trackId };
                
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}
