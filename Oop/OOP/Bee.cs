using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{

    public class Bee : Insects, IFlying, ICrawling, IMove
    {
        public Bee(string name) : base(name) { }
        public Gender gender = Gender.Male;
        private int speed;
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        public void Crawls()
        {
            Console.WriteLine("I sometimes crawl when I am gathering polen.");
        }

        public void CrawlsFast()
        {
           
        }

        public void DoesNotFly()
        {
           
        }

        public void FlyesLongDistances()
        {
           
        }

        public void FlyesShortDistances()
        {
            Console.WriteLine("I fly short distances, from a flower to the beehive.");
        }
        public new void Movement()
        {
            Console.WriteLine($"On a scale from 1 to 10 my speed is{Speed}");
        }
    }
}
