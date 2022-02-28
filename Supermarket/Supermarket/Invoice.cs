namespace Supermarket
{
    public class Invoice : IPay
    {
        public Invoice() {}
        private List<Product> _products { get; set; }
        public decimal ValueToPay()
        {
            decimal value = 0;
            foreach (Product product in _products) {
                value = value + product.ValueToPay();
            }
            return value;
        }
        public void AddProduct(Product product) { 
            _products.Add(product); 
        }
        public override string ToString()
        {
            return "===========================" + 
                  $"\n\tTOTAL.........: {$"{ValueToPay():C2}"}";
        }

    }
}
