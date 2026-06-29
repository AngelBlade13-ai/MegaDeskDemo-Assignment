namespace MegaDeskDemo
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            LoadQuotes(QuoteManager.Quotes);
        }

        private void LoadQuotes(IEnumerable<DeskQuote> quotes)
        {
            quotesGrid.Rows.Clear();

            foreach (DeskQuote quote in quotes)
            {
                quotesGrid.Rows.Add(
                    quote.customerName,
                    quote.orderDate,
                    quote.desk.Width,
                    quote.desk.Depth,
                    quote.desk.DrawerNumber,
                    quote.desk.getSurfaceArea(),
                    quote.desk.Material,
                    quote.desk.ShippingDays);
            }

            emptyLabel.Visible = quotesGrid.Rows.Count == 0;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
