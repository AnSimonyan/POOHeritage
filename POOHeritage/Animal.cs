using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOHeritage
{
    public abstract class Animal
    {
        protected short _legsCount;
        protected bool _hairy;
        protected string _name;
        public  string TypeOfFood;

        public Animal(string name, short legsCount, bool hairy)
        {
            _name = name;
            _legsCount = legsCount;
            _hairy = hairy;
           
        }
        public void SetTypeOfFood(string typeOfFood)
        {
            TypeOfFood = typeOfFood;
        }
        public string GetName()
        {
            return _name;
        }

        public virtual void Move()
        {
            Console.WriteLine(_legsCount);
        }

        public void Eat()
        {
            System.Console.WriteLine(_name + " eats " + TypeOfFood);
        }

    }
}
