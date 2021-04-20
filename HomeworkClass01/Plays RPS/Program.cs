using System;

namespace Plays_RPS
{
    class Program
    {
        static void Main(string[] args)
        {

            int userScore = 0;
            int appScore = 0;
            bool inOut = true;
            
            while (inOut)
            {
                Console.WriteLine("======================================");
                Console.WriteLine("Enyoj playing game Rock Paper Scissors");
                Console.WriteLine("======================================");
                Console.WriteLine("Press: \n1) Playing \n2) Stats \n3) Exit");
                var menuInput = Console.ReadLine();

                switch (menuInput)
                {
                    case "1":
                        Console.WriteLine("Press: \n1. Rock \n2. Paper \n3. Scissors ");
                        string stringPick = Console.ReadLine();
                        int parsedPick;
                        bool converting = int.TryParse(stringPick, out parsedPick);
                        if (converting == false) continue;
                        Game userPick = (Game)parsedPick;

                        int random = new Random().Next(1, 3);
                        var applicationPick = (Game)random;
                        Console.WriteLine($"You pick: {userPick}");
                        Console.WriteLine($"Application pick: {applicationPick}");

                        if ((userPick == Game.Rock && applicationPick == Game.Scissors) || (userPick == Game.Scissors && applicationPick == Game.Paper)
                            || (userPick == Game.Paper && applicationPick == Game.Rock))
                        {
                            userScore++;
                            Console.WriteLine("User wins");
                        }
                        else if ((applicationPick == Game.Rock && userPick == Game.Scissors) || (applicationPick == Game.Scissors && userPick == Game.Paper) 
                            || (applicationPick == Game.Paper && userPick == Game.Rock))
                        {
                            appScore++;
                            Console.WriteLine("Application wins");
                        }
                        break;
                    case "2":
                        Console.WriteLine($"User have {userScore} wins or {WonRatio(userScore, appScore)} % Won ratio ");
                        Console.WriteLine($"Application have {appScore} wins or {WonRatio(appScore, userScore)} % Won ratio");
                        break;
                    case "3":
                        inOut = false;
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
            Console.ReadLine();
        }
        public static float WonRatio(float yourscore, float otherscore)
        {
            return (yourscore / (yourscore + otherscore)) * 100;
        }
    }
}
