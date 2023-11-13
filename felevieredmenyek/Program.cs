using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace felevieredmenyek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Class> tanulok = new();
            List<string> tanorak = new();
            //1. feladat
            //Írjunk függvényt, ami kiszámítja a jegyek átlagát tanulónként.Írjunk függvényt, ami kiszámítja az osztályátlagot, illetve a tantárgyankénti átlagot is.
            var sr = new StreamReader(
                path: @"..\..\..\adatok.txt",
                encoding: System.Text.Encoding.UTF8
                );
            _ = sr.ReadLine();
          
            while (!sr.EndOfStream)
            {
                _ = sr.ReadLine();
                var sor = new Class(sr.ReadLine());
                tanulok.Add(sor);

            }
            double no = 0;
            foreach ( var tanulo in tanulok)
            {
                Console.WriteLine($"{tanulo.ToString()},Átlag: {tanulo.atlag(no)}");
            }
            Console.WriteLine($"\tAz osztályátlag:  {Osztalyatlag(tanulok)}");
           




            //2. feladat: Programozás gyakorlatból megbukottak adatainak kiiratása.
            int index = tanorak.IndexOf("Programozás gyakorlat");
            var bukottak = tanulok.Where(t => t.jegyek[index] == 1);
            foreach (var b in bukottak)
            {
                Console.WriteLine($"\tNév:  {b.TanuloNev}\n\tTanulóikód:  {b.OktatasiAzonosito}");
            }

            //3. feladat: Írjunk függvényt, amivel keressük meg az első olyan embert, akinek hármasa van angol nyelvből, majd írjuk ki az adatait.
            //4. feladat: Kérjük be a felhasználótól, melyik tanuló legjobb jegyét szeretné megtudni.
            //Írjuk ki az adott tanuló legjobb eredményét függvénnyel. Szorgalmi: Kezeljük a lehetséges felhasználói hibát is.
            //5. feladat: Egy új fájlba írjuk ki a fenti tanuló nevét és oktatási azonosítóját.
        }
        static double Osztalyatlag(List<Class> tanulok)
        {
            double atlag = 0;
            foreach (var t in tanulok)
            {
                atlag += t.Atlag;
            }
         
            return atlag/tanulok.Count;
        }
        static List<double> OraAtlag(List<Class> tanulok, List<string> tanorak)
        {
            List<double> oraAtlagok = new();
            double atlag = 0;
            int oszto = 0;
            for (int i = 0; i < tanulok.Count; i++)
            {
                for (int j = 0; j < tanulok[i].jegyek.Count; j++)
                {
                    atlag += tanulok[i].jegyek[j];
                    oszto = tanulok[i].jegyek.Count;
                }
                atlag /= oszto;
                oraAtlagok.Add(atlag);
                atlag = 0;
            }
            return oraAtlagok;
        }
    }
}
