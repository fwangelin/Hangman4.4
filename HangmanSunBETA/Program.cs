using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace HangmanSunBETA
{
    class Program
    {
		static void Main(string[] args)
        {

            ConsoleOptions.ReadHighScoreFromFile();


           // ConsoleOptions.ImportHighScore();

            while (GameEngine.continueGame)

            {
                Graphics.ShowPrepareTheGameScreen();
				Graphics.ShowHangmanIntroGraphics();
            
                ConsoleOptions.ShowStartMenu();      

            }
        }

     
    }
}




