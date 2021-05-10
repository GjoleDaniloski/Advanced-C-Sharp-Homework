using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryQuizzApp
{
    public class DbQuizQuestion
    {
        public static int startQuiz()
        {

            int rightAnswers = 0;

            #region First Question
            bool checkFirstQuestion = true;
            string firstQuestion = "";
            Console.WriteLine("First Question");
            Console.WriteLine(@"What is the capital of Tasmania 
                               a: Dodoma
                               b: Hobart
                               c: Launceston
                               d: Wellington");
            Console.WriteLine("Choose: a, b, c, d");
            while (checkFirstQuestion)
            {
                firstQuestion = Console.ReadLine();
                if ((firstQuestion.ToLower() != "a") && (firstQuestion.ToLower() != "b") && (firstQuestion.ToLower() != "c") && (firstQuestion.ToLower() != "d"))
                {
                    Console.WriteLine("Invalid input");
                    checkFirstQuestion = true;
                }
                else 
                {
                    checkFirstQuestion = false;
                }
            }
            if (firstQuestion == "b")
            {
                rightAnswers++;
            }

            Console.Clear();
            #endregion

            #region Second Question
            bool chechSecondQuestion = true;
            string secondQuestion = "";
            Console.WriteLine("Second Question");
            Console.WriteLine(@" What is the tallest building in the Republic of the Congo?
                                a: Kinshasa Democratic Republic of the Congo Temple
                                b: Palais de la Nation
                                c: Kongo Trade Centre
                                d: Nabemba Tower");
            Console.WriteLine("Choose: a, b, c, d");
            while (chechSecondQuestion)
            {
                secondQuestion = Console.ReadLine();
                if ((secondQuestion.ToLower() != "a") && (secondQuestion.ToLower() != "b") && (secondQuestion.ToLower() != "c") && (secondQuestion.ToLower() != "d"))
                {
                    Console.WriteLine("Invalid input");
                    chechSecondQuestion = true;
                }
                else
                {
                    chechSecondQuestion = false;
                }
            }
            if (secondQuestion == "d")
            {
                rightAnswers++;
            }
            Console.Clear();
            #endregion

            #region Third Question
            bool chechThirdQuestion = true;
            string thirdQuestion = "";
            Console.WriteLine("Third Question");
            Console.WriteLine(@" Which of these is not one of Pluto's moons?
                                a: Styx
                                b: Hydra
                                c: Nix
                                d: Lugia");
            Console.WriteLine("Choose: a, b, c, d");
            while (chechThirdQuestion)
            {
                thirdQuestion = Console.ReadLine();
                if ((thirdQuestion.ToLower() != "a") && (thirdQuestion.ToLower() != "b") && (thirdQuestion.ToLower() != "c") && (thirdQuestion.ToLower() != "d"))
                {
                    Console.WriteLine("Invalid input");
                    chechThirdQuestion = true;
                }
                else
                {
                    chechThirdQuestion = false;
                }
            }
            if (thirdQuestion == "c")
            {
                rightAnswers++;
            }
            Console.Clear();

            #endregion

            #region FourthQuestion
            bool checkFourthQuestion = true;
            string fourthQuestion = "";

            Console.WriteLine("Fourth Question");
            Console.WriteLine(@" What is the smallest lake in the world?
                                a: Onega Lake
                                b: Benxi Lake
                                c: Kivu Lake
                                d: Wakatipu Lake");
            Console.WriteLine("Choose: a, b, c, d");
            while (checkFourthQuestion)
            {
                fourthQuestion = Console.ReadLine();
                if ((fourthQuestion.ToLower() != "a") && (fourthQuestion.ToLower() != "b") && (fourthQuestion.ToLower() != "c") && (fourthQuestion.ToLower() != "d"))
                {
                    Console.WriteLine("Invalid input");
                    checkFourthQuestion = true;
                }
                else
                {
                    checkFourthQuestion = false;
                }
                
            }
            if (fourthQuestion == "b")
            {
                rightAnswers++;
            }
            Console.Clear();
            #endregion

            #region Fifth Question
            bool checkFifthQuestion = true;
            string fifthQuestion = "";
            Console.WriteLine("Fifth Question");
            Console.WriteLine(@" What country has the largest population of alpacas?
                                a: Chad
                                b: Peru
                                c: Australia
                                d: Niger");
            Console.WriteLine("Choose: a, b, c, d");
            while (checkFifthQuestion)
            {
                fifthQuestion = Console.ReadLine();
                if ((fifthQuestion.ToLower() != "a") && (fifthQuestion.ToLower() != "b") && (fifthQuestion.ToLower() != "c") && (fifthQuestion != "d"))
                {
                    Console.WriteLine("Invalid input");
                    checkFifthQuestion = true;
                }
                else
                {
                    checkFifthQuestion = false;
                }
            }
            if (fifthQuestion == "b")
            {
                rightAnswers++;
            }
            #endregion
            Console.Clear();
            Console.WriteLine($"You have correct answer on {rightAnswers} of 5 questions");
            return rightAnswers;
        }
    }
}
