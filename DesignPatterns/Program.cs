using DesignPatterns.FactoryPattern;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Factory Pattern

            IShapeFactory shapeFactory = new ShapeFactory();

            // Create and draw a Circle
            IShape circle = shapeFactory.CreateShape(ShapeType.Circle);
            circle.Draw();

            // Create and draw a Rectangle
            IShape rectangle = shapeFactory.CreateShape(ShapeType.Rectangle);
            rectangle.Draw();

            /* Dynamically add a new shape at runtime
             * shapeFactory.RegisterShape(ShapeType.Triangle, () => new Triangle());
             * IShape triangle = shapeFactory.CreateShape(ShapeType.Triangle);
             * triangle.Draw();
             */

            #endregion

            Console.ReadLine();
        }
    }
}
