using System;
using System.Collections.Generic;

namespace FlyWeightSample
{
    internal class ShapeObjectFactory
    {
        private readonly Dictionary<Shapes, IShape> shapes = new Dictionary<Shapes, IShape>();

        public int TotalObjectsCreated
        {
            get { return shapes.Count; }
        }

        public IShape GetShape(Shapes shapeType)
        {
            IShape shape = null;
            if (shapes.ContainsKey(shapeType))
            {
                shape = shapes[shapeType];
            }
            else
            {
                switch (shapeType)
                {
                    case Shapes.Rectangle:
                        shape = new Rectangle();
                        shapes.Add(Shapes.Rectangle, shape);
                        break;

                    case Shapes.Circle:
                        shape = new Circle();
                        shapes.Add(Shapes.Circle, shape);
                        break;

                    default:
                        throw new Exception("Factory cannot create the object specified");
                }
            }
            return shape;
        }
    }
}