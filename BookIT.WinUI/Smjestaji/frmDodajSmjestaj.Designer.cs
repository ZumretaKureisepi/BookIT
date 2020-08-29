namespace BookIT.WinUI.Smjestaji
{
    partial class frmDodajSmjestaj
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
            this.lblImeSmjestaj = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImeSmjestaja = new System.Windows.Forms.TextBox();
            this.cmbTipSmjestaja = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLokacije = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.close = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDodaj = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImeSmjestaj
            // 
            this.lblImeSmjestaj.AutoSize = true;
            this.lblImeSmjestaj.ForeColor = System.Drawing.Color.DimGray;
            this.lblImeSmjestaj.Location = new System.Drawing.Point(64, 71);
            this.lblImeSmjestaj.Name = "lblImeSmjestaj";
            this.lblImeSmjestaj.Size = new System.Drawing.Size(73, 13);
            this.lblImeSmjestaj.TabIndex = 0;
            this.lblImeSmjestaj.Text = "Ime smještaja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(66, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip smještaja:";
            // 
            // txtImeSmjestaja
            // 
            this.txtImeSmjestaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.txtImeSmjestaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImeSmjestaja.ForeColor = System.Drawing.Color.Aquamarine;
            this.txtImeSmjestaja.Location = new System.Drawing.Point(195, 71);
            this.txtImeSmjestaja.Name = "txtImeSmjestaja";
            this.txtImeSmjestaja.Size = new System.Drawing.Size(183, 13);
            this.txtImeSmjestaja.TabIndex = 2;
            this.txtImeSmjestaja.Validating += new System.ComponentModel.CancelEventHandler(this.txtImeSmjestaja_Validating);
            // 
            // cmbTipSmjestaja
            // 
            this.cmbTipSmjestaja.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbTipSmjestaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipSmjestaja.ForeColor = System.Drawing.Color.Aquamarine;
            this.cmbTipSmjestaja.FormattingEnabled = true;
            this.cmbTipSmjestaja.Location = new System.Drawing.Point(195, 199);
            this.cmbTipSmjestaja.Name = "cmbTipSmjestaja";
            this.cmbTipSmjestaja.Size = new System.Drawing.Size(183, 21);
            this.cmbTipSmjestaja.TabIndex = 4;
            this.cmbTipSmjestaja.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbLokacije_KeyDown);
            this.cmbTipSmjestaja.Validating += new System.ComponentModel.CancelEventHandler(this.cmbTipSmjestaja_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(69, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lokacija:";
            // 
            // cmbLokacije
            // 
            this.cmbLokacije.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbLokacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLokacije.ForeColor = System.Drawing.Color.Aquamarine;
            this.cmbLokacije.FormattingEnabled = true;
            this.cmbLokacije.Location = new System.Drawing.Point(195, 140);
            this.cmbLokacije.Name = "cmbLokacije";
            this.cmbLokacije.Size = new System.Drawing.Size(183, 21);
            this.cmbLokacije.TabIndex = 3;
            this.cmbLokacije.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbLokacije_KeyDown);
            this.cmbLokacije.Validating += new System.ComponentModel.CancelEventHandler(this.cmbLokacije_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.DimGray;
            this.close.Location = new System.Drawing.Point(420, 5);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(16, 16);
            this.close.TabIndex = 14;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.ForeColor = System.Drawing.Color.Aquamarine;
            this.panel1.Location = new System.Drawing.Point(195, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 1);
            this.panel1.TabIndex = 28;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.DimGray;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(241, 239);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(137, 23);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackColor = System.Drawing.Color.Wheat;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(168, 294);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(69, 36);
            this.materialButton1.TabIndex = 30;
            this.materialButton1.Text = "Dodaj";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            // 
            // frmDodajSmjestaj
            // 
            this.AcceptButton = this.btnDodaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(440, 331);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.cmbLokacije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbTipSmjestaja);
            this.Controls.Add(this.txtImeSmjestaja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblImeSmjestaj);
            this.ForeColor = System.Drawing.Color.Aquamarine;
            this.MaximizeBox = false;
            this.Name = "frmDodajSmjestaj";
            this.Text = "Dodavanje smještaja";
            this.Load += new System.EventHandler(this.frmDodajSmjestaj_Load);
            this.Resize += new System.EventHandler(this.frmDodajSmjestaj_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImeSmjestaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImeSmjestaja;
        private System.Windows.Forms.ComboBox cmbTipSmjestaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLokacije;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnDodaj;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}