using System.Collections.Generic;

namespace AgeOfVillagers
{
    public abstract class CompositeShape : IShape
    {
        private readonly List<IShape> components;
        protected CompositeShape()
        {
            components = new List<IShape>();
        }
        protected void AddComponent(IShape shape)
        {
            components.Add(shape);
        }

        public void Draw(GraphicsWithPen gp)
        {
            foreach (IShape item in components)
            {
                item.Draw(gp);
            }
        }
    }

}
