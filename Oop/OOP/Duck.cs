using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Duck : Birds, IFlying, ISwimming, IWalking,IMove
    {
        public Duck(string name) : base(name) { }
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
        public void DoesNotFly()
        {
            
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
        public new void Movement()
        {
            Console.WriteLine($"On a scale from 1 to 10 my speed is {Speed}");

        }
    }
}
