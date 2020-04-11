using System;

namespace FlyWeightSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var factoryObject = new ShapeObjectFactory();

            IShape shape = factoryObject.GetShape(Shapes.Rectangle);
            shape.Print();
            shape = factoryObject.GetShape(Shapes.Rectangle);
            shape.Print();
            shape = factoryObject.GetShape(Shapes.Rectangle);
            shape.Print();

            shape = factoryObject.GetShape(Shapes.Circle);
            shape.Print();
            shape = factoryObject.GetShape(Shapes.Circle);
            shape.Print();
            shape = factoryObject.GetShape(Shapes.Circle);
            shape.Print();

            int NumObjs = factoryObject.TotalObjectsCreated;
            Console.WriteLine("\nTotal No of Objects created = {0}", NumObjs);
            Console.ReadKey();
        }
    }
}