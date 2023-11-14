namespace Making_Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter your username:");
            userName = Console.ReadLine();

           

            if (isRegistered && userName != "")
            {
                Console.WriteLine("Hi there, registered user");
                Console.WriteLine("Hi there, " + userName);

                if (userName.Equals("admin") || userName.Equals("Admin"))
                    {
                        Console.WriteLine("Hi there Admin");
                    }
                
            }
        }
    }
}