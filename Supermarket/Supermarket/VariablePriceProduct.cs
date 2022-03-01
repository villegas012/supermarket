namespace Supermarket
{
    public class VariablePriceProduct : Product
    {
        public string? Measurement { get; set; }

        public float Quantity { get; set; }

        public override decimal ValueToPay()
        {
            return ((Price * (decimal)Tax) + Price) * (decimal)Quantity;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"\n\tMeasurement...: {$"{Measurement:C2}",2}" +
                   $"\n\tQuantity......: {Quantity:N2}" +
                   $"\n\tPrice.........: {Price:C2}" +
                   $"\n\tTax...........: {Tax * 100:N2}% " +
                   $"\n\tValue.........: {$"{ValueToPay():C2}"}";
        }
    }
}
