namespace DonemProjesi
{
    public partial class Formadmin : Form
    {
        List<Rezervasyon> rezervasyonListesi = new List<Rezervasyon>();

        public Formadmin()
        {
            rezervasyonListesi = RezervasyonlarListesi.rezervasyonListesi;
            InitializeComponent();
            
        }

        private void Formadmin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int TekF = int.Parse(textBox1.Text);
            int CiftF = int.Parse(textBox2.Text);
            Admin admin = new Admin();
            admin.FiyatBelirle(TekF, CiftF);
            MessageBox.Show("Fiyatlar baþarýyla güncellendi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            foreach (var rezervasyon in rezervasyonListesi)
            {
                listBox1.Items.Add($"Rezervayon sahibi:{rezervasyon.Ad}");
                listBox1.Items.Add($"Ýletiþim numarasý:{rezervasyon.iletisimNo}");
                listBox1.Items.Add($"Giriþ-Çýkýþ Tarihi:{rezervasyon.GirisTarihi.ToString("dd.MM.yyyy")}-{rezervasyon.CikisTarihi.ToString("dd.MM.yyyy")}");
                listBox1.Items.Add($"Oda Tipi:{rezervasyon.OdaTipi}");
                listBox1.Items.Add($"Toplam Tutar:{rezervasyon.fiyatBilgi}");   // listboxta alt satýra geçmesi için ayrý ayrý ekledim.//
            }
        }
    }
}
