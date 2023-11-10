using System;
using System.IO;
using System.Collections.Generic;

namespace felevieredmenyek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Class> tanulok = new List<Class>();
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
            //2. feladat: Programozás gyakorlatból megbukottak adatainak kiiratása.
            //3. feladat: Írjunk függvényt, amivel keressük meg az első olyan embert, akinek hármasa van angol nyelvből, majd írjuk ki az adatait.
            //4. feladat: Kérjük be a felhasználótól, melyik tanuló legjobb jegyét szeretné megtudni.
            //Írjuk ki az adott tanuló legjobb eredményét függvénnyel. Szorgalmi: Kezeljük a lehetséges felhasználói hibát is.
            //5. feladat: Egy új fájlba írjuk ki a fenti tanuló nevét és oktatási azonosítóját.
        }
    }
}
