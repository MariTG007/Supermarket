namespace Supermarket
{
    public class ComposedProduct : Product
    {

        public float Discount { get; set; }
        public List<Product> Products { get; set; }



        public override decimal ValueToPay()
        {

            decimal amount = 0;
            foreach (Product product in Products)
            {

                amount += product.ValueToPay() - (product.ValueToPay() * (decimal)Discount);
            }

            return amount;
        }
        public override string ToString()

        {
            string product = "";
            foreach (Product prod in Products)
            {
                product += prod.Description + ", ";  
            }
            return $" {Id} - {Description} " +
                $"\n\tProducts...: {$"{product.Replace("Cabano, ", "Cabano")}",18}" +
                $"\n\tDiscount...:  {$"{Discount:P2}",18}" +
                $"\n\tValue......:{$"{ValueToPay():C2}",18}";
        }
    }
}
