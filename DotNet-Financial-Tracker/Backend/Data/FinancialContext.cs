using Microsoft.EntityFrameworkCore;
using Backend.Models;

namespace Backend.Data
{
    public class FinancialContext : DbContext
    {
        public FinancialContext(DbContextOptions<FinancialContext> options) : base(options) { }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
