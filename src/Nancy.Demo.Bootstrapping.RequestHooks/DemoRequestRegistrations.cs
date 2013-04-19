namespace Nancy.Demo.Bootstrapping.RequestHooks
{
    using System.Collections.Generic;
    using Bootstrapper;

    public class DemoRequestRegistrations : IRequestRegistrations
    {
        public IEnumerable<TypeRegistration> TypeRegistrations
        {
            get
            {
                return new[]
                    {
                        new TypeRegistration(typeof (IRolePlayingGame), typeof (DungeonsAndDragons))
                    };
            }
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
            get
            {
                return new[]
                    {
                        new InstanceRegistration(typeof (TheAnswer), new TheAnswer {Value = 42})
                    };
            }
        }
    }
}