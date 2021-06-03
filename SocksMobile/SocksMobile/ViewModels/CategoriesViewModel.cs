using SocksMobile.Base;
using SocksMobile.Models;
using SocksMobile.Services;
using SocksMobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SocksMobile.ViewModels
{
    public class CategoriesViewModel: ViewModelBase
    {
        ServiceSocks serviceSocks;

        public CategoriesViewModel(ServiceSocks service)
        {
            this.serviceSocks = service;
        }
        public Command ViewCategory
        {
            get
            {

                return new Command(async(category) =>
                {
                    //RECIBIMOS LOS CALCETINES Y LO MANDAMOS A 
                    //OTRA VISTA/VIEWMODEL
                    //CREAMOS EL VIEWMODEL 
                    CategoryViewModel viewmodel = App.ServiceLocator.CategoryViewModel;
                    //CREAMOS LA VISTA
                    CategoryView view = new CategoryView();
                    view.BindingContext = viewmodel;
                    viewmodel.Category = int.Parse(category.ToString());
                    List<Product_Complete> lista = await this.serviceSocks.GetProductCompleteByCategoryAsync(int.Parse(category.ToString()));
                    foreach (Product_Complete product in lista)
                    {
                        product.image = "https://ecommercesocksstorage.blob.core.windows.net/socks-blobs-container/Product_" + product.Product_id + ".jpg";
                    }
                    viewmodel.Products = new System.Collections.ObjectModel.ObservableCollection<Product_Complete>(lista);
                    await Application.Current.MainPage.Navigation.PushModalAsync(view);
                });
            }
        }
    }
}