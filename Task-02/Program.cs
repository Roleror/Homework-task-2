using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый член геометрической прогресии:");
            string firstnum = Console.ReadLine();
            Console.WriteLine("Введите знаменатель геометрической прогресии:");
            string secondnum = Console.ReadLine();
            Console.WriteLine("Введите желаемый член прогрессии который вы хотите узнать");
            string thirdnum = Console.ReadLine();
            double minusone = Int32.Parse(thirdnum);
            minusone = minusone - 1;
            int secondnump = Int32.Parse(secondnum);
            int thirdnump = (int)minusone;
            double firstnump = Int32.Parse(firstnum);
            double stepen = +Math.Pow(secondnump, thirdnump);
            Console.WriteLine($"Член геометрической прогресии под номером {thirdnum}:");
            Console.WriteLine(firstnump * stepen);
            Console.ReadLine();
        }
    }
}
