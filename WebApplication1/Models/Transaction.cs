using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public string AccountNumber { get; set; }

        public string AccountHolder {  get; set; }

        public string BankName { get; set; }

        public string SWIFTCode { get; set; }

        public int Amount { get; set; }

        public DateTime Date { get; set; }
    }
}
