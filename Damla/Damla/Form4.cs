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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            KullanicilariGetir();
        }

        private void KullanicilariGetir()
        {
            cmbKullanici.Items.Clear();
            XDocument docOku = XDocument.Load(@"users.xml");
            List<XElement> okunanXElement = docOku.Descendants("user").ToList();

            foreach (var item in okunanXElement)
            {
                cmbKullanici.Items.Add(item.Element("username").Value.ToString());
            }
        }
        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            if (cmbKullanici.SelectedIndex == -1)
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XDocument xDoc = XDocument.Load(@"users.xml");
                XElement rootElement = xDoc.Root;
                foreach (XElement user in rootElement.Elements())
                {
                    if (user.Element("username").Value == cmbKullanici.Text)
                    {
                        user.Remove();
                        MessageBox.Show("Kullanıcı başarıyla silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                xDoc.Save(@"users.xml");
                cmbKullanici.SelectedIndex = -1;
                KullanicilariGetir();
            }
        }
    }
}
