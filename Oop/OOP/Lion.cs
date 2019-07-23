using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Lion : Mammals, IWalking
    {
        public Lion(string name) : base(name) { }
        //public new int Speed { get { return Speed; } set { Speed = value; } }
        public Gender gender = Gender.Female;
        public new int Speed = 10;


        public void Runs()
        {
            Console.WriteLine("I can run as fast as a bullet when I hunt");
        }

        public void Walks()
        {
            Console.WriteLine("When I don't run I have a bossy walk");
        }
    }
}
