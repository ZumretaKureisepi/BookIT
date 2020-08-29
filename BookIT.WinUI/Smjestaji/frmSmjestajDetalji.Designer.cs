namespace BookIT.WinUI.Smjestaji
{
    partial class frmSmjestajDetalji
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipSmjestaja = new System.Windows.Forms.ComboBox();
            this.cmbLokacije = new System.Windows.Forms.ComboBox();
            this.dgvDodatneUsluge = new System.Windows.Forms.DataGridView();
            this.DodatnaUslugaSmjestajId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DodatnaUsluga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DodatnaUslugaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbDodatneUsluge = new System.Windows.Forms.ComboBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUrediGaleriju = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCijenaSmjestaja = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.clbTipDestinacije = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Label();
            this.lblNazivSmjestaja = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.txtOdaberiLokaciju = new System.Windows.Forms.Button();
            this.lblLongitude = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDodatneUsluge)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grad:";
            // 
            // cmbTipSmjestaja
            // 
            this.cmbTipSmjestaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.cmbTipSmjestaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipSmjestaja.ForeColor = System.Drawing.Color.Aquamarine;
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
            this.cmbLokacije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.cmbLokacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLokacije.ForeColor = System.Drawing.Color.Aquamarine;
            this.cmbLokacije.FormattingEnabled = true;
            this.cmbLokacije.Location = new System.Drawing.Point(115, 86);
            this.cmbLokacije.Name = "cmbLokacije";
            this.cmbLokacije.Size = new System.Drawing.Size(121, 21);
            this.cmbLokacije.TabIndex = 3;
            this.cmbLokacije.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbLokacije_KeyDown);
            this.cmbLokacije.Validating += new System.ComponentModel.CancelEventHandler(this.cmbLokacije_Validating);
            // 
            // dgvDodatneUsluge
            // 
            this.dgvDodatneUsluge.AllowUserToAddRows = false;
            this.dgvDodatneUsluge.AllowUserToDeleteRows = false;
            this.dgvDodatneUsluge.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDodatneUsluge.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDodatneUsluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDodatneUsluge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DodatnaUslugaSmjestajId,
            this.DodatnaUsluga,
            this.DodatnaUslugaCijena});
            this.dgvDodatneUsluge.EnableHeadersVisualStyles = false;
            this.dgvDodatneUsluge.Location = new System.Drawing.Point(32, 263);
            this.dgvDodatneUsluge.Name = "dgvDodatneUsluge";
            this.dgvDodatneUsluge.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDodatneUsluge.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDodatneUsluge.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.dgvDodatneUsluge.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Aquamarine;
            this.dgvDodatneUsluge.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.dgvDodatneUsluge.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Aquamarine;
            this.dgvDodatneUsluge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDodatneUsluge.Size = new System.Drawing.Size(545, 150);
            this.dgvDodatneUsluge.TabIndex = 5;
            // 
            // DodatnaUslugaSmjestajId
            // 
            this.DodatnaUslugaSmjestajId.DataPropertyName = "DodatnaUslugaSmjestajId";
            this.DodatnaUslugaSmjestajId.HeaderText = "DodatnaUslugaSmjestajId";
            this.DodatnaUslugaSmjestajId.Name = "DodatnaUslugaSmjestajId";
            this.DodatnaUslugaSmjestajId.ReadOnly = true;
            this.DodatnaUslugaSmjestajId.Visible = false;
            // 
            // DodatnaUsluga
            // 
            this.DodatnaUsluga.DataPropertyName = "DodatnaUsluga";
            this.DodatnaUsluga.HeaderText = "Naziv usluga";
            this.DodatnaUsluga.Name = "DodatnaUsluga";
            this.DodatnaUsluga.ReadOnly = true;
            // 
            // DodatnaUslugaCijena
            // 
            this.DodatnaUslugaCijena.DataPropertyName = "Cijena";
            this.DodatnaUslugaCijena.HeaderText = "Cijena";
            this.DodatnaUslugaCijena.Name = "DodatnaUslugaCijena";
            this.DodatnaUslugaCijena.ReadOnly = true;
            // 
            // cmbDodatneUsluge
            // 
            this.cmbDodatneUsluge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.cmbDodatneUsluge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDodatneUsluge.ForeColor = System.Drawing.Color.Aquamarine;
            this.cmbDodatneUsluge.FormattingEnabled = true;
            this.cmbDodatneUsluge.Location = new System.Drawing.Point(125, 236);
            this.cmbDodatneUsluge.Name = "cmbDodatneUsluge";
            this.cmbDodatneUsluge.Size = new System.Drawing.Size(121, 21);
            this.cmbDodatneUsluge.TabIndex = 6;
            this.cmbDodatneUsluge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbLokacije_KeyDown);
            this.cmbDodatneUsluge.Validating += new System.ComponentModel.CancelEventHandler(this.cmbDodatneUsluge_Validating);
            // 
            // txtCijena
            // 
            this.txtCijena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.txtCijena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCijena.ForeColor = System.Drawing.Color.Aquamarine;
            this.txtCijena.Location = new System.Drawing.Point(387, 236);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(100, 13);
            this.txtCijena.TabIndex = 7;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
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
            this.txtAdresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.txtAdresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdresa.ForeColor = System.Drawing.Color.Aquamarine;
            this.txtAdresa.Location = new System.Drawing.Point(354, 45);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(223, 13);
            this.txtAdresa.TabIndex = 9;
            this.txtAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresa_Validating);
            // 
            // btnSpremi
            // 
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremi.Location = new System.Drawing.Point(502, 175);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 10;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Location = new System.Drawing.Point(502, 233);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Odaberite uslugu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Unesite cijenu:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnUrediGaleriju
            // 
            this.btnUrediGaleriju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrediGaleriju.Location = new System.Drawing.Point(382, 175);
            this.btnUrediGaleriju.Name = "btnUrediGaleriju";
            this.btnUrediGaleriju.Size = new System.Drawing.Size(114, 23);
            this.btnUrediGaleriju.TabIndex = 14;
            this.btnUrediGaleriju.Text = "Uredite galeriju";
            this.btnUrediGaleriju.UseVisualStyleBackColor = true;
            this.btnUrediGaleriju.Click += new System.EventHandler(this.btnUrediGaleriju_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cijena smještaja:";
            // 
            // txtCijenaSmjestaja
            // 
            this.txtCijenaSmjestaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.txtCijenaSmjestaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCijenaSmjestaja.ForeColor = System.Drawing.Color.Aquamarine;
            this.txtCijenaSmjestaja.Location = new System.Drawing.Point(116, 184);
            this.txtCijenaSmjestaja.Name = "txtCijenaSmjestaja";
            this.txtCijenaSmjestaja.Size = new System.Drawing.Size(117, 13);
            this.txtCijenaSmjestaja.TabIndex = 16;
            // 
            // txtOpis
            // 
            this.txtOpis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.txtOpis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpis.ForeColor = System.Drawing.Color.Aquamarine;
            this.txtOpis.Location = new System.Drawing.Point(354, 89);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(223, 62);
            this.txtOpis.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Opis smještaja:";
            // 
            // clbTipDestinacije
            // 
            this.clbTipDestinacije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.clbTipDestinacije.ForeColor = System.Drawing.Color.Aquamarine;
            this.clbTipDestinacije.FormattingEnabled = true;
            this.clbTipDestinacije.Location = new System.Drawing.Point(676, 47);
            this.clbTipDestinacije.Name = "clbTipDestinacije";
            this.clbTipDestinacije.Size = new System.Drawing.Size(120, 139);
            this.clbTipDestinacije.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(592, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tip destinacije:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.ForeColor = System.Drawing.Color.Aquamarine;
            this.panel1.Location = new System.Drawing.Point(354, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 1);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aquamarine;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.ForeColor = System.Drawing.Color.Aquamarine;
            this.panel2.Location = new System.Drawing.Point(116, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 1);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Aquamarine;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.ForeColor = System.Drawing.Color.Aquamarine;
            this.panel3.Location = new System.Drawing.Point(387, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 1);
            this.panel3.TabIndex = 29;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.Aquamarine;
            this.close.Location = new System.Drawing.Point(802, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(16, 16);
            this.close.TabIndex = 30;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // lblNazivSmjestaja
            // 
            this.lblNazivSmjestaja.AutoSize = true;
            this.lblNazivSmjestaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivSmjestaja.Location = new System.Drawing.Point(12, 9);
            this.lblNazivSmjestaja.Name = "lblNazivSmjestaja";
            this.lblNazivSmjestaja.Size = new System.Drawing.Size(20, 24);
            this.lblNazivSmjestaja.TabIndex = 31;
            this.lblNazivSmjestaja.Text = "_";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Lokacija:";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(117, 128);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(0, 13);
            this.lblLatitude.TabIndex = 33;
            // 
            // txtOdaberiLokaciju
            // 
            this.txtOdaberiLokaciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtOdaberiLokaciju.Location = new System.Drawing.Point(115, 152);
            this.txtOdaberiLokaciju.Name = "txtOdaberiLokaciju";
            this.txtOdaberiLokaciju.Size = new System.Drawing.Size(131, 23);
            this.txtOdaberiLokaciju.TabIndex = 34;
            this.txtOdaberiLokaciju.Text = "Odaberi lokaciju";
            this.txtOdaberiLokaciju.UseVisualStyleBackColor = true;
            this.txtOdaberiLokaciju.Click += new System.EventHandler(this.txtOdaberiLokaciju_Click);
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(174, 128);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(0, 13);
            this.lblLongitude.TabIndex = 35;
            // 
            // frmSmjestajDetalji
            // 
            this.AcceptButton = this.btnSpremi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(819, 423);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.txtOdaberiLokaciju);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblNazivSmjestaja);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.clbTipDestinacije);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCijenaSmjestaja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUrediGaleriju);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.cmbDodatneUsluge);
            this.Controls.Add(this.dgvDodatneUsluge);
            this.Controls.Add(this.cmbLokacije);
            this.Controls.Add(this.cmbTipSmjestaja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Aquamarine;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmSmjestajDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Detalji smještaja";
            this.Load += new System.EventHandler(this.frmSmjestajDetalji_Load);
            this.Resize += new System.EventHandler(this.frmSmjestajDetalji_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDodatneUsluge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipSmjestaja;
        private System.Windows.Forms.ComboBox cmbLokacije;
        private System.Windows.Forms.DataGridView dgvDodatneUsluge;
        private System.Windows.Forms.ComboBox cmbDodatneUsluge;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn DodatnaUslugaSmjestajId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DodatnaUsluga;
        private System.Windows.Forms.DataGridViewTextBoxColumn DodatnaUslugaCijena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnUrediGaleriju;
        private System.Windows.Forms.TextBox txtCijenaSmjestaja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox clbTipDestinacije;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label lblNazivSmjestaja;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button txtOdaberiLokaciju;
        private System.Windows.Forms.Label lblLongitude;
    }
}