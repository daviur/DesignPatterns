using System;

namespace DesignPatterns.Creational.Singleton
{
    // Sealed restricts inheritance
    public sealed class LazyThreadSafeSingleton
    {
        // Lazy initialization
        private static readonly Lazy<LazyThreadSafeSingleton> instance =
            new Lazy<LazyThreadSafeSingleton>(() => new LazyThreadSafeSingleton());

        // Public property used to return the one and only instance of the class
        public static LazyThreadSafeSingleton Instance { get; } = instance.Value;

        /* 
        Private constructor ensures that only way to
        get instance is throught the GetInstance property.
        */
        private LazyThreadSafeSingleton() => Console.WriteLine($"LazyThreadSafeSingleton created");
    }
}
