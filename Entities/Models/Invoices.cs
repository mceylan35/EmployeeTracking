﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Invoices : IEntity
    {
        public Invoices()
        {
            InvoiceDetails = new HashSet<InvoiceDetails>();
        }

        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public decimal? Total { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual ICollection<InvoiceDetails> InvoiceDetails { get; set; }
    }
}