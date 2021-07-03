using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cook_Book.Models
{
    public partial class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Detail { get; set; }

        public string Image { get; set; }

        public string Video { get; set; }
    }
}
