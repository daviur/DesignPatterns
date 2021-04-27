using System;

namespace Singleton
{
    // Sealed restricts inheritance
    public sealed class EagerThreadSafeSingleton
    {
        /* 
        Private constructor ensures that only way to
        get instance is through the Instance property.
        */
        private EagerThreadSafeSingleton()
        {
            Console.WriteLine("EagerThreadSafeSingleton created");
        }

        // Public property used to return the one and only instance of the class
        public static EagerThreadSafeSingleton Instance { get; } = new();
    }
}