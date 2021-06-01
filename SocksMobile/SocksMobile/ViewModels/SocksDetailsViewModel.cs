using SocksMobile.Base;
using SocksMobile.Models;
using SocksMobile.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace SocksMobile.ViewModels
{
    public class SocksDetailsViewModel: ViewModelBase
    {
        ServiceSocks ServiceSocks;

        public SocksDetailsViewModel(ServiceSocks service)
        {
            this.ServiceSocks = service;
        }

        private Product_Complete _Product;
        public Product_Complete Product
        {
            get { return this._Product; }
            set
            {
                this._Product = value;
                OnPropertyChanged("Product");
            }
        }
    }
}
