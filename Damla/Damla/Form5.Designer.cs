
namespace Damla
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.lblUrunFiyatiGuncelle = new System.Windows.Forms.Label();
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblGuncellenecekFiyat = new System.Windows.Forms.Label();
            this.lblGuncelFiyat = new System.Windows.Forms.Label();
            this.txtGuncelFiyat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUrunFiyatiGuncelle
            // 
            this.lblUrunFiyatiGuncelle.AutoSize = true;
            this.lblUrunFiyatiGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.lblUrunFiyatiGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrunFiyatiGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblUrunFiyatiGuncelle.Location = new System.Drawing.Point(23, 62);
            this.lblUrunFiyatiGuncelle.Name = "lblUrunFiyatiGuncelle";
            this.lblUrunFiyatiGuncelle.Size = new System.Drawing.Size(249, 29);
            this.lblUrunFiyatiGuncelle.TabIndex = 8;
            this.lblUrunFiyatiGuncelle.Text = "Ürün Fiyatı Güncelle";
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(211, 108);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(141, 21);
            this.cmbUrunler.TabIndex = 6;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuncelle.Location = new System.Drawing.Point(127, 206);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(121, 40);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lblGuncellenecekFiyat
            // 
            this.lblGuncellenecekFiyat.AutoSize = true;
            this.lblGuncellenecekFiyat.BackColor = System.Drawing.Color.Transparent;
            this.lblGuncellenecekFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuncellenecekFiyat.Location = new System.Drawing.Point(24, 106);
            this.lblGuncellenecekFiyat.Name = "lblGuncellenecekFiyat";
            this.lblGuncellenecekFiyat.Size = new System.Drawing.Size(181, 40);
            this.lblGuncellenecekFiyat.TabIndex = 11;
            this.lblGuncellenecekFiyat.Text = "Fiyatı Güncellenecek \r\nÜrün :";
            // 
            // lblGuncelFiyat
            // 
            this.lblGuncelFiyat.AutoSize = true;
            this.lblGuncelFiyat.BackColor = System.Drawing.Color.Transparent;
            this.lblGuncelFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuncelFiyat.Location = new System.Drawing.Point(24, 163);
            this.lblGuncelFiyat.Name = "lblGuncelFiyat";
            this.lblGuncelFiyat.Size = new System.Drawing.Size(120, 20);
            this.lblGuncelFiyat.TabIndex = 12;
            this.lblGuncelFiyat.Text = "Güncel Fiyat :";
            // 
            // txtGuncelFiyat
            // 
            this.txtGuncelFiyat.Location = new System.Drawing.Point(211, 165);
            this.txtGuncelFiyat.Name = "txtGuncelFiyat";
            this.txtGuncelFiyat.Size = new System.Drawing.Size(141, 20);
            this.txtGuncelFiyat.TabIndex = 13;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Damla.Properties.Resources._360_F_142712953_1XMycIzw6DswM6in91CnDYt3Ruk0c0QU;
            this.ClientSize = new System.Drawing.Size(392, 278);
            this.Controls.Add(this.txtGuncelFiyat);
            this.Controls.Add(this.lblGuncelFiyat);
            this.Controls.Add(this.lblGuncellenecekFiyat);
            this.Controls.Add(this.lblUrunFiyatiGuncelle);
            this.Controls.Add(this.cmbUrunler);
            this.Controls.Add(this.btnGuncelle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrunFiyatiGuncelle;
        private System.Windows.Forms.ComboBox cmbUrunler;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblGuncellenecekFiyat;
        private System.Windows.Forms.Label lblGuncelFiyat;
        private System.Windows.Forms.TextBox txtGuncelFiyat;
    }
}