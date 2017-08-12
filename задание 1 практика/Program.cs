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
            string x="";
            string y="";
            bool ok = true;
            FileStream file1 = new FileStream("INPUT.TXT", FileMode.Open); //создаем файловый поток 
            StreamReader reader = new StreamReader(file1); // создаем «потоковый читатель» и связываем его с файловым потоком

            string numbers = reader.ReadLine();
            char[] ch_numbers = numbers.ToCharArray();
            

            for (int i=0; i<ch_numbers.Length; i++)
            {
                if (ok)
                {
                    x = x + ch_numbers[i];
                    if (ch_numbers[i] != ' ') ok = false;
                }
                else
                {
                    y = y + ch_numbers[i];
                }
            }

            int chislo_x;
            int.TryParse(x, out chislo_x);

            int chislo_y;
            int.TryParse(y, out chislo_y);

            Console.WriteLine("Координаты начальной клетки " + x + " и " + y);

            chislo_x = -1;
            chislo_y = -1;

            while ((chislo_x==0) || (chislo_y==0))
            {
                if ((chislo_x!=0) & (chislo_y!=0))
                {
                    chislo_x = chislo_x - 1;
                    chislo_y = chislo_y - 1;
                    if (igrok == 1) igrok = 2;
                    else igrok = 1;
                }
            }

            while (chislo_y!=0)
            {
                    chislo_y = chislo_y - 1;
                    if (igrok == 1) igrok = 2;
                    else igrok = 1;
            }

            while (chislo_x!= 0)
            {
                    chislo_x= chislo_x - 1;
                    if (igrok == 1) igrok = 2;
                    else igrok = 1;
            }

            Console.WriteLine(igrok);
            Console.ReadKey();
        }
    }
}
