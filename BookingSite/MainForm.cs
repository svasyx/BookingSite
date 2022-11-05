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
            Dictionary<string, string> items = new Dictionary<string, string>();
            List<Dwelling> dwellings = new List<Dwelling>(); 

            Dwelling dwelling   = new Dwelling("Kyiv, Akademic Yanhel street, 7", 100,1000);

            Hotel hotel = new Hotel(10, "Kyiv, Akademic Yanhel street, 9", 677,233);
            Flats flats = new Flats(2, "Kyiv, Akademic Yanhel street, 11", 45,102);
            OneRoomFlat oneRoomFlat = new OneRoomFlat("Kyiv, Akademic Yanhel street, 13", 22,332);
            ChillHouse chillHouse = new ChillHouse("Pool", "Kyiv, Akademic Yanhel street, 15", 200, 1200);
            House house = new House(2, "Kyiv, Akademic Yanhel street, 17", 1000,800);

            dwelling.SetList(hotel);
            dwelling.SetList(flats);
            dwelling.SetList(oneRoomFlat);
            dwelling.SetList(chillHouse);
            dwelling.SetList(house);

            dwellings = dwelling.GetList();

            Blog blog = new Blog("News", "Putin is dead");
            blog.SetBlog("Discounts", "30% out");
            blog.SetBlog("Recomendations", "You need to buy it");

            items = blog.GetAllBlog();

            foreach(KeyValuePair<string, string> item in items)
            {
                MessageBox.Show($"Type: {item.Key} and content: {item.Value}");
            }

            Administration administration = new Administration();
            

            //foreach (var obj in dwellings)
            //{
            //    MessageBox.Show(obj.GetString());
            //}

        
           // MessageBox.Show(hotel.GetString());

        }
    }
}