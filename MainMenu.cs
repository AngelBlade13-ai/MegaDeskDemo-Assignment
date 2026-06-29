namespace MegaDeskDemo
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            string imagePath = Path.Combine(Application.StartupPath, "Assets", "desk.png");
            deskPictureBox.Image = Image.FromFile(imagePath);
        }

        private void AddQuoteBtn_Click(object sender, EventArgs e)
        {
            AddQuote addQuoteForm = new AddQuote();
            addQuoteForm.Show();
        }

        private void ViewQuotesBtn_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotesForm = new ViewAllQuotes();
            viewAllQuotesForm.Show();
        }

        private void SearchQuotesBtn_Click(object sender, EventArgs e)
        {
            SearchQuote searchQuoteForm = new SearchQuote();
            searchQuoteForm.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
