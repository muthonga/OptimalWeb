﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.Optimal
{
    [Table("department", Schema = "huresy")]
    public partial class department
    {
        public department()
        {
            empdet = new HashSet<empdet>();
        }

        [Key]
        public int deptid { get; set; }
        [StringLength(10)]
        public string shortcode { get; set; }
        [Required]
        [StringLength(100)]
        public string deptdesc { get; set; }
        public int deptparent { get; set; }
        [StringLength(50)]
        public string hierarchypath { get; set; }
        [Column(TypeName = "image")]
        public byte[] deptlogo { get; set; }
        public int? deptheadempid { get; set; }
        public bool? isgroup { get; set; }
        public bool? ismulticompany { get; set; }
        public bool? issubsidiary { get; set; }
        public string mission { get; set; }
        public string vision { get; set; }
        [StringLength(50)]
        public string fixedlines { get; set; }
        [StringLength(50)]
        public string cellphones { get; set; }
        [StringLength(50)]
        public string fax { get; set; }
        [StringLength(200)]
        public string postaladdress { get; set; }
        public int? postaltown { get; set; }
        [StringLength(20)]
        public string postalcode { get; set; }
        public int? postalcountry { get; set; }
        [StringLength(150)]
        public string email { get; set; }
        [StringLength(150)]
        public string website { get; set; }
        [StringLength(250)]
        public string physicalstreet { get; set; }
        public int? physicaltown { get; set; }
        public int? physicalcountry { get; set; }
        [StringLength(50)]
        public string pin { get; set; }
        [StringLength(50)]
        public string nssfno { get; set; }
        [StringLength(50)]
        public string nhifno { get; set; }
        [Required]
        public bool? deptvalid { get; set; }

        [InverseProperty("dept")]
        public virtual ICollection<empdet> empdet { get; set; }
    }
}