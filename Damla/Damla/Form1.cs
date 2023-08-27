using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Damla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "admin")
            {
                XDocument docOku = XDocument.Load(@"admin.xml");
                List<XElement> okunanXElement = docOku.Descendants("user").ToList();

                foreach (var item in okunanXElement)
                {

                    if (txtKullaniciAdi.Text == item.Element("username").Value.ToString() && txtSifre.Text == item.Element("password").Value.ToString())
                    {
                        Form2 frm = new Form2();
                        this.Hide();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz bilgiler yanlış! Tekrar deneyiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                XDocument docOku = XDocument.Load(@"users.xml");
                List<XElement> okunanXElement = docOku.Descendants("user").ToList();

                foreach (var item in okunanXElement)
                {
                    if (txtKullaniciAdi.Text == item.Element("username").Value.ToString() && txtSifre.Text == item.Element("password").Value.ToString())
                    {
                        Form6 frm = new Form6();
                        this.Hide();
                        frm.ShowDialog();
                    }
                }
                MessageBox.Show("Girdiğiniz bilgiler yanlış! Tekrar deneyiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }
    }
}
