using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input your first number :" );
            var x = Console.ReadLine();

            Console.WriteLine("input Your 2nd Number ");
            var y = Console.ReadLine();

            int Numb1 = Convert.ToInt32(x);
            int Numb2 = Convert.ToInt32(y);

            int result = Numb1 + Numb2;
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
