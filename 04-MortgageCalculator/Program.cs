using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_MortgageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            double principle = 0;
            double years = 0;
            double interest = 0;
            string principleInput, yearsInput, interestInput;


            // User input for Principle amount in dollars
            Console.Write("Enter the loan amount, in dollars(0000.00): ");
            principleInput = Console.ReadLine();
            principle = double.Parse(principleInput);
            //Prompt the user to reenter any illegal input
            if (principle < 0)
            {
                Console.WriteLine("The value for the mortgage cannot be a negative value");
                principle = 0;
            }


            // User input for number of years
            Console.Write("Enter the number of years: ");
            yearsInput = Console.ReadLine();
            years = double.Parse(yearsInput);
            //Prompt the user to reenter any illegal input
            if (years < 0)
            {
                Console.WriteLine("Years cannot be a negative value");
                years = 0;
            }

            // User input for interest rate
            Console.Write("Enter the interest rate(%): ");
            interestInput = Console.ReadLine();
            interest = double.Parse(interestInput);
            //Prompt the user to reenter any illegal input
            if (interest < 0)
            {
                Console.WriteLine("The value for the interest rate cannot be a negative value");
                interest = 0;
            }

            //Calculate the monthly payment
            //ADD IN THE .Net function call Math.pow(x, y) to compute xy (x raised to the y power). 
            double loanM = (interest / 1200.0);
            double numberMonths = years * 12;
            double negNumberMonths = 0 - numberMonths;
            double monthlyPayment = principle * loanM / (1 - System.Math.Pow((1 + loanM), negNumberMonths));

            //double totalPayment = monthlyPayment;


            //Output the result of the monthly payment
            Console.WriteLine(String.Format("The amount of the monthly payment is: {0}{1:0.00}", "$", monthlyPayment));
            Console.WriteLine();
            Console.WriteLine("Press the Enter key to end. . .");
            Console.Read();
        }
    }
}
