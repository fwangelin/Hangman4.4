using System;
using System.Collections.Generic;
using System.IO;

namespace HangmanSunBETA
{
    class ConsoleOptions
    {


        public static List<string> highscoreList = new List<string>();
        public static string[] textFil;

        static string inputChoice;

        public static void ReadHighScoreFromFile()
        {
            highscoreList.Clear();
            textFil = File.ReadAllLines("Highscore.txt");

            foreach (string item in textFil)
            {
                highscoreList.Add(item);
            }
        }

        public static void ImportHighScore()
        {

            //Console.Clear();
            Console.WriteLine("                                                       ".PadLeft(80));
            Console.WriteLine("************************HIGHSCORE**********************".PadLeft(80));
            Console.WriteLine("                                                       ".PadLeft(80));

            ReadHighScoreFromFile();
            foreach (string item in textFil)
            {
                Console.WriteLine(item.PadLeft(60));
            }

            Console.WriteLine("                                                       ".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));

            ContinueGame();


        }


        public static void CountHighScore()
        {
            int highScoreLevel = ReadFromFileDifficultyLevelGenerator.InputDifficultyChoice;

            switch (ReadFromFileDifficultyLevelGenerator.InputDifficultyChoice)
            {
                case 1:
                    highScoreLevel = 5;
                    break;

                case 2:
                    highScoreLevel = 10;
                    break;
                case 3:
                    highScoreLevel = 16;
                    break;
            }

            int playerLife = Player.PlayerLives;
            int result = highScoreLevel * playerLife;
            string total = Player.PlayerName + ":" + " " + result + " " + "points";



            highscoreList.Add(total);


            File.WriteAllLines("Highscore.txt", highscoreList);

        }


        private static void ContinueGame()
        {
            Console.WriteLine("Press enter to continue".PadLeft(80));
            Console.ReadLine();
            ShowStartMenu();
        }
        public static void ExitGame()
        {
            Console.WriteLine("Sorry to see you go...".PadLeft(64));
            Console.ReadLine();
            Environment.Exit(0);
        }


        public static void ShowStartMenu()
        {
            Graphics.ShowPrepareTheGameScreen();
            Graphics.ShowStartMenuGraphics();
            inputChoice = Console.ReadLine();

            switch (inputChoice)
            {
                case "1": GameEngine.CollectDataAndStartTheGame(); break;
                case "2": StoryLine(); break;
                case "3": Info(); break;
                case "4": Graphics.HangmanGraphicSpacing(); ImportHighScore(); break;
                case "5": ExitGame(); break;
                default:
                    Console.WriteLine("You must pick a choice ranging from 1 to 5".PadLeft(73)); Console.ReadLine();
                    ShowStartMenu(); break;
            }
        }
        private static void Info()
        {
            Graphics.ShowInfoGraphics();
            ContinueGame();
        }
        static void StoryLine()
        {
            Graphics.ShowStoryLineGraphics();
            ContinueGame();
        }
    }
}

