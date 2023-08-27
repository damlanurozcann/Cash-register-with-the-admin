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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text != "" && txtSifre.Text != "")
            {
                XDocument xDoc = XDocument.Load(@"users.xml");
                XElement rootElement = xDoc.Root;
                XElement newElement = new XElement("user");
                XElement adiElement = new XElement("username", txtKullaniciAdi.Text);
                XElement telefonElement = new XElement("password", txtSifre.Text);
                newElement.Add(adiElement, telefonElement);
                rootElement.Add(newElement);
                xDoc.Save(@"users.xml");
                MessageBox.Show("Kullanıcı başarıyla eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kullanıcı ekleyebilmek için tüm alanları doldurun.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            
            txtSifre.PasswordChar = '*';
        }
    }
}
