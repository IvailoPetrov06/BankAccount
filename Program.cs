namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount(156126);
            //BankAccount ca = new BankAccount(156126);

            ba.Deposit(156126,20);
            Console.WriteLine(ba);

            ba.Withdraw(14.5);
            Console.WriteLine(ba);

            ba.Withdraw(5);
            Console.WriteLine(ba);

            ba.Deposit(156126,10);
            Console.WriteLine(ba);

            ba.Withdraw(15);
            Console.WriteLine(ba);
        }
    }
}