using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_ListBoxInceleme
{
    class Database
    {
        public static List<Urun> urunTablo = new List<Urun>()
        {
            new Urun()
            {
                id = 1,
                urunAdi = "İz Bıraktığın Kadar Varsın",
                stokAdet = 10,
                urunKategori = "Roman",
                yazar = "Esra Ezmeci",
                urunResim = @"C:\Users\103AKSAM_YAKUP\Desktop\1.jpg",
                aciklama = "Kusursuz bir bütün için harikulade parçalar gerekir. " +
                "Tıkır tıkır işleyen bir sistem ancak böyle yürür, bir kovandaki arıları ya da devasa bir karınca yuvasını düşünün. " +
                "İlişkiler de böyledir, hiçbir şey tek başına tüm ilişkiyi ayakta tutmaya yetmez. " +
                "Fırtınaya yakalanmış bir tekneye yelkenler tek başına yardımcı olamaz, " +
                "sağlam bir motor, belki devreye girmesi gereken kürekler ve güvertede teknenin seyrini sağlayan hünerli birkaç insan lazımdır."
            },
            new Urun()
            {
                id = 2,
                urunAdi = "Kehribar Geçidi",
                stokAdet = 10,
                urunKategori = "Roman",
                yazar = "Nazan Bekiroğlu",
                urunResim = @"C:\Users\103AKSAM_YAKUP\Desktop\2.jpg",
                aciklama = "Okuyucularını Forum’un, Colosseum’un, Senato’nun, Tiber ırmağının, Şifa Tapınağı’nın, sonradan kaybedilmiş veya hiç edinilmemiş özgürlüklerin," +
                " hitabetin, yazmaların, lâhitlerin, şifalı otların, kurtların kuşların, dağların, en dehşetli dövüşlerin," +
                " toga picta’nın ve dikenli deniz salyangozlarının arasında uzun bir yolculuğa davet ediyor."
            },
            new Urun()
            {
                id = 3,
                urunAdi = "taksiii",
                stokAdet = 10,
                urunKategori = "Roman",
                yazar = "Ayşe Kulin",
                urunResim = @"C:\Users\103AKSAM_YAKUP\Desktop\3.jpg",
                aciklama = "Bu kitapta doksanlı yıllardan itibaren İstanbul taksilerinde yaşadıklarımdan bir demet sundum okurlarıma. " +
                "Turistleri, savunmasız yaşlıları, özellikle de yaşlı kadınları hedef alan taksici eziyetine sık maruz kalmış biri olarak " +
                "yazdıklarımın çok kişinin yüreğine dokunacağına inanıyorum. Amacım, İstanbul’un taksi şoförlerini incitmek değil, " +
                "sorunun çözümünü engelleyerek İstanbulluları kendi çıkarları için mağdur edenlere dikkat çekmek. Mesleklerini hakkıyla, " +
                "namusuyla yapan çilekeş sürücülere ise saygılar olsun!"
            }
        };
    }
}
