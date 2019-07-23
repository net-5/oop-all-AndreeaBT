using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Bat : Mammals, IFlying, ICrawling
    {
        public Bat(string name) : base(name) { }
        //public new int Speed { get { return Speed; } set { Speed = value; } }
        public Gender gender = Gender.Male;
        public new int Speed = 4;

        public void Crawls()
        {
            Console.WriteLine("When I don't fly I crawl");
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
            Console.WriteLine("I fly but I can't go long distances");
        }
    }
}
