using System;
using System.Collections.Generic;

#nullable disable

namespace CoreCrud.Models
{
    public partial class UserRegistration
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
    }
}
