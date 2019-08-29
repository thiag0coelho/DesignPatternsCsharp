using Command;
using NUnit.Framework;

namespace Tests
{
    public class TestSuite
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DepositAndWithdraw()
        {
            var account = new Account();

            var command = new Command.Command { Amount = 100, TheAction = Action.Deposit };
            account.Process(command);

            Assert.That(account.Balance, Is.EqualTo(100));
            Assert.IsTrue(command.Success);

            command = new Command.Command { Amount = 50, TheAction = Action.Withdraw };
            account.Process(command);

            Assert.That(account.Balance, Is.EqualTo(50));
            Assert.IsTrue(command.Success);
        }


        [Test]
        public void TryToWithdrawMoreThanBalance_ShouldFail()
        {
            var account = new Account();

            var command = new Command.Command { Amount = 100, TheAction = Action.Deposit };
            account.Process(command);

            command = new Command.Command { Amount = 150, TheAction = Action.Withdraw };
            account.Process(command);

            Assert.That(account.Balance, Is.EqualTo(100));
            Assert.IsFalse(command.Success);
        }
    }
}