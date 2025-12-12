
using Contracts.TransactionDTOs;
using dataaccess.Entities;

namespace service.Mappers;

public static class TransactionMapper
{
    public static TransactionDto ToDto(Transaction t) =>
        t == null ? null : new TransactionDto
        {
            TransactionID = t.TransactionID,
            TransactionString = t.TransactionString,
            TransactionDate = t.TransactionDate,
            Amount = t.Amount,
            User = new UserData(name: t.User.Firstname, email: t.User.Email, id: t.User.UserID),
            Pending = t.Pending
        };

    public static Transaction ToEntity(CreateTransactionDto dto) =>
        new Transaction
        {
            TransactionID = Guid.NewGuid().ToString(),
            TransactionString = dto.TransactionString,
            TransactionDate = dto.TransactionDate ?? DateTime.UtcNow,
            Amount = dto.Amount,
            User = new User{UserID = dto.UserID}, // jeg håber den kan finde ud af dette lol - det tænker jeg hehe
            Pending = dto.Pending ?? true
        };

    public static void ApplyUpdate(Transaction target, UpdateTransactionDto dto)
    {
        if (dto.TransactionString != null) target.TransactionString = dto.TransactionString;
        if (dto.TransactionDate.HasValue) target.TransactionDate = dto.TransactionDate.Value;
        if (dto.Amount.HasValue) target.Amount = dto.Amount.Value;
        if (dto.UserID != null) target.User.UserID = dto.UserID;
        if (dto.Pending.HasValue) target.Pending = dto.Pending.Value;
    }
}