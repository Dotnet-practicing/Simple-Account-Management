//Today We Need Three thinks
//account Bank: Owner,Balance,AccountNumber
//deposite
//Whithdraw


var account1= new BankAccount(1,"abdiaziiz",10);
// account1.Balance=200;
account1.Deposite(100);

System.Console.WriteLine("owner is :"+account1.Owner +"balance:"+account1.Balance.ToString("c"));