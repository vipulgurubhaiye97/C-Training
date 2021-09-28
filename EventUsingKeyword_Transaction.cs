using System;
public class Account
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }
    public decimal MinBalance { get; set; }
}

public enum TransactionStatus
{
    SUCCESS, FAILURE
}

public class Transaction
{
    TransactionStatus status;

    //Event
    // <DelegateClassName> <EventObject>;
    public event Action<string, TransactionStatus, string> OnCompleted;

    /*public void Add_OnCompleted(Action<string,TransactionStatus,string> handler){
        OnCompleted+=handler;
    }

    public void Remove_OnCompleted(Action<string,TransactionStatus,string> handler){
        OnCompleted-=handler;
    }
    */
    public void Deposit(Account account, decimal amt)
    {

        account.Balance += amt;
        ChangeTransactionStatus("Deposit", TransactionStatus.SUCCESS, account.AccountNumber);

    }

    public void WithDraw(Account account, decimal amt)
    {

        if ((account.Balance - amt) < account.MinBalance)
        {
            ChangeTransactionStatus("WithDraw", TransactionStatus.FAILURE, account.AccountNumber);
        }
        else
        {
            account.Balance -= amt;
            ChangeTransactionStatus("WithDraw", TransactionStatus.SUCCESS, account.AccountNumber);
        }

    }

    private void ChangeTransactionStatus(string transactionType, TransactionStatus status, string accountNumber)
    {

        this.status = status;
        if (this.OnCompleted != null)
        {

            //Raise
            this.OnCompleted.Invoke(transactionType, status, accountNumber);
        }
    }
}

public class TransactionLogWriter
{

    public void WriteLog(string transactionType, TransactionStatus status, string accountNumber)
    {

        Console.WriteLine("TransactionType:{0},TransactionStatus:{1},AccountNumber:{2}", transactionType, status, accountNumber);
    }
}

public class Program
{
    public static void Main()
    {
        TransactionLogWriter _logger = new TransactionLogWriter();
        Action<string, TransactionStatus, string> _funObj = new Action<string, TransactionStatus, string>(_logger.WriteLog);

        Account _account = new Account();
        _account.AccountNumber = "44001123456";
        _account.Balance = 1000;
        _account.MinBalance = 500;

        Transaction _tx = new Transaction();
        //_tx.Add_OnCompleted(_funObj);
        _tx.OnCompleted += _funObj;

        _tx.Deposit(_account, 1000);
        _tx.WithDraw(_account, 1000);
        _tx.WithDraw(_account, 600);
        //_tx.WithDraw(_account,500);

    }
}