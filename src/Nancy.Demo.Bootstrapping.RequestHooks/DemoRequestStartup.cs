using System;
using System.Globalization;
using Nancy.Bootstrapper;

namespace Nancy.Demo.Bootstrapping.RequestHooks
{
    public class DemoRequestStartup : IRequestStartup
    {
        public void Initialize(IPipelines pipelines, NancyContext context)
        {
            context.Items["request-time"] = DateTime.UtcNow.ToString(CultureInfo.InvariantCulture);
        }
    }
}