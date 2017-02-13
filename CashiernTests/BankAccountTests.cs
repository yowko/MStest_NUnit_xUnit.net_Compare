using NUnit.Framework;
using Cashier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cashier.NTests
{
    [TestFixture()]
    public class BankAccountTests
    {
        [Test()]
        public void WithdrawNTeast_fail()
        {
            Assert.Fail();
        }
        [Test()]
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
            Assert.AreEqual(expected, actual, 0.1, "Account not withdrawed correctly");

        }
    }
}