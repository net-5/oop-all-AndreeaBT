using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public abstract class Fishes : Animals, IMove
    {
        public Fishes(string name) : base(name) { }

        public int Speed { get; set; }

        public void Movement()
        {

        }
    }
}
