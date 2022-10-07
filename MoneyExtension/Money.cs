namespace MoneyExtension;
public static class Money
{
    public static class MoneyExtensions
    {
        public static int ToCents(decimal amount)
        {
            if(amount < 0)
                return 0;

            return Decimal.ToInt32(amount);
        }
    }
}
