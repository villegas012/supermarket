namespace Supermarket
{
    public class FixedPriceProduct : Product
    {

        public override decimal ValueToPay()
        {
            return (Price * (decimal)Tax) + Price;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tTax...........: {Tax * 100}% " +
                $"\n\tValue.........: {$"{ValueToPay():C2}"}";
        }
    }
}
