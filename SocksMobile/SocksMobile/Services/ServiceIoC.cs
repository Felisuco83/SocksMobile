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
<<<<<<< HEAD
            builder.RegisterType<ProfileViewModel>();
=======
>>>>>>> fb9bd38aadb059309ad91896593ae0952fa1208c
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
<<<<<<< HEAD
=======

>>>>>>> fb9bd38aadb059309ad91896593ae0952fa1208c
        public SocksDetailsViewModel SocksDetailsViewModel
        {
            get
            {
                return
                    this.container.Resolve<SocksDetailsViewModel>();
            }
        }
<<<<<<< HEAD
        public ProfileViewModel ProfileViewModel
        {
            get
            {
                return this.container.Resolve<ProfileViewModel>();
            }
        }
=======
>>>>>>> fb9bd38aadb059309ad91896593ae0952fa1208c
    }
}
