﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.Optimal
{
    [Table("empstate", Schema = "huresy")]
    public partial class empstate
    {
        [Key]
        public int empstatecode { get; set; }
        [Required]
        [StringLength(100)]
        public string empstatedesc { get; set; }
        public double payratio { get; set; }
        [Required]
        public bool? empstatevalid { get; set; }
        [StringLength(20)]
        public string service_type { get; set; }
    }
}