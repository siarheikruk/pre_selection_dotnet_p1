﻿//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double a, b;
            char z;
            Console.WriteLine("Введите a ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите действие (+, -, *, /) ");
            z = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите b ");
            b = Convert.ToDouble(Console.ReadLine());
            switch (z)
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2}", a, b, a + b);
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}", a, b, a - b);
                    break;
                case '*':
                    Console.WriteLine("{0}*{1}={2}", a, b, a * b);
                    break;
                case '/':
                    Console.WriteLine("{0}/{1}={2}", a, b, a / b);
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            Console.ReadLine();
        }
    }
}