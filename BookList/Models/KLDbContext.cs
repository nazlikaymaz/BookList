using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookList.Models
{
    public class KLDbContext : DbContext
    {
        public KLDbContext(DbContextOptions<KLDbContext> options)  : base (options)
        {

        }
        public DbSet<Book> Book { get; set; }
    }
}
