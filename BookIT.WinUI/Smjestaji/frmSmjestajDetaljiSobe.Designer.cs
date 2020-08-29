namespace BookIT.WinUI.Smjestaji
{
    partial class frmSmjestajDetaljiSobe
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipSmjestaja = new System.Windows.Forms.ComboBox();
            this.cmbLokacije = new System.Windows.Forms.ComboBox();
            this.dgvSobe = new System.Windows.Forms.DataGridView();
            this.SobaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojMalihKreveta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojVelikihKreveta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VelicinaSobe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnDodajSobu = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUrediGaleriju = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.clbTipDestinacije = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Label();
            this.lblNazivSmjestaja = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.txtOdaberiLokaciju = new System.Windows.Forms.Button();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSobe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip smještaja:";
            // 
            // cmbTipSmjestaja
            // 
            this.cmbTipSmjestaja.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTipSmjestaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipSmjestaja.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTipSmjestaja.FormattingEnabled = true;
            this.cmbTipSmjestaja.Location = new System.Drawing.Point(115, 47);
            this.cmbTipSmjestaja.Name = "cmbTipSmjestaja";
            this.cmbTipSmjestaja.Size = new System.Drawing.Size(121, 21);
            this.cmbTipSmjestaja.TabIndex = 2;
            this.cmbTipSmjestaja.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbLokacije_KeyDown);
            this.cmbTipSmjestaja.Validating += new System.ComponentModel.CancelEventHandler(this.cmbTipSmjestaja_Validating);
            // 
            // cmbLokacije
            // 
            this.cmbLokacije.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbLokacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLokacije.ForeColor = System.Drawing.Color.DimGray;
            this.cmbLokacije.FormattingEnabled = true;
            this.cmbLokacije.Location = new System.Drawing.Point(115, 86);
            this.cmbLokacije.Name = "cmbLokacije";
            this.cmbLokacije.Size = new System.Drawing.Size(121, 21);
            this.cmbLokacije.TabIndex = 3;
            this.cmbLokacije.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbLokacije_KeyDown);
            this.cmbLokacije.Validating += new System.ComponentModel.CancelEventHandler(this.cmbLokacije_Validating);
            // 
            // dgvSobe
            // 
            this.dgvSobe.AllowUserToAddRows = false;
            this.dgvSobe.AllowUserToDeleteRows = false;
            this.dgvSobe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSobe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSobe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSobe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SobaId,
            this.Naziv,
            this.BrojMalihKreveta,
            this.BrojVelikihKreveta,
            this.VelicinaSobe,
            this.Cijena});
            this.dgvSobe.EnableHeadersVisualStyles = false;
            this.dgvSobe.Location = new System.Drawing.Point(32, 210);
            this.dgvSobe.Name = "dgvSobe";
            this.dgvSobe.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSobe.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSobe.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSobe.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvSobe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.dgvSobe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgvSobe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSobe.Size = new System.Drawing.Size(545, 232);
            this.dgvSobe.TabIndex = 4;
            this.dgvSobe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSobe_CellDoubleClick);
            // 
            // SobaId
            // 
            this.SobaId.DataPropertyName = "SobaId";
            this.SobaId.HeaderText = "SobaId";
            this.SobaId.Name = "SobaId";
            this.SobaId.ReadOnly = true;
            this.SobaId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // BrojMalihKreveta
            // 
            this.BrojMalihKreveta.DataPropertyName = "BrojMalihKreveta";
            this.BrojMalihKreveta.HeaderText = "Broj malih kreveta";
            this.BrojMalihKreveta.Name = "BrojMalihKreveta";
            this.BrojMalihKreveta.ReadOnly = true;
            // 
            // BrojVelikihKreveta
            // 
            this.BrojVelikihKreveta.DataPropertyName = "BrojVelikihKreveta";
            this.BrojVelikihKreveta.HeaderText = "Broj velikih kreveta";
            this.BrojVelikihKreveta.Name = "BrojVelikihKreveta";
            this.BrojVelikihKreveta.ReadOnly = true;
            // 
            // VelicinaSobe
            // 
            this.VelicinaSobe.DataPropertyName = "VelicinaSobeText";
            this.VelicinaSobe.HeaderText = "Velicina sobe";
            this.VelicinaSobe.Name = "VelicinaSobe";
            this.VelicinaSobe.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "CijenaText";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 47);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adresa:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAdresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdresa.ForeColor = System.Drawing.Color.DimGray;
            this.txtAdresa.Location = new System.Drawing.Point(354, 47);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(223, 13);
            this.txtAdresa.TabIndex = 9;
            this.txtAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresa_Validating);
            // 
            // btnSpremi
            // 
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremi.Location = new System.Drawing.Point(492, 170);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 10;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnDodajSobu
            // 
            this.btnDodajSobu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajSobu.Location = new System.Drawing.Point(502, 462);
            this.btnDodajSobu.Name = "btnDodajSobu";
            this.btnDodajSobu.Size = new System.Drawing.Size(75, 23);
            this.btnDodajSobu.TabIndex = 14;
            this.btnDodajSobu.Text = "Dodaj sobu";
            this.btnDodajSobu.UseVisualStyleBackColor = true;
            this.btnDodajSobu.Click += new System.EventHandler(this.btnDodajSobu_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnUrediGaleriju
            // 
            this.btnUrediGaleriju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrediGaleriju.Location = new System.Drawing.Point(372, 170);
            this.btnUrediGaleriju.Name = "btnUrediGaleriju";
            this.btnUrediGaleriju.Size = new System.Drawing.Size(114, 23);
            this.btnUrediGaleriju.TabIndex = 15;
            this.btnUrediGaleriju.Text = "Uredite galeriju";
            this.btnUrediGaleriju.UseVisualStyleBackColor = true;
            this.btnUrediGaleriju.Click += new System.EventHandler(this.btnUrediGaleriju_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Opis smještaja:";
            // 
            // txtOpis
            // 
            this.txtOpis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOpis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpis.ForeColor = System.Drawing.Color.DimGray;
            this.txtOpis.Location = new System.Drawing.Point(354, 82);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(223, 62);
            this.txtOpis.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(601, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tip destinacije:";
            // 
            // clbTipDestinacije
            // 
            this.clbTipDestinacije.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clbTipDestinacije.ForeColor = System.Drawing.Color.DimGray;
            this.clbTipDestinacije.FormattingEnabled = true;
            this.clbTipDestinacije.Location = new System.Drawing.Point(685, 47);
            this.clbTipDestinacije.Name = "clbTipDestinacije";
            this.clbTipDestinacije.Size = new System.Drawing.Size(120, 139);
            this.clbTipDestinacije.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(354, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 1);
            this.panel1.TabIndex = 26;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.DimGray;
            this.close.Location = new System.Drawing.Point(829, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(16, 16);
            this.close.TabIndex = 28;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblNazivSmjestaja
            // 
            this.lblNazivSmjestaja.AutoSize = true;
            this.lblNazivSmjestaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivSmjestaja.Location = new System.Drawing.Point(12, 9);
            this.lblNazivSmjestaja.Name = "lblNazivSmjestaja";
            this.lblNazivSmjestaja.Size = new System.Drawing.Size(20, 24);
            this.lblNazivSmjestaja.TabIndex = 29;
            this.lblNazivSmjestaja.Text = "_";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(174, 128);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(0, 13);
            this.lblLongitude.TabIndex = 39;
            // 
            // txtOdaberiLokaciju
            // 
            this.txtOdaberiLokaciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtOdaberiLokaciju.Location = new System.Drawing.Point(115, 152);
            this.txtOdaberiLokaciju.Name = "txtOdaberiLokaciju";
            this.txtOdaberiLokaciju.Size = new System.Drawing.Size(131, 23);
            this.txtOdaberiLokaciju.TabIndex = 38;
            this.txtOdaberiLokaciju.Text = "Odaberi lokaciju";
            this.txtOdaberiLokaciju.UseVisualStyleBackColor = true;
            this.txtOdaberiLokaciju.Click += new System.EventHandler(this.txtOdaberiLokaciju_Click);
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(117, 128);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(0, 13);
            this.lblLatitude.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Lokacija:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Grad:";
            // 
            // frmSmjestajDetaljiSobe
            // 
            this.AcceptButton = this.btnSpremi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(845, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.txtOdaberiLokaciju);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblNazivSmjestaja);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.clbTipDestinacije);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUrediGaleriju);
            this.Controls.Add(this.btnDodajSobu);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvSobe);
            this.Controls.Add(this.cmbLokacije);
            this.Controls.Add(this.cmbTipSmjestaja);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmSmjestajDetaljiSobe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Detalji sobe";
            this.Load += new System.EventHandler(this.frmSmjestajDetaljiSobe_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmSmjestajDetaljiSobe_Paint);
            this.Resize += new System.EventHandler(this.frmSmjestajDetaljiSobe_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSobe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipSmjestaja;
        private System.Windows.Forms.ComboBox cmbLokacije;
        private System.Windows.Forms.DataGridView dgvSobe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnDodajSobu;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnUrediGaleriju;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox clbTipDestinacije;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label lblNazivSmjestaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn SobaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojMalihKreveta;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojVelikihKreveta;
        private System.Windows.Forms.DataGridViewTextBoxColumn VelicinaSobe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Button txtOdaberiLokaciju;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
    }
}