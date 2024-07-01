using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOHeritage
{
    public class Bipeds : Animal
    {

      
        public Bipeds(string name, string typeOfFood = "") : base(name, 2, true) 
        {
            TypeOfFood = typeOfFood;
        }
        public override void Move()
        {
            System.Console.WriteLine(_name + " It's bipèdes"); 
           
        }



    }
}
