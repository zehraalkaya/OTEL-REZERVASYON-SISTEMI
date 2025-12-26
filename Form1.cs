namespace DonemProjesi
{

    public partial class FormGiris : Form
    {

        public FormGiris()
        {
            InitializeComponent();
            textBox1.Text = "";
            textBox2.Text = "";


        }

        private void FormGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && int.Parse(textBox2.Text) == 1234 && checkBox1.Checked)
            {
                IGirisYap admin = new Admin();
                FormGiris formGiris = new FormGiris();
                admin.GirisYap(formGiris);
                
            }
            else if (checkBox1.Checked)
            {
                IGirisYap musteri = new Musteri();
                FormGiris formGiris = new FormGiris();
                musteri.GirisYap(formGiris);

            }
            else
            {
                MessageBox.Show("Lütfen robot olmadýðýnýzý doðrulayýn");
            }
            checkBox1.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        
    }
}
