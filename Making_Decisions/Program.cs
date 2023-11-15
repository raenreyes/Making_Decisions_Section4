namespace Making_Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 17;
            string userName = "Admin";


            CheckAge(age);
            CheckUserName(userName);
        }

        public static void CheckAge(int age) {
            switch (age)
            {
                case  17:
                    Console.WriteLine("Too young to party in the club!");
                    break;
                case 21:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }
        }

        public static void CheckUserName (string userName) {

            switch (userName) {
                case "Denis":
                    Console.WriteLine("Hello Employee Denis!");
                    break;
                case "Admin":
                    Console.WriteLine("Hello Admin!");
                    break;
                case "Billy":
                    Console.WriteLine("Hello Employee Billy");
                    break;
                    default : 
                    Console.WriteLine("You are not an employee here!");
                    break;
            }
        }
        
    }
}