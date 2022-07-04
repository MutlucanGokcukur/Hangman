using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Hangman
{
    public class Kelimeler
    {
        public ArrayList Konular = new ArrayList();
        public ArrayList Meyveler = new ArrayList();
        public ArrayList Ulkeler = new ArrayList();
        public ArrayList İsimler = new ArrayList();
        public ArrayList Şehirler = new ArrayList();
        public ArrayList Hayvanlar = new ArrayList();
        public void DiziEk()
        {

            #region Konular
            Konular.Add("Meyve");
            Konular.Add("İsim");
            Konular.Add("Şehir");
            Konular.Add("Ülke");
            Konular.Add("Hayvan");
            #endregion

            #region Meyveler
            Meyveler.Add("armut");
            Meyveler.Add("kiraz");
            Meyveler.Add("çilek");
            Meyveler.Add("kavun");
            Meyveler.Add("karpuz");
            Meyveler.Add("vişne");
            Meyveler.Add("avakado");
            Meyveler.Add("böğürtlen");
            Meyveler.Add("hurma");
            Meyveler.Add("erik");
            Meyveler.Add("portakal");
            Meyveler.Add("nar");
            Meyveler.Add("mandalina");
            Meyveler.Add("ananas");
            Meyveler.Add("kivi");
            Meyveler.Add("muz");
            Meyveler.Add("greyfurt");
            Meyveler.Add("ayva");
            Meyveler.Add("üzüm");
            Meyveler.Add("kayısı");
            #endregion

            #region Ulkeler
            Ulkeler.Add("bolivya");
            Ulkeler.Add("macaristan");
            Ulkeler.Add("amerika");
            Ulkeler.Add("finlandiya");
            Ulkeler.Add("yunanistan");
            Ulkeler.Add("türkiye");
            Ulkeler.Add("isveç");
            Ulkeler.Add("hırvatistan");
            Ulkeler.Add("arjantin");
            Ulkeler.Add("çin");
            Ulkeler.Add("japonya");
            Ulkeler.Add("yemen");
            Ulkeler.Add("moğolistan");
            Ulkeler.Add("panama");
            Ulkeler.Add("azerbaycan");
            Ulkeler.Add("kazakistan");
            Ulkeler.Add("ırak");
            Ulkeler.Add("iran");
            Ulkeler.Add("katar");
            Ulkeler.Add("kanada");
            #endregion

            #region Isımler
            İsimler.Add("yusuf");
            İsimler.Add("mahmut");
            İsimler.Add("arda");
            İsimler.Add("muhammet");
            İsimler.Add("betül");
            İsimler.Add("berna");
            İsimler.Add("selin");
            İsimler.Add("mehmet");
            İsimler.Add("beyza");
            İsimler.Add("ahmet");
            İsimler.Add("veli");
            İsimler.Add("ayşe");
            İsimler.Add("abdullah");
            İsimler.Add("merve");
            İsimler.Add("açelya");
            İsimler.Add("ajda");
            İsimler.Add("hande");
            İsimler.Add("sezen");
            İsimler.Add("aleyna");
            İsimler.Add("buket");
            #endregion

            #region Sehirler
            Şehirler.Add("istanbul");
            Şehirler.Add("kocaeli");
            Şehirler.Add("ankara");
            Şehirler.Add("izmir");
            Şehirler.Add("bursa");
            Şehirler.Add("çankırı");
            Şehirler.Add("ordu");
            Şehirler.Add("adana");
            Şehirler.Add("şanlıurfa");
            Şehirler.Add("diyarbakır");
            Şehirler.Add("elazığ");
            Şehirler.Add("muğla");
            Şehirler.Add("manisa");
            Şehirler.Add("sakarya");
            Şehirler.Add("kastamonu");
            Şehirler.Add("kırıkkale");
            Şehirler.Add("adıyaman");
            Şehirler.Add("antalya");
            Şehirler.Add("karabük");
            Şehirler.Add("zonguldak");
            #endregion

            #region Hayvanlar
            Hayvanlar.Add("fil");
            Hayvanlar.Add("köpek");
            Hayvanlar.Add("kedi");
            Hayvanlar.Add("fare");
            Hayvanlar.Add("tavşan");
            Hayvanlar.Add("kaplan");
            Hayvanlar.Add("aslan");
            Hayvanlar.Add("panda");
            Hayvanlar.Add("yılan");
            Hayvanlar.Add("koala");
            Hayvanlar.Add("zürafa");
            Hayvanlar.Add("geyik");
            Hayvanlar.Add("ayı");
            Hayvanlar.Add("çita");
            Hayvanlar.Add("kaplumbağa");
            Hayvanlar.Add("eşek");
            Hayvanlar.Add("keçi");
            Hayvanlar.Add("kurbağa");
            Hayvanlar.Add("kirpi");
            Hayvanlar.Add("timsah");
            #endregion
        }
    }
}
