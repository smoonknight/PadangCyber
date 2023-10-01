using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadangCyberApp.Model
{
    public class CustomerModel : Model, IModel
    {
        public string uid { get; set; }
        public string orderId { get; set; }
        public string plan { get; set; }
        private decimal _totalPrice;
        public string totalPrice
        {
            get { return $"Rp. {string.Format("{0:n}", _totalPrice)}"; }
            set { _totalPrice = decimal.Parse(value); }
        }
        public string nameCustomer { get; set; }
        public string numberTable { get; set; }
        public string timeOrder { get; set; }
        public string numberQueue { get; set; }

        public void LastUpdated(DateTime dateTime)
        {
            lastUpdated = dateTime;
        }
    }

    public class Order
    {
        public string uid { get; set; }
        public string customerId { get; set; }
        public string amount { get; set; }
        private decimal _unitPrice;
        public string unitPrice
        {
            get { return $"Rp. {string.Format("{0:n}", _unitPrice)}"; }
            set { _unitPrice = decimal.Parse(value); }
        }
        public string unitName { get; set; }

        private decimal _totalPrice;
        public string totalPrice
        {
            get { return $"Rp. {string.Format("{0:n}", _totalPrice)}"; }
            set { _totalPrice = decimal.Parse(value); }
        }
    }
}
