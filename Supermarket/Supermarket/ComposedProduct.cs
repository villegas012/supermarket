namespace Supermarket
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public List<Product> Products { get; set; }
        public override decimal ValueToPay()
        {
            decimal value = 0;
            foreach (var product in Products)
            {
                value = value + product.ValueToPay();
            }

            return value - (value * (decimal)Discount);
        }
        public override string ToString()
        {
            string productsName = "";
            foreach (var product in Products)
            {
                productsName = productsName + " " + product.Description;
            }
            return $"{base.ToString()}" +
                   $"\n\tProducts......: {$"{productsName}"}" +
                   $"\n\tDiscount......: {$"{Discount * 100}%"}" +
                   $"\n\tValue.........: {$"{ValueToPay():C2}"}";
        }
    }
}
