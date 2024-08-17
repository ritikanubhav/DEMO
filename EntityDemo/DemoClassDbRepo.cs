using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Business;

namespace Entity.Data
{
	public class DemoClassDbRepo
	{
		private DemoDbcontext db=new DemoDbcontext();
		public void Insert(DemoClass dc)
		{
			db.DemoClasses.Add(dc);	
			db.SaveChanges();
		}
		public void Update(DemoClass dc)
		{
			db.DemoClasses.Update(dc);
			db.SaveChanges();
		}
		public void Delete(DemoClass dc)
		{
			db.DemoClasses.Remove(dc);
			db.SaveChanges();
		}

		public DemoClass GetById(int id)
		{
			DemoClass dc=db.DemoClasses.Find(id);
			return dc;
		}
	}
}
