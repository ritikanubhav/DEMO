using DEMO;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			FirstTableRepo repo = new FirstTableRepo();
			//repo.insert(1, "Enam", 21);
			//repo.insert(2, "Enam", 22);
			//repo.insert(3, "Enam", 23);
			//repo.insert(4, "Enam", 24);
			//repo.insert(5, "Enam", 25);
			//repo.insert(6, "Enam", 26);
			repo.GetAgeById("Enam");
		}
	}
}
