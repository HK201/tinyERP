﻿using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace tinyERP.Dal.Entities
{
    public class Budget
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public double Amount { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public DbSet<Transaction> Transactions { get; set; }
    }
}