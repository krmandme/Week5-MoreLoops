using System;

namespace LoginValidation
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm küsib kasutajal sisestada kasutajatunnus ja salasõna
			//kui sisestatud kasutajatunnus on "admin" ja salasõna "admin1234"
			//siis konsool kuvab "Tere tulemast!";
			//muul juhul konsool kuvab "Vale kasutajatunnus või salasõna. Proovi uuesti."
			//kasutajal on 3 katset

			int i = 0;
				while (i < 3) 
			{
				Console.WriteLine("Sisesta kasutajatunnus:");
				string userName = Console.ReadLine();
				Console.WriteLine("Sisesta salasõna:");
				string userPassword = Console.ReadLine();

				if (userName == "admin" && userPassword == "admin1234")
				{
					Console.WriteLine("Tere tulemast!");
					break;
				}
				else
				{
					i++;
					Console.WriteLine($"Vale kasutajatunnus või salasõna, jäänud on {3 - i} katset.");
				}
			}
			if (3 - i == 0)
			{
				Console.WriteLine("Nägemist!");
			}

			
		}
	}
}
