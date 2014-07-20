using MyTunes.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace MyTunes.Client.Http
{
    public class TracksManagerHttpProxy : ITracksManager
    {
        private HttpClient httpClient;

        public TracksManagerHttpProxy()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost/mytunes/");
        }

        public List<TrackDto> ListTracks()
        {
            var response = httpClient.GetAsync("tracks").Result;
            var result = response.Content.ReadAsAsync<List<TrackDto>>().Result;

            return result;
        }

        public TrackDetailsDto GetTrackDetails(int id)
        {
            var response = httpClient.GetAsync("tracks?id=" + id).Result;
            var result = response.Content.ReadAsAsync<TrackDetailsDto>().Result;

            return result;
        }

        public TrackDetailsDto AddTrack(TrackDetailsDto trackDetailsDto)
        {
            var response = httpClient.PostAsJsonAsync("tracks", trackDetailsDto).Result;
            var result = response.Content.ReadAsAsync<TrackDetailsDto>().Result;

            return result;
        }

        public void DeleteTrack(int id)
        {
            httpClient.DeleteAsync("tracks?id=" + id);
        }
    }
}
