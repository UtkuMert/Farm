
/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					
**	
**				ÖDEV NUMARASI..........: Proje Ödevi
**				ÖĞRENCİ ADI............: Emin Utku Mert
**				ÖĞRENCİ NUMARASI.......: G171210051
**              DERSİN ALINDIĞI GRUP...: 2/D
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace HayvanCiftligi
{
    class Keçi : Hayvan
    {
        public override void enerjiAzalt()
        {
            enerji = enerji - 6;
            if (enerji <= 0)
            {
                this.canlilik.Text = "ÖLÜ";
                this.enerji = 0;

                //hayvanSesi = new SoundPlayer(@"C:\Users\Utku\Desktop\g171210051_2D_ödev_proje\Hayvan Ciftligi Dosyalar\keci.wav");
                //hayvanSesi.Play();
            }
        }

       

        public override void sat()
        {
            if (this.ürünSayisi != 0)
            {
                this.ürünSayisi -= 1;
                this.ürün.Text = this.ürünSayisi + " Adet";
            }
            else
                this.ürünSayisi = 0;
        }
        
        public override void ürünÜret(int Süre)
        {
            if (this.canlilik.Text == "CANLI")
            {
                if (Süre % 7 == 0)
                {
                    this.ürünSayisi++;
                    this.ürün.Text = this.ürünSayisi + " Adet";
                }
            }
        }
    }
}
