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
	public partial class Imagem : ContentPage
	{
		public Imagem ()
		{
			InitializeComponent();    
		}

        private void btnCaptura_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Captura();
        }

        private void btnMapa_Clicked(object sender, EventArgs e)
        {            
            Application.Current.MainPage = new Busca();
        }
    }
}