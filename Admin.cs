using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonemProjesi
{
    public class Admin:Kullanici
    {
      
        public List<Rezervasyon> rezervasyonlarim = new List<Rezervasyon>();
        private string sifre;
        public int FiyatTek = 2300;
        public int FiyatCift = 3500;
    
        public string Sifre
        {
            get
            {
                return sifre;
            }
            set
            {
                sifre = value;
            }
        }
        public Admin()
        {
            
            
        }

        

        public override void İslemYap()
        {

        }
        public void FiyatBelirle(int TekF,int CiftF)
        {
            FiyatCift= CiftF;
            FiyatTek= TekF;
            
            
        }
        public override void GirisYap(Form a)
        {
            Formadmin formAdmin = new Formadmin();
            formAdmin.Show();
            a.Hide();
        }
    }
}
