using System;

namespace RegVac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Vaccine Registration !");

            Console.WriteLine("Enter your ID:");
            string age = Console.ReadLine();
            
            Console.WriteLine("Enter your Surname:");
            string surName = Console.ReadLine();
            

            Console.WriteLine("Enter your First Name:");
            string name = Console.ReadLine();
            
            Console.WriteLine("Enter your Gender:");
            string gender = Console.ReadLine();
            
            Console.WriteLine("Enter your Date of Birth (dd/mm/year):");
            string birth = Console.ReadLine();

            Console.WriteLine("Enter your Province");
            string province = Console.ReadLine();

            Console.WriteLine("Your ID is: " + age);
            Console.WriteLine("Your Surnanme is: " + surName);
            Console.WriteLine("Your Nanme is: " + name);
            Console.WriteLine("Your gender is: " + gender);
            Console.WriteLine("Your Date of Birth is: " + birth);
            Console.WriteLine("Your Province is: " + province);


        }
    }
}
