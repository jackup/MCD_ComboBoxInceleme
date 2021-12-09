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
    public partial class UrunSecimKullanici : Form
    {
        Urun[] urunListe;
        public UrunSecimKullanici(Urun[] secilenUrunler)
        {
            InitializeComponent();
            urunListe = secilenUrunler;
        }

        private void UrunSecimKullanici_Load(object sender, EventArgs e)
        {
            foreach (var item in urunListe)
            {
                Button btn = new Button();
                btn.Text = item.urunAdi;
                btn.Name = "btn" + item.id.ToString();
                btn.Size = new System.Drawing.Size(122, 37);
                btn.Tag = item;
                btn.Click += BtnClick;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void BtnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Urun u1 = btn.Tag as Urun;
            Form f1 = Application.OpenForms["Form1"];
            GroupBox f1gBox = (GroupBox)f1.Controls["groupBox1"];
            ((PictureBox)f1gBox.Controls["pctUrunResim"]).Image = Image.FromFile(u1.urunResim);
            ((TextBox)f1gBox.Controls["txtUrunAdi"]).Text = u1.urunAdi;
            ((TextBox)f1gBox.Controls["txtUrunKategori"]).Text = u1.urunKategori;
            ((TextBox)f1gBox.Controls["txtStokAdet"]).Text = u1.stokAdet.ToString();
            ((TextBox)f1gBox.Controls["txtYazar"]).Text = u1.yazar;
            ((TextBox)f1gBox.Controls["txtAciklama"]).Text = u1.aciklama;
            this.Close();
            
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
