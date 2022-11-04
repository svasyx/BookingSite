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
            Dwelling dwelling   = new Dwelling("Kyiv, Akademic Yanhel street, 7", 100);

            Hotel hotel = new Hotel(10, "Kyiv, Akademic Yanhel street, 9", 677);

            dwelling.dwellings.Add(hotel);

            foreach(var obj in dwelling.dwellings)
            {
                MessageBox.Show(obj.GetString());
            }

        
           // MessageBox.Show(hotel.GetString());

        }
    }
}