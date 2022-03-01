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
                $"\n\tPrice.........: {Price:C2}" +
                $"\n\tTax...........: {Tax * 100:N2}% " +
                $"\n\tValue.........: {$"{ValueToPay():C2}"}";
        }
    }
}
