using System.Collections.Generic;
using System.Linq;

namespace Nancy.Demo.Bootstrapping.RequestHooks
{
    public class MainModule : NancyModule
    {
        public MainModule(
            IRolePlayingGame rolePlayingGame, 
            IEnumerable<IMusketeer> musketeers, 
            TheAnswer theAnswer)
        {
            Get["/"] = x =>
                {
                    var model = new
                        {
                            RolePlayingGame = rolePlayingGame.Name,
                            Musketeers = musketeers.ToArray(),
                            RequestTime = Context.Items["request-time"] as string,
                            TheAnswer = theAnswer.Value.ToString()
                        };

                    return View["home", model];
                };
        }
    }
}
