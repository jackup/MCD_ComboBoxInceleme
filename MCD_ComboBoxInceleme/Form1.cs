using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_ComboBoxInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Items.Add metodu kullanılarak değerler combobox'a eklendi..
            comboBoxDoldurV1();
            //comboBoxDoldurV2();
        }

        //private void comboBoxDoldurV2()
        //{
        //    cmbUrunList.DataSource = Database.urunTablo;
        //}

        private void cmbUrunList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1.Yöntem :
            object o1 = cmbUrunList.SelectedItem;
            Urun u1 = (Urun)o1;

            //u1 = cmbUrunList.SelectedItem == null ? null : cmbUrunList.SelectedItem as Urun;

            //2.Yöntem :
            ComboBox secilenCmbox = sender as ComboBox;

            //1.yöntem eğer form içerisinde bulunan form elemanına özel bir metod yazıldı ise o zaman ilgili form elemanını direkt olarak çağırmak daha mantıklıdır.

            //2.yöntem çalışma zamanında oluşturmuş olduğumuz form elemanlarından hangisine tıklanıldığını veya işlem yapıldığını bilmediğimiz
            //için ve metodumuz birden fazla form elemanında olay metodu olarak tanımlandığı için biz sender üzerinden gelen nesneyi kullanır,
            //kullanıcının hangi windows form elemanında işlem yapmış olduğunu anlarız.


            pctUrunResim.Image = Image.FromFile(u1.urunResim);
            pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;
            txtUrunAdi.Text = u1.urunAdi;
            txtUrunKategori.Text = u1.urunKategori;
            txtStokAdet.Text = u1.stokAdet.ToString();
            txtYazar.Text = u1.yazar;
            txtAciklama.Text = u1.aciklama;
        }

        private void comboBoxDoldurV1()
        {
            foreach (var item in Database.urunTablo)
            {
                cmbUrunList.Items.Add(item);
            }
        }
    }
}
