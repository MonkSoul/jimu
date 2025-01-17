﻿using Autofac;
using Jimu.Module;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jimu.Client
{
    public class ClientWebModuleBase : ClientGeneralModuleBase
    {
        public ClientWebModuleBase(IConfigurationRoot jimuAppSettings) : base(jimuAppSettings)
        {
        }

        /// <summary>
        /// when web host configure
        /// </summary>
        /// <param name="app"></param>
        /// <param name="container"></param>
        public virtual void DoWebConfigure(IApplicationBuilder app, IContainer container)
        {
        }

        /// <summary>
        /// when web host configureservices
        /// </summary>
        public virtual void DoWebConfigureServices(IServiceCollection services, IContainer container)
        {
        }
    }
}
