using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Model
    {
        public string clientOrderCode { get; set; }
       public transferAmount transferAmount { get; set; }
       public string clientNotificationURL { get; set; }
       public string clientSuccessURL { get; set; }
       public string clientOnPaymentReceivedURL { get; set; }
       public string baseAccountIBAN { get; set; }
       public string languageCode { get; set; }
       public string paymentCode { get; set; }
    //   public transactionCode transactionCode { get; set; }
         public string bookingId { get; set; }
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
