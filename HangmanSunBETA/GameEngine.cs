using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HangmanSunBETA
{
    class GameEngine
    {
	
        public static bool continueGame = true;
    	public static string InputGuess { get; set; }
        
		

		public static void CollectDataAndStartTheGame()
		{

			do
			{
			Graphics.ShowTypeInNameGraphics();
			Console.WriteLine();
			Player.PlayerName = Console.ReadLine();
			} while (Player.PlayerName.Length <= 2);
			//File.WriteAllText(@"Highscore.txt", Player.PlayerName);
			ReadFromFileDifficultyLevelGenerator.DifficultyLevel();
			PlayHangman();
		}



        public static void PlayHangman()  
		{

            for (int i = 0; 
				i <ReadFromFileDifficultyLevelGenerator.HiddenWordToGuess.Length ; i++)
            {
                ReadFromFileDifficultyLevelGenerator.HiddenWordToGuess[i] = "-";
            }

            Graphics.GameMusic();
            while (continueGame == true)
			{
                
                Console.WriteLine();              
                Graphics.ShowGameplayGraphics();
                Graphics.ShowMrPluggerGraphics();
                Console.WriteLine();
				Console.WriteLine("Type in a letter to guess..".PadLeft(66));
				Console.WriteLine("                                         You have " + Player.PlayerLives + " lives left!");
                IfGameEndedByLosingLives();


                

                foreach (var i in ReadFromFileDifficultyLevelGenerator.HiddenWordToGuess)
                    Console.Write(i);

                Console.WriteLine();

                string InputGuess = Console.ReadLine().ToLower();

				bool correctLetter = false;

                for (int i = 0; i < ReadFromFileDifficultyLevelGenerator.WordToGuess.Length; i++)
                {
                    if (InputGuess == ReadFromFileDifficultyLevelGenerator.WordToGuess[i].ToString())
                    {
						correctLetter = true;


						ReadFromFileDifficultyLevelGenerator.HiddenWordToGuess[i] = InputGuess;
                    }
                }

                continueGame = false;
                if (correctLetter == false)
                {
                    Player.PlayerLives--;
                   

                }

                    for (int i = 0; i < ReadFromFileDifficultyLevelGenerator.WordToGuess.Length; i++)
				{
					if (ReadFromFileDifficultyLevelGenerator.WordToGuess[i].ToString() != ReadFromFileDifficultyLevelGenerator.HiddenWordToGuess[i])
						continueGame = true;
				}

                
			}

            ConsoleOptions.CountHighScore();
          IfGameEndedByGuessingRight();

        }


        static void IfGameEndedByLosingLives()
        {
            if (Player.PlayerLives == 0) continueGame = false;

            while (continueGame == false)
            {
                string continueYesNo = Console.ReadLine().ToLower();
                if (Player.PlayerLives == 0)
                {
                    Graphics.ShowLosingTheGameGraphic();

                }
                if (continueYesNo == "y")
                {
                    
                    continueGame = true;
                    ConsoleOptions.ShowStartMenu();           //Metoden borde avsluta på ett naturligt sätt, just nu forcerar vi spelet att gå tillbaka till ShowStartMenu Detta medför att alla variabler innehåller samma värden, och ger många logiska buggar.
                                                            // Om vi kör break här så återgår spelet till PlayHangman metoden eftersom den ligger i en loop.
                                                            
                }
                else if (continueYesNo == "n")
                {
                    ConsoleOptions.ExitGame();
                }

            }


            
        }

        

    

        static void IfGameEndedByGuessingRight()
        {
            while (continueGame == false)
            {
                
                Graphics.ShowWinningTheGameGraphic();
                string continueYesNo = Console.ReadLine().ToLower();

                if (continueYesNo == "y")
                {
                    
                    continueGame = true;
                    ConsoleOptions.ShowStartMenu();

                }
                else if (continueYesNo == "n")
                {
                    ConsoleOptions.ExitGame();
                }

            }
        }

	}
}

