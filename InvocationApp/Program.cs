// See https://aka.ms/new-console-template for more information

using Castle.DynamicProxy;
using Entities;
using InvocationApp.Aspect;

var proxy = new ProxyGenerator();
var aspect = proxy
    .CreateClassProxy<Employee>(new InterceptionAspect());
aspect.Add(1,"Zeynel","KOZAK");
Console.ReadLine();