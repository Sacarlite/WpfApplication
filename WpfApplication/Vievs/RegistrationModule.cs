using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VievModel.Windows;
using Vievs.Window;
using Vievs.Windows.MainWindow;

namespace Vievs
{
    public class RegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Регистрация окон
            //Регистрация главного окна
            builder.RegisterType<MainWindow>().As<IMainWindow>().InstancePerDependency();
            //TODO Зарегистрировать окна
            //Регистрация менеджеров
            //Регистрация менеджера окон
            builder.RegisterType<WindowManager>().As<IWindowManager>().InstancePerDependency();
            //TODO Зарегистрировать менеджер
            base.Load(builder);
        }
    }
}
