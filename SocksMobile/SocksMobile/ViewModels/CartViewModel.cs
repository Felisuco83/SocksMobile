using SocksMobile.Base;
using SocksMobile.Models;
using SocksMobile.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocksMobile.ViewModels
{
    public class CartViewModel : ViewModelBase
    {
        private ServiceSocks ServiceSocks;

        public CartViewModel()
        {
            this.ServiceSocks = new ServiceSocks();
            Task.Run(async () =>
            {
                await this.LoadSocks();
            });
        }

        private ObservableCollection<Product_Complete> _Products;
        public ObservableCollection<Product_Complete> Products
        {
            get { return this._Products; }
            set
            {
                this._Products = value;
                OnPropertyChanged("Products");
            }
        }

        public async Task LoadSocks()
        {
            List<Product_Complete> lista = await this.ServiceSocks.GetProductCompleteAsync();
            foreach (Product_Complete product in lista) {
                product.image = "https://ecommercesocksstorage.blob.core.windows.net/socks-blobs-container/Product_" + product.Product_id + ".jpg";
            }
            //this.Products =
            //    new ObservableCollection<Product_Complete>(lista);
            var rnd = new Random();
            this.Products =
                new ObservableCollection<Product_Complete>(lista.OrderBy(x => rnd.Next()).Take(5));
        }
    }
}
