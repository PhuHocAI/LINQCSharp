namespace LINQ
{
    internal class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        //Required: không được để trống
        public decimal Price { get; set; }
        public int GetId()
        {
            return Id;
        }
        public string GetName()
        {
            return Name;
        }
        public decimal GetPrice()
        {
            return Price;
        }
    }
}

