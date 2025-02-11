﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDA.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string Unit { get; set; }
        [Required]
        public string Origin { get; set; }
        [Required]
        [Display(Name = "Price")]
        [Range(1, 1000)]
        public double Price { get; set; }
        public int CategoryId {  get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
		[ValidateNever]
		public List<ProductImage> ProductImages { get; set; }

	}
}
