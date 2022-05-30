using System;

namespace DiceGame
{
	class Program
	{
		static void Main(string[] args)
		{
            //mängus osaleb 2 mängijat - arvuti ja kasutaja;
            //mõlemad mängijad veeretavad tärinuid;
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskab rohkem, on võitja
            //* täringuid visatakse 3x
            //programm kuulutab võitja.

            Random rnd = new Random();

            //arvuti vise
            int cpuRandom = rnd.Next(1, 7);

            //kasutaja vise
            int userRandom = rnd.Next(1, 7);

            int cpuScore = 0;
            int userScore = 0;
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");

                if (cpuRandom < userRandom)
                {
                    userScore++;
                }
                else
                {
                    cpuScore++;
                }
                //arvuti vise
                cpuRandom = rnd.Next(1, 7);

                //kasutaja vise
                userRandom = rnd.Next(1, 7);
                i++;

            }
            if (userScore > cpuScore)
            {
                Console.WriteLine($"Kasutaja võitis. Võitude arv oli {userScore}.");
            }
            else
            {
                Console.WriteLine($"Arvuti võitis. Võitude arv oli {cpuScore}.");
            }

            if (userScore == cpuScore)
            {
                Console.WriteLine("Viik!");
            }

        }
    }
}
