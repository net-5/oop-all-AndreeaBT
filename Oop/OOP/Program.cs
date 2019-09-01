using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Duck duck = new Duck("");
            duck.Name = "Duck Norris";
            Console.WriteLine($"Hi, I am an animal and a duck.I am a {duck.gender} and my name is {duck.Name}.");
            Console.WriteLine($"On a scale from 1 to 10 my maximum speed is {duck.Speed}");
            duck.FlyesLongDistances();
            duck.FlyesShortDistances();
            duck.SwimsAboveWater();
            duck.SwimsBeneathWather();
            duck.Walks();
            duck.Speed = 5;
            duck.Movement();
            Console.WriteLine("\n");

            Ostrich ostrich = new Ostrich("");
            ostrich.Name = "Ostrall";
            Console.WriteLine($"Hi, I am an animal and an ostrich.I am a {ostrich.gender} and my name is {ostrich.Name}.");
            ostrich.Walks();
            ostrich.Runs();
            ostrich.DoesNotFly();
            ostrich.Speed = 6;
            ostrich.Movement();
            Console.WriteLine("\n");

          

            KoiFish koiFish = new KoiFish("");
            koiFish.Name = "Hanako";
            Console.WriteLine($"Hi, I am an animal and a koi fish.I am a {koiFish.gender} and my name is {koiFish.Name} which translates to \'Flower Girl\'.");
            koiFish.SwimsAboveWater();
            koiFish.SwimsBeneathWather();
            koiFish.Speed = 1;
            koiFish.Movement();
            Console.WriteLine("\n");

           

            Bee bee = new Bee("");
            bee.Name = "Mr Bee";
            Console.WriteLine($"Hi, I am an animal and a bee.I am a {bee.gender} and my name is {bee.Name}.");
            bee.Crawls();
            bee.FlyesShortDistances();
            bee.Speed = 3;
            bee.Movement();
            Console.WriteLine("\n");

            
            

            Bat bat = new Bat("");
            bat.Name = "Vladislav";
            Console.WriteLine($"Hi, I am an animal and a bat.I am a {bat.gender} and my name is {bat.Name}.");
            bat.Crawls();
            bat.FlyesShortDistances();
            bat.Speed = 3;
            bat.Movement();
            Console.WriteLine("\n");

            Lion lion = new Lion("");
            lion.Name = "Nova";
            Console.WriteLine($"Hi, I am an animal and a lion. I am a {lion.gender} and my name is {lion.Name}.");
            lion.Walks();
            lion.Runs();
            lion.Speed = 10;
            lion.Movement();
            Console.WriteLine("\n");

            Platypus platypus = new Platypus("");
            platypus.Name = "Perry";
            Console.WriteLine($"Hi, I am an animal and a platypus.I am a {platypus.gender} and my name is {platypus.Name}.");   
            platypus.SwimsAboveWater();
            platypus.SwimsBeneathWather();
            platypus.Walks();
            platypus.Speed = 3;
            platypus.Movement();
            Console.WriteLine("\n");

          


            Crocodile crocodile = new Crocodile("");
            crocodile.Name = "Andrea";
            Console.WriteLine($"Hi, I am an animal and a crocodile.I am a {crocodile.gender} and my name is {crocodile.Name}.");
            crocodile.SwimsAboveWater();
            crocodile.SwimsBeneathWather();
            crocodile.Crawls();
            crocodile.CrawlsFast();
            crocodile.Speed = 4;
            crocodile.Movement();
            Console.WriteLine($"On a scale from 1 to 10 my maximum speed is {crocodile.Speed}");
            Console.WriteLine();

            List<IMove> move = new List<IMove>();
            move.Add(bat);
            move.Add(bee);
            move.Add(crocodile);
            move.Add(duck);
            move.Add(koiFish);
            move.Add(lion);
            move.Add(ostrich);
            move.Add(platypus);
           
            var Speeds = move.Select(x => x.Speed).Distinct().Count();
            Console.WriteLine($"There are this many speeds : {Speeds}");

        }
    }
}
