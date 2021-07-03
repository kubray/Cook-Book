using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cook_Book.Models
{
	public partial class Comment : BaseDBModel
	{
		
		public string Text { get; set; }
		public int UserId { get; set; }
		public int FoodId { get; set; }
		

}
}
