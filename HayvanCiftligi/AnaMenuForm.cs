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
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace HayvanCiftligi
{
      public partial class AnaMenuForm : Form
    {
        static System.Windows.Forms.Timer gecenSüreTimer = new System.Windows.Forms.Timer();

        List<Hayvan> hayvanlar = new List<Hayvan>();

        static Hayvan tavuk = new Tavuk();
        static Hayvan ördek = new Ördek();
        static Hayvan inek = new İnek();
        static Hayvan keçi = new Keçi();

        static int süre = 0;
        static int kasa = 0;

        public AnaMenuForm()
        {
            InitializeComponent();

            fotoDüzenle();
            hayvanlariHazirla();
            süreBaslat();
            
        }

        private void hayvanlariHazirla()  //List'e hayvanlar eklenir ve oluşturulan alanlara kalıtım alınarak gerekli değerler atanır.
        {
            hayvanlar.Add(tavuk); 
            hayvanlar.Add(ördek);
            hayvanlar.Add(inek);
            hayvanlar.Add(keçi);

            tavuk.progressBar = this.tavukProgressBar;
            tavuk.canlilik = this.tavukCanlilikLabel;
            tavuk.ürün = this.yumurtaDeğişkenLabel;
            
            
            ördek.progressBar = this.ördekProgressBar;
            ördek.canlilik = this.ördekCanlilikLabel;
            ördek.ürün = this.ördekYumurtaDeğişkeniLabel;
         

            inek.progressBar = this.inekProgressbar;
            inek.canlilik = this.inekCanlilikLabel;
            inek.ürün = this.inekSütüDeğişkenLabel;
            

            keçi.progressBar = this.keçiProgressbar;
            keçi.canlilik = this.keçiCanlilikLabel;
            keçi.ürün = this.keçiSütüDeğişkenLabel;
            

        }

        private void AnaMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void fotoDüzenle() //Fotoğraf boyutlarının ayarlanması için kullanılan fonksiyon.
        {
            this.tavukPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.ördekPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.inekPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.keçiPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void süreBaslat()
        {
            gecenSüreTimer.Interval = 1000;
            gecenSüreTimer.Tick += saniyeBasiIslem;
            gecenSüreTimer.Start();
        }

        private void saniyeBasiIslem(object sender, EventArgs e)   //Süreye göre işlemler burada kontrol edilir.
        {

            süre += 1;
            this.gecenSüreDegisken.Text = süre.ToString() + " SN";
            

           foreach(Hayvan hayvan in hayvanlar)  // List'e eklenmiş olan hayvanların değerleri burada kontrol edilir.
            {

                if(hayvan.enerji>0)
                { 
                hayvan.enerjiAzalt();
                hayvan.progressBar.Value = hayvan.enerji;
                hayvan.ürünÜret(süre);
                }
            }
        }

        // ----------Yem ver tuşları----------
        private void tavukYemVer_Click(object sender, EventArgs e)
        {
            if (tavuk.canlilik.Text == "CANLI")
            {
                tavuk.enerji = 100;
            }
        }

        private void ördekYemVer_Click(object sender, EventArgs e)
        {
            if (ördek.canlilik.Text == "CANLI")
            {
                ördek.enerji = 100;
            }
        }

        private void inekYemVer_Click(object sender, EventArgs e)
        {
            if (inek.canlilik.Text == "CANLI")
            {
                inek.enerji = 100;
            }
        }

        private void keçiYemVer_Click(object sender, EventArgs e)
        {
            if (keçi.canlilik.Text == "CANLI")
            {
                keçi.enerji = 100;
            }
        }


        //----------Ürün Sat Tuşları----------

        private void tavukSatButton_Click(object sender, EventArgs e)
        {
            
            if (tavuk.ürünSayisi != 0)
            {
                kasa += 1;
                kasaDegiskenLabel.Text = kasa.ToString()+ " ₺";
            }
            tavuk.sat();
        }

        private void ördekSatButton_Click(object sender, EventArgs e)
        {
            if (ördek.ürünSayisi != 0)
            {
                kasa += 3;
                kasaDegiskenLabel.Text = kasa.ToString()+" ₺";
            }
            ördek.sat();
        }
        private void inekSatButton_Click(object sender, EventArgs e)
        {
            if(inek.ürünSayisi!=0)
            { 
            kasa += 5;
            kasaDegiskenLabel.Text = kasa.ToString()+ " ₺";
            }

            inek.sat();
        }
        private void keçiSatButton_Click(object sender, EventArgs e)
        {
           
            if(keçi.ürünSayisi!=0)
            { 
                kasa += 8;
                kasaDegiskenLabel.Text = kasa.ToString()+ " ₺";
            }
            keçi.sat();
        }
        
    }
}
