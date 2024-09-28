namespace TestProject1
{
    public class SavingsAccount : BankAccount
    {
        private double interestRate;

        public SavingsAccount(int accountNumber, decimal initialBalance, double rate)
            : base(accountNumber, initialBalance)
        {
            interestRate = rate;
        }


        public override double CalculateInterest()
        {
            return (double)Balance * interestRate; 
        }

    }
}
