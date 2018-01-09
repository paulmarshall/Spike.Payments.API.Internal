using System;

namespace API.Internal.Models
{
    public class CustomerEvent
    {
       public int Id { get; set; }

       public Guid CustomerId { get; set; }

       public DateTime TimeStamp { get; set; }

       public string Name { get; set; }
    }
}
