using Abstractions;
using Autofac;
using Photoshop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace utils
{
    public static class CompositionRoot
    {
        public static IContainer Compose()
        {
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyTypes(typeof(CompositionRoot).Assembly, typeof(IService<>).Assembly)
                .AsClosedTypesOf(typeof(BaseServiceClass<>))
                .AsImplementedInterfaces();


            return builder.Build();
        }
    }
}
