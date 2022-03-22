using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje_projekt_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trokut t = new Trokut();
            t.UcitajStranice();
            Console.WriteLine("Opseg trokuta je: " + t.Opseg());
            

            Cetverokut cetverokut = new Cetverokut();
            cetverokut.UcitajStranice();
            Console.WriteLine("Opseg cetverokuta je: " + cetverokut.Opseg());

            Console.ReadKey();
        }
    }

    class GeometrijskiLik
    {
        protected int brojStranica;
        protected double[] stranice = new double[10];

        public void UcitajStranice()
        {
           for(int i = 0; i < brojStranica; i++)
            {
                Console.WriteLine("Upiši duljinu {0}. stranice", i+1);
                string s = Console.ReadLine();
                stranice[i] = Convert.ToDouble(s);
            }

        }

        public double Opseg()
        {
            double opseg=0;
            for(int t = 0; t < brojStranica; t++)
            {
                opseg=opseg+stranice[t];
            }
            return opseg;

        }
    }

    class Trokut : GeometrijskiLik
    {
        public Trokut()
        {
            brojStranica = 3;

        }



    }

    class Cetverokut: GeometrijskiLik 
    { 
        public Cetverokut()
        {
            brojStranica= 4;
        }


    }

}
