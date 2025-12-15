using System.ComponentModel.DataAnnotations.Schema;
using Sieve.Attributes;

namespace dataaccess.Entities;

public class Transaction
{
    public String TransactionID { get; set; }
    
    [Sieve(CanSort = true, CanFilter = true)]
    public String TransactionString { get; set; }
    
    [Sieve(CanSort = true, CanFilter = true)]
    public DateTime TransactionDate { get; set; }
    
    [Sieve(CanSort = true, CanFilter = true)]
    public Decimal Amount { get; set; }
    
    [Sieve(CanSort = true, CanFilter = true)]
    public User User { get; set; } // navigations instans

    [ForeignKey(nameof(User))]
    public string UserID { get; set; }

    [Sieve(CanSort = true, CanFilter = true)]
    public bool Pending { get; set; }
}