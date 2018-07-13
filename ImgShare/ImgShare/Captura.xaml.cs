using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
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
        public Captura()
        {
            InitializeComponent();            
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
            try
            {
                await CrossMedia.Current.Initialize();

                if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                {
                    await DisplayAlert("Desculpe", "A câmera não está disponível.", "OK");
                    return;
                }

                var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions() {                   
                    SaveToAlbum = false,
                    PhotoSize = PhotoSize.Medium
                });

                if (file == null) return;

                imgImagem.Source = ImageSource.FromStream(() => 
                {
                    var stream = file.GetStream();
                    file.Dispose();
                    return stream;
                });
            }
            catch (Exception ex)
            {
                await DisplayAlert("Desculpe", "Ocorreu um erro durante a operação.", "OK");
            }
        }
    }
}