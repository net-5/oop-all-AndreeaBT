using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{

    class Ostrich :Birds, IWalking, IMove
    {
        public Ostrich(string name) : base(name) { }
      
        public Gender gender = Gender.Female;
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
            Console.WriteLine("I can run really fast when I play or when I feel endangered");
        }

        public void Walks()
        {
            Console.WriteLine("I have a funny walk");
        }
        public void DoesNotFly()
        {
            Console.WriteLine("I am a bird but I can't fly");
        }
        public new void Movement()
        {
            Console.WriteLine($"On a scale from 1 to 10 my speed is {Speed}");

        }
    }
}
