using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length 
        {
            get => this.length;
                 
            private set
            {
                this.ThrowIfInvalidSide(value, nameof(this.Length));

                this.length = value;
                
            }
        }
        public double Width
        {
            get => this.width;

            private set
            {
                this.ThrowIfInvalidSide(value, nameof(this.Width));

                this.width = value;

            }
        }
        public double Height
        {
            get => this.height;

            private set
            {
                this.ThrowIfInvalidSide(value, nameof(this.Height));

                this.height = value;

            }
        }

        public double CalculateVolume()
        {
            return Length * Width * Height;
        }

        //Lateral Surface Area = 2lh + 2wh
        public double CalculateLateralSurfaceArea()
        {
            return 2 * Length * Height + 2 * Width * Height;
        }

        //Surface Area = 2lw + 2lh + 2wh
        public double CalculateSurfaceArea()
        {
            return 2 * Width * Length + 2 * Length * Height + 2 * Width * Height;
        }
        private void ThrowIfInvalidSide(double value, string side)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{side} cannot be zero or negative.");

            }
            
        }
    }
}
