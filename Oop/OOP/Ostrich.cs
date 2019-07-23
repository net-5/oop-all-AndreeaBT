using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{

    class Ostrich :Birds, IWalking
    {
        public Ostrich(string name) : base(name) { }
        //public new int Speed { get { return Speed; } set { Speed = value; } }
        public Gender gender = Gender.Female;
        public new int Speed = 7;


        public void Runs()
        {
            Console.WriteLine("I can run really fast when I play or when I feel endangered");
        }

        public void Walks()
        {
            Console.WriteLine("I can walk");
        }
        public void DoesNotFly()
        {
            Console.WriteLine("I am a bird but I can't fly");
        }
    }
}
