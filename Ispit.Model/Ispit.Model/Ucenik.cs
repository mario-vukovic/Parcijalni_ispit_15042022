using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model
{
    public class Ucenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public double Prosjek { get; set; }

        public void Starost()
        {
            int datumRodjenja = DatumRodjenja.Year;
            int danasnjiDatum = DateTime.Now.Year;
            int starost = danasnjiDatum - datumRodjenja;
            Console.Write("Ucenik ima {0} godina\n", starost);
        }

        public void IspisProsjeka()
        {
            double prosjek = Prosjek;

            if (prosjek >= 1 && prosjek <= 1.49)
            {
                Console.WriteLine("Prosjek ocjena ucenika daje ocjenu 'nedovoljan'");
            }

            else if (prosjek >= 1.50 && prosjek <= 2.49)
            {
                Console.WriteLine("Prosjek ocjena ucenika daje ocjenu 'dovoljan'");
            }

            else if (prosjek >= 2.50 && prosjek <= 3.49)
            {
                Console.WriteLine("Prosjek ocjena ucenika daje ocjenu 'dobar'");
            }

            else if (prosjek >= 3.50 && prosjek <= 4.49)
            {
                Console.WriteLine("Prosjek ocjena ucenika daje ocjenu 'vrlo dobar'");
            }

            else if (prosjek >= 4.50 && prosjek <= 5.00)
            {
                Console.WriteLine("Prosjek ocjena ucenika daje ocjenu 'odličan'");
            }

            else
            {
                Console.WriteLine("Format prosjeka nije prepoznat");
            }
        }

    }
}
