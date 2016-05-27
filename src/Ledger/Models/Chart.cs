using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ledger.Models
{
    public class Chart
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Account[] Accounts { get; set; }
        public Classification[] Classifications { get; set; }
        public Category[] Categories { get; set; }
        public decimal MinimumAmt { get; set; }
        public decimal MaximumAmt { get; set; }
        public bool TaxOnly { get; set; }
    }
}
