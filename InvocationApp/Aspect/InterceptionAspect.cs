using Castle.DynamicProxy;

namespace InvocationApp.Aspect
{
    public class InterceptionAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            OnBefore(invocation);
            invocation.Proceed();
            OnAfter(invocation);
        }
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

        private static void OnAfter(IInvocation invocation)
        {
            Console.WriteLine("After {0}", invocation.Method);
        }
    }
}
