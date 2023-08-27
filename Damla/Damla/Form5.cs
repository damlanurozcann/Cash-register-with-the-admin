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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void UrunleriGetir()
        {
            cmbUrunler.Items.Clear();
            XDocument docOku = XDocument.Load(@"urunler.xml");
            List<XElement> okunanXElement = docOku.Descendants("urun").ToList();

            foreach (var item in okunanXElement)
            {
                cmbUrunler.Items.Add(item.Element("urunadı").Value.ToString());
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (cmbUrunler.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen listeden bir ürün seçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XDocument xDoc = XDocument.Load(@"urunler.xml");
                XElement rootElement = xDoc.Root;
                foreach (XElement item in rootElement.Elements())
                {
                    if (item.Element("urunadı").Value == cmbUrunler.Text)
                    {
                        item.Element("fiyat").Value = txtGuncelFiyat.Text;
                        MessageBox.Show("Ürünün fiyatı başarılı bir şekilde değiştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                xDoc.Save(@"urunler.xml");

            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            UrunleriGetir();
        }
    }
}
