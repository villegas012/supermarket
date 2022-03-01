namespace Supermarket
{
    public class Invoice : IPay
    {
        private ICollection<Product> _products { get; set; }

        public Invoice() {
            _products = new List<Product>() { };
        }        
        public decimal ValueToPay()
        {
            decimal value = 0;
            foreach (Product product in _products) {
                value = value + product.ValueToPay();
            }
            return value;
        }
        public void AddProduct(Product product) {
            try
            {
                _products.Add(product);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public override string ToString()
        {
            string products = "";
            foreach (Product product in _products) {
                products = products + product.ToString() + "\n";
            }
            return "RECEIPT" +
                   "\n====================================\n" +
                    products +
                   "                       =============" + 
                  $"\n\tTOTAL.........: {$"{ValueToPay():C2}"}";
        }

    }
}
