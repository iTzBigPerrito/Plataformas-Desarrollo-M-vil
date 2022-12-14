using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClaseS3DT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            string user = "dtamayo";
            string pass = "12345";
            if (user == txtUsuario.Text && pass == txtPass.Text)
            {
                Navigation.PushAsync(new Registro(user));
            }
            else
            {
                DisplayAlert("Error", "Usuario y/o Contraseña Incorrectos", "Cerrar");
            }
        }
    }
}