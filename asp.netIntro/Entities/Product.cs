namespace asp.netIntro.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price {  get; set; }
        public int Discount {  get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
