using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPatterns.Singleton
{
    class EagerInitializationImplementation
    {
        public static void EagerInitializingImplementing()
        {
            EagerInitialization lazyInitialization = EagerInitialization.Instance;
            lazyInitialization.PrintDetails("firstname");
            EagerInitialization lazyInitialization1 = EagerInitialization.Instance;
            lazyInitialization1.PrintDetails("secondname");
        }
    }
}
