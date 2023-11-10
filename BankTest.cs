using BankAccount;
namespace BankAccount.Test
{
    public class Tests
    {
        [Test]
        public void Deposit_WhenAccountExists_ShouldReturnVerified()
        {
            int accountId = 7;
            Bank.RegisterBankAccount(accountId);

            string result = Bank.Deposit(accountId);

            Assert.That(result, Is.EqualTo("verified"));
        }

        [Test]
        public void Deposit_WhenAccountDoesNotExist_ShouldReturnDeclined()
        {
            int nonExistentAccountId = 8;

            string result = Bank.Deposit(nonExistentAccountId);

            Assert.That(result, Is.EqualTo("declined"));
        }

        [Test]
        public void Withdraw_WhenAccountExistsAndSufficientBalance_ShouldNotThrowException()
        {
              int accountId = 9;
            Bank.RegisterBankAccount(accountId);

            Assert.DoesNotThrow(() => Bank.Withdraw(100.0, 50.0, accountId));
        }

        [Test]
        public void Withdraw_WhenAccountDoesNotExist_ShouldThrowException()
        {
            int nonExistentAccountId = 10;

            Assert.Throws<InvalidOperationException>(() => Bank.Withdraw(100.0, 50.0, nonExistentAccountId));
        }

        [Test]
        public void Withdraw_WhenInsufficientBalance_ShouldThrowException()
        {
            int accountId = 11;
            Bank.RegisterBankAccount(accountId);

            Assert.Throws<InvalidOperationException>(() => Bank.Withdraw(50.0, 100.0, accountId));
        }
        [Test]
        public void TestBankRegisterDuplicateAccount()
        {
            Bank.RegisterBankAccount(156126);

            Assert.Throws<InvalidOperationException>(() => Bank.RegisterBankAccount(156126));
        }
    }
}