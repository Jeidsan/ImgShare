using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImgShare
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Captura : ContentPage
	{
		public Captura ()
		{
			InitializeComponent ();
		}


        private async void btnPublicar_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Desculpe", "Esta funcionalidade ainda não foi implementada.", "OK");
        }

        private async void btnMapa_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Busca();          
        }

        private async void btnCaptura_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Desculpe", "Esta funcionalidade ainda não foi implementada.", "OK");
        }
    }
}