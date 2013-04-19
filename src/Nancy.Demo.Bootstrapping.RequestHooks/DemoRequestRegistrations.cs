namespace Nancy.Demo.Bootstrapping.RequestHooks
{
    using System.Collections.Generic;
    using Bootstrapper;

    public class DemoRequestRegistrations : IRequestRegistrations
    {
        public IEnumerable<TypeRegistration> TypeRegistrations
        {
            get { return new TypeRegistration[0]; }
        }

        public IEnumerable<CollectionTypeRegistration> CollectionTypeRegistrations
        {
            get
            {
                return new []
                    {
                        new CollectionTypeRegistration(typeof(IMusketeer), new []
                            {
                                typeof(AramisMusketeer),
                                typeof(AthosMusketeer),
                                typeof(PorthosMusketeer)
                            })
                    };
            }
        }

        public IEnumerable<InstanceRegistration> InstanceRegistrations
        {
            get { return new InstanceRegistration[0]; }
        }
    }
}