using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class BookBookLoan : Entity
    {
        public int BookId { get; set; }
        public int BookLoanId { get; set; }
        public virtual Book Book { get; set; }
        public virtual BookLoan BookLoan { get; set; }

    }
}
