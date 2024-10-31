namespace Week5VS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblFeedback.Text = "Book added: " + txtTitle.Text + "($ " + txtPrice.Text + ") - published: " + dtpDatePublished.Value.ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtPrice.Text = "";
            dtpDatePublished.Value = DateTime.Now;
            lblFeedback.Text = "Feedback goes here";
        }
    }
}
