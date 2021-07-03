using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cook_Book.Models
{
	public partial class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public DateTime RegisterDate { get; set; }
		public DateTime BirthDate { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }

		
	}
}
