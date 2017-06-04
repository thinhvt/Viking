using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Viking.Data.Models.Entities;
using Viking.Data.Models.ViewModels;

namespace Viking.Data
{
    public class ApiEndPoint
    {
        public static void Entry(Action<IMapperConfiguration> additionalMapperConfig, params Autofac.Module[] additionalModules)
        {
            Action<IMapperConfiguration> fullMapperConfig = q =>
            {
                ConfigAutoMapper(q);

                if (additionalMapperConfig != null)
                {
                    additionalMapperConfig(q);
                }
            };

            SkyWeb.DatVM.Mvc.Autofac.AutofacInitializer.Initialize(
                Assembly.GetExecutingAssembly(),
                typeof(vikingEntities),
                new MapperConfiguration(fullMapperConfig), additionalModules);
        }



        private static void ConfigAutoMapper(IMapperConfiguration config)
        {
            config.CreateMissingTypeMaps = true;
            config.CreateMap<tbl_Account, AccountViewModel>();

            config.AllowNullDestinationValues = false;
        }
    }
}
