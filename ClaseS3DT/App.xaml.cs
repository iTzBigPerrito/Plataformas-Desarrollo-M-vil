using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClaseS3DT
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // NavigationPage() habilita la navegación entre páginas
            MainPage = new NavigationPage(new Login());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
