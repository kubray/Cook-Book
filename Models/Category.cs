using System;
using System.Collections.Generic;

#nullable disable

namespace Cook_Book.Models
{
    public partial class Category : BaseDBModel
    {
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
