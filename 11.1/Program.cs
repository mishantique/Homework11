using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace _11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа решает уравнение вида kx + b = 0\nВведите коэффициент k:");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Equation equation = new Equation(k, b);
            // Создаём экземпляр без ввода
            Equation equation12 = new Equation(k = 1, b = 2);

            Console.WriteLine("Для экземпляра equation12 {0}", equation12.Root());
            Console.WriteLine("Для экземпляра с коэффициентами с клавиатуры {0}", equation.Root());
            Console.ReadKey();

        }
    }
}
