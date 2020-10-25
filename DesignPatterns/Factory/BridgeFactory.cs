using DesignPatterns.Bridge;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class BridgeFactory
    {
        public static void MakePayment()
        {
            Payment order = new CardPayment();
            order.PaymentSystem = new CityPaymentSystem();
            order.MakePayment();

            order.PaymentSystem = new IdbiPaymentSystem();
            order.MakePayment();

            order = new NetBankingPayment();
            order.PaymentSystem = new IdbiPaymentSystem();
            order.MakePayment();

        }
    }
}
