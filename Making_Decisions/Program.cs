namespace Making_Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your weather in Celsius");
            string input = Console.ReadLine();  
            int temp = int.Parse(input);

            if(temp < 20)
            {
                Console.WriteLine("Take the coat");
            }
            else if (temp == 20)
            {
                Console.WriteLine("Pants and Pull over should be fine");
            }
            else if (temp > 40)
            {
                Console.WriteLine("Stay Inside");
            }
            else
            {
                Console.WriteLine("Shorts and shirt would be good for today");
            }
        }
    }
}