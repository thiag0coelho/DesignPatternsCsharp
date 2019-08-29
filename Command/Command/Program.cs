using static System.Console;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();

            var command = new Command { Amount = 100, TheAction = Action.Deposit };
            account.Process(command);

            WriteLine(account);

            command = new Command { Amount = 50, TheAction = Action.Withdraw };
            account.Process(command);

            WriteLine(account);

            command = new Command { Amount = 150, TheAction = Action.Withdraw };
            account.Process(command);

            WriteLine(account);

            ReadLine();
        }
    }
}
