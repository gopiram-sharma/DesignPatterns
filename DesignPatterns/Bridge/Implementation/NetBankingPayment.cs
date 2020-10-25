using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge
{
    public class NetBankingPayment: Payment
    {
        public override void MakePayment()
        {
            PaymentSystem.ProcessPayment("Netbanking payment.");
        }
    }
}
