using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalDesignPatterns.Singleton
{
    class LazyInitializationImplementation
    {

        public static void LazyInitializingImplementing()
        {
            LazyInitialization lazyInitialization = LazyInitialization.Instance;
            lazyInitialization.PrintDetails("firstname");
            LazyInitialization lazyInitialization1 = LazyInitialization.Instance;
            lazyInitialization1.PrintDetails("secondname");
        }
    }
}

