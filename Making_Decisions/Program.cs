namespace Making_Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your weather in Celsius");
            string numberAsString = Console.ReadLine();
            int temp;

            bool success = int.TryParse(numberAsString, out temp);
            if (success) 
            {
                Console.WriteLine("You gave a valid number and the temperature is " + temp + " degrres celsius");
            }
            else
            {
                temp = 0;
                Console.WriteLine("Valued entered Invalid and the temperature is set to " + temp);
            }

            if (temp < 20 )
            {
                Console.WriteLine("Take the coat");
            }
            else if (temp == 20)
            {
                Console.WriteLine("Pants and Pull over should be fine");
            }
            else if (temp > 40)
            {
                Console.WriteLine("Stay inside way too hot");
            }
            else
            {
                Console.WriteLine("Shorts and shirt would be good for today");
            }
        }
    }
}