namespace Supermarket
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }

        public float Quantity { get; set; }

        public override decimal ValueToPay()
        {
            return ((Price * (decimal)Tax) + Price) * (decimal)Quantity;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"\n\tMeasurement...: {$"{Measurement:C2}"}" +
                   $"\n\tQuantity......: {$"{Quantity:C2}"}" +
                   $"\n\tTax...........: {Tax * 100}% " +
                   $"\n\tValue.........: {$"{ValueToPay():C2}"}";
        }
    }
}
