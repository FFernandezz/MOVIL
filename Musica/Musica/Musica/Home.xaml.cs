using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace Musica
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            MyList.ItemTapped += MyList_ItemTapped;
        }

        private async void  MyList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //App.Current.MainPage = new NavigationPage(new Item());
            var video = e.Item as Video;
            await App.Current.MainPage.Navigation.PushModalAsync(new Item());
        }

        private void OnButtonClickSearch(Object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = httpClient.GetAsync("https://www.googleapis.com/youtube/v3/search?part=snippet&type=video&q=" + Buscador.Text.ToString() + "&maxResults=40&key=AIzaSyBYUuqL7xVMSmN4z0dT4aaxfPxjxqrWrWE").Result;

            string content = response.Content.ReadAsStringAsync().Result;

            var video = JObject.Parse(content);
            ObservableCollection<Video> listVideos = new ObservableCollection<Video>();

            foreach(var result in video["items"])
            {
              

                listVideos.Add(new Video
                {
                    id = result["id"]["videoId"].ToString(),
                    title = result["snippet"]["title"].ToString(),
                    description=result["snippet"]["description"].ToString(),
                    url=result["snippet"]["thumbnails"]["medium"]["url"].ToString()
                }
                
                    );
            }
            MyList.ItemsSource = listVideos;

           

        }

        public void OnButtonAdvertencia(Object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Estamos trabajando, revise la versión 2", "OK");
        }


    }
}
