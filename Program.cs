using System;
using DemoOOP.Models;

namespace DemoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm Down with OOP! Yeah, you know me.");

            Human nibbles = new Human("Mr. Nibbles");
            nibbles.ShowStats();
            Human benny = new Human("Benny Bob",10,30,50);
            
            benny.Attack(nibbles);
            nibbles.ShowStats();

            Ninja carol = new Ninja("Carol");
            carol.InazumaKick(benny);
            benny.ShowStats();

            Snack fritos = new Snack("Fritos",160);
            Snack jellyD = new Snack("Jelly Donut",500);
            Snack beefJ = new Snack("Slim Jim",400);

            nibbles.SnackPack.Add(fritos);
            nibbles.SnackPack.Add(jellyD);
            nibbles.SnackPack.Add(beefJ);

            nibbles.SnackAttack();
            nibbles.ShowStats();

        }
    }
}
