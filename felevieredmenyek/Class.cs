using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace felevieredmenyek
{
    class Class
    {
        public string TanuloNev { get; set; }
        public double OktatasiAzonosito { get; set; }
       public List<int> jegyek { get; set; }
        public double Atlag => jegyek.Average();



        public Class(string adatok)
        {
            string[] adat = adatok.Split("\t");
            TanuloNev = adat[0];
            OktatasiAzonosito = Convert.ToDouble(adat[1]);
            jegyek = new List<int>();
           


            for (int i = 2; i < adat.Length; i++)
            {
                jegyek.Add(Convert.ToInt32(adat[i]));
            }

        }
        

        public override string ToString()
        {
            return $"Tanuló neve: {TanuloNev},Oktatási Azonosító: {OktatasiAzonosito}";
        }
        public double atlag(double atlag)
        {
            foreach (var tanulo in jegyek)
            {
                atlag += tanulo;

            }
            return atlag / jegyek.Count;
        }

    }
}

