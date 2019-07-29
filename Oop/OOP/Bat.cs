using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Bat : Mammals, IFlying, ICrawling, IMove
    {
        public Bat(string name) : base(name) { }

        public Gender gender = Gender.Male;
        private int speed;
        public int  Speed
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
            Console.WriteLine("When I don't fly I crawl");
        }

        public void CrawlsFast()
        {
            Console.WriteLine("I barrely crawl.");
        }

        public void DoesNotFly()
        {
            Console.WriteLine("Of course I can fly.");
        }

        public void FlyesLongDistances()
        {
            Console.WriteLine("I can't fly long distances.");
        }

        public void FlyesShortDistances()
        {
            Console.WriteLine("I fly but I can't go long distances");
        }

        public new void Movement()
        {
            Console.WriteLine($"On a scale from 1 to 10 my speed is {Speed}");
           
        }
    }
}
