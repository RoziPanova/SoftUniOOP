using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        bool flag = true;
        public Box(double length, double width, double height)
        {
            try
            {
                if (length <= 0)
                {
                    flag=false;
                    throw new ArgumentException();
                }
                Length = length;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Length cannot be zero or negative.");
            }
            try
            {
                if (width <= 0)
                {
                    flag = false;
                    throw new ArgumentException();
                }
                Width = width;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Width cannot be zero or negative.");
            }
            try
            {
                if (height <= 0)
                {
                    flag = false;
                    throw new ArgumentException();
                }
                Height = height;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Height cannot be zero or negative.");

            }
        }
        public bool IsEverythingPositive()
        {
            return flag;
        }
        public double SurfaceArea()
        {
            if (Length == Width)
            {
                return (Length * Width) * 6;
            }
            return 2 * (Length * Width + Width * Height + Height * Length);
        }
        public double LateralSurfaceArea()
        {
            if (Length == Width)
            {
                return (Length * Width) * 4;
            }
            return 2 * Height * (Length + Width);
        }
        public double Volume()
        {
            if (Length == Width)
            {
                return Length * Length * Length;
            }
            return Length * Width * Height;
        }
    }
}
