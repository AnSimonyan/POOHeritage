using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POOHeritage
{
    public class Quadrupeds : Animal
    {
       
        public Quadrupeds(string name, string typeOfFood="") : base(name, 4, true) 
        {
            TypeOfFood = typeOfFood;
        }

        public override void Move()
        {
            System.Console.WriteLine(_name + " It's quadrupèdes");

        }
    }

    
}
