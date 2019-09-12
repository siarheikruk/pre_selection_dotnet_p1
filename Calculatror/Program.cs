using System;

namespace Calculatror
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long a, b;
            char z;

            Console.WriteLine("Введите целое число");
            a = ReadLine();

            Console.WriteLine("Введите оператор (+, -, *, /) ");
            z = ReadOperator();

            Console.WriteLine("Введите второе целое число");
            b = ReadLine();

            Calculate(a, b, z);

            Console.ReadLine();

        }

        /// <summary>
        /// Производит калькуляции с двумя целыми числами
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <param name="z">Оператор</param>
        private static void Calculate(long a, long b, char z)
        {
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
                    Console.WriteLine("Что-то пошло не так...");
                    break;
            }
        }
        
        /// <summary>
        /// Читает введенный оператор
        /// </summary>
        /// <returns>Возвращает оператор</returns>
        private static char ReadOperator()
        {
            return Convert.ToChar(Console.ReadLine());
        }

        /// <summary>
        /// Читает введенное целое число
        /// </summary>
        /// <returns>Возвращает целое число</returns>
        private static long ReadLine()
        {
            return Convert.ToInt64(Console.ReadLine());
        }
    }
}