using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Making_Decisions
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
           
            int temp = -1;
            string stateOfMatter;
            //this is how you can add another expression to a ternary operator
            stateOfMatter = temp < 0 ? "Solid" : temp > 100 ? "Gas": "Liquid"; 
            Console.WriteLine($"The state of mater is {stateOfMatter}");

            temp = 20;
            stateOfMatter = temp < 0 ? "Solid" : temp > 100 ? "Gas" : "Liquid";
            Console.WriteLine($"The state of mater is {stateOfMatter}");

            temp = 430;
            stateOfMatter = temp < 0 ? "Solid" : temp > 100 ? "Gas" : "Liquid";
            Console.WriteLine($"The state of mater is {stateOfMatter}");
        }
       
        
    }
}