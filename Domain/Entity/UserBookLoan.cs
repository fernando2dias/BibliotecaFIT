using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class UserBookLoan : Entity
    {
        public int UserId { get; set; }
        public int BookLoanId { get; set; }
        public virtual User User { get; set; }
        public virtual BookLoan BookLoan { get; set; }
    }
}
