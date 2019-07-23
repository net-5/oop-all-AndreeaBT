using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{

    public class Bee : Insects, IFlying, ICrawling
    {
        public Bee(string name) : base(name) { }
        //public new int Speed { get { return Speed; } set { Speed = value; } }
        public Gender gender = Gender.Male;
        public new int Speed = 3;


        public void Crawls()
        {
            Console.WriteLine("I sometimes crawl when I am gathering polen.");
        }

        public void CrawlsFast()
        {
            throw new NotImplementedException();
        }

        public void DoesNotFly()
        {
            throw new NotImplementedException();
        }

        public void FlyesLongDistances()
        {
            throw new NotImplementedException();
        }

        public void FlyesShortDistances()
        {
            Console.WriteLine("I fly short distances, from a flower to the beehive.");
        }
    }
}
