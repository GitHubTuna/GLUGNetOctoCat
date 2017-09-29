using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlugNetOctocat
{
    class Program
    {
        static void Main(string[] args)
        {
            OctoCat myOctocat = new OctoCat();

            Console.WriteLine("What would you like to name your Octocat?");
            string catName=Console.ReadLine();

            Console.WriteLine("What is " + catName + "'s birth year?");
            int birthYear = int.Parse(Console.ReadLine());
        
            Console.WriteLine("In what month was " + catName + " born?");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What day within " + birthMonth + " in " + birthYear + " was " + catName + " born?");
            int birthDay = int.Parse(Console.ReadLine());

            DateTime dt = new DateTime(birthYear, birthMonth, birthDay );

            myOctocat.Name = "Git Hub cat";
            myOctocat.Birthday = dt;
            int age =myOctocat.GetAge(DateTime.Now,myOctocat.Birthday );

            Console.WriteLine(catName + " is " + age + " years old today.");
            Console.ReadLine();
        }
    }
}
