using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Если хотите выйте из калькулятора нажмите Escape");
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            { 
                Console.Clear();
                double NumberOne, NumberTwo;
                string Operation;

                try
                {
                    Console.WriteLine("Введите 1 число");
                    NumberOne = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите 2 число");
                    NumberTwo = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Введено отнюдь не число");
                    Console.ReadLine();
                    continue;   
                }

                
                Console.WriteLine("Какую операцию хотите совершить над этими числами");
                Operation = Console.ReadLine();
                switch (Operation)
                {
                    case "+":
                        Console.WriteLine(NumberOne + NumberTwo);
                        break;
                    case "-":
                        Console.WriteLine(NumberOne - NumberTwo);
                        break;
                    case "/":
                        Console.WriteLine(NumberOne / NumberTwo);
                        break;
                    case "*":
                        Console.WriteLine(NumberOne * NumberTwo);
                        break;
                    case "%":
                        Console.WriteLine(NumberOne % NumberTwo);
                        break;
                    default:
                        Console.WriteLine("Такой операции не существует в калькуляторе");
                        break;
                }
                Console.ReadLine();
            }
            
        }
    }
}
