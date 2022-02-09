using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Rectangle
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
            Console.Write("Input the length: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the width: ");
            width = Convert.ToInt32(Console.ReadLine());
        }
    }
}
