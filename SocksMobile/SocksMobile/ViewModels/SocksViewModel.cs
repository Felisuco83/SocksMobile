using SocksMobile.Models;
using SocksMobile.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using SocksMobile.Base;
using System.Linq;
using SocksMobile.Views;
using Xamarin.Forms;
using System.Threading.Tasks;

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
            List<Product_Complete> lista = await this.serviceSocks.GetProductCompleteAsync();
            foreach(Product_Complete product in lista){
                product.image = "https://ecommercesocksstorage.blob.core.windows.net/socks-blobs-container/Product_" + product.Product_id + ".jpg";
            }
            this.Products =
                new ObservableCollection<Product_Complete>(lista);
            var rnd = new Random();
            this.ProductsSublist =
                new ObservableCollection<Product_Complete>(lista.OrderBy(x => rnd.Next()).Take(9));
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

        private ObservableCollection<Product_Complete> _ProductsSublist;
        public ObservableCollection<Product_Complete> ProductsSublist {
            get { return this._ProductsSublist; }
            set {
                this._ProductsSublist = value;
                OnPropertyChanged("ProductsSublist");
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

        /*public Command CargarProductos
        {
            get
            {
                return new Command(async() => {
                    List<Product> lista =
                    await this.serviceSocks.GetProductsAsync();
                    this.Products =
                    new ObservableCollection<Product_Complete>(lista);
                });
            }
        }*/

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
