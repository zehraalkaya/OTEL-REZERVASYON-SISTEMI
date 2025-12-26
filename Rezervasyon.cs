using System.Text;

namespace DonemProjesi
{
  
    public class Rezervasyon
    {
        
        private DateTime girisTarihi;
        private DateTime cikisTarihi;
        public string OdaTipi {  get; set; }
        public string Ad {  get; set; }
        public string iletisimNo {  get; set; }
        public string fiyatBilgi {  get; set; }
        public DateTime GirisTarihi
        {
            get
            {
                return girisTarihi;
            }
            set
            {
                girisTarihi = value;
            }
        }
        public DateTime CikisTarihi
        {
            get
            {
                return cikisTarihi;
            }
            set
            {
                cikisTarihi = value;
            }
        }
        public Rezervasyon()
        {
          
        }
        
        
    }
}
