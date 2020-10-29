using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.ViewModels
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal ProductPrice { get; set; }
        public HttpPostedFileBase ImagePath { get; set; }
    }
}