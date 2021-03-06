using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using SocksMobile.Models;
using SocksMobile.Services;
using SocksMobile.ViewModels;

namespace SocksMobile.Services
{
    public class ServiceIoC
    {
        private IContainer container;

        public ServiceIoC()
        {
            this.RegisterDependencies();
        }

        private void RegisterDependencies()
        {
            ContainerBuilder builder = new ContainerBuilder();
            //REGISTRAMOS TODAS LAS CLASES QUE TENGAN
            //INYECCION DE DEPENDENCIAS
            builder.RegisterType<SocksViewModel>();
            builder.RegisterType<SocksDetailsViewModel>();
            builder.RegisterType<ProfileViewModel>();
            builder.RegisterType<CategoryViewModel>();
            builder.RegisterType<CategoriesViewModel>();
            builder.RegisterType<CartViewModel>();
            builder.RegisterType<ServiceSocks>();
            //CREAMOS EL CONTENEDOR
            this.container = builder.Build();
        }

        public SocksViewModel SocksViewModel
        {
            get
            {
                return
                    this.container.Resolve<SocksViewModel>();
            }
        }
        public SocksDetailsViewModel SocksDetailsViewModel
        {
            get
            {
                return
                    this.container.Resolve<SocksDetailsViewModel>();
            }
        }
        public ProfileViewModel ProfileViewModel
        {
            get
            {
                return this.container.Resolve<ProfileViewModel>();
            }
        }

        public CartViewModel CartViewModel
        {
            get
            {
                return this.container.Resolve<CartViewModel>();
            }
        }

        public CategoriesViewModel CategoriesViewModel
        {
            get
            {
                return this.container.Resolve<CategoriesViewModel>();
            }
        }

        public CategoryViewModel CategoryViewModel
        {
            get
            {
                return this.container.Resolve<CategoryViewModel>();
            }
        }
    }
}
