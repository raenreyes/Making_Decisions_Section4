using System.Runtime.CompilerServices;

namespace Making_Decisions
{
    internal class Program
    {
        //global variables are made static so we can access them without creating an instance
        static int highScore = 80;
        static string highScorePlayer = "Denis";
        static void Main(string[] args)
        {
            CheckScore(100,"MasterDev09");
            
        }
        public static void CheckScore(int score, string playerName) {
            //here we are comparing our global varibles to local variables
            if (score > highScore)
            {
                Console.WriteLine("The old highscore of " + highScore + 
                 " was broken with a new score of " + score);
                Console.WriteLine("New highscore holder is " + playerName);
            }
            else {
                Console.WriteLine("The old highscore of " + highScore +
                 " could not be broken and is still held by " + highScorePlayer);
            }
        }
    }
}