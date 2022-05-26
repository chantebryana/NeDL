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

        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRangeException()
        {
            //Arrange
            //initialize variables for later
            double beginningBalance = 11.99;
            double debitAmount = -0.01;

            //set up new BankAccount object with a beginning balance
            BankAccount account = new BankAccount("Ms. Bryana Walton", beginningBalance);

            //Act
            try
            {
                //try to withdrawal a negative value from account
                account.Debit(debitAmount);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                //Assert
                //should get 'negative value' exception message
                StringAssert.Contains(e.Message, BankAccount.DebitAmountLessThanZeroMessage);

                //empty return to break out of method
                return;
            }

            //throws exception if 'catch' isn't hit
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void Debit_WhenAmountIsGreaterThanBalance_ShouldThrowArgumentOutOfRangeException()
        {
            //Arrange
            //initialize variables for later
            double beginningBalance = 11.99;
            double debitAmount = 12.00;

            //set up new BankAccount object with a beginning balance
            BankAccount account = new BankAccount("That's Pat Walton", beginningBalance);

            //Act
            try
            {
                //try to overdraft from BankAccount objects
                account.Debit(debitAmount);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                //Assert
                //should get 'overdraw' exception message
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
                
                //empty return to break out of method
                return;
            }

            //throw exception if 'catch' block never hit
            Assert.Fail("The expected exception was not thrown.");
        }
    }
}