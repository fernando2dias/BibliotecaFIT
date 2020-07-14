using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UserBookLoan> UserBookLoans { get; set; }
    }
}
