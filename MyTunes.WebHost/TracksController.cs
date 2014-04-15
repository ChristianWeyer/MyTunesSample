using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using MyTunes.BusinessLogic;
using MyTunes.BusinessLogic.Interfaces;

namespace MyTunes.WebHost
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
            return tracksManager.GetTrackDetails(id);
        }
    }
}