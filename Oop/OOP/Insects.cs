using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public abstract class Insects : Animals, IMove
    {
        public Insects(string name) : base(name) { }

        public int Speed { get; set; }

        public void Movement()
        {

        }
    }
}
