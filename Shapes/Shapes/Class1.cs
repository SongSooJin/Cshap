using System;
using System.Drawing;

namespace Shapes
{
    public class Circle
    {
        double radius;
        public Circle() {
            radius = 0;
        }
        public Circle(int r) {
            this.radius = r;
        }
        public double Area()
        {
            return Math.PI * (radius * radius);
        }
        public void Draw()
        {
            Pen p = new Pen(Color.Red);
        }
        //public Circle(double radius) {
        //    this.radius = radius;
        //}

    }
}
