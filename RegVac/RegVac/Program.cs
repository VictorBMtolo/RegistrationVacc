using System;

namespace RegVac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Vaccine Registration !");

            Console.WriteLine("Enter your Identification:");
            string age = Console.ReadLine();
            
            Console.WriteLine("Enter your Surname:");
            string surName = Console.ReadLine();
            

            Console.WriteLine("Enter your First Name:");
            string name = Console.ReadLine();
            
            Console.WriteLine("Enter your Gender:");
            string gender = Console.ReadLine();
            
            Console.WriteLine("Enter your Date of vaccination (dd/mm/year):");
            string vac = Console.ReadLine();

            Console.WriteLine("Enter your Province");
            string province = Console.ReadLine();

            Console.WriteLine("Your ID is: " + age);
            Console.WriteLine("Your Surnanme is: " + surName);
            Console.WriteLine("Your Nanme is: " + name);
            Console.WriteLine("Your gender is: " + gender);
            Console.WriteLine("Your Date of vaccination is: " + vac);
            Console.WriteLine("Your Province is: " + province);


        }
    }
}
