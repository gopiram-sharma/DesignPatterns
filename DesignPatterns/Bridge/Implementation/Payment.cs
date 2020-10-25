using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge
{
    public abstract class Payment
    {
        public IPaymentSystem PaymentSystem;
        public abstract void MakePayment();
    }
}
