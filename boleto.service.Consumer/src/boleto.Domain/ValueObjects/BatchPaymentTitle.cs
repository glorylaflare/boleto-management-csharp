using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boleto.Domain.ValueObjects
{
    public class BatchPaymentTitle
    {
        public string UserId { get; set; }
        public List<PaymentTitle> Items { get; set; }
       
        public BatchPaymentTitle(string userId, List<PaymentTitle> items) 
        {
            UserId = userId;
            Items = items;
        }
    }
}
