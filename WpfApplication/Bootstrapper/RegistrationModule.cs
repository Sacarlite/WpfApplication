using Autofac;
using Bootstrapper.Factory;
using Domain.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vievs;

namespace Bootstrapper
{
    public class RegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Регистрация фабрики окон
            builder.RegisterType<WindowFactory>().As<IWindowFactory>().SingleInstance();
            //TODO зарегистрировать фабрику
            //Регистрация зависимости
            builder.RegisterGeneric(typeof(WindowVievModelsFactory<>)).As(typeof(IWindowVievModelsFactory<>)).SingleInstance();
            base.Load(builder);
        }
    }
}
