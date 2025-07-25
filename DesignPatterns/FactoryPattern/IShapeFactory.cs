namespace DesignPatterns.FactoryPattern
{
    public interface IShapeFactory
    {
        IShape CreateShape(ShapeType shapeType);
        void RegisterShape(ShapeType shapeType, Func<IShape> creator);
    }
}
