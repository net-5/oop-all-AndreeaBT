using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Platypus : Mammals, IWalking, ISwimming
    {
        public Platypus(string name) : base(name) { }
        //public new int Speed { get { return Speed; } set { Speed = value; } }
        public Gender gender = Gender.Male;
        public new int Speed = 4;

        public void Runs()
        {
            throw new NotImplementedException();
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
    }
}
