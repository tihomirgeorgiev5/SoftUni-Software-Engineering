using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle: Shape
    {

        private double height;

        private double width;
        

        public Rectangle(double height, double width)
            :base()
        {
            
            this.Height = height;
            this.Width = width;
        }

        public double Height
        {
            get { return this.height; }
            private set { this.height = value; }
        }
        public double Width
        {
            get { return this.width; }
            private set { this.width = value; }
        }

        public override double CalculatePerimeter()
        {
            return 2 * (height + width);
        }

        public override double CalculateArea()
        {
            return height * width;
        }

        public override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}
