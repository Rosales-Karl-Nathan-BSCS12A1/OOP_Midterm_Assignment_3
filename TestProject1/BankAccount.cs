namespace TestProject1
{
    public class BankAccount
    {
        public int AccountNumber { get; private set; }
        public decimal Balance { get; private set; }

        public BankAccount(int accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public double Num3 { get; set; }

        public BankAccount(int num1, int num2, double num3)
        {
            Num1 = num1;
            Num2 = num2;
            Num3 = num3;
        }

        public void Deposit(int amount)
        {
            Num1 += amount;
        }

        public int GetBalance()
        {
            return Num1;
        }

        public void Withdraw(int amount)
        {
            Num1 -= amount;
        }

        public virtual double CalculateInterest()
        {
            double totalInterest = Num2 * Num3;
            return totalInterest;
        }

        public void Withdraw(decimal amount, bool isOtherBank)
        {
            decimal withdrawalAmount = amount;

            if (isOtherBank)
            {
                decimal fee = 5.00m;
                withdrawalAmount += fee;
            }
            else if (withdrawalAmount <= Balance)
            {
                Balance -= withdrawalAmount;
            }
        }
    }
}
