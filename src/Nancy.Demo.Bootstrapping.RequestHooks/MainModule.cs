namespace Nancy.Demo.Bootstrapping.RequestHooks
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get["/"] = x =>
                {
                    var model = new
                        {
                            RequestTime = Context.Items["request-time"] as string
                        };

                    return View["home", model];
                };
        }
    }
}
