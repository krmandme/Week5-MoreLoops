using System;

namespace MoreLoops
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm küsib kasutajal sisestada kasutajatunnus ja salasõna
			//kui sisestatud kasutajatunnus on "admin" ja salasõna "admin1234"
			//siis konsool kuvab "Tere tulemast!";
			//muul juhul konsool kuvab "Vale kasutajatunnus või salasõna. Proovi uuesti."

			Console.WriteLine("Sisesta kasutajatunnus:");
			string userName = Console.ReadLine();
			Console.WriteLine("Sisesta salasõna:");
			string userPassword = Console.ReadLine();

			//AND (&&) või OR

			//"admin" AND "admin1234" --> true
			//"admin1" AND "admin1234" --> false
			//"admin" AND "admin12345" --> false
			//"admin1" AND "admin123" --> false



			if (userName == "admin" && userPassword == "admin1234")
			{
				Console.WriteLine("Tere tulemast!");
			}
			else
			{
				Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
			}

		}
	}
}
