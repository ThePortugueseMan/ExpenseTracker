using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Data;
using ExpenseTracker.Models;

namespace ExpenseTracker.Pages.Transactions
{
    public class IndexModel : PageModel
    {
        private readonly ExpenseTracker.Data.ExpenseTrackerContext _context;

        public IndexModel(ExpenseTracker.Data.ExpenseTrackerContext context)
        {
            _context = context;
        }

        public IList<Transaction> Transaction { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Transaction != null)
            {
                Transaction = await _context.Transaction.ToListAsync();
            }
        }
    }
}
