﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Threading.Tasks;

namespace LZN.Web
{
    public class DefaultModuleRegister: Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //注册当前程序集中以“Ser”结尾的类,暴漏类实现的所有接口，生命周期为PerLifetimeScope
            builder.RegisterAssemblyTypes(GetAssembly("LZN.Application")).Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(GetAssembly("LZN.Core"),GetAssembly("LZN.EntityFramwork"))
                .Where(t => t.Name.EndsWith("Respository")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(GetAssembly("LZN.Core"), GetAssembly("LZN.EntityFramwork"))
                .Where(t => t.Name.EndsWith("ContextBase")).AsImplementedInterfaces().InstancePerLifetimeScope();
            //builder.RegisterAssemblyTypes(GetAssembly("LZN.EntityFramwork"))
            //  .Where(t => t.Name.EndsWith("DbContext")).AsImplementedInterfaces().InstancePerLifetimeScope();
            //builder.RegisterAssemblyTypes(System.Reflection.Assembly.GetExecutingAssembly()).
            //    Where(t => t.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();
            //注册所有"MyApp.Repository"程序集中的类
            //builder.RegisterAssemblyTypes(GetAssembly("MyApp.Repository")).AsImplementedInterfaces();
        }

        public static Assembly GetAssembly(string assemblyName)
        {
            var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(AppContext.BaseDirectory + $"{assemblyName}.dll");
            return assembly;
        }
    }
}
