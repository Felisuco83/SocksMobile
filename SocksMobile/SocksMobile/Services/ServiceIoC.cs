﻿using Autofac;
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
    }
}
