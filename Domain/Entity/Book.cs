using Domain.Enumerables;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Domain.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int QuantityPages { get; set; }
        public DateTime Published { get; set; }
        public string BarCode { get; set; }
        public Status Status { get; set; }
        public Site Site { get; set; }

        public virtual ICollection<BookBookLoan> BookBookLoans { get; set; }
    }
}
