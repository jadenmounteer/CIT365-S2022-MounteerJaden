namespace MegaDesk_Mounteer
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddNewQuoteButton_Click(object sender, EventArgs e)
        {
            // Navigate to add quote menu
            AddQuote viewAddQuote =  new AddQuote();
            viewAddQuote.Tag = this;
            viewAddQuote.Show(this);
            this.Hide();
        }

        private void ViewQuotesButton_Click(object sender, EventArgs e)
        {
            // Navigate to the view all quotes menu
            ViewAllQuotes viewAllQuotes = new ViewAllQuotes();
            viewAllQuotes.Tag = this;
            viewAllQuotes.Show(this);
            this.Hide();
        }

        private void SearchQuotesButton_Click(object sender, EventArgs e)
        {
            // Navigate to the search quotes menu
            SearchQuote searchQuote = new SearchQuote();
            searchQuote.Tag = this;
            searchQuote.Show(this);
            this.Hide();
        }
    }
}