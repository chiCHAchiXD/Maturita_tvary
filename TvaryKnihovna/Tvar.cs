using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//pridano
//using System.Windows.Forms;
using System.Drawing;


namespace TvaryKnihovna
{
    public abstract class Tvar
    {
        protected int sirka;
        protected int vyska;

        protected int x;
        protected int y;

        protected Color barva;
    
        public Tvar()
        {
            this.sirka = 0;
            this.vyska = 0;
        }    
        //pridano
        public Tvar(int sirka)
        {
            this.sirka = sirka;
            this.vyska = sirka;
        }
        //pridano
        public Tvar(int sirka, int vyska)
        {
            this.sirka = sirka;
            this.vyska = vyska;
        }

        //konstruktor pro GUI
        public Tvar(Color barva, int x, int y, int sirka, int vyska)
        {
            this.barva = barva;
            this.x = x;
            this.y = y;
            this.sirka = sirka;
            this.vyska = vyska;
        }

        public abstract void Nakreslit();
        public abstract void Nakreslit(Graphics papir);
    
        public abstract double VypocitatObvod();
    
        public abstract double VypocitatObsah();        
    
        //@Override
        public override String ToString() 
        {
            return "this.sirka=" + this.sirka + " this.vyska=" + this.vyska;
        }

        //pridano pro WinForms
        public void PresunoutVodorovne(int krok)
        {
            this.x += krok;
        }
        public void PresunoutSvisle(int krok)
        {
            this.y += krok;
        }

        public void Zvetsit(int krok)
        {
            this.sirka += krok;
            this.vyska += krok;
        }

        public void Zmensit(int krok)
        {
            this.sirka -= krok;
            this.vyska -= krok;
        }
    }
}
