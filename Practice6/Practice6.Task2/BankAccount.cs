namespace Practice6.Task2;

public abstract class BankAccount
{
  public decimal Balance { get; protected set; }

  public virtual void Withdraw(decimal amount)
  {
    if (amount < 0)
    {
      throw new ArgumentException("Сумма снятия не может быть отрицательной.");
    }

    if (Balance < amount)
    {
      throw new InsufficientBalanceException("Недостаточно средств на счете.");
    }

    Balance -= amount;
    Console.WriteLine($"Снято {amount}. Остаток: {Balance}");
  }

  public virtual void Deposit(decimal amount)
  {
    if (amount < 0)
    {
      throw new ArgumentException("Сумма депозита не может быть отрицательной.");
    }

    Balance += amount;
    Console.WriteLine($"Депозит {amount} успешно зачислен. Текущий баланс: {Balance}");
  }
}