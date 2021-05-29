using SocksMobile.Models;
using SocksMobile.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using SocksMobile.Base;

namespace SocksMobile.ViewModels
{
    public class SocksViewModel: ViewModelBase
    {
        ServiceSocks serviceSocks;

        public SocksViewModel(ServiceSocks service)
        {
            this.serviceSocks = service;
            this.LoadSocks();
        }

        public async void LoadSocks()
        {
            List<Product> lista = await this.serviceSocks.GetProductsAsync();
            this.Products =
                new ObservableCollection<Product>(lista);
        }

        private ObservableCollection<Product> _Products;
        public ObservableCollection<Product> Products
        {
            get { return this._Products; }
            set
            {
                this._Products = value;
                OnPropertyChanged("Products");
            }
        }

        //public Command Edicion
        //{
        //    get
        //    {
        //        return new Command(() => {
        //            PersonajesEdicion view = new PersonajesEdicion();
        //            Application.Current.MainPage.Navigation.PushModalAsync(view);
        //        });
        //    }
        //}

        public Command CargarProductos
        {
            get
            {
                return new Command(async() => {
                    List<Product> lista =
                    await this.serviceSocks.GetProductsAsync();
                    this.Products =
                    new ObservableCollection<Product>(lista);
                });
            }
        }

    }
}
