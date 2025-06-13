using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace kargoTakipSistemiii
{
    public enum Durum   //Kargonun hangi aşamada olduğunu gösteriyorr
    {
        Bekliyor,
        Yolda,
        TeslimEdildi
    }

    public interface ITakipEdilebilir    //Bu arayüzü implemente eden her sınıf , gönderi durumunu güncelleyebilmeli
    {
        void DurumGuncelle(Durum yeniDurum);
        void TakipBilgisiGoster();
    }

    public abstract class Kargo : ITakipEdilebilir   //  Bu abstract sınıf , hem yurtiçi hem de yurtdışı için ortak özellikleri barındırıyor

    {
        public string TakipNo { get; set; }
        public string Alici { get; set; }
        public Durum GonderiDurumu { get; set; }

        public Kargo(string takipNo, string alici, Durum durum)
        {
            TakipNo = takipNo;
            Alici = alici;
            GonderiDurumu = durum;
        }

        public abstract void DurumGuncelle(Durum yeniDurum);
        public abstract void TakipBilgisiGoster();
    }

    public class Yurtici : Kargo    // karg sınıfından kalıtım aldı
    {
        public Yurtici(string takipNo, string alici, Durum durum = Durum.Bekliyor)
            : base(takipNo, alici, durum) { }

        public override void DurumGuncelle(Durum yeniDurum)
        {
            GonderiDurumu = yeniDurum;
        }

        public override void TakipBilgisiGoster()   // override ederek mesaj kutusunda farklı mesaj gösteriyor
        {
            MessageBox.Show($"[YURTİÇİ] Takip No: {TakipNo}, Alıcı: {Alici}, Durum: {GonderiDurumu}");
        }
    }

    public class Yurtdisi : Kargo
    {
        public Yurtdisi(string takipNo, string alici, Durum durum = Durum.Bekliyor)
            : base(takipNo, alici, durum) { }

        public override void DurumGuncelle(Durum yeniDurum)
        {
            GonderiDurumu = yeniDurum;
        }

        public override void TakipBilgisiGoster()
        {
            MessageBox.Show($"[YURTDIŞI] Takip No: {TakipNo}, Alıcı: {Alici}, Durum: {GonderiDurumu}");
        }
    }

    public static class DosyaIslemleri   //bu sını verileri .txt dosyasına yazıyr ve oradan geri yüklüyor. Program kapatıldığında veriler silinmiyor
    {
        private static string dosyaYolu = "veriler.txt";

        public static void KargoListeyiDosyayaYaz(List<Kargo> kargoListesi)   // tüm verileri veriler.txt dosyasına yazar
        {
            using (StreamWriter sw = new StreamWriter(dosyaYolu))
            {
                foreach (Kargo kargo in kargoListesi)
                {
                    string tip = kargo is Yurtici ? "Yurtici" : "Yurtdisi";
                    sw.WriteLine($"{tip}|{kargo.TakipNo}|{kargo.Alici}|{kargo.GonderiDurumu}");
                }
            }
        }

        public static List<Kargo> DosyadanKargoListesiOku()   // bu metot dosyaya yazılmış verileri program tekrar açıldığında okuyup listeye aktarır
        {
            List<Kargo> kargoListesi = new List<Kargo>();

            if (File.Exists(dosyaYolu))
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                foreach (string satir in satirlar)
                {
                    string[] parcalar = satir.Split('|');
                    if (parcalar.Length == 4)
                    {
                        string tip = parcalar[0];
                        string takipNo = parcalar[1];
                        string alici = parcalar[2];
                        Durum durum = (Durum)Enum.Parse(typeof(Durum), parcalar[3]);

                        if (tip == "Yurtici")
                            kargoListesi.Add(new Yurtici(takipNo, alici, durum));
                        else if (tip == "Yurtdisi")
                            kargoListesi.Add(new Yurtdisi(takipNo, alici, durum));
                    }
                }
            }

            return kargoListesi;
        }
    }
}

