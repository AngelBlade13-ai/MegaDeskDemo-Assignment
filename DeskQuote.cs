namespace MegaDeskDemo
{
    public class DeskQuote
    {
        public string CustomerName { get; set; } = string.Empty;

        public DateTime QuoteDate { get; set; }

        public Desk Desk { get; set; } = new Desk();

        public string DeliveryTime { get; set; } = string.Empty;

        public int TotalSize => Desk.SurfaceArea;
    }
}
