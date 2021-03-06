﻿using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class RefOrderStatusCode : BaseEntity, IAggregateRoot
    {
        [Key]
        public int OrderStatusCode { get; set; }

        // Cancelled, Completed, etc.
        // TO DO: Сделать для таких значений enum (везде).
        public string OrderStatusDescription { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
