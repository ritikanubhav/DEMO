using Entity.Data;
using Entity.Business;
namespace ConsoleApp2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			DemoClassDbRepo repo = new DemoClassDbRepo();
			DemoClass dc = new DemoClass()
			{
				Age = 10,
				Name = "Test1",
			};
			repo.Insert(dc);
			repo.Insert(new DemoClass()
			{ 
				Age = 12,
				Name = "Test2",
			});
			repo.Insert(new DemoClass()
			{
				Age = 15,
				Name = "Test3",
			});
            Console.WriteLine(" insertion completed");
			repo.Delete(dc);
			repo.Update(new DemoClass()
			{
				DemoClassId = 1,
				Age = 10,
				Name = "UpdatedTest1",
			});
			Console.WriteLine("updated id 1 and deleted id 2");
			DemoClass demoClass = repo.GetById(3);
			Console.WriteLine($"DemoClass with id 3\n{demoClass.DemoClassId} {demoClass.Name} {demoClass.Age}");
		}
	}
}
