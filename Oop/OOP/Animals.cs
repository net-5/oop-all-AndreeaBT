using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
  
    public enum Gender
    {
        Female,
        Male
    }
    public abstract class Animals
    {
      
        public string Name { get; set; }
        public Animals(string name) { string Name = name; }

       
    }
}
