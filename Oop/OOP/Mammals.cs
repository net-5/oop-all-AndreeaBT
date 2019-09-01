using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{

    public abstract class Mammals : Animals, IMove
    {
        public Mammals(string name) : base(name) { }
        public new string Name { get; set; }
      
        public int Speed { get; set; }

        public void Movement()
        {
          
        }
    }
}
