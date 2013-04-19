using System.Collections.Generic;
using System.Linq;

namespace Nancy.Demo.Bootstrapping.RequestHooks
{
    public class MainModule : NancyModule
    {
        public MainModule(IEnumerable<IMusketeer> musketeers)
        {
            Get["/"] = x =>
                {
                    var model = new
                        {
                            Musketeers = musketeers.ToArray(),
                            RequestTime = Context.Items["request-time"] as string
                        };

                    return View["home", model];
                };
        }
    }
}
