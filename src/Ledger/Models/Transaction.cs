using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ledger.Models
{
    public class Transaction
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter an account to debit.")]
        public int DebitAcctID { get; set; }
        [Required(ErrorMessage = "Please enter an account to credit.")]
        public int CreditAcctID { get; set; }
        public Classification Classification { get; set; }
        public Category Category { get; set; }
        public int? CheckNumber { get; set; }
        public bool TaxFlag { get; set; }
        public bool Flag { get; set; }
        public string Description { get; set; }
    }
}
