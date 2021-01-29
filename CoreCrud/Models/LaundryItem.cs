using System;
using System.Collections.Generic;

#nullable disable

namespace CoreCrud.Models
{
    public partial class LaundryItem
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal? Price { get; set; }
    }
}
