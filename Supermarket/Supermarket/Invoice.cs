namespace Supermarket
{
    public class Invoice : IPay
    {
        List<Product> _products = new List<Product>();
        public Invoice()
        {

        }

        public void AddProduct(Product product)
        {
            _products.Add(product);

        }
        public decimal ValueToPay()
        {
            decimal amount = 0;
            foreach (Product product in _products)
            {

                amount += product.ValueToPay();
            }

            return amount;
        }
        public override string ToString()
        {
            string items = "";
            foreach (Product p in _products)
            {
                items += p.ToString() + "\n";
            }
            return $"RECEIPT" +
              $"\n------------------------------" +
              $"\n{items}" +
              $"\n\t\t\t================" +

              $"\n\tTOTAL:       {$"{ValueToPay():C2}",18}";
        }
    }
}
