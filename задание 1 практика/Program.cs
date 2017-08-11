using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace задание_1_практика
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int [100, 100];
            int igrok = 1;
            int x;
            int y;
            Random rand = new Random();
            FileStream file1 = new FileStream("INPUT.TXT", FileMode.Open); //создаем файловый поток 

            x = rand.Next(0, 100);
            y = rand.Next(0, 100);

            Console.WriteLine("Координаты начальной клетки " + (x + 1) + " и " + (y + 1));

            while ((x==0) || (y==0))
            {
                if ((x!=0) & (y!=0))
                {
                    x = x - 1;
                    y = y - 1;
                    if (igrok == 1) igrok = 2;
                    else igrok = 1;
                }
            }

            while (x==0)
            {
                if (y!=0)
                {
                    y = y - 1;
                    if (igrok == 1) igrok = 2;
                    else igrok = 1;
                }
            }

            while (y == 0)
            {
                if (x != 0)
                {
                    x = x - 1;
                    if (igrok == 1) igrok = 2;
                    else igrok = 1;
                }
            }

            Console.WriteLine(igrok);
            Console.ReadKey();
        }
    }
}
