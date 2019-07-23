using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class KoiFish : Fishes, ISwimming
    {
        public KoiFish(string name) : base(name) { }
        //public new int Speed { get { return Speed; } set { Speed = value; } }
        public Gender gender = Gender.Female;
        public new int Speed = 1;


        public void SwimsBeneathWather()
        {
            Console.WriteLine("I can swim only beneath water and I breath thru my gills");
        }

        public void SwimsAboveWater()
        {
            Console.WriteLine("I sometimes try to reach above when I receive food but I don't swim above water");        }
    }
}
