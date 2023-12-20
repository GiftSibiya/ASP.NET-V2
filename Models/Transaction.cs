using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        public String AccountNumber { get; set; }
        [Column(TypeName = "nvarchar(100)")]

        public int BeneficiaryName { get; set; }
        [Column(TypeName = "nvarchar(100)")]

        public int BankName { get; set; }
        [Column(TypeName = "nvarchar(11)")]

        public int SwiftCode { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
