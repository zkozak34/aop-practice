using Castle.DynamicProxy;

public class MyInterceptorAspect : IInterceptor
{
    public void Intercept(IInvocation invocation)
    {
        Console.WriteLine("Before {0}", invocation.Method);
        invocation.Proceed();
        Console.WriteLine("After {0}", invocation.Method);
    }
}