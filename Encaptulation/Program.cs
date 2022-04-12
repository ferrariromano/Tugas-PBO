using System;

namespace encapsulation
{
    class program
    {
        static void Main(string[] args)
        {
            Hero NamaHeroML = new Hero("Zilong", 100, 1000);
            NamaHeroML.GetAndSet();
        }
    }

    public class Hero
    {
        public string nama;
        public int power;
        public int health;

        public Hero(string NamaHero, int PowerHero, int HealtHero)
        {
            nama = NamaHero;
            power = PowerHero;
            health = HealtHero;
        }
        
        public string GetNamaHero()
        {
            return nama;
        }

        public void setNamaHero(string NamaSetHero)
        {
            nama = NamaSetHero;
        }

        public void GetAndSet()
        {
            Console.WriteLine("Nama Hero adalah " + nama);
        }
    }
}
