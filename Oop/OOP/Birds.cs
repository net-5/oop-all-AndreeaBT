using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{

    public abstract class Birds : Animals, IMove
    {
        public Birds(string name) : base(name) { }

        public int Speed { get; set; }

      
        public  void Movement()
        {

        }

      
      
    }
}
