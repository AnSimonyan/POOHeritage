using System.Security.Cryptography;

namespace POOHeritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bipeds human = new Bipeds("The human1");
            human.SetTypeOfFood ("Vegetables and meat and fruit");
            human.Move();
            Console.WriteLine("Food: " + human.TypeOfFood);

            Quadrupeds elephant = new Quadrupeds("The elephant 1", "Vegetables");
            elephant.Move();
            Console.WriteLine("Food: " +  elephant.TypeOfFood); 


        }
    }
}
