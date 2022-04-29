using Castle.DynamicProxy;
using Core.Interceptors;

namespace InvocationApp.Aspect
{
    public class InterceptionAspect : IInterceptor
    {
        private void OnBefore(IInvocation invocation)
        {
            Console.WriteLine("Before {0}", invocation.Method);
            Console.WriteLine($"{"MethodName",-20} : {invocation.Method.Name}");
            Console.WriteLine($"{"TargetType",-20} : {invocation.TargetType}");
            Console.WriteLine($"{"InvocationTarget",-20} : {invocation.InvocationTarget}");
            Console.WriteLine($"{"Proxy",-20} : {invocation.Proxy}");
            Console.WriteLine("ARGUMENTs");
            foreach (var invocationArgument in invocation.Arguments)
            {
                Console.WriteLine($"\t{"Type",-12} : {invocationArgument.GetType(),-15} | {invocationArgument}");
            }

            Console.WriteLine();
        }

        private void OnAfter(IInvocation invocation)
        {
            Console.WriteLine("After {0}", invocation.Method);
        }

        public void Intercept(IInvocation invocation)
        {
            OnBefore(invocation);
            invocation.Proceed();
            OnAfter(invocation);
        }
    }
}
