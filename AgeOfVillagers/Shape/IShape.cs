using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public interface IShape
    {
        void Draw(GraphicsWithPen gp);
    }

    public class Line : IShape
    {
        private readonly Point point1, point2;
        public Line(Point p1, Point p2)
        {
            point1 = p1;
            point2 = p2;
        }

        public void Draw(GraphicsWithPen gp)
        {
            gp.GetGraphics()
                .DrawLine(gp.GetPen(), point1, point2);
        }
    }

    public class Arc : IShape
    {
        private readonly Point _topLeft, _bottomRight;
        private readonly float _startAngle, _endAngle;
        private int width, height;
        public Arc(Point topLeft, Point bottomRight, float startAngle, float endAngle)
        {
            _topLeft = topLeft;
            _bottomRight = bottomRight;
            _startAngle = startAngle;
            _endAngle = endAngle;

            width = Math.Abs(bottomRight.X - topLeft.X);
            height = Math.Abs(bottomRight.Y - topLeft.Y);
        }

        public void Draw(GraphicsWithPen gp)
        {
            gp.GetGraphics()
                .DrawArc(gp.GetPen(), _topLeft.X, _topLeft.Y, width, height, _startAngle, _endAngle);
        }
    }
}
