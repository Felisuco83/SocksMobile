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
    public class ProfileViewModel : ViewModelBase
    {
        private ServiceSocks ServiceSocks;
        private int iduser = 519874581;


        //CONSTRUCTOR
        public ProfileViewModel()
        {
            this.ServiceSocks = new ServiceSocks();
            Task.Run(async () =>
            {
                await this.CargarUsuario();
                //await this.CargarNombre();
                await this.LoadSocks();
            });
        }


        //VARIABLES
        private Users _User;
        public Users User
        {
            private set
            {
                if (_User != value)
                {
                    this._User = value;
                    OnPropertyChanged("Users");
                }
            }
            get { return this._User; }
        }

        private String name;
        public string Name
        {
            private set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
            get
            {
                return name;
            }
        }
        private String apellido;
        public string Apellido
        {
            private set
            {
                if (apellido != value)
                {
                    apellido = value;
                    OnPropertyChanged("Apellido");
                }
            }
            get
            {
                return apellido;
            }
        }
        //public async Task CargarNombre()
        //{
        //    this.Name = "Pepito Palotes";
        //}
        //public async Task CargarNombreUser()
        //{
        //    this.User.Users_name = "Pedro almendros";
        //}

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
        public ObservableCollection<Product_Complete> ProductsSublist
        {
            get { return this._ProductsSublist; }
            set
            {
                this._ProductsSublist = value;
                OnPropertyChanged("ProductsSublist");
            }
        }

        //METODOS
        public async Task CargarUsuario()
        {
            if (User == null)
            {
                Users usuario = await this.ServiceSocks.GetUserAsync(iduser);
                this.User = usuario;
                this.Name = usuario.Users_name;
                this.Apellido = usuario.Users_lastName;
            }
        }


        public async Task LoadSocks()
        {
            List<Favorite> favorites = await this.ServiceSocks.GetUserFavoritesAsync(iduser);
            List<int> idFavorites = favorites.Select(x => x.Favorite_id).ToList();

            List<Product_Complete> lista = await this.ServiceSocks.GetProductCompleteAsync();
            foreach (Product_Complete product in lista)
            {
                product.image = "https://ecommercesocksstorage.blob.core.windows.net/socks-blobs-container/Product_" + product.Product_id + ".jpg";
            }
            this.Products =
                new ObservableCollection<Product_Complete>(lista);
            //var rnd = new Random();
            var productosFinal = lista.Where(i => idFavorites.Contains(i.Product_id)).ToList();
            this.ProductsSublist = new ObservableCollection<Product_Complete>(productosFinal);
        }
    }
}
