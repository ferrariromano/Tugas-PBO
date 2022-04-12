using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            Lingkaran Luaslingkaran = new Lingkaran(5);
            Console.Write("Luas Lingkaran =" + Luaslingkaran.HitungLuas());

            segitiga LuasSegitiga =new segitiga(3, 4);
            Console.WriteLine("luas segitiga = " + LuasSegitiga.HitungLuas());

            Console.ReadKey();
        }

    }
    public abstract class HitungBangunDatar
    {
        public double luas;

        public abstract double HitungLuas();
    }

    public class Lingkaran : HitungBangunDatar
    {
        double JariJari;

        public Lingkaran(double r)
        {
            JariJari = r;
        }

        public override double HitungLuas()
        {
            luas = 3.14 * JariJari * JariJari;
            return luas;
        }
    }

    public class segitiga : HitungBangunDatar
    {
        double alas, tinggi;

        public segitiga(double a, double t)
        {
            alas = a;
            tinggi = t;
        }

        public override double HitungLuas()
        {
            luas = 0.5 * alas * tinggi;
            return luas;
        }
    }
}