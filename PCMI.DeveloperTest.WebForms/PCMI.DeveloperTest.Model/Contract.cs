namespace PCMI.DeveloperTest.Model
{
    public class Contract
    {
        public Contract(int id, string number, string customerFirstName, string customerLastName, Status status, decimal price, decimal priceWithATX)
        {
            Id = id;
            Number = number;
            Customer = new Customer(customerFirstName, customerLastName);
            Status = status;
            Price = price;
            PriceWithATX = priceWithATX;
        }

        public int Id { get; set; }
        public string Number { get; set; }
        public Customer Customer { get; set; }
        public Status Status { get; set; }
        public decimal Price { get; set; }
        public decimal PriceWithATX { get; set; }
    }

    public enum Status
    {
        Active,
        Inactive
    }
}
