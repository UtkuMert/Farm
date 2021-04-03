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
using System.Windows.Forms;
using System.Media;
using static System.Net.Mime.MediaTypeNames;

namespace HayvanCiftligi
{
   public abstract class Hayvan
    {
        public int ürünSayisi = 0;
        public int enerji = 100;

        public Label canlilik;    // Label komutları kullanılacak değerlerin atanıp kontrol edilmesi için tanımlanmıştır.
        public Label ürün;
        public ProgressBar progressBar;
        public SoundPlayer hayvanSesi;

        
        public abstract void ürünÜret(int Süre);
        public abstract void enerjiAzalt();
        public abstract void sat();
        

    }


}
