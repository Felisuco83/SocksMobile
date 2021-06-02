using SocksMobile.Base;
using SocksMobile.Models;
using SocksMobile.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace SocksMobile.ViewModels
{
    public class SocksDetailsViewModel: ViewModelBase
    {
        ServiceSocks ServiceSocks;

        public SocksDetailsViewModel(ServiceSocks service)
        {
            this.ServiceSocks = service;
            Task.Run(async () => {
                this.Sizes = await this.ServiceSocks.GetProduct_SizesByProductAsync(this.Product.Product_id);
            });
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


        private List<Product_sizes> _Sizes;
        public List<Product_sizes> Sizes {
            get { return this._Sizes; }
            set {
                this._Sizes = value;
                OnPropertyChanged("Sizes");
            }
        }
    }
}
