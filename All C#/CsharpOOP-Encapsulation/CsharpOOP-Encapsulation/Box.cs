using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP_Encapsulation
{
    public class Box
    {
        private double width;
        private double length;
        private double height;

        public Box(double width, double length, double height)
        {
            this.Width = width;
            this.Length = length;
            this.Height = height;
        }

        public double GetSurface()
        {
            return (2 * Length * Width) + (2 * Length * Height) + (2 * Width * Height);
        }

        public double GetLateralSurface()
        {
            return (2 * Length * Height) + (2 * Width * Height);
        }

        public double GetVolume()
        {
            return Width * Length * Height;
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    throw new ArgumentException("Width cannot be zero or negative.");//ArgumentException("Width cannot be zero or negative.");
                }
            }
        }
        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value > 0)
                {
                    this.length = value;
                }
                else
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value > 0)
                {
                    this.height = value;
                }
                else
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
            }
        }

    }
}
