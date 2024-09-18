namespace Practice6.Task2;

public class SavingsAccount : BankAccount
{
  private DateTime lastWithdrawalDate;

  public SavingsAccount()
  {
    lastWithdrawalDate = DateTime.MinValue;
  }

  public override void Withdraw(decimal amount)
  {
    if ((DateTime.Now - lastWithdrawalDate).Days < 30)
    {
      throw new WithdrawalLimitExceededException("Нельзя снимать деньги чаще, чем раз в месяц.");
    }

    base.Withdraw(amount);
    lastWithdrawalDate = DateTime.Now;
  }
}