using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type your name:");
            var name = Console.ReadLine();
            Console.WriteLine("Please type your favorite color:");
            var color = Console.ReadLine();
            Console.WriteLine("Please type your favorite number between 1 and 10:");
            var fav = Console.ReadLine();
            Console.WriteLine("Please type your favorite animal:");
            var animal = Console.ReadLine();
            Console.WriteLine($"{name} has {fav} pet {animal}s and likes to dress them in {color} sweaters");
            Console.WriteLine(DoMath(3, 6));

        }
        public static int DoMath(int num1, int num2)
        {
            int total = num1 + num2;
            return total;
        }
    }
}



    
