using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Damla
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            ÜrünAdları();
            richTextBox1.Text = "ÜRÜN ADI" + "  ---------------  " + "ADET" + "  ---------------  " + "FİYAT";
        }
        int i = 0;
        double fiyat_urun1_toplam = 0;
        double fiyat_urun2_toplam = 0;
        double fiyat_urun3_toplam = 0;
        double fiyat_urun4_toplam = 0;
        double genel_toplam = 0;
        double genel_toplam_2 = 0;
        private void ÜrünAdları()
        {
            XDocument docOku = XDocument.Load(@"urunler.xml");
            List<XElement> okunanXElement = docOku.Descendants("urun").ToList();

            foreach (var item in okunanXElement)
            {
                if (i == 0)
                {
                    checkBox1.Text = item.Element("urunadı").Value.ToString();
                }
                else if (i == 1)
                {
                    checkBox2.Text = item.Element("urunadı").Value.ToString();
                }
                else if (i == 2)
                {
                    checkBox3.Text = item.Element("urunadı").Value.ToString();
                }
                else if (i == 3)
                {
                    checkBox4.Text = item.Element("urunadı").Value.ToString();
                }
                i++;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "0")
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - 1);
                XDocument xDoc = XDocument.Load(@"urunler.xml");
                XElement rootElement = xDoc.Root;
                foreach (XElement user in rootElement.Elements())
                {

                    if (user.Element("urunadı").Value == checkBox1.Text)
                    {
                        fiyat_urun1_toplam = Convert.ToDouble(user.Element("fiyat").Value) * Convert.ToDouble(textBox1.Text);
                        genel_toplam = fiyat_urun1_toplam + fiyat_urun2_toplam + fiyat_urun3_toplam + fiyat_urun4_toplam;
                        label1.Text = genel_toplam.ToString();
                    }
                }

            }
            else
            {
                MessageBox.Show("Değer 0'dan küçük olamaz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + 1);
            XDocument xDoc = XDocument.Load(@"urunler.xml");
            XElement rootElement = xDoc.Root;
            foreach (XElement user in rootElement.Elements())
            {
                if (user.Element("urunadı").Value == checkBox1.Text)
                {
                    fiyat_urun1_toplam = Convert.ToDouble(user.Element("fiyat").Value) * Convert.ToDouble(textBox1.Text);
                    genel_toplam = fiyat_urun1_toplam + fiyat_urun2_toplam + fiyat_urun3_toplam + fiyat_urun4_toplam;
                    label1.Text = genel_toplam.ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "0")
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox2.Text) - 1);
                XDocument xDoc = XDocument.Load(@"urunler.xml");
                XElement rootElement = xDoc.Root;
                foreach (XElement user in rootElement.Elements())
                {
                    if (user.Element("urunadı").Value == checkBox2.Text)
                    {
                        fiyat_urun2_toplam = Convert.ToDouble(user.Element("fiyat").Value) * Convert.ToDouble(textBox2.Text);
                        genel_toplam = fiyat_urun1_toplam + fiyat_urun2_toplam + fiyat_urun3_toplam + fiyat_urun4_toplam;

                        label1.Text = genel_toplam.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Değer 0'dan küçük olamaz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(Convert.ToInt32(textBox2.Text) + 1);
            XDocument xDoc = XDocument.Load(@"urunler.xml");
            XElement rootElement = xDoc.Root;
            foreach (XElement user in rootElement.Elements())
            {
                if (user.Element("urunadı").Value == checkBox2.Text)
                {
                    fiyat_urun2_toplam = Convert.ToDouble(user.Element("fiyat").Value) * Convert.ToDouble(textBox2.Text);
                    genel_toplam = fiyat_urun1_toplam + fiyat_urun2_toplam + fiyat_urun3_toplam + fiyat_urun4_toplam;
                    label1.Text = genel_toplam.ToString();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "0")
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) - 1);
                XDocument xDoc = XDocument.Load(@"urunler.xml");
                XElement rootElement = xDoc.Root;
                foreach (XElement user in rootElement.Elements())
                {
                    if (user.Element("urunadı").Value == checkBox3.Text)
                    {
                        fiyat_urun3_toplam = Convert.ToDouble(user.Element("fiyat").Value) * Convert.ToDouble(textBox3.Text);
                        genel_toplam = fiyat_urun1_toplam + fiyat_urun2_toplam + fiyat_urun3_toplam + fiyat_urun4_toplam;
                        label1.Text = genel_toplam.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Değer 0'dan küçük olamaz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) + 1);
            XDocument xDoc = XDocument.Load(@"urunler.xml");
            XElement rootElement = xDoc.Root;
            foreach (XElement user in rootElement.Elements())
            {
                if (user.Element("urunadı").Value == checkBox3.Text)
                {
                    fiyat_urun3_toplam = Convert.ToDouble(user.Element("fiyat").Value) * Convert.ToDouble(textBox3.Text);
                    genel_toplam = fiyat_urun1_toplam + fiyat_urun2_toplam + fiyat_urun3_toplam + fiyat_urun4_toplam;
                    label1.Text = genel_toplam.ToString();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "0")
            {
                textBox4.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) - 1);
                XDocument xDoc = XDocument.Load(@"urunler.xml");
                XElement rootElement = xDoc.Root;
                foreach (XElement user in rootElement.Elements())
                {
                    if (user.Element("urunadı").Value == checkBox4.Text)
                    {
                        fiyat_urun4_toplam = Convert.ToDouble(user.Element("fiyat").Value) * Convert.ToDouble(textBox4.Text);
                        genel_toplam = fiyat_urun1_toplam + fiyat_urun2_toplam + fiyat_urun3_toplam + fiyat_urun4_toplam;
                        label1.Text = genel_toplam.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Değer 0'dan küçük olamaz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) + 1);
            XDocument xDoc = XDocument.Load(@"urunler.xml");
            XElement rootElement = xDoc.Root;
            foreach (XElement user in rootElement.Elements())
            {
                if (user.Element("urunadı").Value == checkBox4.Text)
                {
                    fiyat_urun4_toplam = Convert.ToDouble(user.Element("fiyat").Value) * Convert.ToDouble(textBox4.Text);
                    genel_toplam = fiyat_urun1_toplam + fiyat_urun2_toplam + fiyat_urun3_toplam + fiyat_urun4_toplam;
                    label1.Text = genel_toplam.ToString();
                }
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            genel_toplam_2 = 0;
            richTextBox1.Text = "ÜRÜN ADI" + "  ---------------  " + "ADET" + "  ---------------  " + "FİYAT";
            if (checkBox1.Checked == true)
            {
                richTextBox1.AppendText("\n\n" + checkBox1.Text);
                richTextBox1.AppendText("  ------------------  " + textBox1.Text);
                richTextBox1.AppendText("  -----------------------  " + fiyat_urun1_toplam);
                genel_toplam_2 += fiyat_urun1_toplam;
            }
            if (checkBox2.Checked == true)
            {

                richTextBox1.AppendText("\n\n" + checkBox2.Text);
                richTextBox1.AppendText("  -----------------------  " + textBox2.Text);
                richTextBox1.AppendText("  -----------------------  " + fiyat_urun2_toplam);
                genel_toplam_2 += fiyat_urun2_toplam;
            }
            if (checkBox3.Checked == true)
            {

                richTextBox1.AppendText("\n\n" + checkBox3.Text);
                richTextBox1.AppendText("  ----------------------  " + textBox3.Text);
                richTextBox1.AppendText("  -----------------------  " + fiyat_urun3_toplam);
                genel_toplam_2 += fiyat_urun3_toplam;
            }
            if (checkBox4.Checked == true)
            {

                richTextBox1.AppendText("\n\n" + checkBox4.Text);
                richTextBox1.AppendText("  ----------------  " + textBox4.Text);
                richTextBox1.AppendText("  -----------------------  " + fiyat_urun4_toplam);
                genel_toplam_2 += fiyat_urun4_toplam;
            }
            richTextBox1.AppendText("\n\n\t\t\t\t\t\t" + "\nTOPLAM : " + genel_toplam_2);
        }
       
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            fiyat_urun1_toplam = 0;
            fiyat_urun2_toplam = 0;
            fiyat_urun3_toplam = 0;
            fiyat_urun4_toplam = 0;
            genel_toplam_2 = 0;
            genel_toplam = 0;
            label1.Text = "0";
        }


        private void btnYazdir_Click(object sender, EventArgs e)
        {
         
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font baslikFont = new Font("Arials", 18, FontStyle.Bold);
            Brush baslikFontRenk = Brushes.Black;
            PointF baslikBaslangicNoktasi = new PointF(300, 100);
            e.Graphics.DrawString("---------Fatura---------", baslikFont, baslikFontRenk,
                baslikBaslangicNoktasi);

            Font fontTipi = new Font("Times New Roman", 8, FontStyle.Bold);
            Brush fontRenk = Brushes.Black;
            PointF baslangicNoktasi = new PointF(100, 200);
            e.Graphics.DrawString(richTextBox1.Text, baslikFont, fontRenk, baslangicNoktasi);

        }
    }

       
    }


