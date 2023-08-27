
namespace Damla
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.btnKullaniciSil = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnUrunFiyatGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnKullaniciEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKullaniciEkle.Location = new System.Drawing.Point(167, 28);
            this.btnKullaniciEkle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(170, 85);
            this.btnKullaniciEkle.TabIndex = 0;
            this.btnKullaniciEkle.Text = "Kullanıcı Ekleme";
            this.btnKullaniciEkle.UseVisualStyleBackColor = false;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnKullaniciSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKullaniciSil.Location = new System.Drawing.Point(167, 142);
            this.btnKullaniciSil.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(170, 85);
            this.btnKullaniciSil.TabIndex = 0;
            this.btnKullaniciSil.Text = "Kullanıcı Silme";
            this.btnKullaniciSil.UseVisualStyleBackColor = false;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.Location = new System.Drawing.Point(167, 363);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(170, 85);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnUrunFiyatGuncelle
            // 
            this.btnUrunFiyatGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUrunFiyatGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunFiyatGuncelle.Location = new System.Drawing.Point(167, 252);
            this.btnUrunFiyatGuncelle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUrunFiyatGuncelle.Name = "btnUrunFiyatGuncelle";
            this.btnUrunFiyatGuncelle.Size = new System.Drawing.Size(170, 85);
            this.btnUrunFiyatGuncelle.TabIndex = 0;
            this.btnUrunFiyatGuncelle.Text = "Ürün Fiyatı Güncelleme";
            this.btnUrunFiyatGuncelle.UseVisualStyleBackColor = false;
            this.btnUrunFiyatGuncelle.Click += new System.EventHandler(this.btnUrunFiyatGuncelle_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Damla.Properties.Resources._360_F_142712953_1XMycIzw6DswM6in91CnDYt3Ruk0c0QU;
            this.ClientSize = new System.Drawing.Size(519, 519);
            this.Controls.Add(this.btnUrunFiyatGuncelle);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKullaniciSil);
            this.Controls.Add(this.btnKullaniciEkle);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKullaniciEkle;
        private System.Windows.Forms.Button btnKullaniciSil;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnUrunFiyatGuncelle;
    }
}