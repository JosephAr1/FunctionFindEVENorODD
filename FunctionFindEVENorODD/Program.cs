using System;

namespace FunctionFindEVENorODD
{
    class Program
    {
        
        static void Main(string[] args)
        {

            int n; 

            Console.WriteLine("Please enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            findoddoreven(n);


        }
        static void findoddoreven(int n)
        {
            if(n% 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}
