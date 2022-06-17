using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Choco_Shop
{
    internal class Chocho_Shop
    {


        static void Oplata()
        {
            Console.WriteLine("Сколько шоколада купим? 1 плитка шоколада стоит 1 доллар или 3 обертки.");
            Console.WriteLine("Итак, чем оплачивать будем? Долларами или обёртками?");
            Console.WriteLine("У Вас осталось {0} долларов и {1} обёрток, но у Вас есть {2} шоколадок!");
            Console.WriteLine("1. Долларами");
            Console.WriteLine("2. Обёртками");
        }
        static void PayDollar(int[] Dollar)
        {
            int value = 0;
            for (int i = 0; i < Dollar.Length; i++)
            {
                value = (i + 1);
            }
            Console.WriteLine("Вы купили {0} плиток шоколада, прибавилось {0}, но потрачено {0} долларов!", value);
        }
        static void PayWrapper(int[] Wrapper)
        {
            int vjalue = 0;
            int value = 0;
            for (int j = 0; j < Wrapper.Length; j++)
            {
                vjalue = ((j + 1)/3);
            }
            for (int i = 0; i < Wrapper.Length; i++)
            {
                value = (i + 1);
            }
            Console.WriteLine("Вы купили {0} плиток шоколада, прибавилось {0} обёрток, но потрачено {1} обёрток!", vjalue, value);
        }
        static void Main(string[] args)
        {
            Console.Write("Сколько долларов дать? - ");
            int n = int.Parse(Console.ReadLine());
            int[] Dollar = new int[n];
            Console.Write("Сколько обёрток от шоколада дать? - ");
            int m = int.Parse(Console.ReadLine());
            int[] Wrapper = new int[m];
            while (true)
            {
                Oplata();
                char otvet = Convert.ToChar(Console.ReadLine());
                switch (otvet)
                {
                    case '1': PayDollar(Dollar); break;
                    case '2': PayWrapper(Wrapper); break;
                    default: return;
                }
            }
        }
    }
}