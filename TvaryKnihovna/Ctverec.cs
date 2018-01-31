using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//pridano
using System.Drawing;

namespace TvaryKnihovna
{
    public class Ctverec : Obdelnik
    {
        public Ctverec() 
            : base()
        {
            
        }
    
        public Ctverec(int sirka)
            : base(sirka, sirka)
        {
            //super();
            //this.sirka = sirka;
            //this.vyska = sirka;            
        }

        public Ctverec(Color barva, int x, int y, int sirka)
            :base(barva, x, y, sirka, sirka)
        { 
        
        }
    
        public override String ToString()
        {
            return "ctverec je specialni -> " + base.ToString();
        }  
    }
}
