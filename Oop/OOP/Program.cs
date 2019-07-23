using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animals = new Animals("");
            animals.Name = "Animal";

            Birds birds = new Birds("");
            birds.Name = "Bird";

            Duck duck = new Duck("");
            duck.Name = "Duck Norris";
            Console.WriteLine($"Hi, I am an {animals.Name}, the {birds.Name} type, I am a {duck.gender} and my name is {duck.Name}.");
            Console.WriteLine($"On a scale from 1 to 10 my maximum speed is {duck.Speed}");
            duck.FlyesLongDistances();
            duck.FlyesShortDistances();
            duck.SwimsAboveWater();
            duck.SwimsBeneathWather();
            duck.Walks();
            Console.WriteLine("\n");

            Ostrich ostrich = new Ostrich("");
            ostrich.Name = "Ostrall";
            Console.WriteLine($"Hi, I am an {animals.Name}, the {birds.Name} type, I am a {ostrich.gender} and my name is {ostrich.Name}.");
            Console.WriteLine($"On a scale from 1 to 10 my maximum speed is {ostrich.Speed}");
            ostrich.Walks();
            ostrich.Runs();
            ostrich.DoesNotFly();
            Console.WriteLine("\n");

            Fishes fishes = new Fishes("");
            fishes.Name = "Fish";
            Console.WriteLine("\n");

            KoiFish koiFish = new KoiFish("");
            koiFish.Name = "Hanako";
            Console.WriteLine($"Hi, I am an {animals.Name}, the {fishes.Name} type, I am a {koiFish.gender} and my name is {koiFish.Name} which translates to \'Flower Girl\'.");
            Console.WriteLine($"On a scale from 1 to 10 my maximum speed is {koiFish.Speed}");
            koiFish.SwimsAboveWater();
            koiFish.SwimsBeneathWather();
            Console.WriteLine("\n");

            Insects insects = new Insects("");
            insects.Name = "Insect";
            Console.WriteLine("\n");

            Bee bee = new Bee("");
            bee.Name = "Mr Bee";
            Console.WriteLine($"Hi, I am an {animals.Name}, the {insects.Name} type, I am a {bee.gender} and my name is {bee.Name}.");
            Console.WriteLine($"On a scale from 1 to 10 my maximum speed is {bee.Speed}");
            bee.Crawls();
            bee.FlyesShortDistances();
            Console.WriteLine("\n");

            Mammals mammal = new Mammals("");
            mammal.Name = "Mammal";
            Console.WriteLine("\n");

            Bat bat = new Bat("");
            bat.Name = "Vladislav";
            Console.WriteLine($"Hi, I am an {animals.Name}, the {mammal.Name} type, I am a {bat.gender} and my name is {bat.Name}.");
            Console.WriteLine($"On a scale from 1 to 10 my maximum speed is {bat.Speed}");
            bat.Crawls();
            bat.FlyesShortDistances();
            Console.WriteLine("\n");

            Lion lion = new Lion("");
            lion.Name = "Nova";
            Console.WriteLine($"Hi, I am an {animals.Name}, the {mammal.Name} type, I am a {lion.gender} and my name is {lion.Name}.");
            Console.WriteLine($"On a scale from 1 to 10 my maximum speed is {lion.Speed}");
            lion.Walks();
            lion.Runs();
            Console.WriteLine("\n");

            Platypus platypus = new Platypus("");
            platypus.Name = "Perry";
            Console.WriteLine($"Hi, I am an {animals.Name}, the {mammal.Name} type, I am a {platypus.gender} and my name is {platypus.Name}.");
            Console.WriteLine($"On a scale from 1 to 10 my maximum speed is {platypus.Speed}");
            platypus.SwimsAboveWater();
            platypus.SwimsBeneathWather();
            platypus.Walks();
            Console.WriteLine("\n");

            Reptiles reptiles = new Reptiles("");
            reptiles.Name = "Reptile";
            Console.WriteLine("\n");

            Crocodile crocodile = new Crocodile("");
            crocodile.Name = "Andrea";
            Console.WriteLine($"Hi, I am an {animals.Name}, the {reptiles.Name} type, I am a {crocodile.gender} and my name is {crocodile.Name}.");
            Console.WriteLine($"On a scale from 1 to 10 my maximum speed is {crocodile.Speed}");
            crocodile.SwimsAboveWater();
            crocodile.SwimsBeneathWather();
            crocodile.Crawls();
            crocodile.CrawlsFast();





        }
    }
}
