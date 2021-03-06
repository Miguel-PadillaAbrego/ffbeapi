﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ffbeApi.Database.Entities
{
    [Table("equipment_types")]
    public partial class EquipmentTypes
    {
        public EquipmentTypes()
        {
            Equipment = new HashSet<Equipment>();
        }

        [Column("id")]
        public short Id { get; set; }
        [Required]
        [Column("name")]
        public string Name { get; set; }
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [InverseProperty("Type")]
        public ICollection<Equipment> Equipment { get; set; }
    }
}
