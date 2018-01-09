using System;
using Microsoft.EntityFrameworkCore;

namespace API.Internal.Models
{
    public class CustomerEventContext : DbContext
    {
        public CustomerEventContext(DbContextOptions<CustomerEventContext> options)
            : base(options)
        {
        }

        public DbSet<CustomerEvent> CustomerEvents { get; set; }
    }
}
