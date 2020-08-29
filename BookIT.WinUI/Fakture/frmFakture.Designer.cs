namespace BookIT.WinUI.Fakture
{
    partial class frmFakture
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
            this.txtImeKlijenta = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvFakture = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FakturaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojFakture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezimeKlijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumFakture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFakture)).BeginInit();
            this.SuspendLayout();
            // 
            // txtImeKlijenta
            // 
            this.txtImeKlijenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.txtImeKlijenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImeKlijenta.Location = new System.Drawing.Point(199, 52);
            this.txtImeKlijenta.Name = "txtImeKlijenta";
            this.txtImeKlijenta.Size = new System.Drawing.Size(100, 13);
            this.txtImeKlijenta.TabIndex = 0;
            this.txtImeKlijenta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtImeKlijenta_KeyUp);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretrazi.Location = new System.Drawing.Point(349, 46);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 1;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // dgvFakture
            // 
            this.dgvFakture.AllowUserToAddRows = false;
            this.dgvFakture.AllowUserToDeleteRows = false;
            this.dgvFakture.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFakture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFakture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFakture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FakturaId,
            this.BrojFakture,
            this.ImePrezimeKlijent,
            this.DatumFakture,
            this.Iznos});
            this.dgvFakture.EnableHeadersVisualStyles = false;
            this.dgvFakture.Location = new System.Drawing.Point(12, 112);
            this.dgvFakture.Name = "dgvFakture";
            this.dgvFakture.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFakture.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFakture.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.dgvFakture.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Aquamarine;
            this.dgvFakture.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.dgvFakture.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Aquamarine;
            this.dgvFakture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFakture.Size = new System.Drawing.Size(512, 336);
            this.dgvFakture.TabIndex = 2;
            this.dgvFakture.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFakture_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(30, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unesite ime i prezime korisnika:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.ForeColor = System.Drawing.Color.Aquamarine;
            this.panel1.Location = new System.Drawing.Point(199, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 1);
            this.panel1.TabIndex = 28;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.Aquamarine;
            this.close.Location = new System.Drawing.Point(520, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(16, 16);
            this.close.TabIndex = 29;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Pretraži fakture";
            // 
            // FakturaId
            // 
            this.FakturaId.DataPropertyName = "FakturaId";
            this.FakturaId.HeaderText = "FakturaId";
            this.FakturaId.Name = "FakturaId";
            this.FakturaId.ReadOnly = true;
            this.FakturaId.Visible = false;
            // 
            // BrojFakture
            // 
            this.BrojFakture.DataPropertyName = "BrojFakture";
            this.BrojFakture.HeaderText = "Broj fakture";
            this.BrojFakture.Name = "BrojFakture";
            this.BrojFakture.ReadOnly = true;
            // 
            // ImePrezimeKlijent
            // 
            this.ImePrezimeKlijent.DataPropertyName = "ImePrezimeKlijent";
            this.ImePrezimeKlijent.HeaderText = "Ime i prezime klijenta";
            this.ImePrezimeKlijent.Name = "ImePrezimeKlijent";
            this.ImePrezimeKlijent.ReadOnly = true;
            this.ImePrezimeKlijent.Width = 150;
            // 
            // DatumFakture
            // 
            this.DatumFakture.DataPropertyName = "DatumFakture";
            this.DatumFakture.HeaderText = "Datum fakture";
            this.DatumFakture.Name = "DatumFakture";
            this.DatumFakture.ReadOnly = true;
            // 
            // Iznos
            // 
            this.Iznos.DataPropertyName = "IznosStr";
            this.Iznos.HeaderText = "Iznos";
            this.Iznos.Name = "Iznos";
            this.Iznos.ReadOnly = true;
            // 
            // frmFakture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFakture);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtImeKlijenta);
            this.ForeColor = System.Drawing.Color.Aquamarine;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmFakture";
            this.Text = "Fakture";
            this.Load += new System.EventHandler(this.frmFakture_Load);
            this.Resize += new System.EventHandler(this.frmFakture_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFakture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImeKlijenta;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dgvFakture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FakturaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojFakture;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezimeKlijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumFakture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
    }
}