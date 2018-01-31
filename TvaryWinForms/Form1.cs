using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//pridano
using TvaryKnihovna;

namespace TvaryWinForms
{
    public partial class Form1 : Form
    {
        //clenske promenne
        private Tvar aktivniTvar = null;

        //konstanta
        private const int KROK = 5;

        //konstruktor
        public Form1()
        {
            InitializeComponent();

            //Obdelnik obdelnik1 = new Obdelnik(40, 6);
            //MessageBox.Show( obdelnik1.ToString() );
        }

        //metody
        private void btnBarva_Click(object sender, EventArgs e)
        {
            //colorDialog1.ShowDialog();

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnBarva.BackColor = colorDialog1.Color;
            }
            else
            {
                //zrusit akci
            }
        }

        private void btnKruh_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(tbX.Text);
            int y = Convert.ToInt32(tbY.Text);
            int sirka = Convert.ToInt32(tbSirka.Text);
            int vyska = Convert.ToInt32(tbVyska.Text);

            //Kruh k = new Kruh(sirka);
            Kruh k = new Kruh(colorDialog1.Color, x, y, sirka);

            lbSeznamTvaru.Items.Add(k);

            panel1.Refresh();
        }

        //napiseme jednu spolecnou obsluznou metodu pro vytvareni vsech objektu
        //tj. pro kruh, obdelnik i ctverec - spolecna obsluha udalosti
        //                                           sender je parametr metody - odkaz na objekt, ktery udalost aktivoval
        //                                                             e je parametr metody - detaily o dane udalosti
        private void btnUniverzalniTvar_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(tbX.Text);
            int y = Convert.ToInt32(tbY.Text);
            int sirka = Convert.ToInt32(tbSirka.Text);
            int vyska = Convert.ToInt32(tbVyska.Text);

            //Kruh k = new Kruh(sirka);
            //Kruh k = new Kruh(colorDialog1.Color, x, y, sirka);

            //programovani pro univerzalni Tvar
            Tvar tvar = null;
            if (sender is Button)
            {
                Button b = sender as Button;  //pretypovani na Button
                if (b.Name == "btnKruh")
                {
                    tvar = new Kruh(colorDialog1.Color, x, y, sirka);
                }
                if (b.Name == "btnObdelnik")
                {
                    tvar = new Obdelnik(colorDialog1.Color, x, y, sirka, vyska);
                }
                if (b.Name == "btnCtverec")
                {
                    tvar = new Ctverec(colorDialog1.Color, x, y, sirka);
                }         
            }

            //lbSeznamTvaru.Items.Add(k);
            lbSeznamTvaru.Items.Add(tvar);

            panel1.Refresh();
        }




        //pokracovat zde
        //btnUniverzalniTvar_Click................


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //zde se kresli na panel1
            Graphics papir = e.Graphics;

            //spatne reseni
            //Kruh kk = (Kruh)lbSeznamTvaru.Items[0];
            //kk.Nakreslit(papir);

            //spravne reseni
            if (lbSeznamTvaru.Items.Count > 0)
            {
                //Kruh kk = (Kruh)lbSeznamTvaru.Items[0];
                //kk.Nakreslit(papir);

                foreach (Tvar tvar in lbSeznamTvaru.Items)
                {
                    tvar.Nakreslit(papir);
                }

            }

        }

        private void lbSeznamTvaru_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbSeznamTvaru.SelectedIndex;
            try
            {
                this.aktivniTvar = lbSeznamTvaru.Items[index] as Tvar;
            }
            catch 
            {
            }
            

            tbObvod.Text = "";
            tbObsah.Text = "";
        }

        private void btnVypocitatObvod_Click(object sender, EventArgs e)
        {
            //neni zamerena zadna polozka v seznamu lbSeznamTvaru
            if (lbSeznamTvaru.SelectedIndex == -1)
            {
                return;
            }

            double obvod = this.aktivniTvar.VypocitatObvod();
            tbObvod.Text = obvod.ToString("N2");
        }

        private void btnVypocitatObsah_Click(object sender, EventArgs e)
        {
            //neni zamerena zadna polozka v seznamu lbSeznamTvaru
            if (lbSeznamTvaru.SelectedIndex == -1)
            {
                return;
            }

            double obsah = this.aktivniTvar.VypocitatObsah();
            tbObsah.Text = obsah.ToString("N2");
        }

        private void btnDoprava_Click(object sender, EventArgs e)
        {
            if (lbSeznamTvaru.SelectedIndex == -1)
            {
                return;
            }

            this.aktivniTvar.PresunoutVodorovne(KROK);
            panel1.Refresh();
        }

        private void btnDoleva_Click(object sender, EventArgs e)
        {
            if (lbSeznamTvaru.SelectedIndex == -1)
            {
                return;
            }

            this.aktivniTvar.PresunoutVodorovne(-KROK);
            panel1.Refresh();
        }

        private void btnDolu_Click(object sender, EventArgs e)
        {
            if (lbSeznamTvaru.SelectedIndex == -1)
            {
                return;
            }

            this.aktivniTvar.PresunoutSvisle(KROK);
            panel1.Refresh();
        }

        private void btnNahoru_Click(object sender, EventArgs e)
        {
            if (lbSeznamTvaru.SelectedIndex == -1)
            {
                return;
            }

            this.aktivniTvar.PresunoutSvisle(-KROK);
            panel1.Refresh();
        }

        private void btnZvetsit_Click(object sender, EventArgs e)
        {
            if (lbSeznamTvaru.SelectedIndex == -1)
            {
                return;
            }

            this.aktivniTvar.Zvetsit(KROK);
            panel1.Refresh();
        }

        private void btnZmensit_Click(object sender, EventArgs e)
        {
            if (lbSeznamTvaru.SelectedIndex == -1)
            {
                return;
            }

            this.aktivniTvar.Zmensit(KROK);
            panel1.Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(lbSeznamTvaru.SelectedIndex == -1)
            {
                return;
            }

            switch (e.KeyCode)
            {
                case Keys.Right:
                    this.aktivniTvar.PresunoutVodorovne(KROK);
                    break;
                case Keys.Left:
                    this.aktivniTvar.PresunoutVodorovne(-KROK);
                    break;
                case Keys.Up:
                    this.aktivniTvar.PresunoutSvisle(-KROK);
                    break;
                case Keys.Down:
                    this.aktivniTvar.PresunoutSvisle(KROK);
                    break;
                case Keys.Add:
                    this.aktivniTvar.Zvetsit(KROK);
                    break;
                case Keys.Subtract:
                    this.aktivniTvar.Zmensit(KROK);
                    break;
            }
            e.Handled = true;
            panel1.Refresh();
        }

        private void cbOvladaciPanel_CheckedChanged(object sender, EventArgs e)
        {
            KeyPreview = cbOvladaciPanel.Checked;
            gbOvladaciPanel.Visible = !cbOvladaciPanel.Checked;
        }
    }
}
