using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Platypus : Animals, IWalking, ISwimming, IMove
    {
        public Platypus(string name) : base(name) { }
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
        public void Runs()
        {
           
        }

        public void SwimsBeneathWather()
        {
            Console.WriteLine("I can swim underwater and hold my breath a long amount of time");
        }

        public void SwimsAboveWater()
        {
            Console.WriteLine("I can swim above water when I am relaxed");
        }

        public void Walks()
        {
            Console.WriteLine("I can walk but it is not my strong point");
        }

        public void Movement()
        {
            Console.WriteLine($"On a scale from 1 to 10 my speed is {Speed}"); 
        }
    }
}
