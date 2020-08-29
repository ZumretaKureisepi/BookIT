namespace BookIT.WinUI.Smjestaji
{
    partial class frmUrediSobu
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNazivSobe = new System.Windows.Forms.TextBox();
            this.txtBrojMalihKreveta = new System.Windows.Forms.TextBox();
            this.txtBrojVelikihKreveta = new System.Windows.Forms.TextBox();
            this.txtVelicinaSobe = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtCijenaDodatneUsluge = new System.Windows.Forms.TextBox();
            this.cmbDodatneUsluge = new System.Windows.Forms.ComboBox();
            this.dgvDodatneUsluge = new System.Windows.Forms.DataGridView();
            this.DodatnaUslugaSmjestajId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DodatnaUsluga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DodatnaUslugaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnUrediGaleriju = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDodatneUsluge)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv sobe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Aquamarine;
            this.label2.Location = new System.Drawing.Point(35, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broj malih kreveta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Aquamarine;
            this.label3.Location = new System.Drawing.Point(35, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj velikih kreveta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Aquamarine;
            this.label4.Location = new System.Drawing.Point(35, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Veličina sobe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Aquamarine;
            this.label5.Location = new System.Drawing.Point(35, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cijena:";
            // 
            // txtNazivSobe
            // 
            this.txtNazivSobe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.txtNazivSobe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNazivSobe.ForeColor = System.Drawing.Color.Aquamarine;
            this.txtNazivSobe.Location = new System.Drawing.Point(182, 41);
            this.txtNazivSobe.Name = "txtNazivSobe";
            this.txtNazivSobe.Size = new System.Drawing.Size(145, 13);
            this.txtNazivSobe.TabIndex = 5;
            this.txtNazivSobe.Validating += new System.ComponentModel.CancelEventHandler(this.txtNazivSobe_Validating);
            // 
            // txtBrojMalihKreveta
            // 
            this.txtBrojMalihKreveta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.txtBrojMalihKreveta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBrojMalihKreveta.ForeColor = System.Drawing.Color.Aquamarine;
            this.txtBrojMalihKreveta.Location = new System.Drawing.Point(182, 80);
            this.txtBrojMalihKreveta.Name = "txtBrojMalihKreveta";
            this.txtBrojMalihKreveta.Size = new System.Drawing.Size(145, 13);
            this.txtBrojMalihKreveta.TabIndex = 6;
            this.txtBrojMalihKreveta.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojMalihKreveta_Validating);
            // 
            // txtBrojVelikihKreveta
            // 
            this.txtBrojVelikihKreveta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.txtBrojVelikihKreveta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBrojVelikihKreveta.ForeColor = System.Drawing.Color.Aquamarine;
            this.txtBrojVelikihKreveta.Location = new System.Drawing.Point(182, 125);
            this.txtBrojVelikihKreveta.Name = "txtBrojVelikihKreveta";
            this.txtBrojVelikihKreveta.Size = new System.Drawing.Size(145, 13);
            this.txtBrojVelikihKreveta.TabIndex = 7;
            this.txtBrojVelikihKreveta.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojVelikihKreveta_Validating);
            // 
            // txtVelicinaSobe
            // 
            this.txtVelicinaSobe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.txtVelicinaSobe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVelicinaSobe.ForeColor = System.Drawing.Color.Aquamarine;
            this.txtVelicinaSobe.Location = new System.Drawing.Point(182, 167);
            this.txtVelicinaSobe.Name = "txtVelicinaSobe";
            this.txtVelicinaSobe.Size = new System.Drawing.Size(29, 13);
            this.txtVelicinaSobe.TabIndex = 8;
            this.txtVelicinaSobe.Validating += new System.ComponentModel.CancelEventHandler(this.txtVelicinaSobe_Validating);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvaj.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSacuvaj.Location = new System.Drawing.Point(211, 240);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(120, 23);
            this.btnSacuvaj.TabIndex = 10;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtCijena
            // 
            this.txtCijena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.txtCijena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCijena.ForeColor = System.Drawing.Color.Aquamarine;
            this.txtCijena.Location = new System.Drawing.Point(182, 207);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(145, 13);
            this.txtCijena.TabIndex = 9;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Aquamarine;
            this.label6.Location = new System.Drawing.Point(23, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Unesite cijenu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Aquamarine;
            this.label7.Location = new System.Drawing.Point(23, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Odaberite uslugu:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Location = new System.Drawing.Point(199, 101);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 17;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtCijenaDodatneUsluge
            // 
            this.txtCijenaDodatneUsluge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.txtCijenaDodatneUsluge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCijenaDodatneUsluge.ForeColor = System.Drawing.Color.Aquamarine;
            this.txtCijenaDodatneUsluge.Location = new System.Drawing.Point(174, 66);
            this.txtCijenaDodatneUsluge.Name = "txtCijenaDodatneUsluge";
            this.txtCijenaDodatneUsluge.Size = new System.Drawing.Size(100, 13);
            this.txtCijenaDodatneUsluge.TabIndex = 16;
            this.txtCijenaDodatneUsluge.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijenaDodatneUsluge_Validating);
            // 
            // cmbDodatneUsluge
            // 
            this.cmbDodatneUsluge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.cmbDodatneUsluge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDodatneUsluge.ForeColor = System.Drawing.Color.Aquamarine;
            this.cmbDodatneUsluge.FormattingEnabled = true;
            this.cmbDodatneUsluge.Location = new System.Drawing.Point(174, 28);
            this.cmbDodatneUsluge.Name = "cmbDodatneUsluge";
            this.cmbDodatneUsluge.Size = new System.Drawing.Size(100, 21);
            this.cmbDodatneUsluge.TabIndex = 15;
            this.cmbDodatneUsluge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDodatneUsluge_KeyDown);
            this.cmbDodatneUsluge.Validating += new System.ComponentModel.CancelEventHandler(this.cmbDodatneUsluge_Validating);
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
            this.dgvDodatneUsluge.Location = new System.Drawing.Point(26, 146);
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
            this.dgvDodatneUsluge.Size = new System.Drawing.Size(257, 178);
            this.dgvDodatneUsluge.TabIndex = 14;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.txtCijenaDodatneUsluge);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dgvDodatneUsluge);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbDodatneUsluge);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.ForeColor = System.Drawing.Color.Aquamarine;
            this.groupBox1.Location = new System.Drawing.Point(12, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 353);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodatne usluge za sobu";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Aquamarine;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.ForeColor = System.Drawing.Color.Aquamarine;
            this.panel6.Location = new System.Drawing.Point(173, 78);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(101, 1);
            this.panel6.TabIndex = 24;
            // 
            // btnUrediGaleriju
            // 
            this.btnUrediGaleriju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrediGaleriju.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnUrediGaleriju.Location = new System.Drawing.Point(38, 240);
            this.btnUrediGaleriju.Name = "btnUrediGaleriju";
            this.btnUrediGaleriju.Size = new System.Drawing.Size(120, 23);
            this.btnUrediGaleriju.TabIndex = 21;
            this.btnUrediGaleriju.Text = "Uredi galeriju";
            this.btnUrediGaleriju.UseVisualStyleBackColor = true;
            this.btnUrediGaleriju.Click += new System.EventHandler(this.btnUrediGaleriju_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.ForeColor = System.Drawing.Color.Aquamarine;
            this.panel1.Location = new System.Drawing.Point(181, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 1);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aquamarine;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.ForeColor = System.Drawing.Color.Aquamarine;
            this.panel2.Location = new System.Drawing.Point(181, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 1);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Aquamarine;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.ForeColor = System.Drawing.Color.Aquamarine;
            this.panel3.Location = new System.Drawing.Point(181, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(146, 1);
            this.panel3.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Aquamarine;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.ForeColor = System.Drawing.Color.Aquamarine;
            this.panel4.Location = new System.Drawing.Point(181, 179);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(146, 1);
            this.panel4.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Aquamarine;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.ForeColor = System.Drawing.Color.Aquamarine;
            this.panel5.Location = new System.Drawing.Point(181, 219);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(146, 1);
            this.panel5.TabIndex = 24;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.Aquamarine;
            this.close.Location = new System.Drawing.Point(340, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(16, 16);
            this.close.TabIndex = 25;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Aquamarine;
            this.label8.Location = new System.Drawing.Point(207, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "m²";
            // 
            // frmUrediSobu
            // 
            this.AcceptButton = this.btnSacuvaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(356, 638);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUrediGaleriju);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtVelicinaSobe);
            this.Controls.Add(this.txtBrojVelikihKreveta);
            this.Controls.Add(this.txtBrojMalihKreveta);
            this.Controls.Add(this.txtNazivSobe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Aquamarine;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmUrediSobu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Uredi sobu";
            this.Load += new System.EventHandler(this.frmUrediSobu_Load);
            this.Resize += new System.EventHandler(this.frmUrediSobu_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDodatneUsluge)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNazivSobe;
        private System.Windows.Forms.TextBox txtBrojMalihKreveta;
        private System.Windows.Forms.TextBox txtBrojVelikihKreveta;
        private System.Windows.Forms.TextBox txtVelicinaSobe;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCijenaDodatneUsluge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDodatneUsluge;
        private System.Windows.Forms.DataGridViewTextBoxColumn DodatnaUslugaSmjestajId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DodatnaUsluga;
        private System.Windows.Forms.DataGridViewTextBoxColumn DodatnaUslugaCijena;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDodatneUsluge;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUrediGaleriju;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label8;
    }
}