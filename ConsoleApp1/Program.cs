using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {/// <summary>
     /// Задача 2. Составить программу, в результате которой величина а меняется
     /// значением с величиной b, а величина c — с величиной d.
     /// </summary>
     /// <param name="message"></param>
     /// <returns></returns>

        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());

        }/// <summary>
        /// Ввод переменных
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        
        }/// <summary>
        /// метод меняющий числа местами
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = Input("a= ");
            int b = Input("b= ");
            int c = Input("c= ");
            int d = Input("d= ");
            Console.WriteLine($"Результат: \t{a}\t{b}\t{c}\t{d}");
            Swap(ref a, ref b);
            Swap(ref c, ref d);
            Console.WriteLine($"Результат: \t{a}\t{b}\t{c}\t{d}");
            Console.ReadKey();

        }
    }
}
