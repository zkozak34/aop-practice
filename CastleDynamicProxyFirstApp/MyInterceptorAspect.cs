using Castle.DynamicProxy;
using Core.Interceptors;

public class MyInterceptorAspect : MethodInterceptor
{
    public override void OnBefore(IInvocation invocation)
    {
        Console.WriteLine("On before {0}", invocation.Method);
    }

    public override void OnAfter(IInvocation invocation)
    {
        Console.WriteLine("On after {0}", invocation.Method);
    }
}