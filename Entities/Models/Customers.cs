﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Customers : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}