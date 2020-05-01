using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    class Client
    {
        public AbstractProductA AbstractProductA
        {
            get => default;
            set
            {
            }
        }

        public AbstractFactory AbstractFactory
        {
            get => default;
            set
            {
            }
        }

        public AbstractProductB AbstractProductB
        {
            get => default;
            set
            {
            }
        }
    }
}
