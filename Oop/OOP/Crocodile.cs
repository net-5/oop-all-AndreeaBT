using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Crocodile :Reptiles, ISwimming, ICrawling,IMove
    {
        public Crocodile(string name) : base(name) { }
        public Gender gender = Gender.Female;
        private int speed;
        public  int Speed
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
            Console.WriteLine("When I am lazy I barrely crawl");
        }

        public void CrawlsFast()
        {
            Console.WriteLine("When I feel endangered or my pray is on the ground I crawl fast");
        }

        public void SwimsBeneathWather()
        {
            Console.WriteLine("I can swim underwater and hold my breath but not for long");

        }

        public void SwimsAboveWater()
        {
            Console.WriteLine("I can swim above water when I am relaxed");
        }
        public new void Movement()
        {
            Console.WriteLine($"On a scale from 1 to 10 my speed is {Speed}");

        }
    }
}
