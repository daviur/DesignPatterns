using System;

namespace DesignPatterns.Creational.Singleton
{
    // Sealed restricts inheritance
    public sealed class LazyNonThreadSafeSingleton
    {
        private static LazyNonThreadSafeSingleton instance;

        /* 
        Private constructor ensures that only way to
        get instance is throught the GetInstance property.
        */
        private LazyNonThreadSafeSingleton()
        {
            Console.WriteLine("LazyNonThreadSafeSingleton created");
        }

        // Public property used to return the one and only intance of the class
        // Lazy initialization
        public static LazyNonThreadSafeSingleton GetInstance =>
            instance ?? (instance = new LazyNonThreadSafeSingleton());
    }
}