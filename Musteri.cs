using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonemProjesi
{
    
    public class Musteri : Kullanici  
    {
        public List<Rezervasyon> rezervasyonlarim = new List<Rezervasyon>();

        private string numara;
        public string Ad {  get; set; }


        public string Numara
        {
            get
            {
                return numara;
            }
            set
            {
                numara = value;
            }
        }
        public Musteri()
        {
            
            
        }
       
        public override void İslemYap()
        {
        }
        public override void GirisYap(Form a)
        {
            FormMusteri formMusteri = new FormMusteri();
            formMusteri.Show();
            a.Hide();
        }
    }
}
