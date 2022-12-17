using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Data;

namespace ExpenseTracker.Models;
public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ExpenseTrackerContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<ExpenseTrackerContext>>()))
        {
            if (context == null || context.Transaction == null)
            {
                throw new ArgumentNullException("Null ExpenseTrackerContext");
            }

            // Look for any movies.
            if (context.Transaction.Any())
            {
                return;   // DB has been seeded
            }

            context.Transaction.AddRange(
                new Transaction
                {
                    Type = "Expense",
                    Description = null,
                    TransDate = DateTime.Parse("2022-12-12"),
                    Category = "House",
                    Value = 8M
                },
                new Transaction
                {
                    Type = "Expense",
                    Description = "Test description",
                    TransDate = DateTime.Parse("2022-12-11"),
                    Category = "Supermarket",
                    Value = 31.89M
                },
                new Transaction
                {
                    Type = "Revenue",
                    Description = "Payday",
                    TransDate = DateTime.Parse("2023-01-10"),
                    Category = "Work",
                    Value = 2000M
                },
                new Transaction
                {
                    Type = "Expense",
                    Description = null,
                    TransDate = DateTime.Parse("2023-01-10"),
                    Category = "Moving",
                    Value = 250M
                }
            );
            context.SaveChanges();
        }
    }
}
