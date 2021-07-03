using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cook_Book.Models
{
    public partial class Food : BaseDBModel
    {
      
        public string Name { get; set; }

        public string Detail { get; set; }

        public string Image { get; set; }

        public string Video { get; set; }
        public string Recipe { get; set; }

        public string TextColor { get; set; }
        
    }
}
