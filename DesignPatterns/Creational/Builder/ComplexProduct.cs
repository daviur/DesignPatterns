using System;

namespace DesignPatterns.Creational.Builder
{
    public class ComplexProduct
    {
        public ComplexProduct()
        {
            Console.WriteLine("ComplexProduct created");
        }

        public PartA PartA
        {
            get => default;
            set
            {
                Console.WriteLine("PartA added to ComplexProduct");
            }
        }

        public PartB PartB
        {
            get => default;
            set
            {
                Console.WriteLine("PartB added to ComplexProduct");
            }
        }
    }
}
