// See https://aka.ms/new-console-template for more information
using Castle.DynamicProxy;

var proxy = new ProxyGenerator();
var aspect = proxy
    .CreateClassProxy<MyClass>(new MyInterceptorAspect());
aspect.MyMethod();
Console.ReadLine();