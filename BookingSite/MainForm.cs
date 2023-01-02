namespace BookingSite
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void BuyerBtn_Click(object sender, EventArgs e)
        {
            BuyerForm buyerForm = new BuyerForm();  
            buyerForm.Show();   
        }

        private void SellerBtn_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();   
            sellerForm.Show();  
        }
    }
}