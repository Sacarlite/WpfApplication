using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //TODO Зарегистрировать менеджер
        }
    }
}
