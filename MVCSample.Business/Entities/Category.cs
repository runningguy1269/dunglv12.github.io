using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MVCSample.Business.Entities
{
    [Table("categories")]
    public class Category
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int category_id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên danh mục")]
        [StringLength(100,ErrorMessage ="Danh mục không được quá 100 kí tự")]
        [DisplayName("Tên danh mục")]
      
        
        public string category_name { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        [NotMapped]
        public int CurrentPage { get; set; }
        [NotMapped]
        public int PageCount { get; set; }
        //Nhiều
        public virtual ICollection<Product> Products { get; set; }
    }
}
