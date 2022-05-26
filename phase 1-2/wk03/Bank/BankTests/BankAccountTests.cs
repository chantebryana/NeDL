using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            //Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            
            //sets up new BankAccount object with a beginning balance
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            //Act
            //withdrawal a valid amount from BankAccount object
            account.Debit(debitAmount);

            //Assert
            double actual = account.Balance;

            //user Assert.AreEqual() method to verify that the ending balance is as expected
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");

        }
    }
}