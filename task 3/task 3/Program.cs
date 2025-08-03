namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            BankAccount account1 = new BankAccount("Ahmed Hkm", "12345678901234", "01012345678", 1500, "Cairo");

            
            BankAccount account2 = new BankAccount("Youssef Ali", "98765432101234", "01123456789", "Alexandria");

            account1.ShowAccountDetails();
            account2.ShowAccountDetails();
        }
    }
}
