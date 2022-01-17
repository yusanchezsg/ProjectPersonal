using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Patter.Models.Entitys
{
    [Table("PRODUCTS")]
    public class Products
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        [Column("ID", Order = 0)]
        public int ProductId { get; set; }
        [Column("DESCRIPTION", Order = 1)]
        public string Description { get; set; }
        [Column("AMOUNT", Order = 2)]
        public string Amount { get; set; }
    }
}
