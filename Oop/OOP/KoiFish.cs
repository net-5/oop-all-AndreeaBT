using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class KoiFish : Fishes, ISwimming,IMove
    {
        public KoiFish(string name) : base(name) { }
        
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

        public void SwimsBeneathWather()
        {
            Console.WriteLine("I can swim only beneath water and I breath thru my gills");
        }

        public void SwimsAboveWater()
        {
            Console.WriteLine("I sometimes try to reach above when I receive food but I don't swim above water");
        }
        public new void Movement()
        {
            Console.WriteLine($"On a scale from 1 to 10 my speed is {Speed}");

        }
    }
}
