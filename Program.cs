using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KONSOL_ARKA_PLAN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string renk;
            Console.WriteLine("Lütfen bir renk belirtin: mavi yeşil kırmızı sarı ");
            renk = Console.ReadLine();
            switch (renk)
            {
                case "mavi":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    break;
                case "yeşil":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                    break;
                case "kırmızı":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    break;
                case "sarı":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Böyle bir renk yok!");
                    break;
            }
        }
    }
}
