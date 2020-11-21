using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Int16  a, b, c;

            str = Console.ReadLine();
            a = Convert.ToChar(str);

            str = Console.ReadLine();
            b = Convert.ToChar(str);

            str = Console.ReadLine();
            c = Convert.ToChar(str);

            Char resultOne = a + b + c;
            Char resultTwo = a * b * c;

            Console.WriteLine("Сумма чисел =", resultOne);
            Console.WriteLine("Произведение  чисел =", resultTwo);