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
            customerNameValueLabel.Text = quote.customerName;
            quoteDateValueLabel.Text = quote.orderDate;
            widthValueLabel.Text = quote.desk.Width.ToString();
            depthValueLabel.Text = quote.desk.Depth.ToString();
            drawersValueLabel.Text = quote.desk.DrawerNumber.ToString();
            totalSizeValueLabel.Text = $"{quote.desk.getSurfaceArea()} in^2";
            materialValueLabel.Text = quote.desk.Material;
            deliveryValueLabel.Text = $"{quote.desk.ShippingDays} days";
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
