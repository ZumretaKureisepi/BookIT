namespace BookIT.WinUI.Smjestaji
{
    partial class frmDodajSobu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv sobe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broj malih kreveta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj velikih kreveta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Veličina sobe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cijena:";
            // 
            // txtNazivSobe
            // 
            this.txtNazivSobe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNazivSobe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNazivSobe.ForeColor = System.Drawing.Color.DimGray;
            this.txtNazivSobe.Location = new System.Drawing.Point(219, 39);
            this.txtNazivSobe.Name = "txtNazivSobe";
            this.txtNazivSobe.Size = new System.Drawing.Size(169, 13);
            this.txtNazivSobe.TabIndex = 5;
            this.txtNazivSobe.Validating += new System.ComponentModel.CancelEventHandler(this.txtNazivSobe_Validating);
            // 
            // txtBrojMalihKreveta
            // 
            this.txtBrojMalihKreveta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBrojMalihKreveta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBrojMalihKreveta.ForeColor = System.Drawing.Color.DimGray;
            this.txtBrojMalihKreveta.Location = new System.Drawing.Point(219, 80);
            this.txtBrojMalihKreveta.Name = "txtBrojMalihKreveta";
            this.txtBrojMalihKreveta.Size = new System.Drawing.Size(169, 13);
            this.txtBrojMalihKreveta.TabIndex = 6;
            this.txtBrojMalihKreveta.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojMalihKreveta_Validating);
            // 
            // txtBrojVelikihKreveta
            // 
            this.txtBrojVelikihKreveta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBrojVelikihKreveta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBrojVelikihKreveta.ForeColor = System.Drawing.Color.DimGray;
            this.txtBrojVelikihKreveta.Location = new System.Drawing.Point(219, 125);
            this.txtBrojVelikihKreveta.Name = "txtBrojVelikihKreveta";
            this.txtBrojVelikihKreveta.Size = new System.Drawing.Size(169, 13);
            this.txtBrojVelikihKreveta.TabIndex = 7;
            this.txtBrojVelikihKreveta.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojVelikihKreveta_Validating);
            // 
            // txtVelicinaSobe
            // 
            this.txtVelicinaSobe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtVelicinaSobe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVelicinaSobe.ForeColor = System.Drawing.Color.DimGray;
            this.txtVelicinaSobe.Location = new System.Drawing.Point(219, 167);
            this.txtVelicinaSobe.Name = "txtVelicinaSobe";
            this.txtVelicinaSobe.Size = new System.Drawing.Size(26, 13);
            this.txtVelicinaSobe.TabIndex = 8;
            this.txtVelicinaSobe.Validating += new System.ComponentModel.CancelEventHandler(this.txtVelicinaSobe_Validating);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvaj.Location = new System.Drawing.Point(313, 245);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 10;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtCijena
            // 
            this.txtCijena.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCijena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCijena.ForeColor = System.Drawing.Color.DimGray;
            this.txtCijena.Location = new System.Drawing.Point(219, 207);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(169, 13);
            this.txtCijena.TabIndex = 9;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(219, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 1);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.ForeColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(219, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 1);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.ForeColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(219, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 1);
            this.panel3.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.ForeColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(219, 179);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(169, 1);
            this.panel4.TabIndex = 30;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.ForeColor = System.Drawing.Color.DimGray;
            this.panel5.Location = new System.Drawing.Point(219, 219);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(169, 1);
            this.panel5.TabIndex = 31;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.DimGray;
            this.close.Location = new System.Drawing.Point(435, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(16, 16);
            this.close.TabIndex = 32;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(241, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "m²";
            // 
            // frmDodajSobu
            // 
            this.AcceptButton = this.btnSacuvaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(454, 313);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmDodajSobu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Dodavanje sobe";
            this.Load += new System.EventHandler(this.frmDodajSobu_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmDodajSobu_Paint);
            this.Resize += new System.EventHandler(this.frmDodajSobu_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label8;
    }
}