﻿using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class OrderItem : BaseEntity, IAggregateRoot
    {
        [Key]
        public int OrderItemId { get; private set; }
        public string OrderItemQuantity { get; private set; }
        public decimal OrderItemPrice { get; private set; }

        /// <summary>
        /// RMA = Return Merchandise Authorization.
        /// </summary>
        public int RMANumber { get; private set; }
        public string RMAIssuedBy { get; private set; }
        public DateTime RMAIssuedDate { get; private set; }
        public string OtherOrderItemDetails { get; private set; }

        [ForeignKey("Product")]
        public int ProductId { get; private set; }

        [ForeignKey("Order")]
        public int OrderId { get; private set; }

        [ForeignKey("RefOrderItemStatusCode")]
        public int OrderItemStatusCode { get; private set; }

        public virtual Product Products { get; private set; }
        public virtual Order Order { get; private set; }
        public virtual RefOrderItemStatusCode RefOrderItemStatusCode { get; private set; }
        public virtual ICollection<ShipmentItem> ShipmentItems { get; set; }
    }
}
