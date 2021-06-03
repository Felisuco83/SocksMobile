using SocksMobile.Base;
using SocksMobile.Models;
using SocksMobile.Services;
using SocksMobile.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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

        private ObservableCollection<int> _Cantidad;
        public ObservableCollection<int> Cantidad
        {
            get { return this._Cantidad; }
            set
            {
                this._Cantidad = value;
                OnPropertyChanged("Cantidad");
            }
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

        public void RandomNumer() {
            var rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                this.Cantidad.Add(rnd.Next(1, 3));
            }
        }

        public Command SocksDetails
        {
            get
            {

                return new Command((socks) =>
                {
                    //RECIBIMOS LOS CALCETINES Y LO MANDAMOS A 
                    //OTRA VISTA/VIEWMODEL
                    //CREAMOS EL VIEWMODEL 
                    SocksDetailsViewModel viewmodel = App.ServiceLocator.SocksDetailsViewModel;
                    //CREAMOS LA VISTA
                    DetalleProductos view = new DetalleProductos();
                    view.BindingContext = viewmodel;
                    viewmodel.Product = socks as Product_Complete;
                    Application.Current.MainPage.Navigation.PushModalAsync
                    (view);
                });
            }
        }
    }
}
