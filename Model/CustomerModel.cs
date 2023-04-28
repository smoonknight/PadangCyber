using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadangCyberApp.Model
{
    public class CustomerModel
    {
        public string customerId { get; set; }
        public string orderId { get; set; }
        public string plan { get; set; }
        public float totalPrice { get; set; }
        public string nameCustomer { get; set; }
        public int numberTable { get; set; }
        public DateTime timeOrder { get; set; }
        public int numberQueue { get; set; }
        public OrderList orderList { get; set; }
    }

    public class OrderList
    {

    }
}
