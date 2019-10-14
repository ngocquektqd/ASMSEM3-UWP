using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Assignment.Constant;
using Assignment.Entity;

namespace Assignment.Service
{
    class SongService : ISongService
    {
        public Song PostSongFree(Song song)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Song> GetFreeSongs()
        {
            ObservableCollection<Song> songs = new ObservableCollection<Song>();
            var client = new HttpClient();
            var responseContent = client.GetAsync(ApiUrl.GET_FREE_SONG_URL).Result.Content.ReadAsStringAsync().Result;
            songs = JsonConvert.DeserializeObject<ObservableCollection<Song>>(responseContent);
            return songs;
        }
    }
}
