using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge
{
    public class CardPayment: Payment
    {
        public override void MakePayment()
        {
            PaymentSystem.ProcessPayment("Card payment.");
        }
    }
}
