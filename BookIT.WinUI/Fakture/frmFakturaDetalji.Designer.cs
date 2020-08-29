namespace BookIT.WinUI.Fakture
{
    partial class frmFakturaDetalji
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDatumFakture = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLokacijaKlijent = new System.Windows.Forms.Label();
            this.lblAdresaKlijenta = new System.Windows.Forms.Label();
            this.lblImeKlijenta = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLokacijaVlasnikSmjestaj = new System.Windows.Forms.Label();
            this.lblAdresaVlasnikaSmjestaja = new System.Windows.Forms.Label();
            this.lblImeVlasnikaSmjestaja = new System.Windows.Forms.Label();
            this.dgvDetaljiFakture = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUkupanIznos = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.lblNazivSmjestaja = new System.Windows.Forms.Label();
            this.DodatnaUslugaRezervacijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DodatnaUsluga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiFakture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum fakture:";
            // 
            // lblDatumFakture
            // 
            this.lblDatumFakture.AutoSize = true;
            this.lblDatumFakture.Location = new System.Drawing.Point(136, 60);
            this.lblDatumFakture.Name = "lblDatumFakture";
            this.lblDatumFakture.Size = new System.Drawing.Size(0, 13);
            this.lblDatumFakture.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLokacijaKlijent);
            this.groupBox1.Controls.Add(this.lblAdresaKlijenta);
            this.groupBox1.Controls.Add(this.lblImeKlijenta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Aquamarine;
            this.groupBox1.Location = new System.Drawing.Point(46, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klijent";
            // 
            // lblLokacijaKlijent
            // 
            this.lblLokacijaKlijent.AutoSize = true;
            this.lblLokacijaKlijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLokacijaKlijent.Location = new System.Drawing.Point(6, 81);
            this.lblLokacijaKlijent.Name = "lblLokacijaKlijent";
            this.lblLokacijaKlijent.Size = new System.Drawing.Size(35, 13);
            this.lblLokacijaKlijent.TabIndex = 2;
            this.lblLokacijaKlijent.Text = "label5";
            // 
            // lblAdresaKlijenta
            // 
            this.lblAdresaKlijenta.AutoSize = true;
            this.lblAdresaKlijenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresaKlijenta.Location = new System.Drawing.Point(6, 56);
            this.lblAdresaKlijenta.Name = "lblAdresaKlijenta";
            this.lblAdresaKlijenta.Size = new System.Drawing.Size(35, 13);
            this.lblAdresaKlijenta.TabIndex = 1;
            this.lblAdresaKlijenta.Text = "label4";
            // 
            // lblImeKlijenta
            // 
            this.lblImeKlijenta.AutoSize = true;
            this.lblImeKlijenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeKlijenta.Location = new System.Drawing.Point(6, 32);
            this.lblImeKlijenta.Name = "lblImeKlijenta";
            this.lblImeKlijenta.Size = new System.Drawing.Size(35, 13);
            this.lblImeKlijenta.TabIndex = 0;
            this.lblImeKlijenta.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLokacijaVlasnikSmjestaj);
            this.groupBox2.Controls.Add(this.lblAdresaVlasnikaSmjestaja);
            this.groupBox2.Controls.Add(this.lblImeVlasnikaSmjestaja);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Aquamarine;
            this.groupBox2.Location = new System.Drawing.Point(308, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vlasnik smještaja";
            // 
            // lblLokacijaVlasnikSmjestaj
            // 
            this.lblLokacijaVlasnikSmjestaj.AutoSize = true;
            this.lblLokacijaVlasnikSmjestaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLokacijaVlasnikSmjestaj.Location = new System.Drawing.Point(6, 81);
            this.lblLokacijaVlasnikSmjestaj.Name = "lblLokacijaVlasnikSmjestaj";
            this.lblLokacijaVlasnikSmjestaj.Size = new System.Drawing.Size(35, 13);
            this.lblLokacijaVlasnikSmjestaj.TabIndex = 2;
            this.lblLokacijaVlasnikSmjestaj.Text = "label3";
            // 
            // lblAdresaVlasnikaSmjestaja
            // 
            this.lblAdresaVlasnikaSmjestaja.AutoSize = true;
            this.lblAdresaVlasnikaSmjestaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresaVlasnikaSmjestaja.Location = new System.Drawing.Point(6, 56);
            this.lblAdresaVlasnikaSmjestaja.Name = "lblAdresaVlasnikaSmjestaja";
            this.lblAdresaVlasnikaSmjestaja.Size = new System.Drawing.Size(35, 13);
            this.lblAdresaVlasnikaSmjestaja.TabIndex = 1;
            this.lblAdresaVlasnikaSmjestaja.Text = "label6";
            // 
            // lblImeVlasnikaSmjestaja
            // 
            this.lblImeVlasnikaSmjestaja.AutoSize = true;
            this.lblImeVlasnikaSmjestaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeVlasnikaSmjestaja.Location = new System.Drawing.Point(6, 32);
            this.lblImeVlasnikaSmjestaja.Name = "lblImeVlasnikaSmjestaja";
            this.lblImeVlasnikaSmjestaja.Size = new System.Drawing.Size(35, 13);
            this.lblImeVlasnikaSmjestaja.TabIndex = 0;
            this.lblImeVlasnikaSmjestaja.Text = "label7";
            // 
            // dgvDetaljiFakture
            // 
            this.dgvDetaljiFakture.AllowUserToAddRows = false;
            this.dgvDetaljiFakture.AllowUserToDeleteRows = false;
            this.dgvDetaljiFakture.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetaljiFakture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetaljiFakture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetaljiFakture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DodatnaUslugaRezervacijaId,
            this.DodatnaUsluga,
            this.Cijena});
            this.dgvDetaljiFakture.EnableHeadersVisualStyles = false;
            this.dgvDetaljiFakture.Location = new System.Drawing.Point(46, 273);
            this.dgvDetaljiFakture.Name = "dgvDetaljiFakture";
            this.dgvDetaljiFakture.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetaljiFakture.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetaljiFakture.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.dgvDetaljiFakture.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Aquamarine;
            this.dgvDetaljiFakture.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.dgvDetaljiFakture.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Aquamarine;
            this.dgvDetaljiFakture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetaljiFakture.Size = new System.Drawing.Size(462, 155);
            this.dgvDetaljiFakture.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ukupno:";
            // 
            // lblUkupanIznos
            // 
            this.lblUkupanIznos.AutoSize = true;
            this.lblUkupanIznos.Location = new System.Drawing.Point(196, 435);
            this.lblUkupanIznos.Name = "lblUkupanIznos";
            this.lblUkupanIznos.Size = new System.Drawing.Size(35, 13);
            this.lblUkupanIznos.TabIndex = 11;
            this.lblUkupanIznos.Text = "label3";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.Aquamarine;
            this.close.Location = new System.Drawing.Point(547, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(16, 16);
            this.close.TabIndex = 15;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // lblNazivSmjestaja
            // 
            this.lblNazivSmjestaja.AutoSize = true;
            this.lblNazivSmjestaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivSmjestaja.Location = new System.Drawing.Point(41, 27);
            this.lblNazivSmjestaja.Name = "lblNazivSmjestaja";
            this.lblNazivSmjestaja.Size = new System.Drawing.Size(0, 20);
            this.lblNazivSmjestaja.TabIndex = 16;
            // 
            // DodatnaUslugaRezervacijaId
            // 
            this.DodatnaUslugaRezervacijaId.HeaderText = "DodatnaUslugaRezervacijaId";
            this.DodatnaUslugaRezervacijaId.Name = "DodatnaUslugaRezervacijaId";
            this.DodatnaUslugaRezervacijaId.ReadOnly = true;
            this.DodatnaUslugaRezervacijaId.Visible = false;
            // 
            // DodatnaUsluga
            // 
            this.DodatnaUsluga.DataPropertyName = "DodatnaUsluga";
            this.DodatnaUsluga.HeaderText = "Naziv usluge";
            this.DodatnaUsluga.Name = "DodatnaUsluga";
            this.DodatnaUsluga.ReadOnly = true;
            this.DodatnaUsluga.Width = 200;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "CijenaStr";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // frmFakturaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(562, 462);
            this.Controls.Add(this.lblNazivSmjestaja);
            this.Controls.Add(this.close);
            this.Controls.Add(this.lblUkupanIznos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDetaljiFakture);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDatumFakture);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Aquamarine;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmFakturaDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Detalji fakture";
            this.Load += new System.EventHandler(this.frmFakturaDetalji_Load);
            this.Resize += new System.EventHandler(this.frmFakturaDetalji_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiFakture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDatumFakture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLokacijaKlijent;
        private System.Windows.Forms.Label lblAdresaKlijenta;
        private System.Windows.Forms.Label lblImeKlijenta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLokacijaVlasnikSmjestaj;
        private System.Windows.Forms.Label lblAdresaVlasnikaSmjestaja;
        private System.Windows.Forms.Label lblImeVlasnikaSmjestaja;
        private System.Windows.Forms.DataGridView dgvDetaljiFakture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUkupanIznos;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label lblNazivSmjestaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DodatnaUslugaRezervacijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DodatnaUsluga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
    }
}