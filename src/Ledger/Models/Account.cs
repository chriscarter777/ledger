using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ledger.Models
{
    public enum acctType
    {
        Checking,
        Savings,
        Credit,
        Loan,
        Liability,
        Asset
    }

    public class Account
    {
        public int ID { get; set; }
        public int AcctHolderID { get; set; }
        [Required(ErrorMessage = "Please enter an account type.")]
        public acctType AcctType { get; set; }
        [Required(ErrorMessage = "Please enter a name for the account.")]
        public string Name { get; set; }
        public int? AcctNumber { get; set; }
        public string Institution { get; set; }
        public decimal? Limit { get; set; }
        public decimal? Interest { get; set; }
}
}
