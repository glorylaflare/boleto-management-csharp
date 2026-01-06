using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boleto.Domain.ValueObjects
{
    public class PaymentTitle
    {
        public string BarCode { get; set; }
        public string Amount { get; set; }
        public string PaymentId { get; set; }

        public PaymentTitle(string barCode, string amount, string paymentId)
        {
            BarCode = barCode;
            Amount = amount;
            PaymentId = paymentId;
        }
    }
}
