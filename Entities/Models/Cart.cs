namespace Entities.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; }

        public Cart()
        {
            Lines = new List<CartLine>();
        }

        public virtual void AddItem(Product product, int quantity)
        {
            CartLine? line = Lines.FirstOrDefault(x => x.Product.Id.Equals(product.Id));
            if (line is null)
            {
                Lines.Add(new CartLine()
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Product product) =>
            Lines.RemoveAll(l => l.Product.Id.Equals(product.Id));

        public decimal ComputeTotalValue() =>
            Lines.Sum(e => e.Quantity * e.Product.Price);

        public virtual void Clear() => Lines.Clear();
    }
}