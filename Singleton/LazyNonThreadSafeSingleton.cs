using System;

namespace Singleton
{
    // Sealed restricts inheritance
    public sealed class LazyNonThreadSafeSingleton
    {
        private static LazyNonThreadSafeSingleton _singleton;

        /* 
        Private constructor ensures that only way to
        get instance is through the Instance property.
        */
        private LazyNonThreadSafeSingleton()
        {
            Console.WriteLine("LazyNonThreadSafeSingleton created");
        }

        // Public property used to return the one and only instance of the class
        // Lazy initialization
        public static LazyNonThreadSafeSingleton Instance =>
            _singleton ??= new LazyNonThreadSafeSingleton();
    }
}