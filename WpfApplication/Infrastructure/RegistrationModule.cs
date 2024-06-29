using Autofac;
using Domain.Settings;
using Domain.Version;
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
            //Регистрация сервисов
            builder.RegisterType<AplicationVersionProvider>().As<IAplicationVersionProvider>().SingleInstance();
            base.Load(builder);
        }
    }
}