using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cashier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        [TestMethod()]
        public void WithdrawMSTest_fail()
        {
            Assert.Fail();
        }
        [TestMethod()]
        public void Withdraw_WithValidAmount_UpdatesBalance()
        {
            //Assert.Fail(); // arrange  
            double beginningBalance = 1199;
            double debitAmount = 455;
            double expected = 744;
            BankAccount account = new BankAccount("Mr. Paul Lee", beginningBalance);

            // act  
            account.Withdraw(debitAmount);

            // assert  
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.1, "Account not withdrawed correctly");
            
        }
    }
}