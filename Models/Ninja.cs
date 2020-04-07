using System;

namespace DemoOOP.Models
{
    public class Ninja : Human
    {
        public int Intelligence;

        public Ninja(string name) : base(name,50,100,300)
        {
            Intelligence = 1000;
            health = 200;
        }

        public int InazumaKick(Human target)
        {
            if(target is Human)
            {
                int dmg = Intelligence * 10;
                Console.WriteLine($"{Name} just kicked 21.1 gigawatts of electricity into {target.Name}");
                return target.TakeDmg(dmg);
            }
            else
            {
                throw new Exception("That wasn't a proper Attack!!!");
            }
        }
    }
}