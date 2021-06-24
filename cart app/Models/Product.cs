using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cart_app.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Photo { get; set; }
        public string Currency { get; set; }
        public string Title { get; set; }

        public string clientOrderCode { get; set; }

        public transferAmount transferAmount { get; set; }

        public string clientNotificationURL { get; set; }
        public string clientSuccessURL { get; set; }
        public string clientOnPaymentReceivedURL { get; set; }
        public string baseAccountIBAN { get; set; }
        public string languageCode { get; set; }
        public string paymentCode { get; set; }
        //    public transactionCode transactionCode { get; set; }

        public string bookingId { get; set; }
        //      public string sessionCode { get; set; }
    }
    public class transferAmount
    {
        public string value { get; set; }
        public string currency { get; set; }

    }
    public class transactionCode
    {
        public int Sales { get; set; }
        public int value { get; set; }
    }
}

