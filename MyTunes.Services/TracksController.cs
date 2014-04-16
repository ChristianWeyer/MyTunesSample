using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using MyTunes.BusinessLogic;
using MyTunes.BusinessLogic.Interfaces;

namespace MyTunes.Services
{
    public class TracksController : ApiController
    {
        private ITracksManager tracksManager;

        public TracksController()
        {
            tracksManager = new TracksManager();
        }

        // List tracks
        public List<TrackDto> Get()
        {
            return tracksManager.ListTracks();
        }

        // Get track details
        public TrackDetailsDto Get(int id)
        {
            try
            {
                var result = tracksManager.GetTrackDetails(id);

                if (result == null)
                {
                    throw new HttpResponseException(HttpStatusCode.NotFound);
                }

                return result;
            }
            catch (NullReferenceException)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        public TrackDetailsDto Post(TrackDetailsDto trackDetailsDto)
        {
            return tracksManager.AddTrack(trackDetailsDto);
        }

        public void Delete(int id)
        {
            tracksManager.DeleteTrack(id);
        }
    }
}