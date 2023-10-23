#nullable enable
using Abstractions;
using Autofac.Core;
using Photoshop;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;

namespace utils
{
    public class BaseServiceClass<T>: IService<T> where T:Enum
    {
        public T Value { get; set; }

        public virtual void Test()
        {
            Console.WriteLine($"BaseServiceClass<T> VALUE:{Value}");
        }
    }


    public class ServiceClass : BaseServiceClass<PsBlendMode>
    {
        public override void Test()
        {
            Console.WriteLine($"ServiceClass VALUE:{Value}");
        }
    }



    public class TypeWrap<T>
    {
        public static Type GetEmbedInAssemblyType()
        {
            var externalAssemblyType = typeof(T);
            var type = typeof(TypeWrap<>).Assembly.GetTypes().First(i => string.CompareOrdinal(i.FullName, externalAssemblyType.FullName) == 0);
            return type;
        }
    }
}