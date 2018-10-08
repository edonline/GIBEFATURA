using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Collections;

namespace GIBEFATURA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlTextReader element;
        private void XmlOku()
        {
            string DosyaAdi_ = null;
            DosyaAdi_ = @txtXmlDosyaYolu.Text;
            //MessageBox.Show(DosyaAdi_);
            if (!System.IO.File.Exists(DosyaAdi_))
            {
                MessageBox.Show("Dosya Bulunamadı");
            }
            else
            {
                element = new XmlTextReader(DosyaAdi_);
                try
                {
                    while (element.Read())
                    {
                        if (element.Name == "Identifier")
                        {
                            string vno = element.ReadString();
                            if (!listBox1.Items.Contains(vno)) //--> girilen deger listboxta eger yoksa
                            {
                                listBox1.Items.Add(vno);// --> listboxın içine ekle
                            }
                            else
                            {
                                //MessageBox.Show("Bu veri listboxtta mevcut");//--> varsa listbox'a ekleme
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                MessageBox.Show(listBox1.Items.Count.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            XmlOku();
            string _PosGenel;
            try
            {
                _PosGenel = @txtPOSGENELDosyayolu.Text + "\\EFATVNO.DAT";
                StreamWriter sw = new StreamWriter(_PosGenel);
                foreach (string line in listBox1.Items)
                {
                    if (line.Length == 10)
                    {
                        sw.WriteLine(line + "     ");
                    }
                    if (line.Length == 11)
                    {
                        sw.WriteLine(line + "    ");
                    }
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KasaNoOku();
            txtXmlDosyaYolu.Text = Properties.Settings.Default.xmlyol;
            txtPOSKONDosyaYolu.Text = Properties.Settings.Default.poskonyol;
            txtPOSGENELDosyayolu.Text = Properties.Settings.Default.posgenelyol;
        }
        private void KasaNoOku()
        {
            using (var stream = new FileStream(Application.StartupPath + @"\KASANOLISTE.TXT", FileMode.Open))
            {
                using (var sr = new StreamReader(stream))
                {
                    while (sr.Peek() >= 0)
                    {
                        lstIpList.Items.Add(sr.ReadLine());
                    }
                }
            }
        }
        private void KasaNoKaydet()
        {
            using (var stream = new FileStream(Application.StartupPath + @"\KASANOLISTE.TXT", FileMode.Truncate))
            {
                using (var writer = new StreamWriter(stream))
                {
                    foreach (string satir in lstIpList.Items)
                    {
                        writer.WriteLine(satir);
                    }
                    writer.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenXmlDialog.Filter = "xml Dosyalar (*.xml)|*.xml|Tüm Dosyalar (*.*)|*.*";
            DialogResult Dia = OpenXmlDialog.ShowDialog();

            if (Dia == DialogResult.OK) // Test result.
            {
                txtXmlDosyaYolu.Text = OpenXmlDialog.FileName;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult Dia = folderPOSKONdialog.ShowDialog();
            if (Dia == DialogResult.OK)
            {
                string secili = folderPOSKONdialog.SelectedPath;
                txtPOSKONDosyaYolu.Text = secili;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult Dia = folderPOSGENELdialog.ShowDialog();
            if (Dia == DialogResult.OK)
            {
                string secili = folderPOSGENELdialog.SelectedPath;
                txtPOSGENELDosyayolu.Text = secili;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KasaNoKaydet();
            Properties.Settings.Default.xmlyol = txtXmlDosyaYolu.Text;
            Properties.Settings.Default.poskonyol=txtPOSKONDosyaYolu.Text;
            Properties.Settings.Default.posgenelyol=txtPOSGENELDosyayolu.Text;
            Properties.Settings.Default.Save();
            foreach (string line in lstIpList.Items)
            {
                StreamWriter sw = new StreamWriter(@txtPOSKONDosyaYolu.Text + "\\MESAJ." + line.ToString());
                sw.WriteLine("1530");
                sw.Close();
                sw.Dispose();
            }
            MessageBox.Show("İşlem Tamamlandı\nLütfen Kasalardan Kontrol Ediniz.!");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (int.TryParse(txtIp.Text, out parsedValue))
            {
                if (!lstIpList.Items.Contains(txtIp.Text))
                {
                    lstIpList.Items.Add(txtIp.Text);
                }
                else
                {
                    MessageBox.Show("Bu KASA NO mevcut");
                }
            }
            else
            {
                MessageBox.Show(txtIp.Text + " KASA NO bilgisi Yanlış!");
            }
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            lstIpList.Items.Remove(txtIp.Text);
        }


        private void lstIpList_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstIpList.SelectedIndex < lstIpList.Items.Count)
            {
                txtIp.Text = lstIpList.SelectedItem.ToString();
            }
        }

    }
}
