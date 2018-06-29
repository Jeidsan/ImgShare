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
	public partial class Cadastro : ContentPage
	{
		public Cadastro ()
		{
			InitializeComponent ();
		}

        private void btnEntrar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Confirmar dados", "Dados Salvos", "Ok");
            Application.Current.MainPage = new Login();
        }
    }
}