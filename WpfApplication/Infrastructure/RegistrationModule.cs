using Autofac;
using Domain.Settings;
using Infrastructure.Settings.WindowWrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class RegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Регистрация Мемент
            builder.RegisterType<MainWindowMementoWrapper>().As<IMainWindowMementoWrapper>().As<IWindowMementoWrapperInitializer>().SingleInstance();
            base.Load(builder);
        }
    }
}