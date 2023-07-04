using System;
using System.Reflection.Metadata;

namespace UserManager.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }  

    }
}
