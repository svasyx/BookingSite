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
            Dwelling dwelling   = new Dwelling("Kyiv, Akademic Yanhel street, 7", 100,1000);

            Hotel hotel = new Hotel(10, "Kyiv, Akademic Yanhel street, 9", 677,233);
            Flats flats = new Flats(2, "Kyiv, Akademic Yanhel street, 11", 45,102);
            OneRoomFlat oneRoomFlat = new OneRoomFlat("Kyiv, Akademic Yanhel street, 13", 22,332);
            ChillHouse chillHouse = new ChillHouse("Pool", "Kyiv, Akademic Yanhel street, 15", 200, 1200);
            House house = new House(2, "Kyiv, Akademic Yanhel street, 17", 1000,800);

            dwelling.dwellings.Add(hotel);
            dwelling.dwellings.Add(flats);
            dwelling.dwellings.Add(oneRoomFlat);
            dwelling.dwellings.Add(chillHouse);
            dwelling.dwellings.Add(house);





            foreach (var obj in dwelling.dwellings)
            {
                MessageBox.Show(obj.GetString());
            }

        
           // MessageBox.Show(hotel.GetString());

        }
    }
}