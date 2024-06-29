using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VievModel.VievModels.MainVievModel;

namespace VievModel
{
    public class RegistrationModule : Module
    {
        //Регистрация VievModels
        protected override void Load(ContainerBuilder builder)
        {
            //Регистрация VievModels окон
            builder.RegisterType<MainVievModel>().As<IMainVievModel>()
               .InstancePerDependency();
            //TODO зарегистрировать окна
            base.Load(builder);
        }
    }
}
