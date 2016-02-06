using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Musica
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            loginBtn.Text = "LOGIN";
        }

        void OnButtonClickedLogin(object sender, EventArgs arg)
        {
            //profile.RotateTo(45 + profile.Rotation);
            Navigation.PushModalAsync(new Home());
        }

    }
}
