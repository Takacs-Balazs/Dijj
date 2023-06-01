using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static List<osztaly> lista = new List<osztaly>();
        static void Main(string[] args)
        {
           StreamReader sr = new StreamReader("Nobel.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] adatok = sr.ReadLine().Split(';');
                lista.Add(new osztaly(int.Parse(adatok[0]), adatok[1], adatok[2], adatok[3]));
            }
            Console.WriteLine($"4. feladat:{lista.Where(x => x.Evszam == 2017 && x.Tipus == "Irodalmi").First()}");
            Console.WriteLine($"6. feladat:{lista.Where(x => x.Vezeteknev == "Churie")}");
            Console.WriteLine("7. feladat:");
            lista.GroupBy(x => x.Tipus;)

            StreamWriter sw = new StreamWriter("orvosi.txt");
            for (int i = 0; i < adatok.Length)
            {
                string adat = adatok[i]
            }
            sr.Close();

        }
    }
}
