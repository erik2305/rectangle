using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public void GetLength()
        {
            Console.Write("The length is: " + length);
        }
        public int SetLength(int length)
        {
            Console.Write("Input the new length: ");
            length = Convert.ToInt32(Console.ReadLine());
            return length;
        }
        public void GetWidth()
        {
            Console.Write("The width is: " + width);
        }
        public int SetWidth(int width)
        {
            Console.Write("Input the new width: ");
            width = Convert.ToInt32(Console.ReadLine());
            return width;
        }
        public void GetPerimeter()
        {
            Console.WriteLine("Perimeter is: " + (2 * width + 2 * length));
        }
        public void GetArea()
        {
            Console.WriteLine("Area is: " + (width * length));
        }
    }
}
