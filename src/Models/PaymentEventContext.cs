using System;
using Microsoft.EntityFrameworkCore;

namespace API.Internal.Models
{
    public class PaymentEventContext : DbContext
    {
        public PaymentEventContext(DbContextOptions<PaymentEventContext> options)
            : base(options)
        {
        }

        public DbSet<PaymentEvent> PaymentEvents { get; set; }
    }
}
