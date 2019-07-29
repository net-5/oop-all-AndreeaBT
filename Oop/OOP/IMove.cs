using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    interface IMove
    {
         void Movement();
         int Speed { get; set; }
    }
}
