using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Hangman.Properties;

namespace Hangman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        #region Genel Değişkenler
        string kelime = "";
        char[] yertutucu;
        bool bayrak;
        int hak = 9;
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Başlat Butonuna Basmadan Tüm Tuşlara Basma Kapalı
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnÇ.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;
            btnG.Enabled = false;
            btnĞ.Enabled = false;
            btnH.Enabled = false;
            btnI.Enabled = false;
            btnİ.Enabled = false;
            btnJ.Enabled = false;
            btnK.Enabled = false;
            btnL.Enabled = false;
            btnM.Enabled = false;
            btnN.Enabled = false;
            btnO.Enabled = false;
            btnÖ.Enabled = false;
            btnP.Enabled = false;
            btnR.Enabled = false;
            btnS.Enabled = false;
            btnŞ.Enabled = false;
            btnT.Enabled = false;
            btnU.Enabled = false;
            btnÜ.Enabled = false;
            btnV.Enabled = false;
            btnY.Enabled = false;
            btnZ.Enabled = false;
            #endregion
        }
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            #region Tüm Tuşları Aktif Yapma
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnÇ.Enabled = true;
            btnD.Enabled = true;
            btnE.Enabled = true;
            btnF.Enabled = true;
            btnG.Enabled = true;
            btnĞ.Enabled = true;
            btnH.Enabled = true;
            btnI.Enabled = true;
            btnİ.Enabled = true;
            btnJ.Enabled = true;
            btnK.Enabled = true;
            btnL.Enabled = true;
            btnM.Enabled = true;
            btnN.Enabled = true;
            btnO.Enabled = true;
            btnÖ.Enabled = true;
            btnP.Enabled = true;
            btnR.Enabled = true;
            btnS.Enabled = true;
            btnŞ.Enabled = true;
            btnT.Enabled = true;
            btnU.Enabled = true;
            btnÜ.Enabled = true;
            btnV.Enabled = true;
            btnY.Enabled = true;
            btnZ.Enabled = true;
            #endregion
            Kelimeler K1 = new Kelimeler();
            K1.DiziEk();
            #region Rastgele Konu ve Kelime Seçme
            Random rnd = new Random();
            int deger = rnd.Next(0, K1.Konular.Count);
            string konu = Convert.ToString(K1.Konular[deger]);
            lblkonu.Text = "Konu: " + konu;
            switch (deger)
            {
                case 0:
                    int meyvekelime = rnd.Next(0, K1.Meyveler.Count);
                    kelime = Convert.ToString(K1.Meyveler[meyvekelime]);
                    break;
                case 1:
                    int isimkelime = rnd.Next(0, K1.İsimler.Count);
                    kelime = Convert.ToString(K1.İsimler[isimkelime]);
                    break;
                case 2:
                    int şehirkelime = rnd.Next(0, K1.Şehirler.Count);
                    kelime = Convert.ToString(K1.Şehirler[şehirkelime]);
                    break;
                case 3:
                    int ülkekelime = rnd.Next(0, K1.Ulkeler.Count);
                    kelime = Convert.ToString(K1.Ulkeler[ülkekelime]);
                    break;
                case 4:
                    int hayvankelime = rnd.Next(0, K1.Hayvanlar.Count);
                    kelime = Convert.ToString(K1.Hayvanlar[hayvankelime]);
                    break;
                default:
                    MessageBox.Show("Sistem Hatası\nHatadan Dolayı Özür Dileriz\nLütfen Uygulamayı" +
                    "Baştan Başlatınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            #endregion
            kelime = kelime.ToUpper();

            #region Harf Sayısı Kadar Çizgi Bastırma
            yertutucu = new char[kelime.Length];

            for (int i = 0; i < yertutucu.Length; i++)
            {
                yertutucu[i] = '_';
                lblKelimeÇizgi.Text += "_ ";
            }
            #endregion

        }
        private void HarfOlay(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            char harf =Convert.ToChar(btn.Text); //Basılan Butonun Hangi Tuş Olduğunu Algılama
            harf.ToString().ToUpper();

            #region Butonların D/Y Olmasına Göre Renk Değiştirmesi ve Pasif Olması Kontrolü
            if (kelime.Contains(harf))
            {
                btn.BackColor = Color.LimeGreen;
                btn.Enabled = false;
            }
            else
            {
                btn.BackColor = Color.IndianRed;
                btn.Enabled = false;
                hak = hak - 1;
                #region Hak Her Azaldığında Resim Değişmesi
                switch (hak)
                {
                    case 8:
                        pictureBox1.Image = Resources.adamasmaca3;
                        break;
                    case 7:
                        pictureBox1.Image = Resources.adamasmaca4;
                        break;
                    case 6:
                        pictureBox1.Image = Resources.adamasmaca5;
                        break;
                    case 5:
                        pictureBox1.Image = Resources.adamasmaca7;
                        break;
                    case 4:
                        pictureBox1.Image = Resources.adamasmaca8;
                        break;
                    case 3:
                        pictureBox1.Image = Resources.adamasmaca9;
                        break;
                    case 2:
                        pictureBox1.Image = Resources.adamasmaca10;
                        break;
                    case 1:
                        pictureBox1.Image = Resources.adamasmaca11;
                        break;
                    case 0:
                        pictureBox1.Image = Resources.adamasmaca12son;
                        break;
                    default:
                        break;
                }
                #endregion
                lblHakSayac.Text = "Kalan Hakkınız: "+Convert.ToString(hak);
                
            }
            #endregion

            bayrak = false;
            lblKelimeÇizgi.Text = "";

            for (int i = 0; i < kelime.Length; i++)
            {
                if (kelime[i]==harf)
                {
                    yertutucu[i] = harf;
                    bayrak = true;
                }
                lblKelimeÇizgi.Text += Convert.ToString(yertutucu[i]) + " ";
            }
            if (hak==0)
            {
                MessageBox.Show("Hakkınız Kalmamıştır\nDoğru Kelime: " + kelime, "Oyun Bitti"
                ,MessageBoxButtons.OK,MessageBoxIcon.Information);
                Application.Exit();
            }
            if (lblKelimeÇizgi.Text.Contains("_")==false)
            {
                MessageBox.Show("Kelimeyi Bildiniz", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
