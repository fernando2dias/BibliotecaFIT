using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class BookLoan
    {
        public int Id { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public virtual ICollection<BookBookLoan> BookBookLoans { get; set; }
        public virtual ICollection<UserBookLoan> UserBookLoans { get; set; }
    }
}
