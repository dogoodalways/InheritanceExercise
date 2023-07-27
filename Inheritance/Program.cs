using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird BlueJay = new Bird();
            BlueJay.WingColor = "Blue";
            BlueJay.BeakLength = 5;
            BlueJay.Canfly = true;
            BlueJay.DoMigrate = true;




            Reptile Lizard = new Reptile()
            {
                IsColdBlooded = true,
                IsAlive = true,
                Habitat = "Swamp",
                CanGrowTail = true,
            };

            var myAnimals = new Animal[] {BlueJay, Lizard};

            foreach(var Animal in myAnimals)
            {
                Console.WriteLine($"Alive:{Animal.IsAlive}");
                Console.WriteLine($"Age:{Animal.Age} years old.");
                Console.WriteLine($"It has {Animal.LegCount} legs.");
                Console.WriteLine($"It lives by {Animal.LandSeaAir}");
                Console.WriteLine("");
            }
        }
    }
}
