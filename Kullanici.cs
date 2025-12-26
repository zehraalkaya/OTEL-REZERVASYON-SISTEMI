using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonemProjesi
{
    
    public abstract class Kullanici : IGirisYap
    {
        
        
        public string Ad {  get; set; }

        public abstract void GirisYap(Form a);
        
           
            
        

        public abstract void İslemYap();


    }
}
