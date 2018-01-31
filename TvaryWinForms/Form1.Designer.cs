namespace TvaryWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbNovyTvar = new System.Windows.Forms.GroupBox();
            this.btnCtverec = new System.Windows.Forms.Button();
            this.btnObdelnik = new System.Windows.Forms.Button();
            this.btnKruh = new System.Windows.Forms.Button();
            this.btnBarva = new System.Windows.Forms.Button();
            this.tbVyska = new System.Windows.Forms.TextBox();
            this.tbSirka = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbVypocitat = new System.Windows.Forms.GroupBox();
            this.tbObsah = new System.Windows.Forms.TextBox();
            this.tbObvod = new System.Windows.Forms.TextBox();
            this.btnVypocitatObsah = new System.Windows.Forms.Button();
            this.btnVypocitatObvod = new System.Windows.Forms.Button();
            this.gbOvladaciPanel = new System.Windows.Forms.GroupBox();
            this.btnZmensit = new System.Windows.Forms.Button();
            this.btnZvetsit = new System.Windows.Forms.Button();
            this.btnDoprava = new System.Windows.Forms.Button();
            this.btnDoleva = new System.Windows.Forms.Button();
            this.btnDolu = new System.Windows.Forms.Button();
            this.btnNahoru = new System.Windows.Forms.Button();
            this.lbSeznamTvaru = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbOvladaciPanel = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gbNovyTvar.SuspendLayout();
            this.gbVypocitat.SuspendLayout();
            this.gbOvladaciPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNovyTvar
            // 
            this.gbNovyTvar.Controls.Add(this.btnCtverec);
            this.gbNovyTvar.Controls.Add(this.btnObdelnik);
            this.gbNovyTvar.Controls.Add(this.btnKruh);
            this.gbNovyTvar.Controls.Add(this.btnBarva);
            this.gbNovyTvar.Controls.Add(this.tbVyska);
            this.gbNovyTvar.Controls.Add(this.tbSirka);
            this.gbNovyTvar.Controls.Add(this.tbY);
            this.gbNovyTvar.Controls.Add(this.tbX);
            this.gbNovyTvar.Controls.Add(this.label5);
            this.gbNovyTvar.Controls.Add(this.label4);
            this.gbNovyTvar.Controls.Add(this.label3);
            this.gbNovyTvar.Controls.Add(this.label2);
            this.gbNovyTvar.Controls.Add(this.label1);
            this.gbNovyTvar.Location = new System.Drawing.Point(12, 12);
            this.gbNovyTvar.Name = "gbNovyTvar";
            this.gbNovyTvar.Size = new System.Drawing.Size(276, 248);
            this.gbNovyTvar.TabIndex = 0;
            this.gbNovyTvar.TabStop = false;
            this.gbNovyTvar.Text = "Novy tvar";
            // 
            // btnCtverec
            // 
            this.btnCtverec.Location = new System.Drawing.Point(66, 212);
            this.btnCtverec.Name = "btnCtverec";
            this.btnCtverec.Size = new System.Drawing.Size(135, 23);
            this.btnCtverec.TabIndex = 12;
            this.btnCtverec.Text = "novy ctverec";
            this.btnCtverec.UseVisualStyleBackColor = true;
            this.btnCtverec.Click += new System.EventHandler(this.btnUniverzalniTvar_Click);
            // 
            // btnObdelnik
            // 
            this.btnObdelnik.Location = new System.Drawing.Point(66, 183);
            this.btnObdelnik.Name = "btnObdelnik";
            this.btnObdelnik.Size = new System.Drawing.Size(135, 23);
            this.btnObdelnik.TabIndex = 11;
            this.btnObdelnik.Text = "novy obdelnik";
            this.btnObdelnik.UseVisualStyleBackColor = true;
            this.btnObdelnik.Click += new System.EventHandler(this.btnUniverzalniTvar_Click);
            // 
            // btnKruh
            // 
            this.btnKruh.Location = new System.Drawing.Point(66, 154);
            this.btnKruh.Name = "btnKruh";
            this.btnKruh.Size = new System.Drawing.Size(135, 23);
            this.btnKruh.TabIndex = 10;
            this.btnKruh.Text = "novy kruh";
            this.btnKruh.UseVisualStyleBackColor = true;
            this.btnKruh.Click += new System.EventHandler(this.btnUniverzalniTvar_Click);
            // 
            // btnBarva
            // 
            this.btnBarva.Location = new System.Drawing.Point(101, 125);
            this.btnBarva.Name = "btnBarva";
            this.btnBarva.Size = new System.Drawing.Size(100, 23);
            this.btnBarva.TabIndex = 9;
            this.btnBarva.Text = "dialog barva";
            this.btnBarva.UseVisualStyleBackColor = true;
            this.btnBarva.Click += new System.EventHandler(this.btnBarva_Click);
            // 
            // tbVyska
            // 
            this.tbVyska.Location = new System.Drawing.Point(101, 97);
            this.tbVyska.Name = "tbVyska";
            this.tbVyska.Size = new System.Drawing.Size(100, 20);
            this.tbVyska.TabIndex = 8;
            this.tbVyska.Text = "40";
            // 
            // tbSirka
            // 
            this.tbSirka.Location = new System.Drawing.Point(101, 71);
            this.tbSirka.Name = "tbSirka";
            this.tbSirka.Size = new System.Drawing.Size(100, 20);
            this.tbSirka.TabIndex = 7;
            this.tbSirka.Text = "90";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(101, 45);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(100, 20);
            this.tbY.TabIndex = 6;
            this.tbY.Text = "0";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(101, 19);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(100, 20);
            this.tbX.TabIndex = 5;
            this.tbX.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "barva:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "vyska:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "sirka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "x:";
            // 
            // gbVypocitat
            // 
            this.gbVypocitat.Controls.Add(this.tbObsah);
            this.gbVypocitat.Controls.Add(this.tbObvod);
            this.gbVypocitat.Controls.Add(this.btnVypocitatObsah);
            this.gbVypocitat.Controls.Add(this.btnVypocitatObvod);
            this.gbVypocitat.Location = new System.Drawing.Point(12, 266);
            this.gbVypocitat.Name = "gbVypocitat";
            this.gbVypocitat.Size = new System.Drawing.Size(314, 95);
            this.gbVypocitat.TabIndex = 1;
            this.gbVypocitat.TabStop = false;
            this.gbVypocitat.Text = "Vypocitat obvod a obsah tvaru";
            // 
            // tbObsah
            // 
            this.tbObsah.Location = new System.Drawing.Point(176, 63);
            this.tbObsah.Name = "tbObsah";
            this.tbObsah.ReadOnly = true;
            this.tbObsah.Size = new System.Drawing.Size(100, 20);
            this.tbObsah.TabIndex = 3;
            // 
            // tbObvod
            // 
            this.tbObvod.Location = new System.Drawing.Point(176, 26);
            this.tbObvod.Name = "tbObvod";
            this.tbObvod.ReadOnly = true;
            this.tbObvod.Size = new System.Drawing.Size(100, 20);
            this.tbObvod.TabIndex = 2;
            // 
            // btnVypocitatObsah
            // 
            this.btnVypocitatObsah.Location = new System.Drawing.Point(46, 61);
            this.btnVypocitatObsah.Name = "btnVypocitatObsah";
            this.btnVypocitatObsah.Size = new System.Drawing.Size(107, 23);
            this.btnVypocitatObsah.TabIndex = 1;
            this.btnVypocitatObsah.Text = "vypocitat obsah";
            this.btnVypocitatObsah.UseVisualStyleBackColor = true;
            this.btnVypocitatObsah.Click += new System.EventHandler(this.btnVypocitatObsah_Click);
            // 
            // btnVypocitatObvod
            // 
            this.btnVypocitatObvod.Location = new System.Drawing.Point(42, 24);
            this.btnVypocitatObvod.Name = "btnVypocitatObvod";
            this.btnVypocitatObvod.Size = new System.Drawing.Size(115, 23);
            this.btnVypocitatObvod.TabIndex = 0;
            this.btnVypocitatObvod.Text = "vypocitat obvod";
            this.btnVypocitatObvod.UseVisualStyleBackColor = true;
            this.btnVypocitatObvod.Click += new System.EventHandler(this.btnVypocitatObvod_Click);
            // 
            // gbOvladaciPanel
            // 
            this.gbOvladaciPanel.Controls.Add(this.btnZmensit);
            this.gbOvladaciPanel.Controls.Add(this.btnZvetsit);
            this.gbOvladaciPanel.Controls.Add(this.btnDoprava);
            this.gbOvladaciPanel.Controls.Add(this.btnDoleva);
            this.gbOvladaciPanel.Controls.Add(this.btnDolu);
            this.gbOvladaciPanel.Controls.Add(this.btnNahoru);
            this.gbOvladaciPanel.Location = new System.Drawing.Point(345, 243);
            this.gbOvladaciPanel.Name = "gbOvladaciPanel";
            this.gbOvladaciPanel.Size = new System.Drawing.Size(368, 92);
            this.gbOvladaciPanel.TabIndex = 2;
            this.gbOvladaciPanel.TabStop = false;
            this.gbOvladaciPanel.Text = "Ovladaci panel";
            // 
            // btnZmensit
            // 
            this.btnZmensit.Location = new System.Drawing.Point(287, 49);
            this.btnZmensit.Name = "btnZmensit";
            this.btnZmensit.Size = new System.Drawing.Size(75, 23);
            this.btnZmensit.TabIndex = 5;
            this.btnZmensit.Text = "zmensit";
            this.btnZmensit.UseVisualStyleBackColor = true;
            this.btnZmensit.Click += new System.EventHandler(this.btnZmensit_Click);
            // 
            // btnZvetsit
            // 
            this.btnZvetsit.Location = new System.Drawing.Point(287, 19);
            this.btnZvetsit.Name = "btnZvetsit";
            this.btnZvetsit.Size = new System.Drawing.Size(75, 23);
            this.btnZvetsit.TabIndex = 4;
            this.btnZvetsit.Text = "zvetsit";
            this.btnZvetsit.UseVisualStyleBackColor = true;
            this.btnZvetsit.Click += new System.EventHandler(this.btnZvetsit_Click);
            // 
            // btnDoprava
            // 
            this.btnDoprava.Location = new System.Drawing.Point(183, 36);
            this.btnDoprava.Name = "btnDoprava";
            this.btnDoprava.Size = new System.Drawing.Size(75, 23);
            this.btnDoprava.TabIndex = 3;
            this.btnDoprava.Text = "doprava";
            this.btnDoprava.UseVisualStyleBackColor = true;
            this.btnDoprava.Click += new System.EventHandler(this.btnDoprava_Click);
            // 
            // btnDoleva
            // 
            this.btnDoleva.Location = new System.Drawing.Point(6, 36);
            this.btnDoleva.Name = "btnDoleva";
            this.btnDoleva.Size = new System.Drawing.Size(75, 23);
            this.btnDoleva.TabIndex = 2;
            this.btnDoleva.Text = "doleva";
            this.btnDoleva.UseVisualStyleBackColor = true;
            this.btnDoleva.Click += new System.EventHandler(this.btnDoleva_Click);
            // 
            // btnDolu
            // 
            this.btnDolu.Location = new System.Drawing.Point(93, 63);
            this.btnDolu.Name = "btnDolu";
            this.btnDolu.Size = new System.Drawing.Size(75, 23);
            this.btnDolu.TabIndex = 1;
            this.btnDolu.Text = "dolu";
            this.btnDolu.UseVisualStyleBackColor = true;
            this.btnDolu.Click += new System.EventHandler(this.btnDolu_Click);
            // 
            // btnNahoru
            // 
            this.btnNahoru.Location = new System.Drawing.Point(93, 19);
            this.btnNahoru.Name = "btnNahoru";
            this.btnNahoru.Size = new System.Drawing.Size(75, 23);
            this.btnNahoru.TabIndex = 0;
            this.btnNahoru.Text = "nahoru";
            this.btnNahoru.UseVisualStyleBackColor = true;
            this.btnNahoru.Click += new System.EventHandler(this.btnNahoru_Click);
            // 
            // lbSeznamTvaru
            // 
            this.lbSeznamTvaru.FormattingEnabled = true;
            this.lbSeznamTvaru.Location = new System.Drawing.Point(294, 12);
            this.lbSeznamTvaru.Name = "lbSeznamTvaru";
            this.lbSeznamTvaru.Size = new System.Drawing.Size(172, 225);
            this.lbSeznamTvaru.TabIndex = 3;
            this.lbSeznamTvaru.SelectedIndexChanged += new System.EventHandler(this.lbSeznamTvaru_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(472, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 225);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbOvladaciPanel
            // 
            this.cbOvladaciPanel.AutoSize = true;
            this.cbOvladaciPanel.Location = new System.Drawing.Point(345, 344);
            this.cbOvladaciPanel.Name = "cbOvladaciPanel";
            this.cbOvladaciPanel.Size = new System.Drawing.Size(181, 17);
            this.cbOvladaciPanel.TabIndex = 5;
            this.cbOvladaciPanel.Text = "ovladani tvaru: Klavesnice / GUI";
            this.cbOvladaciPanel.UseVisualStyleBackColor = true;
            this.cbOvladaciPanel.CheckedChanged += new System.EventHandler(this.cbOvladaciPanel_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 373);
            this.Controls.Add(this.cbOvladaciPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbSeznamTvaru);
            this.Controls.Add(this.gbOvladaciPanel);
            this.Controls.Add(this.gbVypocitat);
            this.Controls.Add(this.gbNovyTvar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.gbNovyTvar.ResumeLayout(false);
            this.gbNovyTvar.PerformLayout();
            this.gbVypocitat.ResumeLayout(false);
            this.gbVypocitat.PerformLayout();
            this.gbOvladaciPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNovyTvar;
        private System.Windows.Forms.GroupBox gbVypocitat;
        private System.Windows.Forms.GroupBox gbOvladaciPanel;
        private System.Windows.Forms.ListBox lbSeznamTvaru;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbVyska;
        private System.Windows.Forms.TextBox tbSirka;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBarva;
        private System.Windows.Forms.Button btnCtverec;
        private System.Windows.Forms.Button btnObdelnik;
        private System.Windows.Forms.Button btnKruh;
        private System.Windows.Forms.TextBox tbObsah;
        private System.Windows.Forms.TextBox tbObvod;
        private System.Windows.Forms.Button btnVypocitatObsah;
        private System.Windows.Forms.Button btnVypocitatObvod;
        private System.Windows.Forms.Button btnZmensit;
        private System.Windows.Forms.Button btnZvetsit;
        private System.Windows.Forms.Button btnDoprava;
        private System.Windows.Forms.Button btnDoleva;
        private System.Windows.Forms.Button btnDolu;
        private System.Windows.Forms.Button btnNahoru;
        private System.Windows.Forms.CheckBox cbOvladaciPanel;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

