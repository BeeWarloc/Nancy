using System.Collections.Generic;
using System.Linq;

namespace Nancy.Demo.Bootstrapping.RequestHooks
{
    public class MainModule : NancyModule
    {
        public MainModule(IEnumerable<IMusketeer> musketeers, TheAnswer theAnswer)
        {
            Get["/"] = x =>
                {
                    var model = new
                        {
                            Musketeers = musketeers.ToArray(),
                            RequestTime = Context.Items["request-time"] as string,
                            TheAnswer = theAnswer.Value.ToString()
                        };

                    return View["home", model];
                };
        }
    }
}
