using ExpenseTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Application.Abstractions
{
    public interface IAppDbContext
    {
        DbSet<Expense> Expenses { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
