using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessAccessLayer.Model.ModProject
{
    public class BillingModel
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
       // public string CustomerName { get; set; }
        public string Particular{ get; set; }
        public string Qty { get; set; }
        public string Rate { get; set; }
        public bool CST_VAT { get; set; }
        public string Net12_5 { get; set; }
        public string Vat12_5 { get; set; }
        public string Net2 { get; set; }
        public string CST2 { get; set; }
        public string TotalAmount { get; set; }
        public string PurchaseOrderDate { get; set; }
        public int Flag { get; set; }
        public string BillId { get; set; }
        
    }
}
