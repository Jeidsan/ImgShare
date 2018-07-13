using ImgShare.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

        private async void btnEntrar_Clicked(object sender, EventArgs e)
        {
            User user = new User() { Email = txtLogin.Text, Password = txtSenha.Text };

            var uri = String.Format("{0}/login", Application.Current.Properties["baseAddress"]);
            var json = JsonConvert.SerializeObject(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PostAsync(uri, content);  

            Application.Current.Properties["token"] = "teste";
            Application.Current.MainPage = new Captura();
        }
    }
}