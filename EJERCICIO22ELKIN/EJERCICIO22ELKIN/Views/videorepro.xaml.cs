using EJERCICIO22ELKIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xam.Forms.VideoPlayer;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EJERCICIO22ELKIN.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class videorepro : ContentPage
    {
        public videorepro(Models.videorecord recor)
        {
            InitializeComponent();
            datos(recor);
        }

        private async void btnatras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void datos(videorecord video)
        {
            lbldescripcion.Text = video.descripcion;
            UriVideoSource uriVideoSurce = new UriVideoSource()
            {
                Uri = video.uri
            };
            recor.Source = uriVideoSurce;
        }
    }
}