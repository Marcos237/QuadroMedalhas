using Microsoft.Extensions.DependencyInjection;

namespace System.Linq
{
    internal class SystemCore_EnumerableDebugView<T>
    {
        private ServiceCollection services;

        public SystemCore_EnumerableDebugView(ServiceCollection services)
        {
            this.services = services;
        }
    }
}