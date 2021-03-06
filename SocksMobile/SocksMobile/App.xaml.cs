using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SocksMobile.Services;
using SocksMobile.Views;

namespace SocksMobile
{
    public partial class App : Application
    {
        private static ServiceIoC _ServiceLocator;
        public static ServiceIoC ServiceLocator
        {
            get
            {
                return _ServiceLocator = _ServiceLocator
                    ?? new ServiceIoC();
            }
        }

        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new AppShell();
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
