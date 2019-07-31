using StormyCommerce.Core.Entities.Common;
using System;

namespace StormyCommerce.Core.Entities.Customer
{
    //TODO:Put all Address Data Here, avoid joins on the database
    public class CustomerAddress : Address
    {
        public CustomerAddress()
        {

        }
        public CustomerAddress(int id)
        {
            Id = id;
        }
        public long CustomerId { get; set; }
        public StormyCustomer Customer { get; set; }        
        public DateTimeOffset? LastUsedOn { get; set; }
    }
}
