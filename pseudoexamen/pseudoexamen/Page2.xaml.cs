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
    public partial class Page2 : ContentPage
    {
        string usuario;
        public Page2(string usuario)
        {
            InitializeComponent();
            lblusuario.Text = "Usuario conectado:" + usuario;
        }

        private void txtdato_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Rango del 1 al 100
            try
            {
                double dato = Convert.ToDouble(txtdato.Text);
                if(dato >100)
                {
                    DisplayAlert("Alerta","Dato fuera de rango","Cerrar");
                    txtdato.Text = "";
                }
            }
            catch (Exception)
            {
                                
            }
            

            
        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {
            double dato = Convert.ToDouble(txtdato.Text);
            string estudiante = pkEstudiantes.Items[pkEstudiantes.SelectedIndex];
            Navigation.PushAsync(new Page3(usuario, dato, estudiante));
        }
    }
}