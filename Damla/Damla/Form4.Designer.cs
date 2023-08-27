
namespace Damla
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.btnKullaniciSil = new System.Windows.Forms.Button();
            this.cmbKullanici = new System.Windows.Forms.ComboBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblKullaniciSil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKullaniciSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnKullaniciSil.Location = new System.Drawing.Point(114, 195);
            this.btnKullaniciSil.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(121, 40);
            this.btnKullaniciSil.TabIndex = 0;
            this.btnKullaniciSil.Text = "Kullanıcı Sil";
            this.btnKullaniciSil.UseVisualStyleBackColor = true;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // cmbKullanici
            // 
            this.cmbKullanici.FormattingEnabled = true;
            this.cmbKullanici.Location = new System.Drawing.Point(114, 154);
            this.cmbKullanici.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbKullanici.Name = "cmbKullanici";
            this.cmbKullanici.Size = new System.Drawing.Size(120, 21);
            this.cmbKullanici.TabIndex = 1;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(119, 118);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(116, 20);
            this.lblKullaniciAdi.TabIndex = 3;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // lblKullaniciSil
            // 
            this.lblKullaniciSil.AutoSize = true;
            this.lblKullaniciSil.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullaniciSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblKullaniciSil.Location = new System.Drawing.Point(77, 61);
            this.lblKullaniciSil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKullaniciSil.Name = "lblKullaniciSil";
            this.lblKullaniciSil.Size = new System.Drawing.Size(187, 29);
            this.lblKullaniciSil.TabIndex = 4;
            this.lblKullaniciSil.Text = "Kullanıcı Silme";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Damla.Properties.Resources._360_F_142712953_1XMycIzw6DswM6in91CnDYt3Ruk0c0QU;
            this.ClientSize = new System.Drawing.Size(352, 297);
            this.Controls.Add(this.lblKullaniciSil);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.cmbKullanici);
            this.Controls.Add(this.btnKullaniciSil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form4";
            this.Text = "Kullanıcı Silme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKullaniciSil;
        private System.Windows.Forms.ComboBox cmbKullanici;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblKullaniciSil;
    }
}