namespace DesignPatterns.FactoryPattern
{
    public class ShapeFactory : IShapeFactory
    {
        private readonly Dictionary<ShapeType, Func<IShape>> _shapeRegistry = new();

        public ShapeFactory()
        {
            RegisterShape(ShapeType.Circle, () => new Circle());
            RegisterShape(ShapeType.Rectangle, () => new Rectangle());
        }

        public void RegisterShape(ShapeType shapeType, Func<IShape> shapeCreator)
        {
            if (!_shapeRegistry.ContainsKey(shapeType))
            {
                _shapeRegistry[shapeType] = shapeCreator;
            }

        }

        public IShape CreateShape(ShapeType shapeType)
        {
            if (_shapeRegistry.TryGetValue(shapeType, out Func<IShape>? shapeCreator))
            {
                return shapeCreator();
            }

            throw new ArgumentException($"Shape '{shapeType}' is not registered.");
        }
    }
}
