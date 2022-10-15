using System;
using System.Collections.Generic;
using System.Text;

namespace atm_app.Business
{
    internal interface ITransactions
    {
        public void WithDraw(int customerCode);
        public void Deposit(int customerCode);
        public void PayingBill(int customerCode);
    }
}
