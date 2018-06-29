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
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

        private void btnEntrar_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Cadastro();
            //DisplayAlert("Login", "Login e senha Incorreto","Ok");
        }
    }
}