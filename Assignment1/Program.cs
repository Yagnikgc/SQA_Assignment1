using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Program
    {
        int length, width;
        static void Main(string[] args)
        {
            new Program().Go();
        }

        public void Go()
        {
            length = getInput("Length");
            width = getInput("Width");
            Rectangle rectangle = new Rectangle(length, width);
            while (true)
            {
                Console.WriteLine("\n\t1. Get Rectangle Length\n" +
                    "\t2. Change Rectangle Length\n" +
                    "\t3. Get Rectangle Width\n" +
                    "\t4. Change Rectangle Width\n" +
                    "\t5. Get Rectangle Perimeter\n" +
                    "\t6. GetRectangle Area\n" +
                    "\t7. Exit\n");
                Console.Write("Choose an option: ");
                string option = Console.ReadLine();
                int opt;
                if(int.TryParse(option, out opt))
                {
                    if(opt == 7)
                    {
                        Console.WriteLine("Good Bye");
                        break;
                    }else if (opt > 6 || opt <= 0)
                    {
                        Console.Write("\n\tInvalid option\n\tplease enter again");
                    }
                    else
                    {
                        switch (opt)
                        {
                            case 1:
                                Console.WriteLine("Length of ractangle: " + rectangle.GetLength().ToString());
                                break;
                            case 2:
                                length = getInput("Length");
                                break;
                            case 3:
                                Console.WriteLine("Width of ractangle: " + rectangle.GetWidth().ToString());
                                break;
                            case 4:
                                width = getInput("Width");
                                break;
                            case 5:
                                Console.WriteLine("Perimeter of ractangle: " + rectangle.GetPerimeter().ToString());
                                break;
                            case 6:
                                Console.WriteLine("Area of ractangle: " + rectangle.GetArea().ToString());
                                break;
                            default:
                                throw new Exception("Invalid error in switch");
                        }
                    }
                }
                else
                {
                    Console.Write("\n\tCharacters are not allowed\n\tplease enter again");
                }
            }
        }
        public int getInput(string para)
        {
            string strVal;
            int val;
            while (true)
            {
                Console.Write("Enter "+para+": ");
                strVal = Console.ReadLine();
                if (int.TryParse(strVal, out val))
                {
                    if (val <= 0)
                    {
                        Console.Write("\n\t"+para + " can't be negative or zero\n\tplease enter again");
                    }
                    else
                        return val;
                }
                else
                {
                    Console.Write("\n\tCharacters are not allowed\n\tplease enter again");
                }
            }
        }
    }
}
