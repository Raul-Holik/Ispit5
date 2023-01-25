using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ispit5
{
    internal class Program
    {
        class NebeskoTijelo
        {
            double brzinaOkoOsi, brzinaOkoSunca;

        }
        class Planet : NebeskoTijelo
        {

            public Planet(double brzinaOkoOsi, double brzinaOkoSunca)
            {
                brzinaOkoOsi = brzinaOkoOsi;

            }
        }
        class Satelit : NebeskoTijelo
        {
            public Satelit(double brzinaOkoOsi, double brzinaOkoSunca)
            {

            }
        }
        static void Main(string[] args)
        {
            //5.
            //Definirajte klasu NebeskoTijelo sa sljedećim varijablama članicama:
            //• varijable tipa double
            //BrzinaOkoOsi
            //BrzinaOkoSunca
            //Definirajte klase Planet i Satelit izvedene iz klase NebeskoTijelo, te im definirajte sljedeće konstruktore:
            //Planet(double, double)
            //Satelit(double, double)
            //koji će dodijeliti vrijednosti proslijeđenih argumenata naslijeđenim varijablama članicama
            //Definirajte dva objekta Zemlja i Mjesec tipova Planet i Satelit.

            Planet zemlja = new Planet(3.4, 5.1);
            Satelit mjesec = new Satelit(1.1, 3.3);

            Console.WriteLine(zemlja);
            Console.WriteLine(mjesec);

            Console.ReadKey();
        }
    }
}
