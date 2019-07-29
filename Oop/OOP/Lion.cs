using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Lion : Mammals, IWalking,IMove
    {
        public Lion(string name) : base(name) { }
        //public new int Speed { get { return Speed; } set { Speed = value; } }
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
            Console.WriteLine("I can run as fast as a bullet when I hunt");
        }

        public void Walks()
        {
            Console.WriteLine("When I don't run I have a bossy walk");
        }
        public new void Movement()
        {
            Console.WriteLine($"On a scale from 1 to 10 my speed is {Speed}");

        }
    }
}
