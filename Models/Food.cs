using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int CategoryId { get; set; }
        // Database map'lemesıne gerek yok.
        // Sadece ekranda göstermek ıçın ekledım.
        [NotMapped]
        public List<Comment> Comments { get; set; }

             
    }
}
