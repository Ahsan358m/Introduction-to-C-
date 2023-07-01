using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First Name");
            string fname =Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            string lname = Console.ReadLine();
            Console.WriteLine("Your first name is : "+fname+" Your last name is : "+lname);
            Console.WriteLine("Your first name is {0} Your last name is {1}", fname, lname);
            Console.WriteLine($"Your first name is {fname} Your last name is {lname}");
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            string fullname = $"{fname} {lname.ToLower()}";
            Console.WriteLine($"Your name is {fullname} and your age is {age + 1} your salary is {100_000 + 12}");
           
            Console.ReadLine();
        }
    }
}
