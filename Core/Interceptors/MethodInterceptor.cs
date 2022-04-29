using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace Core.Interceptors
{
    public class MethodInterceptor : MethodInterceptionBaseAttribute
    {
        public override void Intercept(IInvocation invocation)
        {
            bool successFlag = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                successFlag = false;
                OnException(invocation, e);
                throw;
            }
            finally
            {
                if (successFlag) 
                    OnSuccess(invocation);
            }
            OnAfter(invocation);
        }
        public virtual void OnBefore(IInvocation invocation) {}
        public virtual void OnAfter(IInvocation invocation) {}
        public virtual void OnException(IInvocation invocation, Exception e) {}
        public virtual void OnSuccess(IInvocation invocation) {}
    }
}
