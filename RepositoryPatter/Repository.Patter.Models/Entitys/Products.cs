using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Patter.Models.Entitys
{
    [Table("PRODUCTS")]
    public class Products
    {

        public int ProductId { get; set; }
        public string  Description { get; set; }

        public string Amount { get; set; }
    }
}
