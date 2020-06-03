using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MVCSample.Business.Entities
{
    [Table("products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int product_id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên sản phẩm")]
        [DisplayName("Tên hàng")]
        public string product_name { get; set; }
        [DisplayName("Nhà cung cấp")]
        [ForeignKey(nameof(Supplier))]
        public int supplier_id { get; set; }
        [ForeignKey(nameof(Category))]
        [DisplayName("Danh mục")]
        public int category_id { get; set; }
        [DisplayName("Quy cách")]
        public string quantity_per_unit { get; set; }
        [DisplayName("Đơn giá")]
        public float unit_price { get; set; }
        [DisplayName("Đơn vị lưu kho")]
        public int units_in_stock { get; set; }
        [DisplayName("Đơn vị xuất bán")]
        public int units_on_order { get; set; }
        [DisplayName("Mức độ đặt hàng lại")]
        public int reorder_level { get; set; }
        [Range(0,1)]
        [DisplayName("Giảm giá")]
        public int discontinued { get; set; }

        //không thừa nhận trường Category trong bảng Product tránh sai sót
        [NotMapped]
        //Một
        public virtual Category Category { get; set; }

        public virtual Supplier Supplier { get; set; }

    }
}
