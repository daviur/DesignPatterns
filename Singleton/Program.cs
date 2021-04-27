using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton
            Parallel.Invoke(
                CreateLazyNonThreadSafeSingleton,
                CreateLazyNonThreadSafeSingleton,
                CreateEagerThreadSafeSingleton,
                CreateEagerThreadSafeSingleton,
                CreateLazyThreadSafeSingleton,
                CreateLazyThreadSafeSingleton
            );
        }

        private static void CreateLazyNonThreadSafeSingleton()
        {
            var unused = LazyNonThreadSafeSingleton.Instance;
        }

        private static void CreateEagerThreadSafeSingleton()
        {
            var unused = EagerThreadSafeSingleton.Instance;
        }

        private static void CreateLazyThreadSafeSingleton()
        {
            var unused = LazyThreadSafeSingleton.Instance;
        }
    }
}
