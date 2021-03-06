﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.Optimal
{
    [Table("leaveoperation", Schema = "huresy")]
    public partial class leaveoperation
    {
        [Key]
        public int leaveopcode { get; set; }
        public int? initopcode { get; set; }
        public int? parentopcode { get; set; }
        public int empid { get; set; }
        public int leavetypecode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime actiondate { get; set; }
        [Column(TypeName = "decimal(10, 1)")]
        public decimal? leavebalbf { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? startdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? returndate { get; set; }
        [Column(TypeName = "decimal(18, 1)")]
        public decimal soughtdays { get; set; }
        [Column(TypeName = "decimal(30, 1)")]
        public decimal? balcf { get; set; }
        public int actionby { get; set; }
        public int? actingempid { get; set; }
        public int leavestagecode { get; set; }
        public int? leavestatuscode { get; set; }
        public string leavecomments { get; set; }
        public int? leaveyear { get; set; }
        public int? paymonth { get; set; }
        public int? payyear { get; set; }
        [Required]
        public bool? iscurrent { get; set; }

        [ForeignKey(nameof(empid))]
        [InverseProperty(nameof(empdet.leaveoperation))]
        public virtual empdet emp { get; set; }
    }
}