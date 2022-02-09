using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            int width = 0;
            while (true)
            {
                Console.Clear();
                Console.Write("Input the length: ");
                try
                {
                    length = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("length must be integer");
                }
                Console.Write("Input the width: ");
                try
                {
                    width = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("width must be integer");
                }
                if (length <=0 || width <= 0)
                {
                    Console.WriteLine("length and width should be grater than zero");
                }
                Console.ReadLine();
                break;
            }
            while (true)
            {
                Rectangle rectangle = new Rectangle(length, width);
                int menu = 0;
                Console.Clear();
                Console.Write("1. Get Rectangle Length" + '\n' +
                    "2. Change Rectangle Length " + '\n' +
                    "3. Get Rectangle Width " + '\n' +
                    "4. Change Rectangle Width " + '\n' +
                    "5. Get Rectangle Perimeter " + '\n' +
                    "6. Get Rectangle Area " + '\n' +
                    "7. Exit" + '\n' +
                    "Your Option is: ");
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("input must be a number");
                }
                switch (menu)
                {
                    case 1:
                        rectangle.GetLength();
                        break;
                    case 2:
                        try
                        {
                            length = rectangle.SetLength(length);
                        }
                        catch
                        {
                            Console.WriteLine("input must be a number");
                        }
                        while (true)
                        {
                            if (length < 1)
                            {
                                Console.WriteLine("Input positive value");
                                Console.ReadLine();
                                length = rectangle.SetLength(length);
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;
                    case 3:
                        rectangle.GetWidth();
                        break;
                    case 4:
                        try
                        {
                            width = rectangle.SetWidth(width);
                        }
                        catch
                        {
                            Console.WriteLine("input must be a number");
                        }
                        while(true)
                        {
                            if (width <1)
                            {
                                Console.WriteLine("Input positive value");
                                Console.ReadLine();
                                width = rectangle.SetWidth(width);
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;
                    case 5:
                        rectangle.GetPerimeter();
                        break;
                    case 6:
                        rectangle.GetArea();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Input Number in the range from 1 to 7");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
