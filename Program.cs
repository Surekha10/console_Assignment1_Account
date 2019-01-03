using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number 1 : ");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 : ");
            int Number2 = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Sum -1, Subtract -2, Divide -3, Multiply -4, Exit -5");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch(opt)
                {
                    case 1:
                        {
                            int Total = Number1 + Number2;
                            Console.WriteLine("Result :"+Total);
                            break;
                        }
                    case 2:
                        {
                            int Total = Number1 - Number2;
                            Console.WriteLine("Result :" + Total);
                            break;
                        }
                    case 3:
                        {
                            if (Number2 > 0)
                            {
                                int Total = Number1 / Number2;
                                Console.WriteLine("Result :" + Total);
                            }
                            else
                            {
                                Console.WriteLine("Wrong Number");
                            }
                            break;
                        }
                    case 4:
                        {
                            int Total = Number1 * Number2;
                            Console.WriteLine("Result :" + Total);
                            break;
                        }
                    case 5:
                        {
                            flag = false;
                            break;
                        }
                    
                }
            }
        }
    }
}
