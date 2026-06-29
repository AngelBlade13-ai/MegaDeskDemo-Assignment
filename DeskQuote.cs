namespace MegaDeskDemo
{
    public class DeskQuote
    {
        public string customerName { get; set; }

        public string orderDate { get; set; }

        public Desk desk { get; set; }

        public double price { get; set; }

        public DeskQuote()
        {
            customerName = string.Empty;
            orderDate = string.Empty;
            desk = new Desk();
        }
    }
}
