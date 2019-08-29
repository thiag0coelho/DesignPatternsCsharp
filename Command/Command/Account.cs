using System;

namespace Command
{
    public class Account
    {
        public int Balance { get; set; }

        public void Process(Command c)
        {
            switch (c.TheAction)
            {
                case Action.Deposit:
                    Balance += c.Amount;
                    c.Success = true;
                    break;
                case Action.Withdraw:
                    c.Success = Balance >= c.Amount;
                    if (c.Success) Balance -= c.Amount;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToString()
        {
            return $"{nameof(Balance)}: {Balance}";
        }
    }
}
