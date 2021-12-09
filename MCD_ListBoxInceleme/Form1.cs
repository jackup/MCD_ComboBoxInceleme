using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_ListBoxInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxDoldurV2()
        {
            lstUrunler.DisplayMember = "urunAdi";
            //lstUrunler.ValueMember = "id";
            lstUrunler.DataSource = Database.urunTablo;
        }

        private void listBoxDoldurV1()
        {
            foreach (var item in Database.urunTablo)
            {
                lstUrunler.Items.Add(item);
            }
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int urunSecimAdet = lstUrunler.SelectedItems.Count;
            if (urunSecimAdet == 1)
            {
                ListBox lBox = (ListBox)sender;
                //lBox = sender as ListBox;
                Urun u1 = (Urun)lBox.SelectedItem;

                pctUrunResim.Image = Image.FromFile(u1.urunResim);
                pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;

                txtUrunAdi.Text = u1.urunAdi;
                txtUrunKategori.Text = u1.urunKategori;
                txtStokAdet.Text = u1.stokAdet.ToString();
                txtYazar.Text = u1.yazar;
                txtAciklama.Text = u1.aciklama;
            }
            else if (urunSecimAdet > 1)
            {
                List<Urun> secilenUrunListe = new List<Urun>();
                foreach (var item in lstUrunler.SelectedItems)
                {
                    secilenUrunListe.Add(item as Urun);
                }

                UrunSecimKullanici secimKullanici = new UrunSecimKullanici(secilenUrunListe.ToArray());
                secimKullanici.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen Görmek İstediğiniz Ürünü Seçiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            listBoxDoldurV2();
            //listBoxDoldurV1();
        }
    }
}
