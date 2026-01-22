using System;
using System.Collections.Generic;

public class BankAccount
{
    public decimal CalculateFinalBalance(decimal initialBalance, decimal[] transactions)
    {
        decimal currentBalance = initialBalance;

        foreach (decimal t in transactions)
        {
            if (t >= 0)
            {
                // Deposit: Add amount to balance
                currentBalance += t;
            }
            else
            {
                // Withdrawal: check if enough balance exists
                // We use Math.Abs(t) to get the positive value of the withdrawal
                decimal amountToWithdraw = Math.Abs(t);
                
                if (currentBalance >= amountToWithdraw)
                {
                    currentBalance -= amountToWithdraw;
                }
                // If not enough balance, the transaction is ignored
            }
        }

        return currentBalance;
    }
}
