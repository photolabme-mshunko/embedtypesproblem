// See https://aka.ms/new-console-template for more information
using Abstractions;
using Autofac;
using Photoshop;
using System.ComponentModel;
using System.Runtime.InteropServices;
using utils;

Console.WriteLine("Hello, World!");
InitiInteropUsing.UseInterop();

var container = CompositionRoot.Compose();

var typeGeneric = TypeWrap<PsBlendMode>.GetEmbedInAssemblyType();
var serviceGeneric = typeof(IService<>).MakeGenericType(typeGeneric);

container.TryResolve(serviceGeneric, out var service0);
if (service0 is IService<PsBlendMode> i0)
{
    i0.Test();
}
else
{
    Console.WriteLine("Resolve with current assembly types wont work [1]");
}


container.TryResolve<IService<PsBlendMode>>(out var service1);
if (service1 is IService<PsBlendMode> i1)
{
    i1.Test();
}
else
{
    Console.WriteLine("Resolve with current assembly types wont work [2]");
}
