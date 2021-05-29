using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using SocksMobile.Models;
using SocksMobile.Services;

namespace XamarinBBDD.Services
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
            builder.RegisterType<Ecommerce_socksService>();
            //builder.RegisterType<SocksViewModel>();
            //CREAMOS EL CONTENEDOR
            this.container = builder.Build();
        }

        //public SocksViewModel PersonajesViewModel
        //{
        //    get
        //    {
        //        return
        //            this.container.Resolve<SocksViewModel>();
        //    }
        //}
    }
}
