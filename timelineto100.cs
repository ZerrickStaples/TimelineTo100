using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age.");

            int userAge = int.Parse(Console.ReadLine());

            if (userAge >= 0 && userAge <= 2)
            {
                Console.WriteLine("Still in Momma's arms.");
            }
            else if (3 <= userAge && userAge <= 4)
            {
                Console.WriteLine("Preschool maniac.");
            }
            else if (5 <= userAge && userAge <= 11)
            {
                Console.WriteLine("Elementary school.");
            }
            else if (12 <= userAge && userAge <= 14)
            {
                Console.WriteLine("Middle school.");
            }
            else if (15 <= userAge && userAge <= 18)
            {
                Console.WriteLine("High school.");
            }
            else if (19 <= userAge && userAge <= 22)
            {
                Console.WriteLine("College.");
            }
            else if (23 <= userAge && userAge <= 65)
            {
                Console.WriteLine("Working for The Man.");
            }
            else if (66 <= userAge && userAge <=100)
            {
                Console.WriteLine("The Golden Years.");
            }
            else
            {
                Console.WriteLine("Might be an alien.");
            }
        }
    }
}
