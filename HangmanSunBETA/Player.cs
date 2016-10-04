using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanSunBETA
{
	class Player
	{
		static string playerName;
		static int playerLives;


        public static string PlayerName
		{
			get { return playerName; }
			set
			{		
				playerName = value;					        		
			}
		}

		
		public static int PlayerLives
		{
			get { return playerLives; }

			set
			{
				playerLives = value;

			}
		}

	


	}
}
