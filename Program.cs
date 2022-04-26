using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            Console.Write("What percentage did you get in your class? ");
            // Get the value that they type in
            string Percentage = Console.ReadLine();

            // Turn the string into an integer so that you can find the grade value
            int PercentageNumber = int.Parse(Percentage);

            string LetterGrade = "";

            if (PercentageNumber >= 90)
            {
                //
                Console.WriteLine("Congradulations You passed!");
                LetterGrade = "A";
            }
            else if (PercentageNumber <= 89 && PercentageNumber >= 80)
            {
                //
                Console.WriteLine("Congradulations You passed!");
                LetterGrade = "B";
            }
            else if (PercentageNumber <= 79 && PercentageNumber >= 70)
            {
                //
                Console.WriteLine("Congradulations You passed!");
                LetterGrade = "C";
            }
            else if (PercentageNumber <= 69 && PercentageNumber >= 60)
            {
                //
                Console.WriteLine("You didn't quite make the points to pass. Better luck next time");
                LetterGrade = "D";
            }
            else
            {
                //
                Console.WriteLine("You didn't quite make the points to pass. Better luck next time");
                LetterGrade = "F";
            }

            Console.WriteLine($"You got an {LetterGrade}");
        }
    }
}
