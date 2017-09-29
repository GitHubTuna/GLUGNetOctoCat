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

            var intList = birthYear.ToString().Select(digit => int.Parse(digit.ToString()));

            int leftValue;
            int rightValue;

            leftValue = int.Parse(intList.ElementAt(0).ToString() + intList.ElementAt(1).ToString());
            rightValue = int.Parse(intList.ElementAt(2).ToString() + intList.ElementAt(3).ToString());

            string yearInWordsPartOne = NumberToWords(leftValue);
            string yearInWordsPartTwo = NumberToWords(rightValue);
            string monthName = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(birthMonth);

            Console.WriteLine("What day within " + monthName + ", " + yearInWordsPartOne + "-" + yearInWordsPartTwo + " was " + catName + " born?");
            int birthDay = int.Parse(Console.ReadLine());

            DateTime dt = new DateTime(birthYear, birthMonth, birthDay );

            myOctocat.Name = "Git Hub cat";
            myOctocat.Birthday = dt;
            int age =myOctocat.GetAge(DateTime.Now,myOctocat.Birthday );

            Console.WriteLine(catName + " is " + age + " years old today.");
            Console.ReadLine();
        }

        //https://stackoverflow.com/questions/18046836/convert-number-into-words
        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "Zero";

            if (number < 0)
                return "Minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " Million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " Thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " Hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                var tensMap = new[] { "zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }
    }
}
