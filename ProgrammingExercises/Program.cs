using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ProgrammingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //SumeTwoNumbers();
            SelectAvarageNumber();
        }

        private static void SumeTwoNumbers()
        {
            int firstNumber;
            int secondNumber;
            int sumNumbers;

            WriteLine("Enter first number");
            firstNumber = int.Parse(ReadLine());
            WriteLine("Enter second number");
            secondNumber = int.Parse(ReadLine());
            sumNumbers = firstNumber + secondNumber;
            WriteLine("Sum: " + sumNumbers);
            ReadLine();
        }

        private static void SelectAvarageNumber()
        {
            WriteLine("Enter first number");
            int firstNumb = int.Parse(ReadLine());

            WriteLine("Enter second number");
            int secondNumb = int.Parse(ReadLine());

            WriteLine("Enter third number");
            int thirdNumb = int.Parse(ReadLine());

            WriteLine("Enter fourth number");
            int fourthNumb = int.Parse(ReadLine());

            int[] numbTable = new int[] { firstNumb, secondNumb, thirdNumb, fourthNumb };

            double averageValue = numbTable.Average();
            WriteLine("Average value: " + averageValue);
        }
    }
}
