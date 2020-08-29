using System.Drawing;

namespace BookIT.WinUI
{
    partial class frmMainAdmin
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
            this.close = new System.Windows.Forms.Label();
            this.btnLokacije = new System.Windows.Forms.Button();
            this.btnDodatneUsluge = new System.Windows.Forms.Button();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKorisniciDodaj = new System.Windows.Forms.Button();
            this.btnKorisniciPretraga = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnGradovi = new System.Windows.Forms.Button();
            this.btnDrzave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMojProfil
            // 
            this.btnMojProfil.AutoSize = true;
            this.btnMojProfil.BackColor = System.Drawing.Color.Transparent;
            this.btnMojProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMojProfil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.btnMojProfil.FlatAppearance.BorderSize = 3;
            this.btnMojProfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMojProfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.btnMojProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMojProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMojProfil.ForeColor = System.Drawing.Color.DimGray;
            this.btnMojProfil.Image = global::BookIT.WinUI.Properties.Resources.profil;
            this.btnMojProfil.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMojProfil.Location = new System.Drawing.Point(0, 34);
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
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.DimGray;
            this.close.Location = new System.Drawing.Point(543, 8);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(16, 16);
            this.close.TabIndex = 13;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // btnLokacije
            // 
            this.btnLokacije.BackColor = System.Drawing.Color.Transparent;
            this.btnLokacije.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLokacije.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.btnLokacije.FlatAppearance.BorderSize = 3;
            this.btnLokacije.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLokacije.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.btnLokacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLokacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLokacije.ForeColor = System.Drawing.Color.DimGray;
            this.btnLokacije.Image = global::BookIT.WinUI.Properties.Resources.lokacije;
            this.btnLokacije.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLokacije.Location = new System.Drawing.Point(0, 436);
            this.btnLokacije.Name = "btnLokacije";
            this.btnLokacije.Size = new System.Drawing.Size(110, 134);
            this.btnLokacije.TabIndex = 4;
            this.btnLokacije.TabStop = false;
            this.btnLokacije.Text = "Lokacije";
            this.btnLokacije.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLokacije.UseVisualStyleBackColor = false;
            this.btnLokacije.Click += new System.EventHandler(this.btnLokacije_Click);
            this.btnLokacije.MouseEnter += new System.EventHandler(this.btnLokacije_MouseEnter);
            // 
            // btnDodatneUsluge
            // 
            this.btnDodatneUsluge.BackColor = System.Drawing.Color.Transparent;
            this.btnDodatneUsluge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDodatneUsluge.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.btnDodatneUsluge.FlatAppearance.BorderSize = 3;
            this.btnDodatneUsluge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDodatneUsluge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.btnDodatneUsluge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodatneUsluge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnDodatneUsluge.ForeColor = System.Drawing.Color.DimGray;
            this.btnDodatneUsluge.Image = global::BookIT.WinUI.Properties.Resources.dodatne_usluge;
            this.btnDodatneUsluge.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDodatneUsluge.Location = new System.Drawing.Point(0, 302);
            this.btnDodatneUsluge.Name = "btnDodatneUsluge";
            this.btnDodatneUsluge.Size = new System.Drawing.Size(110, 134);
            this.btnDodatneUsluge.TabIndex = 3;
            this.btnDodatneUsluge.TabStop = false;
            this.btnDodatneUsluge.Text = "Dod. usluge";
            this.btnDodatneUsluge.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDodatneUsluge.UseVisualStyleBackColor = false;
            this.btnDodatneUsluge.Click += new System.EventHandler(this.btnDodatneUsluge_Click);
            this.btnDodatneUsluge.MouseEnter += new System.EventHandler(this.btnDodatneUsluge_MouseEnter);
            this.btnDodatneUsluge.MouseLeave += new System.EventHandler(this.btnFakture_MouseLeave);
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.BackColor = System.Drawing.Color.Transparent;
            this.btnKorisnici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKorisnici.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.btnKorisnici.FlatAppearance.BorderSize = 3;
            this.btnKorisnici.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnKorisnici.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.btnKorisnici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKorisnici.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKorisnici.ForeColor = System.Drawing.Color.DimGray;
            this.btnKorisnici.Image = global::BookIT.WinUI.Properties.Resources.korisnici;
            this.btnKorisnici.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnKorisnici.Location = new System.Drawing.Point(0, 168);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(110, 134);
            this.btnKorisnici.TabIndex = 2;
            this.btnKorisnici.TabStop = false;
            this.btnKorisnici.Text = "Korisnici";
            this.btnKorisnici.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKorisnici.UseVisualStyleBackColor = false;
            this.btnKorisnici.Click += new System.EventHandler(this.btnKorisnici_Click);
            this.btnKorisnici.MouseEnter += new System.EventHandler(this.btnKorisnici_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(186, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "BookIT - Administrator";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 1);
            this.panel1.TabIndex = 15;
            // 
            // btnKorisniciDodaj
            // 
            this.btnKorisniciDodaj.BackColor = System.Drawing.Color.Transparent;
            this.btnKorisniciDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKorisniciDodaj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.btnKorisniciDodaj.FlatAppearance.BorderSize = 3;
            this.btnKorisniciDodaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnKorisniciDodaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.btnKorisniciDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKorisniciDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKorisniciDodaj.ForeColor = System.Drawing.Color.DimGray;
            this.btnKorisniciDodaj.Image = global::BookIT.WinUI.Properties.Resources.korisnici_dodaj;
            this.btnKorisniciDodaj.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnKorisniciDodaj.Location = new System.Drawing.Point(232, 168);
            this.btnKorisniciDodaj.Name = "btnKorisniciDodaj";
            this.btnKorisniciDodaj.Size = new System.Drawing.Size(110, 134);
            this.btnKorisniciDodaj.TabIndex = 16;
            this.btnKorisniciDodaj.TabStop = false;
            this.btnKorisniciDodaj.Text = "Dodaj";
            this.btnKorisniciDodaj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKorisniciDodaj.UseVisualStyleBackColor = false;
            this.btnKorisniciDodaj.Visible = false;
            this.btnKorisniciDodaj.Click += new System.EventHandler(this.btnKorisniciDodaj_Click);
            this.btnKorisniciDodaj.MouseEnter += new System.EventHandler(this.btnKorisniciDodaj_MouseEnter);
            this.btnKorisniciDodaj.MouseLeave += new System.EventHandler(this.btnKorisniciDodaj_MouseLeave);
            // 
            // btnKorisniciPretraga
            // 
            this.btnKorisniciPretraga.BackColor = System.Drawing.Color.Transparent;
            this.btnKorisniciPretraga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKorisniciPretraga.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.btnKorisniciPretraga.FlatAppearance.BorderSize = 3;
            this.btnKorisniciPretraga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnKorisniciPretraga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.btnKorisniciPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKorisniciPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKorisniciPretraga.ForeColor = System.Drawing.Color.DimGray;
            this.btnKorisniciPretraga.Image = global::BookIT.WinUI.Properties.Resources.korisnici_pretraga;
            this.btnKorisniciPretraga.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnKorisniciPretraga.Location = new System.Drawing.Point(116, 168);
            this.btnKorisniciPretraga.Name = "btnKorisniciPretraga";
            this.btnKorisniciPretraga.Size = new System.Drawing.Size(110, 134);
            this.btnKorisniciPretraga.TabIndex = 17;
            this.btnKorisniciPretraga.TabStop = false;
            this.btnKorisniciPretraga.Text = "Pretraga";
            this.btnKorisniciPretraga.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKorisniciPretraga.UseVisualStyleBackColor = false;
            this.btnKorisniciPretraga.Visible = false;
            this.btnKorisniciPretraga.Click += new System.EventHandler(this.btnKorisniciPretraga_Click);
            this.btnKorisniciPretraga.MouseEnter += new System.EventHandler(this.btnKorisniciPretraga_MouseEnter);
            this.btnKorisniciPretraga.MouseLeave += new System.EventHandler(this.btnKorisniciPretraga_MouseLeave);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.btnLogout.FlatAppearance.BorderSize = 3;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DimGray;
            this.btnLogout.Image = global::BookIT.WinUI.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLogout.Location = new System.Drawing.Point(520, 32);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(47, 47);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.TabStop = false;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            // 
            // btnGradovi
            // 
            this.btnGradovi.BackColor = System.Drawing.Color.Transparent;
            this.btnGradovi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGradovi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.btnGradovi.FlatAppearance.BorderSize = 3;
            this.btnGradovi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGradovi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.btnGradovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGradovi.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradovi.ForeColor = System.Drawing.Color.DimGray;
            this.btnGradovi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGradovi.Location = new System.Drawing.Point(232, 436);
            this.btnGradovi.Name = "btnGradovi";
            this.btnGradovi.Size = new System.Drawing.Size(110, 134);
            this.btnGradovi.TabIndex = 19;
            this.btnGradovi.TabStop = false;
            this.btnGradovi.Text = "Gradovi";
            this.btnGradovi.UseVisualStyleBackColor = false;
            this.btnGradovi.Visible = false;
            this.btnGradovi.Click += new System.EventHandler(this.btnGradovi_Click);
            // 
            // btnDrzave
            // 
            this.btnDrzave.BackColor = System.Drawing.Color.Transparent;
            this.btnDrzave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDrzave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.btnDrzave.FlatAppearance.BorderSize = 3;
            this.btnDrzave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDrzave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.btnDrzave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrzave.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrzave.ForeColor = System.Drawing.Color.DimGray;
            this.btnDrzave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDrzave.Location = new System.Drawing.Point(116, 436);
            this.btnDrzave.Name = "btnDrzave";
            this.btnDrzave.Size = new System.Drawing.Size(110, 134);
            this.btnDrzave.TabIndex = 20;
            this.btnDrzave.TabStop = false;
            this.btnDrzave.Text = "Države";
            this.btnDrzave.UseVisualStyleBackColor = false;
            this.btnDrzave.Visible = false;
            this.btnDrzave.Click += new System.EventHandler(this.btnDrzave_Click);
            // 
            // frmMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(566, 575);
            this.Controls.Add(this.btnDrzave);
            this.Controls.Add(this.btnGradovi);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnKorisniciPretraga);
            this.Controls.Add(this.btnKorisniciDodaj);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.btnLokacije);
            this.Controls.Add(this.btnDodatneUsluge);
            this.Controls.Add(this.btnKorisnici);
            this.Controls.Add(this.btnMojProfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainAdmin";
            this.Text = "BookIT";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMojProfil;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Button btnLokacije;
        private System.Windows.Forms.Button btnDodatneUsluge;
        private System.Windows.Forms.Button btnKorisnici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKorisniciDodaj;
        private System.Windows.Forms.Button btnKorisniciPretraga;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnGradovi;
        private System.Windows.Forms.Button btnDrzave;
    }
}

