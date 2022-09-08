class BankAccount
{
    public int AccountNumber { get; }

    public string Owner { set; get; }

    public decimal Balance { get; private set; }

    // public Transaction[] Transactions { get; set; } = new Transaction[0];
    public List<Transaction>Transactions { get; set; }=new List<Transaction>();

    public BankAccount(int accountNumber, string owner, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Owner = owner;

        Deposit(initialBalance);
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            return;
        }
        if (amount < 100)
        {
            System.Console.WriteLine("$100 wax ka yar lama ogala saxiib😂");
            return;
        }
        Balance += amount;

        var transaction = new Transaction()
        {
            Reference = Transactions.Count + 1,
            Amount = amount,
            Date = DateTime.Now
        };
//////////this old verion or array 
        var transactionCount = Transactions.Count;
        // var oldTransactions = Transactions;

        // Transactions = new Transaction[transactionCount + 1];

        // // Soo celi xogtii hore.
        // var position = 0;
        // foreach (var oldTransaction in oldTransactions)
        // {
        //     Transactions[position] = oldTransaction;
        //     position += 1;
        // }

        // Transactions[transactionCount] = transaction;
        Transactions.Add(transaction);
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Ma haysatid lacag kugu filan! 😛");
            return; // Joog! 😂
        }
        if (amount < 100)
        {
            System.Console.WriteLine("$100 wax ka yar lama ogala saxiib😂");
            return;
        }
        Balance -= amount;
        var transaction = new Transaction()
        {
            Reference = Transactions.Count + 1,
            Amount = -amount,
            Date = DateTime.Now
        };

        var transactionCount = Transactions.Count;
        ///array resize
        // var oldTransactions = Transactions;

        // Transactions = new Transaction[transactionCount + 1];

        // var position = 0;
        // foreach (var oldTransaction in oldTransactions)
        // {
        //     Transactions[position] = oldTransaction;
        //     position += 1;
        // }

        // Transactions[transactionCount] = transaction;

        Transactions.Add(transaction);
    }
}