using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
   
    public abstract class Reptiles : Animals, IMove
    {
        public  Reptiles(string name) : base(name) { }

        public int Speed { get; set; }

        public  void Movement()
        {
            
        }

     
    }
}
