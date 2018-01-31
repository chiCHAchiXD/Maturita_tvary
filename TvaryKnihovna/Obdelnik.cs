using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//pridano
using System.Drawing;

namespace TvaryKnihovna
{
    public class Obdelnik : Tvar
    {
        public Obdelnik()
            : base()
        {
            //super();
           
        }
    
        public Obdelnik(int sirka, int vyska)
            : base(sirka, vyska)
        {
            //super();
            //this.sirka = sirka;
            //this.vyska = vyska;
            //super(sirka, vyska);
            
        }

        public Obdelnik(Color barva, int x, int y, int sirka, int vyska)
            :base(barva, x, y, sirka, vyska)
        { 
            
        }
    
        public override void Nakreslit()
        {
            for (int y = 0; y < this.vyska; y++)
            {
                for (int x = 0; x < this.sirka; x++)
                {
                    //System.out.print("X");
                    Console.Write("X");
                }
                //System.out.println();
                Console.WriteLine();
            }
            //System.out.println();
            Console.WriteLine();
        }

        public override void Nakreslit(Graphics papir)
        { 
            //obrys obdelniku
            Pen pero = new Pen(this.barva, 3);
            papir.DrawRectangle(pero, this.x, this.y, this.sirka, this.vyska);

            //vyplneny obdelnik - pozdeji...
            Brush stetec = new SolidBrush(this.barva);
            papir.FillRectangle(stetec, this.x, this.y, this.sirka, this.vyska);

        }

        public override double VypocitatObvod()
        {
            return 2 * (this.sirka + this.vyska);
        }

        public override double VypocitatObsah()
        {
            return this.sirka * this.vyska;
        }
    
        public override String ToString()
        {
            return "obdelnik: " + base.ToString();
        }    

    }
}
