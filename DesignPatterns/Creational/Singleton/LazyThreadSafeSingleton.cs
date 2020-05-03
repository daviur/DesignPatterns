using System;

namespace DesignPatterns.Creational.Singleton
{
    // Sealed restricts inheritance
    public sealed class LazyThreadSafeSingleton
    {
        // Lazy initialization
        private static readonly Lazy<LazyThreadSafeSingleton> Singleton =
            new Lazy<LazyThreadSafeSingleton>(() => new LazyThreadSafeSingleton());

        /* 
        Private constructor ensures that only way to
        get singleton is throught the Instance property.
        */
        private LazyThreadSafeSingleton()
        {
            Console.WriteLine("LazyThreadSafeSingleton created");
        }

        // Public property used to return the one and only singleton of the class
        public static LazyThreadSafeSingleton Instance { get; } = Singleton.Value;
    }
}