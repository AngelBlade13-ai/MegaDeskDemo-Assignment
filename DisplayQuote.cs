namespace MegaDeskDemo
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }

        public DisplayQuote(DeskQuote quote) : this()
        {
            RenderQuote(quote);
        }

        private void RenderQuote(DeskQuote quote)
        {
            customerNameValueLabel.Text = quote.CustomerName;
            quoteDateValueLabel.Text = quote.QuoteDate.ToShortDateString();
            widthValueLabel.Text = quote.Desk.Width.ToString();
            depthValueLabel.Text = quote.Desk.Depth.ToString();
            drawersValueLabel.Text = quote.Desk.Drawers.ToString();
            totalSizeValueLabel.Text = $"{quote.TotalSize} in^2";
            materialValueLabel.Text = quote.Desk.SurfaceMaterial.ToString();
            deliveryValueLabel.Text = quote.DeliveryTime;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
