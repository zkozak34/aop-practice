// See https://aka.ms/new-console-template for more information

using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Interceptors;

//var proxy = new ProxyGenerator();
//var aspect = proxy
//    .CreateClassProxy<MyClass>(new MyInterceptorAspect());
//aspect.MyMethod();

var builder = new ContainerBuilder();
builder
    .RegisterType<MyClass>().As<IMyClass>()
    .EnableInterfaceInterceptors(new ProxyGenerationOptions()
    {
        Selector = new AspectInterceptorSelector()
    })
    .InstancePerDependency();

var container = builder.Build();
var willBeInterceptor = container.Resolve<IMyClass>();
willBeInterceptor.MyMethod();

Console.ReadLine();