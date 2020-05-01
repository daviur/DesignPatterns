using System;

namespace DesignPatterns.Creational.Singleton
{
    // Sealed restricts inheritance
    public sealed class EagerThreadSafeSingleton
    {
        // Public property used to return the one and only intance of the class
        public static EagerThreadSafeSingleton GetInstance { get; } = new EagerThreadSafeSingleton();

        /* 
        Private constructor ensures that only way to
        get instance is throught the GetInstance property.
        */
        private EagerThreadSafeSingleton()
        {
            Console.WriteLine($"EagerThreadSafeSingleton created");
        }
    }
}
