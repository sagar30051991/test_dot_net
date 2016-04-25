using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessAccessLayer.Model.ModProject
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ContactNo { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string Vat_Tin { get; set; }
        public string CST_No { get; set; }
        public string PurchaseOrderDate { get; set; }
        public int Flag { get; set; }
    }
}
