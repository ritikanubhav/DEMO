using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Business;
using Microsoft.EntityFrameworkCore;

namespace Entity.Data
{
	//1. create your dbcontext class inheriting from dbcontext
	internal class DemoDbcontext:DbContext
	{
		//2. override method onconfiguring(optionBuilder)
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//3. add sql server connection string
			optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=EFdemo;Integrated Security=True");
		}

		//4. add dbset for classes /entities
		// map to tables
		public DbSet<DemoClass> DemoClasses { get; set; }
	}
}
