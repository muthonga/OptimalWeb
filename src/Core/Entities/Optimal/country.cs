﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.Optimal
{
    [Table("country", Schema = "huresy")]
    public partial class country
    {
        [Key]
        public int contrycode { get; set; }
        [StringLength(100)]
        public string countryname { get; set; }
        [StringLength(255)]
        public string nationality { get; set; }
    }
}