// See https://aka.ms/new-console-template for more information

using Castle.DynamicProxy;
using Entities;
using InvocationApp.Aspect;

var proxy = new ProxyGenerator();
var aspect = proxy
    .CreateClassProxy<Employee>(
        new DefensiveProgrammingAspect());

var emp1 = new Employee()
{
    Id = 1,
    FirstName = "Zeynel",
    LastName = "KOZAK"
};

aspect.Add(emp1.Id,emp1.FirstName,emp1.LastName);
Console.ReadLine();