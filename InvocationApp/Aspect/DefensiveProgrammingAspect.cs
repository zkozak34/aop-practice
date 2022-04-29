using Castle.DynamicProxy;

namespace InvocationApp.Aspect;

public class DefensiveProgrammingAspect : IInterceptor
{
    public void Intercept(IInvocation invocation)
    {
        OnBefore(invocation);
        invocation.Proceed();
        OnAfter(invocation);
    }

    private void OnBefore(IInvocation invocation)
    {
        var parameters = invocation.Arguments;
        foreach (var parameter in parameters)
        {
            if (parameter.Equals(null))
                throw new ArgumentNullException();
        }

        Console.WriteLine("Null check has been completed for {0}", invocation.Method);
    }

    private void OnAfter(IInvocation invocation)
    {

    }
}