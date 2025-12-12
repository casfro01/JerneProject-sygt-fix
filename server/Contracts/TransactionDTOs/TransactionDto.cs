using System;

namespace Contracts.TransactionDTOs;

public class TransactionDto
{
    public string TransactionID { get; set; }
    public string TransactionString { get; set; }
    public DateTime TransactionDate { get; set; }
    public decimal Amount { get; set; }
    public UserData User { get; set; }
    public bool Pending { get; set; }
    
}


// TODO : flyt ud i en anden mappe/fil - kan ikke lige finde rundt i det fordi jeg er idiot
// tilføj gerne det I skal bruge ;)
public record UserData(string name, string email, string id)
{
}
