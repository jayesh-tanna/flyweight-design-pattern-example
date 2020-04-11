using System;

namespace FlyWeightSample
{
    internal class Circle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing Circle");
        }
    }
}