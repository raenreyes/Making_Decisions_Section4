using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Making_Decisions
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current temperature outside in Celsius");
            string tempString = Console.ReadLine();
            string displayText = string.Empty;
          
            bool validNumber = int.TryParse(tempString, out int intTemp);

            if (validNumber)
            {
                displayText = intTemp <= 15 ? "too cold": 
                intTemp >= 16 && intTemp <= 28 ? "Perfect" : "too hot";
                Console.WriteLine("Your weather is " + displayText);
            }
            else {
                Console.WriteLine("Not a valid temperature!");
            }
        }
       
        
    }
}