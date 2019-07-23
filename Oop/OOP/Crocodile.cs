using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Crocodile :Reptiles, ISwimming, ICrawling
    {
        public Crocodile(string name) : base(name) { }
        //public new int Speed { get { return Speed; } set { Speed = value; } }
        public Gender gender = Gender.Female;
        public new int Speed = 5;


        public void Crawls()
        {
            Console.WriteLine("When I am lazy I barely crawl");
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
    }
}
