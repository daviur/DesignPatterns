using System;

namespace DesignPatterns.Creational.Builder
{
    public class ComplexProduct
    {
        private PartA _partA;
        private PartB _partB;

        public ComplexProduct()
        {
            Console.WriteLine("ComplexProduct created");
        }

        public PartA PartA
        {
            set
            {
                _partA = value ?? throw new ArgumentNullException(nameof(value));
                Console.WriteLine("PartA added to ComplexProduct");
            }
        }

        public PartB PartB
        {
            set
            {
                _partB = value ?? throw new ArgumentNullException(nameof(value));
                Console.WriteLine("PartB added to ComplexProduct");
            }
        }
    }
}