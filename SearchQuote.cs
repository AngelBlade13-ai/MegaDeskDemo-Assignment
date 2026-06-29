namespace MegaDeskDemo
{
    public partial class SearchQuote : Form
    {
        public SearchQuote()
        {
            InitializeComponent();
        }

        private void SearchQuote_Load(object sender, EventArgs e)
        {
            materialComboBox.SelectedIndex = 0;
            LoadQuotes(QuoteManager.Quotes);
        }

        private void MaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaterial = materialComboBox.Text;

            if (selectedMaterial == "All")
            {
                LoadQuotes(QuoteManager.Quotes);
                return;
            }

            LoadQuotes(QuoteManager.Quotes.Where(quote => quote.desk.Material == selectedMaterial));
        }

        private void LoadQuotes(IEnumerable<DeskQuote> quotes)
        {
            searchGrid.Rows.Clear();

            foreach (DeskQuote quote in quotes)
            {
                searchGrid.Rows.Add(
                    quote.customerName,
                    quote.orderDate,
                    quote.desk.Width,
                    quote.desk.Depth,
                    quote.desk.DrawerNumber,
                    quote.desk.getSurfaceArea(),
                    quote.desk.Material,
                    quote.desk.ShippingDays);
            }

            emptyLabel.Visible = searchGrid.Rows.Count == 0;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
