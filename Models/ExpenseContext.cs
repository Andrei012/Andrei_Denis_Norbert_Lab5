using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Andrei_Denis_Norbert_Lab5.Models
{
    public class ExpenseContext: DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options): base(options)
        {
        }
        public DbSet<Expenses> Expense { get; set; }
        public DbSet<ExpenseDTO> ExpenseDTO { get; set; }
    }
}
