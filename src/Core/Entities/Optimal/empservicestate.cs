﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.Optimal
{
    [Table("empservicestate", Schema = "huresy")]
    public partial class empservicestate
    {
        public empservicestate()
        {
            empdet = new HashSet<empdet>();
        }

        [Key]
        public int empservicestatecode { get; set; }
        [Required]
        [StringLength(100)]
        public string empservicestatedesc { get; set; }
        public double payratio { get; set; }
        [Required]
        public bool? isvalid { get; set; }

        [InverseProperty("empservicestatecodeNavigation")]
        public virtual ICollection<empdet> empdet { get; set; }
    }
}