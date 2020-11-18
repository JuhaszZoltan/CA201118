using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201118
{
    class Program
    {
        static List<Palinka> palinkak;
        static readonly Random rnd = new Random();
        static readonly string[] gyumolcsok = 
            { "szilva", "barack", "dió", "körte", "alma", "banán", "agave" };
        static void Main()
        {
            ListaFeltolt(20);
            MindenKiir();
            //OsszesPalinka();
            //EladasTeszt(50);
            Console.WriteLine("done!");
            Console.ReadKey();
        }

        private static void MindenKiir()
        {
            foreach (var p in palinkak)
            {
                Console.WriteLine(
                    $"{p.Gyumolcs} pálnaka ({p.AlkoholFok}%): " +
                    $"\n\tKészült:   {p.KeszitesEve}" +
                    $"\n\tKészleten: {p.Mennyiseg / 10F} liter" +
                    $"\n\tÁr:        {p.Ar} Ft/dl\n");
            }
        }

        private static void ListaFeltolt(int db)
        {
            palinkak = new List<Palinka>();
            for (int i = 0; i < db; i++)
            {
                palinkak.Add(
                    new Palinka()
                    {
                        AlkoholFok = rnd.Next(30, 88),
                        Gyumolcs = gyumolcsok[rnd.Next(gyumolcsok.Length)],
                        Mennyiseg = rnd.Next(51),
                        KeszitesEve = rnd.Next(2000, DateTime.Now.Year + 1),
                        Ar = rnd.Next(50, 1001),
                    });
            }
        }

        private static void OsszesPalinka()
        {
            throw new NotImplementedException();
        }

        private static void EladasTeszt(int v)
        {
            throw new NotImplementedException();
        }
    }
}
