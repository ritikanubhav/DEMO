using System.ComponentModel.DataAnnotations;

namespace Entity.Business
{
	public class DemoClass
	{
		//add id for a primary key( prefix can be class name but Id must be at the last)
		[Required]
		public int DemoClassId { get; set; }
		[Required]
		public int Age { get; set; }
		[Required]
		[StringLength(50,ErrorMessage ="characters > 50")]
		public string Name { get; set; }
	}
}
