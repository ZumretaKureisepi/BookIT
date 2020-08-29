using System.Drawing;

namespace BookIT.WinUI
{
    partial class frmMain
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
            this.btnMojProfil = new System.Windows.Forms.Button();
            this.btnRezervacije = new System.Windows.Forms.Button();
            this.btnFakture = new System.Windows.Forms.Button();
            this.btnSmjestaj = new System.Windows.Forms.Button();
            this.btnSmjestajiDodaj = new System.Windows.Forms.Button();
            this.btnSmjestajiPretraga = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMojProfil
            // 
            this.btnMojProfil.AutoSize = true;
            this.btnMojProfil.BackColor = System.Drawing.Color.Transparent;
            this.btnMojProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMojProfil.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnMojProfil.FlatAppearance.BorderSize = 3;
            this.btnMojProfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMojProfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMojProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMojProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMojProfil.ForeColor = System.Drawing.Color.DimGray;
            this.btnMojProfil.Image = global::BookIT.WinUI.Properties.Resources.profil;
            this.btnMojProfil.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMojProfil.Location = new System.Drawing.Point(0, 50);
            this.btnMojProfil.Name = "btnMojProfil";
            this.btnMojProfil.Size = new System.Drawing.Size(110, 134);
            this.btnMojProfil.TabIndex = 1;
            this.btnMojProfil.TabStop = false;
            this.btnMojProfil.Text = "Moj profil";
            this.btnMojProfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMojProfil.UseVisualStyleBackColor = false;
            this.btnMojProfil.Click += new System.EventHandler(this.btnMojProfil_Click);
            this.btnMojProfil.MouseEnter += new System.EventHandler(this.btnMojProfil_MouseEnter);
            this.btnMojProfil.MouseLeave += new System.EventHandler(this.btnMojProfil_MouseLeave);
            // 
            // btnRezervacije
            // 
            this.btnRezervacije.BackColor = System.Drawing.Color.Transparent;
            this.btnRezervacije.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRezervacije.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnRezervacije.FlatAppearance.BorderSize = 3;
            this.btnRezervacije.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRezervacije.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRezervacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervacije.ForeColor = System.Drawing.Color.DimGray;
            this.btnRezervacije.Image = global::BookIT.WinUI.Properties.Resources.rezervacije;
            this.btnRezervacije.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRezervacije.Location = new System.Drawing.Point(0, 455);
            this.btnRezervacije.Name = "btnRezervacije";
            this.btnRezervacije.Size = new System.Drawing.Size(110, 134);
            this.btnRezervacije.TabIndex = 4;
            this.btnRezervacije.TabStop = false;
            this.btnRezervacije.Text = "Rezervacije";
            this.btnRezervacije.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRezervacije.UseVisualStyleBackColor = false;
            this.btnRezervacije.Click += new System.EventHandler(this.btnRezervacije_Click);
            this.btnRezervacije.MouseEnter += new System.EventHandler(this.btnRezervacije_MouseEnter);
            this.btnRezervacije.MouseLeave += new System.EventHandler(this.btnRezervacije_MouseLeave);
            // 
            // btnFakture
            // 
            this.btnFakture.BackColor = System.Drawing.Color.Transparent;
            this.btnFakture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFakture.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFakture.FlatAppearance.BorderSize = 3;
            this.btnFakture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFakture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFakture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFakture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFakture.ForeColor = System.Drawing.Color.DimGray;
            this.btnFakture.Image = global::BookIT.WinUI.Properties.Resources.faktura;
            this.btnFakture.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFakture.Location = new System.Drawing.Point(0, 320);
            this.btnFakture.Name = "btnFakture";
            this.btnFakture.Size = new System.Drawing.Size(110, 134);
            this.btnFakture.TabIndex = 3;
            this.btnFakture.TabStop = false;
            this.btnFakture.Text = "Fakture";
            this.btnFakture.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFakture.UseVisualStyleBackColor = false;
            this.btnFakture.Click += new System.EventHandler(this.btnFakture_Click);
            this.btnFakture.MouseEnter += new System.EventHandler(this.btnFakture_MouseEnter);
            this.btnFakture.MouseLeave += new System.EventHandler(this.btnFakture_MouseLeave);
            // 
            // btnSmjestaj
            // 
            this.btnSmjestaj.BackColor = System.Drawing.Color.Transparent;
            this.btnSmjestaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSmjestaj.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSmjestaj.FlatAppearance.BorderSize = 3;
            this.btnSmjestaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSmjestaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSmjestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmjestaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmjestaj.ForeColor = System.Drawing.Color.DimGray;
            this.btnSmjestaj.Image = global::BookIT.WinUI.Properties.Resources.smjestaj;
            this.btnSmjestaj.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSmjestaj.Location = new System.Drawing.Point(0, 185);
            this.btnSmjestaj.Name = "btnSmjestaj";
            this.btnSmjestaj.Size = new System.Drawing.Size(110, 134);
            this.btnSmjestaj.TabIndex = 2;
            this.btnSmjestaj.TabStop = false;
            this.btnSmjestaj.Text = "Smještaji";
            this.btnSmjestaj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSmjestaj.UseVisualStyleBackColor = false;
            this.btnSmjestaj.Click += new System.EventHandler(this.btnSmjestaj_Click);
            this.btnSmjestaj.MouseEnter += new System.EventHandler(this.btnSmjestaj_MouseEnter);
            this.btnSmjestaj.MouseLeave += new System.EventHandler(this.btnSmjestaj_MouseLeave);
            // 
            // btnSmjestajiDodaj
            // 
            this.btnSmjestajiDodaj.BackColor = System.Drawing.Color.Transparent;
            this.btnSmjestajiDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSmjestajiDodaj.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSmjestajiDodaj.FlatAppearance.BorderSize = 3;
            this.btnSmjestajiDodaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSmjestajiDodaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSmjestajiDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmjestajiDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmjestajiDodaj.ForeColor = System.Drawing.Color.DimGray;
            this.btnSmjestajiDodaj.Image = global::BookIT.WinUI.Properties.Resources.smjestaj_dodaj;
            this.btnSmjestajiDodaj.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSmjestajiDodaj.Location = new System.Drawing.Point(232, 185);
            this.btnSmjestajiDodaj.Name = "btnSmjestajiDodaj";
            this.btnSmjestajiDodaj.Size = new System.Drawing.Size(110, 134);
            this.btnSmjestajiDodaj.TabIndex = 16;
            this.btnSmjestajiDodaj.TabStop = false;
            this.btnSmjestajiDodaj.Text = "Dodaj";
            this.btnSmjestajiDodaj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSmjestajiDodaj.UseVisualStyleBackColor = false;
            this.btnSmjestajiDodaj.Visible = false;
            this.btnSmjestajiDodaj.Click += new System.EventHandler(this.btnSmjestajiDodaj_Click);
            this.btnSmjestajiDodaj.MouseEnter += new System.EventHandler(this.btnSmjestajiDodaj_MouseEnter);
            this.btnSmjestajiDodaj.MouseLeave += new System.EventHandler(this.btnSmjestajiDodaj_MouseLeave);
            // 
            // btnSmjestajiPretraga
            // 
            this.btnSmjestajiPretraga.BackColor = System.Drawing.Color.Transparent;
            this.btnSmjestajiPretraga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSmjestajiPretraga.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSmjestajiPretraga.FlatAppearance.BorderSize = 3;
            this.btnSmjestajiPretraga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSmjestajiPretraga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSmjestajiPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmjestajiPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmjestajiPretraga.ForeColor = System.Drawing.Color.DimGray;
            this.btnSmjestajiPretraga.Image = global::BookIT.WinUI.Properties.Resources.smjestaj_pretraga;
            this.btnSmjestajiPretraga.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSmjestajiPretraga.Location = new System.Drawing.Point(116, 185);
            this.btnSmjestajiPretraga.Name = "btnSmjestajiPretraga";
            this.btnSmjestajiPretraga.Size = new System.Drawing.Size(110, 134);
            this.btnSmjestajiPretraga.TabIndex = 17;
            this.btnSmjestajiPretraga.TabStop = false;
            this.btnSmjestajiPretraga.Text = "Pretraga";
            this.btnSmjestajiPretraga.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSmjestajiPretraga.UseVisualStyleBackColor = false;
            this.btnSmjestajiPretraga.Visible = false;
            this.btnSmjestajiPretraga.Click += new System.EventHandler(this.btnSmjestajiPretraga_Click);
            this.btnSmjestajiPretraga.MouseEnter += new System.EventHandler(this.btnSmjestajiPretraga_MouseEnter);
            this.btnSmjestajiPretraga.MouseLeave += new System.EventHandler(this.btnSmjestajiPretraga_MouseLeave);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnLogout.FlatAppearance.BorderSize = 3;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DimGray;
            this.btnLogout.Image = global::BookIT.WinUI.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLogout.Location = new System.Drawing.Point(521, 50);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(47, 47);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.TabStop = false;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(-2, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 3);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 45);
            this.label1.TabIndex = 20;
            this.label1.Text = "BookIT - Vlasnik smještaja";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.DimGray;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(544, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(16, 16);
            this.close.TabIndex = 22;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(566, 620);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSmjestajiPretraga);
            this.Controls.Add(this.btnSmjestajiDodaj);
            this.Controls.Add(this.btnRezervacije);
            this.Controls.Add(this.btnFakture);
            this.Controls.Add(this.btnSmjestaj);
            this.Controls.Add(this.btnMojProfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "BookIT - Vlasnik smještaja";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMojProfil;
        private System.Windows.Forms.Button btnRezervacije;
        private System.Windows.Forms.Button btnFakture;
        private System.Windows.Forms.Button btnSmjestaj;
        private System.Windows.Forms.Button btnSmjestajiDodaj;
        private System.Windows.Forms.Button btnSmjestajiPretraga;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label close;
    }
}

