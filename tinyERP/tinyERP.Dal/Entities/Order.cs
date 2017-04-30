﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using tinyERP.Dal.Types;

namespace tinyERP.Dal.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public State State { get; set; }

        [Required]
        public DateTime CreationDate { get; set; } = DateTime.Today;

        [Required]
        public DateTime StateModificationDate { get; set; } = DateTime.Today;

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public string OrderNumber => Id != 0 ? $"{CreationDate.Year % 100}-{Id:000}" : "Nach dem Speichern generiert";
    }
}
