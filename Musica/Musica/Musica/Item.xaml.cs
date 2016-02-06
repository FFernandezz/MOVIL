using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Musica
{
    public partial class Item : ContentPage

    {
        //private Video myvideo;
        public Item()
        {
            InitializeComponent();
            //this.myvideo = video;
            //NavigationPage.SetHasBackButton(this, false);
            //var des = myvideo.description.ToString();
            Descripcion.Text = "Esta es la descripción del video de youtube.";
            
        }

        public void OnButtonAdvertencia(Object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Estamos trabajando, revise la versión 2", "OK");
        }
    }
}
