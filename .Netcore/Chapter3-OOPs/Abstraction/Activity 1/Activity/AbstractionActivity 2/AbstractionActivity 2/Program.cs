using AbstractionActivity_2;

internal class Program
{
    private static void Main(string[] args)
    {
        BankATM myatm=new BankATM(500.00m);
        myatm.WithdrawMoney(100.00m);
        myatm.CheckBalance();
        myatm.DepositMoney(0);
        
    }
}