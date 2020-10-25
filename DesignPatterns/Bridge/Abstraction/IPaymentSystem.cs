using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge
{
    public interface IPaymentSystem
    {
        void ProcessPayment(string paymentSystem);
    }
}
