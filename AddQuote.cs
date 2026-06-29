namespace MegaDeskDemo
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            materialComboBox.SelectedIndex = 0;
            deliveryComboBox.SelectedIndex = 0;
            quoteDatePicker.Value = DateTime.Today;
        }

        private void SubmitQuoteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customerNameTextBox.Text))
            {
                MessageBox.Show("Please enter a customer name.", "Missing Customer Name");
                return;
            }

            Desk desk = new Desk
            {
                Width = (int)widthNumericUpDown.Value,
                Depth = (int)depthNumericUpDown.Value,
                Drawers = (int)drawersNumericUpDown.Value,
                SurfaceMaterial = Enum.Parse<DesktopMaterial>(materialComboBox.Text)
            };

            DeskQuote quote = new DeskQuote
            {
                CustomerName = customerNameTextBox.Text.Trim(),
                QuoteDate = quoteDatePicker.Value.Date,
                Desk = desk,
                DeliveryTime = deliveryComboBox.Text
            };

            DisplayQuote displayQuoteForm = new DisplayQuote(quote);
            displayQuoteForm.Show();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
