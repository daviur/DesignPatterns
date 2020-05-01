using System;

namespace DesignPatterns.Creational.Singleton
{
    // Sealed restricts inheritance
    public sealed class LazyNonThreadSafeSingleton
    {
        private static LazyNonThreadSafeSingleton instance = null;

        // Public property used to return the one and only intance of the class
        public static LazyNonThreadSafeSingleton GetInstance
        {
            get
            {
                // Lazy initialization
                return instance ?? (instance = new LazyNonThreadSafeSingleton());
            }
        }

        /* 
        Private constructor ensures that only way to
        get instance is throught the GetInstance property.
        */
        private LazyNonThreadSafeSingleton()
        {
            Console.WriteLine($"LazyNonThreadSafeSingleton created");
        }
    }
}
