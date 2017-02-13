using Xunit;
using Cashier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cashier.xTests
{
    public class BankAccountxTests
    {
        [Fact()]
        public void WithdrawxTest()
        {
            Assert.True(false, "This test needs an implementation");
        }
        [Fact()]
        public void Withdraw_WithValidAmount_UpdatesBalance()
        {
            //Assert.Fail(); // arrange  
            double beginningBalance = 1199;
            double debitAmount = 455;
            double expected = 744;
            BankAccount account = new BankAccount("Mr. Paul Li", beginningBalance);

            // act  
            account.Withdraw(debitAmount);

            // assert  
            double actual = account.Balance;
            Assert.Equal(expected, actual);
        }
    }
}