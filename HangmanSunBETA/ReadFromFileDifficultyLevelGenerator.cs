using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HangmanSunBETA
{
	class ReadFromFileDifficultyLevelGenerator
	{
		static Random randomizer = new Random();

		public static string WordToGuess { get; set; }
		public static string[] HiddenWordToGuess { get; set; }
		static string[] easyWords = new string[19];
		static string[] mediumWords = new string[19];
		static string[] hardWords = new string[19];
		public static int InputDifficultyChoice { get; set; }
		


		public static string ChooseADifficulty(int input)
		{
			
			if (input == 1)
			{
				easyWords = File.ReadAllLines(@"EasyLevelWords.txt");
				var easyWordToGuess = randomizer.Next(easyWords.Length);
				WordToGuess = easyWords[easyWordToGuess];
				HiddenWordToGuess = new string[WordToGuess.Length];
			}
			else if (input == 2)
			{
				mediumWords = File.ReadAllLines(@"MediumLevelWords.txt");
				var mediumWordToGuess = randomizer.Next(mediumWords.Length);
				WordToGuess = mediumWords[mediumWordToGuess];
				HiddenWordToGuess = new string[WordToGuess.Length];
			}
			else if (input == 3)
			{
				hardWords = File.ReadAllLines(@"HardLevelWords.txt");
				var hardWordToGuess = randomizer.Next(hardWords.Length);
				WordToGuess = hardWords[hardWordToGuess];
				HiddenWordToGuess = new string[WordToGuess.Length];
			}

			return WordToGuess;

		}



		public static void DifficultyLevel()
		{

			Graphics.ShowDifficultyGraphics();

			string inputChoice = Console.ReadLine();
			if (inputChoice == "1")
			{
				InputDifficultyChoice = 1;
				//WordToGuess = ReadFromFileDifficultyLevelGenerator.GetEasyWord(); "Ett alternativ bara"
				ChooseADifficulty(InputDifficultyChoice);
				Player.PlayerLives = 10;
				GameEngine.PlayHangman();
			}
			else if (inputChoice == "2")
			{
				InputDifficultyChoice = 2;
				ChooseADifficulty(InputDifficultyChoice);
				Player.PlayerLives = 7;
				GameEngine.PlayHangman();
			}
			else if (inputChoice == "3")
			{
				InputDifficultyChoice = 3;
				ChooseADifficulty(InputDifficultyChoice);
				Player.PlayerLives = 5;
				GameEngine.PlayHangman();
			}
			else if (inputChoice == "4")
			{
				InputDifficultyChoice = 4;
				ConsoleOptions.ShowStartMenu();
			}
			else
			{
				while (inputChoice != "1" && inputChoice != "2" && inputChoice != "3" && inputChoice != "4")
				{
					Console.WriteLine("Please type in a choice between 1 and 4".PadLeft(76));
					DifficultyLevel();
				}
			}
		}

	}

}
