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
    public class CategoryViewModel: ViewModelBase
    {
        ServiceSocks serviceSocks;

        public CategoryViewModel(ServiceSocks service)
        {
            this.serviceSocks = service;
            this.Category = 0;
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

        private int _Category;
        public int Category
        {
            get { return this._Category; }
            set
            {
                this._Category = value;               
                OnPropertyChanged("Category");
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
