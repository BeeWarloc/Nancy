namespace Nancy.Demo.Bootstrapping.RequestHooks
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get["/"] = x => View["home"];
        }
    }
}
