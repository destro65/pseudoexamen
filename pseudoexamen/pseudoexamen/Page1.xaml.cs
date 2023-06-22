using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pseudoexamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "uisrael";
            string contra = "2023";
            if(txtUsuario.Text==usuario && txtContrasena.Text==contra)
            {
                Navigation.PushAsync(new Page2(usuario));
            }else
            {
                DisplayAlert("Alerta", "Usuario no registrado", "Cerrar");
            }
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}