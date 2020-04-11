using System;

namespace FlyWeightSample
{
    internal class Rectangle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing Rectangle");
        }
    }
}