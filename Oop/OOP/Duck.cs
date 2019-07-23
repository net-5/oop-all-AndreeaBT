using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Duck : Birds, IFlying, ISwimming, IWalking
    {
        public Duck(string name) : base(name) { }
        //public new int Speed { get { return Speed; } set { Speed = value; } }
        public Gender gender = Gender.Male;
        public new int Speed = 4;

        public void DoesNotFly()
        {
            throw new NotImplementedException();
        }

        public void FlyesLongDistances()
        {
            Console.WriteLine("I can fly long distances because I migrate to other countries depending on the season");
        }

        public void FlyesShortDistances()
        {
            Console.WriteLine("I can fly");
        }

        public void Runs()
        {
            throw new NotImplementedException();
        }

        public void SwimsBeneathWather()
        {
            Console.WriteLine("I can dive for short periods of time when I catch fish");        }

        public void SwimsAboveWater()
        {
            Console.WriteLine("I like swimming, in fact I spend quite some time on water");
        }

        public void Walks()
        {
            Console.WriteLine("Sometimes I walk and I have a funny walk that makes people laugh");
        }
    }
}
