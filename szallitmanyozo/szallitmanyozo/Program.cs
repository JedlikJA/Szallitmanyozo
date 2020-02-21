using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szallitmanyozo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] teljes = { "ABC-123", "ASD-234", "FGH-673", "FCK-666", "SEX-069" };
            List<string> bent = new List<string>();
            string választás;
            do
            {
                //A választási lehetőségek kiírása
                Console.WriteLine("Elmegy (E)");
                Console.WriteLine("Bejön (B)");
                Console.WriteLine("Kilépés (K)");
                //A válasz bekérése
                választás = Console.ReadLine();
                switch (választás)
                {
                    case "E": Elmegy(); break;
                    case "B": Bejön(teljes,bent); break;
                    case "K": Kilépés(); break;
                    default: Console.WriteLine("Nem megyfelelő választás"); break;
                }
            } while (választás != "K");
            Console.ReadKey();
        }

        private static void Kilépés()
        {
            throw new NotImplementedException();
        }

        private static void Elmegy()
        {
            //ha üres a lista akkor írjuk ki hogy nincs bent autó
            //ellenőrzés hogy az autó a listában van-e, ha igen akkor ki kell törölni
        }

        private static void Bejön(string[] teljes, List<string> bent)
        {
            if (//tele van)
            {

            }
            Console.WriteLine("Adja meg a rendszámot!");
            string rendszám = Console.ReadLine();
            if (teljes.Contains(rendszám))
            {
                bent.Add(rendszám);
                Console.WriteLine("Az autó bemehet");
            }
            else
            {
                Console.WriteLine("Ez az autó nem jöhet be");
            }
        }
    }
}
