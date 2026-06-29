using System.ComponentModel;

namespace MegaDeskDemo
{
    public partial class AddQuote : Form
    {
        private DeskQuote deskQuote = new DeskQuote();

        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Today.ToShortDateString();
            deskQuote.orderDate = DateLabel.Text;
            DrawerInput.SelectedIndex = 0;
            MaterialComboBox.SelectedIndex = 0;
            ShippingComboBox.SelectedIndex = 0;
        }

        private void NameBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox input = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(input.Text))
            {
                WidthErrorProvider.SetError(NameBox, "Enter a customer name.");
                e.Cancel = true;
                return;
            }

            deskQuote.customerName = input.Text.Trim();
            WidthErrorProvider.SetError(NameBox, "");
        }

        private void WidthBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox input = (TextBox)sender;

            try
            {
                int newWidth;
                bool isNum = Int32.TryParse(input.Text, out newWidth);

                if (isNum)
                {
                    deskQuote.desk.Width = newWidth;
                    WidthErrorProvider.SetError(WidthBox, "");
                }
                else
                {
                    WidthErrorProvider.SetError(WidthBox, "Enter a number.");
                    e.Cancel = true;
                }
            }
            catch (Exception)
            {
                WidthErrorProvider.SetError(WidthBox, "Input must be between 24 and 96 inches.");
                e.Cancel = true;
            }
        }

        private void DepthBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox input = (TextBox)sender;

            try
            {
                int newDepth;
                bool isNum = Int32.TryParse(input.Text, out newDepth);

                if (isNum)
                {
                    deskQuote.desk.Depth = newDepth;
                    WidthErrorProvider.SetError(DepthBox, "");
                }
                else
                {
                    WidthErrorProvider.SetError(DepthBox, "Enter a number.");
                    e.Cancel = true;
                }
            }
            catch (Exception)
            {
                WidthErrorProvider.SetError(DepthBox, "Input must be between 12 and 48 inches.");
                e.Cancel = true;
            }
        }

        private void DrawerInput_Validating(object sender, CancelEventArgs e)
        {
            ComboBox input = (ComboBox)sender;

            try
            {
                deskQuote.desk.DrawerNumber = int.Parse(input.Text);
                WidthErrorProvider.SetError(DrawerInput, "");
            }
            catch (Exception)
            {
                WidthErrorProvider.SetError(DrawerInput, "Choose a drawer amount from 0 to 7.");
                e.Cancel = true;
            }
        }

        private void MaterialComboBox_Validating(object sender, CancelEventArgs e)
        {
            ComboBox input = (ComboBox)sender;

            if (string.IsNullOrWhiteSpace(input.Text))
            {
                WidthErrorProvider.SetError(MaterialComboBox, "Choose a material.");
                e.Cancel = true;
                return;
            }

            deskQuote.desk.Material = input.Text;
            WidthErrorProvider.SetError(MaterialComboBox, "");
        }

        private void ShippingComboBox_Validating(object sender, CancelEventArgs e)
        {
            ComboBox input = (ComboBox)sender;

            try
            {
                deskQuote.desk.ShippingDays = int.Parse(input.Text);
                WidthErrorProvider.SetError(ShippingComboBox, "");
            }
            catch (Exception)
            {
                WidthErrorProvider.SetError(ShippingComboBox, "Choose 3, 5, or 7 shipping days.");
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            deskQuote.orderDate = DateLabel.Text;
            QuoteManager.AddQuote(deskQuote);
            DisplayQuote displayQuoteForm = new DisplayQuote(deskQuote);
            displayQuoteForm.Show();
            deskQuote = new DeskQuote();
            deskQuote.orderDate = DateLabel.Text;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
