using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ImgShare
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            Application.Current.Properties["baseAddress"] = "http://localhost:52790/api";

            MainPage = new ImgShare.Login();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
