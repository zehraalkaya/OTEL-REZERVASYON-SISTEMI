namespace DonemProjesi
{
    public partial class FormMusteri : Form
    {
        public FormMusteri()
        {
            
            InitializeComponent();
            
        }

        private void FormMusteri_Load(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd.MM.yyyy";

        }
        int TekFiyat, CiftFiyat;
        int ToplamFiyat;
        Rezervasyon rezervasyon = new Rezervasyon();
        List<Rezervasyon> rezervasyonListesi = new List<Rezervasyon>();
        Admin admin = new Admin();

        
        






        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedItem == "Tek Kiþilik")
            {
                TekFiyat = admin.FiyatTek;
                ToplamFiyat = (dateTimePicker2.Value - dateTimePicker1.Value).Days * admin.FiyatTek;
                label7.Text = ToplamFiyat.ToString();

            }
            if (comboBox1.SelectedItem == "Çift Kiþilik")
            {
                CiftFiyat = admin.FiyatCift;
                ToplamFiyat = (dateTimePicker2.Value - dateTimePicker1.Value).Days * admin.FiyatCift;
                label7.Text = ToplamFiyat.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rezervasyon.OdaTipi = comboBox1.SelectedItem.ToString();
            if (comboBox1.SelectedItem == "Tek Kiþilik")
            {
                TekFiyat = admin.FiyatTek;
                ToplamFiyat = (dateTimePicker2.Value - dateTimePicker1.Value).Days * admin.FiyatTek;

                rezervasyon.CikisTarihi = dateTimePicker2.Value;
                rezervasyon.GirisTarihi = dateTimePicker1.Value;
                rezervasyon.Ad = textBoxad.Text;
                rezervasyon.iletisimNo = textBox2.Text;
                rezervasyon.fiyatBilgi = ToplamFiyat.ToString();
                listBox1.Items.Add("Rezervasyon tarihi=" + rezervasyon.GirisTarihi.ToString("dd.MM.yyyy") + "-" + rezervasyon.CikisTarihi.ToString("dd.MM.yyyy"));
                listBox1.Items.Add("toplam fiyat=" + ToplamFiyat );
                listBox1.Items.Add("oda tipi=" + rezervasyon.OdaTipi);// listboxta alt satýra geçmesi için ayrý ayrý ekledim.//

            }
            if (comboBox1.SelectedItem == "Çift Kiþilik")
            {
                CiftFiyat = admin.FiyatCift;
                ToplamFiyat = (dateTimePicker2.Value - dateTimePicker1.Value).Days * admin.FiyatCift;
                rezervasyon.CikisTarihi = dateTimePicker2.Value;
                rezervasyon.GirisTarihi = dateTimePicker1.Value;
                rezervasyon.Ad=textBoxad.Text;
                rezervasyon.iletisimNo = textBox2.Text;
                rezervasyon.fiyatBilgi = ToplamFiyat.ToString();
                listBox1.Items.Add("Rezervasyon tarihi=" + rezervasyon.GirisTarihi.ToString("dd.MM.yyyy") + "-" + rezervasyon.CikisTarihi.ToString("dd.MM.yyyy"));
                listBox1.Items.Add("toplam fiyat=" + ToplamFiyat );
                listBox1.Items.Add("oda tipi=" + rezervasyon.OdaTipi);// listboxta alt satýra geçmesi için ayrý ayrý ekledim.//
            }

            rezervasyonListesi.Add(rezervasyon);
            MessageBox.Show("Rezervasyonununuz baþarýyla oluþturuldu!");
            RezervasyonlarListesi.rezervasyonListesi = rezervasyonListesi;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
        }
    }
}
