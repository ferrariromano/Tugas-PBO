using System;

namespace inheritance
{
    public class Tabung : Lingkaran
    {

        int tinggi;
        double V;

        public Tabung(int t)
        {
            Lingkaran L = new Lingkaran();
            V = L.LuasLingkaran(5) * t;
            Console.WriteLine(V);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Volume tabung adalah ");
            Tabung Cylinder = new Tabung(5);

        } 
    }


    public class Lingkaran
    {

        public double r;
        public double luas;

        public int LuasLingkaran(double r)
        {
            luas = 3.14 * r * r;
            return (int)luas;

        }



    }

}