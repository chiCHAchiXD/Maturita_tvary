using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//pridano
using System.Drawing;

namespace TvaryKnihovna
{
    public class Kruh : Tvar
    {
        public Kruh()
            : base()
        {
            
        }
    
        public Kruh(int sirka)
            : base(sirka, sirka)
        {
            //super();
            //this.sirka = sirka;
            //this.vyska = sirka;
            
        }    

        public Kruh(Color barva, int x, int y, int sirka)
            :base(barva, x, y, sirka, sirka)
        { 
        
        }
    
        public override void Nakreslit()
        {
            Console.WriteLine("kruh neni jednoduche v konsoli nakreslit\n");
        }

        public override void Nakreslit(Graphics papir)
        {
            Pen pero = new Pen(this.barva, 3);
            papir.DrawEllipse(pero, this.x, this.y, this.sirka, this.sirka);

        }

        public override double VypocitatObvod()
        {
            double obvod = 3.14 * this.sirka;
            return obvod;
        }

        public override double VypocitatObsah()
        {
            double r = this.sirka / 2.0;
            double obsah = 3.14 * r * r;
            return obsah;
        }

        public override String ToString()
        {
            return "kruh: " + base.ToString();
        }

    }
}
