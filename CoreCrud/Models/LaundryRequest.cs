using System;
using System.Collections.Generic;

#nullable disable

namespace CoreCrud.Models
{
    public partial class LaundryRequest
    {
        public int RequestId { get; set; }
        public DateTime? RequestDate { get; set; }
        public string RequestName { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public int? TopWear { get; set; }
        public int? BottomWear { get; set; }
        public int? WooleanCloth { get; set; }
        public int? Saree { get; set; }
        public int? Other { get; set; }
    }
}
