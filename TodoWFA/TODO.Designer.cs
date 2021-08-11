
namespace TodoWFA
{
    partial class TODO
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxTo = new System.Windows.Forms.ListBox();
            this.listBoxDo = new System.Windows.Forms.ListBox();
            this.buttonDo = new System.Windows.Forms.Button();
            this.buttonTo = new System.Windows.Forms.Button();
            this.buttonDoPliku = new System.Windows.Forms.Button();
            this.buttonZPliku = new System.Windows.Forms.Button();
            this.buttonNaPulpit = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(12, 64);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(200, 23);
            this.buttonDodaj.TabIndex = 0;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 3;
            // 
            // listBoxTo
            // 
            this.listBoxTo.FormattingEnabled = true;
            this.listBoxTo.Location = new System.Drawing.Point(218, 12);
            this.listBoxTo.Name = "listBoxTo";
            this.listBoxTo.Size = new System.Drawing.Size(315, 147);
            this.listBoxTo.TabIndex = 4;
            // 
            // listBoxDo
            // 
            this.listBoxDo.FormattingEnabled = true;
            this.listBoxDo.Location = new System.Drawing.Point(539, 12);
            this.listBoxDo.Name = "listBoxDo";
            this.listBoxDo.Size = new System.Drawing.Size(315, 147);
            this.listBoxDo.TabIndex = 5;
            // 
            // buttonDo
            // 
            this.buttonDo.Location = new System.Drawing.Point(329, 171);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(75, 23);
            this.buttonDo.TabIndex = 6;
            this.buttonDo.Text = ">";
            this.buttonDo.UseVisualStyleBackColor = true;
            this.buttonDo.Click += new System.EventHandler(this.buttonDo_Click);
            // 
            // buttonTo
            // 
            this.buttonTo.Location = new System.Drawing.Point(662, 171);
            this.buttonTo.Name = "buttonTo";
            this.buttonTo.Size = new System.Drawing.Size(75, 23);
            this.buttonTo.TabIndex = 7;
            this.buttonTo.Text = "<";
            this.buttonTo.UseVisualStyleBackColor = true;
            this.buttonTo.Click += new System.EventHandler(this.buttonTo_Click);
            // 
            // buttonDoPliku
            // 
            this.buttonDoPliku.Location = new System.Drawing.Point(12, 142);
            this.buttonDoPliku.Name = "buttonDoPliku";
            this.buttonDoPliku.Size = new System.Drawing.Size(200, 23);
            this.buttonDoPliku.TabIndex = 8;
            this.buttonDoPliku.Text = "Zapisz do wybranego pliku";
            this.buttonDoPliku.UseVisualStyleBackColor = true;
            this.buttonDoPliku.Click += new System.EventHandler(this.buttonDoPliku_Click);
            // 
            // buttonZPliku
            // 
            this.buttonZPliku.Location = new System.Drawing.Point(12, 113);
            this.buttonZPliku.Name = "buttonZPliku";
            this.buttonZPliku.Size = new System.Drawing.Size(200, 23);
            this.buttonZPliku.TabIndex = 9;
            this.buttonZPliku.Text = "Wczytaj z pliku";
            this.buttonZPliku.UseVisualStyleBackColor = true;
            this.buttonZPliku.Click += new System.EventHandler(this.buttonZPliku_Click);
            // 
            // buttonNaPulpit
            // 
            this.buttonNaPulpit.Location = new System.Drawing.Point(12, 171);
            this.buttonNaPulpit.Name = "buttonNaPulpit";
            this.buttonNaPulpit.Size = new System.Drawing.Size(200, 23);
            this.buttonNaPulpit.TabIndex = 10;
            this.buttonNaPulpit.Text = "Zapisz na pulpicie";
            this.buttonNaPulpit.UseVisualStyleBackColor = true;
            this.buttonNaPulpit.Click += new System.EventHandler(this.buttonNaPulpit_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(235, 171);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(75, 23);
            this.buttonUsun.TabIndex = 11;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // TODO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 212);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonNaPulpit);
            this.Controls.Add(this.buttonZPliku);
            this.Controls.Add(this.buttonDoPliku);
            this.Controls.Add(this.buttonTo);
            this.Controls.Add(this.buttonDo);
            this.Controls.Add(this.listBoxDo);
            this.Controls.Add(this.listBoxTo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonDodaj);
            this.Name = "TODO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDo";
            this.Load += new System.EventHandler(this.TODO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBoxTo;
        private System.Windows.Forms.ListBox listBoxDo;
        private System.Windows.Forms.Button buttonDo;
        private System.Windows.Forms.Button buttonTo;
        private System.Windows.Forms.Button buttonDoPliku;
        private System.Windows.Forms.Button buttonZPliku;
        private System.Windows.Forms.Button buttonNaPulpit;
        private System.Windows.Forms.Button buttonUsun;
    }
}

