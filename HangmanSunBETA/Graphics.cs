using System;
using System.Threading;

namespace HangmanSunBETA
{
    class Graphics
    {

        public static void ShowPrepareTheGameScreen()
        {
            Console.WindowWidth = 110;
            Console.WindowHeight = 30;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
        }


        static public void HangmanGraphicSpacing()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }

        static public void ShowStartMenuGraphics()
        {
            Console.Clear();
            HangmanGraphicSpacing();
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("***                 Choose one option               ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***                     1.Start                     ***".PadLeft(80));
            Console.WriteLine("***                     2.Storyline                 ***".PadLeft(80));
            Console.WriteLine("***                     3.Info                      ***".PadLeft(80));
            Console.WriteLine("***                     4.Highscore                 ***".PadLeft(80));
            Console.WriteLine("***                     5.Quit                      ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***        To choose one option type in a number    ***".PadLeft(80));
            Console.WriteLine("***                  between 1 and 5                ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));

        }

        static public void ShowInfoGraphics()
        {
            Console.Clear();
            HangmanGraphicSpacing();
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("*** When game has started a hidden word will appear ***".PadLeft(80));
            Console.WriteLine("*** in the form of: - Each line represent 1 letter. ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("*** When you type in a letter that exists in the    ***".PadLeft(80));
            Console.WriteLine("*** hidden word, the represented line will change   ***".PadLeft(80));
            Console.WriteLine("*** and the correct guessed letter will appear in   ***".PadLeft(80));
            Console.WriteLine("*** its spot in the word to guess.                  ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("*** If you manage to guess all correct letters in   ***".PadLeft(80));
            Console.WriteLine("*** the word your lives will generate points that   ***".PadLeft(80));
            Console.WriteLine("*** can be displayed as Highscore in the beginning  ***".PadLeft(80));
            Console.WriteLine("*** of the game.                                    ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("*** If your lives run out, you will get the         ***".PadLeft(80));
            Console.WriteLine("*** option to try again.                            ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***        Game created by BetaGroup, 2016          ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));

        }


        static public void ShowTypeInNameGraphics()
        {
            Console.Clear();
            HangmanGraphicSpacing();
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***            Please type in your name!            ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***     Your name must be at least 3 characters!    ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));
        }

        static public void ShowGameplayGraphics()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("                                               Welcome " + Player.PlayerName);
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***            Now you have the chance to           ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***       save the guilty convict... Good luck!     ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine();
            Console.WriteLine();

        }


        static public void ShowDifficultyGraphics()
        {
            Console.Clear();
            HangmanGraphicSpacing();
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("***              Choose difficulty level            ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***                     1.Easy                      ***".PadLeft(80));
            Console.WriteLine("***                     2.Normal                    ***".PadLeft(80));
            Console.WriteLine("***                     3.Hard                      ***".PadLeft(80));
            Console.WriteLine("***                     4.Back                      ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***        To choose one option type in a number    ***".PadLeft(80));
            Console.WriteLine("***                  between 1 and 4                ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));
        }


        static public void ShowHangmanIntroGraphics()
        {


            Thread.Sleep(1000);

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(@"██╗  ██╗ █████╗ ".PadLeft(65));
            Console.WriteLine(@"██║  ██║██╔══██╗".PadLeft(65));
            Console.WriteLine(@"███████║███████║".PadLeft(65));
            Console.WriteLine(@"██╔══██║██╔══██║".PadLeft(65));
            Console.WriteLine(@"██║  ██║██║  ██║".PadLeft(65));
            Console.WriteLine(@"╚═╝  ╚═╝╚═╝  ╚═╝".PadLeft(65));

            Console.Beep(440, 500);   //
            Console.Beep(440, 500);
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(@"██╗  ██╗ █████╗ ███╗   ██╗ ██████╗ ".PadLeft(70));
            Console.WriteLine(@"██║  ██║██╔══██╗████╗  ██║██╔════╝ ".PadLeft(70));
            Console.WriteLine(@"███████║███████║██╔██╗ ██║██║  ███╗".PadLeft(70));
            Console.WriteLine(@"██╔══██║██╔══██║██║╚██╗██║██║   ██║".PadLeft(70));
            Console.WriteLine(@"██║  ██║██║  ██║██║ ╚████║╚██████╔╝".PadLeft(70));
            Console.WriteLine(@"╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝ ".PadLeft(70));


            Console.Beep(440, 500); //
            Console.Beep(349, 350);
            Console.Beep(523, 150);

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(@"██╗  ██╗ █████╗ ███╗   ██╗ ██████╗ ███╗   ███╗ █████╗ ".PadLeft(80));
            Console.WriteLine(@"██║  ██║██╔══██╗████╗  ██║██╔════╝ ████╗ ████║██╔══██╗".PadLeft(80));
            Console.WriteLine(@"███████║███████║██╔██╗ ██║██║  ███╗██╔████╔██║███████║".PadLeft(80));
            Console.WriteLine(@"██╔══██║██╔══██║██║╚██╗██║██║   ██║██║╚██╔╝██║██╔══██║".PadLeft(80));
            Console.WriteLine(@"██║  ██║██║  ██║██║ ╚████║╚██████╔╝██║ ╚═╝ ██║██║  ██║".PadLeft(80));
            Console.WriteLine(@"╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝     ╚═╝╚═╝  ╚═╝".PadLeft(80));
            Console.Beep(440, 500); //

            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(@"██╗  ██╗ █████╗ ███╗   ██╗ ██████╗ ███╗   ███╗ █████╗ ███╗   ██╗".PadLeft(85));
            Console.WriteLine(@"██║  ██║██╔══██╗████╗  ██║██╔════╝ ████╗ ████║██╔══██╗████╗  ██║".PadLeft(85));
            Console.WriteLine(@"███████║███████║██╔██╗ ██║██║  ███╗██╔████╔██║███████║██╔██╗ ██║".PadLeft(85));
            Console.WriteLine(@"██╔══██║██╔══██║██║╚██╗██║██║   ██║██║╚██╔╝██║██╔══██║██║╚██╗██║".PadLeft(85));
            Console.WriteLine(@"██║  ██║██║  ██║██║ ╚████║╚██████╔╝██║ ╚═╝ ██║██║  ██║██║ ╚████║".PadLeft(85));
            Console.WriteLine(@"╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝".PadLeft(85));
            Console.WriteLine(@"                                                                ".PadLeft(85));
            Console.WriteLine(@"                                                     Version 4.4".PadLeft(85));
            Console.Beep(440, 1000); //
            Console.WriteLine("Welcome to Hangman The Game".PadLeft(65));

            Console.Beep(659, 500);//
            Console.Beep(659, 500);
            Console.WriteLine("Now we will have some fun!".PadLeft(65));
            Console.Beep(659, 500);//
            Console.Beep(698, 350);
            Console.Beep(523, 150);
            Console.WriteLine();
            Console.WriteLine("Try to save Mr.Plugger".PadLeft(62));
            Console.Beep(415, 500);//
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.WriteLine("by guessing the right word!".PadLeft(65));
            Console.Beep(440, 1000);//
            Console.WriteLine();


            ConsoleOptions.ImportHighScore();
            Console.WriteLine("Press enter to continue".PadLeft(67));
        }


        static public void ShowStoryLineGraphics()
        {
            Console.Clear();
            HangmanGraphicSpacing();
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***    Mr.Plugger is a GUILTY bastard that wants    ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***       to escape the clutches of hell, but       ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***                can you save him?                ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***        Are you ready to create injustice?       ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***              by saving Mr.Plugger?              ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));

        }

        static public void ShowLosingTheGameGraphic()
        {
            Console.Clear();
            HangmanGraphicSpacing();
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***          Well now Mr.Plugger got hanged         ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***            and you might wonder why?            ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***           Well it's all because of you          ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***          and your inability to think :/         ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***              Poor poor Mr.Plugger...            ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine();
            Console.WriteLine("Would you like to play again? Y/N".PadLeft(68));
        }

        static public void ShowWinningTheGameGraphic()
        {
            Console.Clear();
            HangmanGraphicSpacing();
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***                CONGRATULATIONS!                 ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***           Mr.Plugger is now free, and you       ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***     totally brought injustice upon this world   ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***     by releasing an evil man as Mr.Plugger...   ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("***   Oh he also punched you in the face as thanks! ***".PadLeft(80));
            Console.WriteLine("***                                                 ***".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("*******************************************************".PadLeft(80));
            Console.WriteLine("The correct word was: ".PadLeft(59) + ReadFromFileDifficultyLevelGenerator.WordToGuess);
            Console.WriteLine();
            //här har jag lagt till text som säger vilket ord som var korrekt
            Console.WriteLine("Would you like to play again? Y/N".PadLeft(68));
        }

        static public void ShowMrPluggerGraphics()
        {
            Console.Clear();
            if (Player.PlayerLives == 10)
            {
                ShowGameplayGraphics();
                Console.WriteLine(@"                                                               ");
                Console.WriteLine(@"                                                               ");
                Console.WriteLine(@"                                                               ");
                Console.WriteLine(@"                                                               ");
                Console.WriteLine(@"                                                                ");
                Console.WriteLine(@"                                                                ");
                Console.WriteLine(@"                                                               ");
                Console.WriteLine(@"                                                     ");
                Console.WriteLine(@"                                                     ");
                Console.WriteLine(@"                                                               ");
                Console.WriteLine(@"                                                               ");
                Console.WriteLine(@"                                                                 ");
            }
            else if (Player.PlayerLives == 9)
            {
                ShowGameplayGraphics();
                Console.WriteLine(@"                                                               ");
                Console.WriteLine(@"                                                               ");
                Console.WriteLine(@"                                                               ");
                Console.WriteLine(@"                                                               ");
                Console.WriteLine(@"                                                                ");
                Console.WriteLine(@"                                                                ");
                Console.WriteLine(@"                                                               ");
                Console.WriteLine(@"                                                     ");
                Console.WriteLine(@"                                                     ");
                Console.WriteLine(@"                                          __________ _________ ");
                Console.WriteLine(@"                                         /                    \");
                Console.WriteLine(@"                                        /                      \ ");
            }
            else if (Player.PlayerLives == 8)
            {
                ShowGameplayGraphics();
                Console.WriteLine(@"                                                               ");
                Console.WriteLine(@"                                                    |          ");
                Console.WriteLine(@"                                                    |          ");
                Console.WriteLine(@"                                                    |          ");
                Console.WriteLine(@"                                                    |           ");
                Console.WriteLine(@"                                                    |           ");
                Console.WriteLine(@"                                                    |          ");
                Console.WriteLine(@"                                                    |");
                Console.WriteLine(@"                                                    |");
                Console.WriteLine(@"                                          __________|_________ ");
                Console.WriteLine(@"                                         /                    \");
                Console.WriteLine(@"                                        /                      \ ");
            }
            else if (Player.PlayerLives == 7)
            {
                ShowGameplayGraphics();
                Console.WriteLine(@"                                                     ________ ");
                Console.WriteLine(@"                                                    |          ");
                Console.WriteLine(@"                                                    |          ");
                Console.WriteLine(@"                                                    |          ");
                Console.WriteLine(@"                                                    |          ");
                Console.WriteLine(@"                                                    |          ");
                Console.WriteLine(@"                                                    |           ");
                Console.WriteLine(@"                                                    |           ");
                Console.WriteLine(@"                                                    |          ");
                Console.WriteLine(@"                                          __________|_________ ");
                Console.WriteLine(@"                                         /                    \");
                Console.WriteLine(@"                                        /                      \ ");
            }
            else if (Player.PlayerLives == 6)
            {
                ShowGameplayGraphics();
                Console.WriteLine(@"                                                     ________ ");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |         ");
                Console.WriteLine(@"                                                    |          ");
                Console.WriteLine(@"                                                    |           ");
                Console.WriteLine(@"                                                    |          ");
                Console.WriteLine(@"                                          __________|_________ ");
                Console.WriteLine(@"                                         /                    \");
                Console.WriteLine(@"                                        /                      \ ");
            }
            else if (Player.PlayerLives == 5)
            {
                ShowGameplayGraphics();
                Console.WriteLine(@"                                                     ________ ");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        O");
                Console.WriteLine(@"                                                    |          ");
                Console.WriteLine(@"                                                    |           ");
                Console.WriteLine(@"                                                    |          ");
                Console.WriteLine(@"                                          __________|_________ ");
                Console.WriteLine(@"                                         /                    \");
                Console.WriteLine(@"                                        /                      \ ");
            }
            else if (Player.PlayerLives == 4)
            {
                ShowGameplayGraphics();
                Console.WriteLine(@"                                                     ________ ");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        O");
                Console.WriteLine(@"                                                    |        | ");
                Console.WriteLine(@"                                                    |          ");
                Console.WriteLine(@"                                                    |          ");
                Console.WriteLine(@"                                          __________|_________ ");
                Console.WriteLine(@"                                         /                    \");
                Console.WriteLine(@"                                        /                      \ ");
            }
            else if (Player.PlayerLives == 3)
            {
                ShowGameplayGraphics();
                Console.WriteLine(@"                                                     ________ ");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        O");
                Console.WriteLine(@"                                                    |       /| ");
                Console.WriteLine(@"                                                    |          ");
                Console.WriteLine(@"                                                    |          ");
                Console.WriteLine(@"                                          __________|_________ ");
                Console.WriteLine(@"                                         /                    \");
                Console.WriteLine(@"                                        /                      \ ");
            }
            else if (Player.PlayerLives == 2)
            {
                ShowGameplayGraphics();
                Console.WriteLine(@"                                                     ________ ");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        O");
                Console.WriteLine(@"                                                    |       /|\");
                Console.WriteLine(@"                                                    |          ");
                Console.WriteLine(@"                                                    |          ");
                Console.WriteLine(@"                                          __________|_________ ");
                Console.WriteLine(@"                                         /                    \");
                Console.WriteLine(@"                                        /                      \ ");
            }
            else if (Player.PlayerLives == 1)
            {
                ShowGameplayGraphics();
                Console.WriteLine(@"                                                     ________ ");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        O");
                Console.WriteLine(@"                                                    |       /|\");
                Console.WriteLine(@"                                                    |       /  ");
                Console.WriteLine(@"                                                    |          ");
                Console.WriteLine(@"                                          __________|_________ ");
                Console.WriteLine(@"                                         /                    \");
                Console.WriteLine(@"                                        /                      \ ");
            }
            else if (Player.PlayerLives == 0)
            {
                ShowGameplayGraphics();
                Console.WriteLine(@"                                                     ________ ");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                                    |        O");
                Console.WriteLine(@"                                                    |       /|\");
                Console.WriteLine(@"                                                    |       /|\");
                Console.WriteLine(@"                                                    |        |");
                Console.WriteLine(@"                                          __________|_________ ");
                Console.WriteLine(@"                                         /                    \");
                Console.WriteLine(@"                                        /                      \ ");
                Console.WriteLine();

            }

        }



        static public void GameMusic()
        {

            {
                System.Threading.Thread thread = new System.Threading.Thread(
                new System.Threading.ThreadStart(
                delegate ()
                {

                    {
                        Console.Beep(659, 125);
                        Console.Beep(659, 125);
                        Thread.Sleep(125);
                        Console.Beep(659, 125);
                        Thread.Sleep(167);
                        Console.Beep(523, 125);
                        Console.Beep(659, 125);
                        Thread.Sleep(125);
                        Console.Beep(784, 125);
                        Thread.Sleep(375);
                        Console.Beep(392, 125);
                        Thread.Sleep(375);
                        Console.Beep(523, 125);
                        Thread.Sleep(250);
                        Console.Beep(392, 125);
                        Thread.Sleep(250);
                        Console.Beep(330, 125);
                        Thread.Sleep(250);
                        Console.Beep(440, 125);
                        Thread.Sleep(125);
                        Console.Beep(494, 125);
                        Thread.Sleep(125);
                        Console.Beep(466, 125);
                        Thread.Sleep(42);
                        Console.Beep(440, 125);
                        Thread.Sleep(125);
                        Console.Beep(392, 125);
                        Thread.Sleep(125);
                        Console.Beep(659, 125);
                        Thread.Sleep(125);
                        Console.Beep(784, 125);
                        Thread.Sleep(125);
                        Console.Beep(880, 125);
                        Thread.Sleep(125);
                        Console.Beep(698, 125);
                        Console.Beep(784, 125);
                        Thread.Sleep(125);
                        Console.Beep(659, 125);
                        Thread.Sleep(125);
                        Console.Beep(523, 125);
                        Thread.Sleep(125);
                        Console.Beep(587, 125);
                        Console.Beep(494, 125);
                        Thread.Sleep(125);
                        Console.Beep(523, 125);
                        Thread.Sleep(250);
                        Console.Beep(392, 125);
                        Thread.Sleep(250);
                        Console.Beep(330, 125);
                        Thread.Sleep(250);
                        Console.Beep(440, 125);
                        Thread.Sleep(125);
                        Console.Beep(494, 125);
                        Thread.Sleep(125);
                        Console.Beep(466, 125);
                        Thread.Sleep(42);
                        Console.Beep(440, 125);
                        Thread.Sleep(125);
                        Console.Beep(392, 125);
                        Thread.Sleep(125);
                        Console.Beep(659, 125);
                        Thread.Sleep(125);
                        Console.Beep(784, 125);
                        Thread.Sleep(125);
                        Console.Beep(880, 125);
                        Thread.Sleep(125);
                        Console.Beep(698, 125);
                        Console.Beep(784, 125);
                        Thread.Sleep(125);
                        Console.Beep(659, 125);
                        Thread.Sleep(125);
                        Console.Beep(523, 125);
                        Thread.Sleep(125);
                        Console.Beep(587, 125);
                        Console.Beep(494, 125);
                        Thread.Sleep(375);
                        Console.Beep(784, 125);
                        Console.Beep(740, 125);
                        Console.Beep(698, 125);
                        Thread.Sleep(42);
                        Console.Beep(622, 125);
                        Thread.Sleep(125);
                        Console.Beep(659, 125);
                        Thread.Sleep(167);
                        Console.Beep(415, 125);
                        Console.Beep(440, 125);
                        Console.Beep(523, 125);
                        Thread.Sleep(125);
                        Console.Beep(440, 125);
                        Console.Beep(523, 125);
                        Console.Beep(587, 125);
                        Thread.Sleep(250);
                        Console.Beep(784, 125);
                        Console.Beep(740, 125);
                        Console.Beep(698, 125);
                        Thread.Sleep(42);
                        Console.Beep(622, 125);
                        Thread.Sleep(125);
                        Console.Beep(659, 125);
                        Thread.Sleep(167);
                        Console.Beep(698, 125);
                        Thread.Sleep(125);
                        Console.Beep(698, 125);
                        Console.Beep(698, 125);
                        Thread.Sleep(625);
                        Console.Beep(784, 125);
                        Console.Beep(740, 125);
                        Console.Beep(698, 125);
                        Thread.Sleep(42);
                        Console.Beep(622, 125);
                        Thread.Sleep(125);
                        Console.Beep(659, 125);
                        Thread.Sleep(167);
                        Console.Beep(415, 125);
                        Console.Beep(440, 125);
                        Console.Beep(523, 125);
                        Thread.Sleep(125);
                        Console.Beep(440, 125);
                        Console.Beep(523, 125);
                        Console.Beep(587, 125);
                        Thread.Sleep(250);
                        Console.Beep(622, 125);
                        Thread.Sleep(250);
                        Console.Beep(587, 125);
                        Thread.Sleep(250);
                        Console.Beep(523, 125);
                        Thread.Sleep(1125);
                        Console.Beep(784, 125);
                        Console.Beep(740, 125);
                        Console.Beep(698, 125);
                        Thread.Sleep(42);
                        Console.Beep(622, 125);
                        Thread.Sleep(125);
                        Console.Beep(659, 125);
                        Thread.Sleep(167);
                        Console.Beep(415, 125);
                        Console.Beep(440, 125);
                        Console.Beep(523, 125);
                        Thread.Sleep(125);
                        Console.Beep(440, 125);
                        Console.Beep(523, 125);
                        Console.Beep(587, 125);
                        Thread.Sleep(250);
                        Console.Beep(784, 125);
                        Console.Beep(740, 125);
                        Console.Beep(698, 125);
                        Thread.Sleep(42);
                        Console.Beep(622, 125);
                        Thread.Sleep(125);
                        Console.Beep(659, 125);
                        Thread.Sleep(167);
                        Console.Beep(698, 125);
                        Thread.Sleep(125);
                        Console.Beep(698, 125);
                        Console.Beep(698, 125);
                        Thread.Sleep(625);
                        Console.Beep(784, 125);
                        Console.Beep(740, 125);
                        Console.Beep(698, 125);
                        Thread.Sleep(42);
                        Console.Beep(622, 125);
                        Thread.Sleep(125);
                        Console.Beep(659, 125);
                        Thread.Sleep(167);
                        Console.Beep(415, 125);
                        Console.Beep(440, 125);
                        Console.Beep(523, 125);
                        Thread.Sleep(125);
                        Console.Beep(440, 125);
                        Console.Beep(523, 125);
                        Console.Beep(587, 125);
                        Thread.Sleep(250);
                        Console.Beep(622, 125);
                        Thread.Sleep(250);
                        Console.Beep(587, 125);
                        Thread.Sleep(250);
                        Console.Beep(523, 125);
                        Thread.Sleep(625);

                    }
                }
                ));

                thread.Start();
            }

        }




    }
}
