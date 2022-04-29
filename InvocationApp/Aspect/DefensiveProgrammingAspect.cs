using Castle.DynamicProxy;
using Core.Interceptors;

namespace InvocationApp.Aspect;

public class DefensiveProgrammingAspect : MethodInterceptor
{
    public override void OnBefore(IInvocation invocation)
    {
        var parameters = invocation.Arguments;
        foreach (var parameter in parameters)
        {
            if (parameter.Equals(""))
                throw new ArgumentNullException();
        }

        Console.WriteLine("Null check has been completed for {0}", invocation.Method);
    }

    public override void OnAfter(IInvocation invocation)
    {
        Console.WriteLine("Completed.");
    }
}