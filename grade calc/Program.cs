using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade_calc
{
    class Program
    {

        static void Main(string[] args)
        {
            // welcome the user to the program (output)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the grade calculator program");
            Console.WriteLine();
            // Ask for first grade percentage (output and input)
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter first grade (out of 100) :'");
            Console.ForegroundColor = ConsoleColor.White;
            string firstGrade = Console.ReadLine();
            // Ask for second grade percentage (output and input)
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter second grade(out of 100): ");
            Console.ForegroundColor = ConsoleColor.White;
            string secondgrade = Console.ReadLine();
            // Ask for third grade percentage (output and input)
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter third grade (out of 100): ");
            Console.ForegroundColor = ConsoleColor.White;
            string thirdgrade = Console.ReadLine();

            // catch issues
            try
            {
                // convert to floats (we will divide, we need fractions) (process)
                float gradel = float.Parse(firstGrade);
                float grade2 = float.Parse(secondgrade);
                float grade3 = float.Parse(thirdgrade);
                // calculate percentage (process)
                float average = (gradel + grade2 + grade3) / 3;
            

            // show result
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.Write("Final mark is: " + average + " ");
            Console.ForegroundColor = ConsoleColor.White;

            // test mark against grade bounds (process) and show result(output)
            if (average < 40) {
                Console.WriteLine("Fail");
            }
            else if (average < 55) {
                Console.WriteLine("Pass");
            }
            else if (average < 70) {
                Console.WriteLine("Merit");
            }
            else {
                Console.WriteLine("Distinction");
            }
        }
        // catch issues (process)
        catch (Exception e) {
        // alert the user to the error (output)
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error! " + e.Message);
        }
          //stop the console from closing(input)
          Console.ReadKey();
        }
    }
}

