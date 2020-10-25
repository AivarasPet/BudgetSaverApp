namespace BudgetSaverApp.Transactions
{
    public class TransactionsFactory
    {
        public static ITransactionService GetTransactionService()
        {
            return new TransactionService();
        }
    }
}
