using MVCSample.Business.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCSample.Business.Models
{
    public class CategoryViewModel
    {
        public CategoryViewModel()
        {
            this.Products = new HashSet<Product>();
        }

        [Required(ErrorMessage = "Vui lòng nhập tên danh mục")]
        [StringLength(100, ErrorMessage = "Danh mục không được quá 100 kí tự")]
        [DisplayName("Tên danh mục")]

        public string category_name { get; set; }
     

        public virtual ICollection<Product> Products { get; set; }
    }
}