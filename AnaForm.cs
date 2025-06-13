using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace kargoTakipSistemiii
{
    public partial class AnaForm : Form
    {
        List<Kargo> gonderiler = new List<Kargo>();   // gönderileri tutmak için bir liste oluşturduk, her oluşturulan kargo bu listede saklanıyor ve formda gösteriliyor


        private void AnaForm_Load(object sender, EventArgs e)
        {

           
        }


        public AnaForm()
        {
            InitializeComponent();
            cmbDurum.DataSource = Enum.GetValues(typeof(Durum));   // gönderi tipleri comboboxa eklenir 
            cmbTip.Items.Add("Yurtici");
            cmbTip.Items.Add("Yurtdisi");

            gonderiler = DosyaIslemleri.DosyadanKargoListesiOku();  // daha öncei kaytlar dosyadan okunur
            ListeyiYenile();  // girilen veriler datagridview e yüklenir
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            string takipNo = txtTakipNo.Text;
            string alici = txtAlici.Text;
            string tip = cmbTip.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(takipNo) || string.IsNullOrEmpty(alici) || string.IsNullOrEmpty(tip))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            if (gonderiler.Any(g => g.TakipNo == takipNo))   // aynı takip numarası varsa engeller
            {
                MessageBox.Show("Bu takip numarası zaten mevcut.");
                return;
            }

            Kargo gonderi;
            if (tip == "Yurtici")
                gonderi = new Yurtici(takipNo, alici);
            else
                gonderi = new Yurtdisi(takipNo, alici);

            gonderiler.Add(gonderi);
            DosyaIslemleri.KargoListeyiDosyayaYaz(gonderiler);
            ListeyiYenile();

            txtTakipNo.Clear();
            txtAlici.Clear();
            MessageBox.Show("Gönderi oluşturuldu.");

            ListeyiYenile(); // tabloyu günceller

        }

        private void btnDurumGuncelle_Click(object sender, EventArgs e)   // durumguncelle meetoddu ile enum değeri güncellenir , grid yeiden yüklenir
        {
            if (dgvKargolar.CurrentRow != null)
            {
                string takipNo = dgvKargolar.CurrentRow.Cells["Takip No"].Value.ToString();
                var g = gonderiler.FirstOrDefault(x => x.TakipNo == takipNo);

                if (g != null && cmbDurum.SelectedItem != null)
                {
                    Durum yeniDurum = (Durum)Enum.Parse(typeof(Durum), cmbDurum.SelectedItem.ToString());
                    g.DurumGuncelle(yeniDurum);
                    DosyaIslemleri.KargoListeyiDosyayaYaz(gonderiler);
                    ListeyiYenile();
                }
                else
                {
                    MessageBox.Show("Lütfen bir durum seçiniz.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir gönderi seçiniz.");
            }
        }

        private void btnSorgula_Click(object sender, EventArgs e)    // girilen takip numarası litede var mı yok mu ona bakar, gönderi yokssa uyarı verir
        {
            string takipNo = txtTakipNo.Text;

            foreach (var g in gonderiler)
            {
                if (g.TakipNo == takipNo)
                {
                    g.TakipBilgisiGoster();
                    return;
                }
            }

            MessageBox.Show("Gönderi bulunamadı.");
        }

        private void ListeyiYenile()    // her oluşturma , güncelleme veya dosyadan okuma işleminden sonra bu metot çağrılır
        {
            var tablo = new DataTable();
            tablo.Columns.Add("Takip No");
            tablo.Columns.Add("Alıcı");
            tablo.Columns.Add("Gönderi Durumu");
            tablo.Columns.Add("Tip");

            foreach (var g in gonderiler)
            {
                string tip = g is Yurtici ? "Yurtici" : "Yurtdisi";
                tablo.Rows.Add(g.TakipNo, g.Alici, g.GonderiDurumu.ToString(), tip);
            }

            dgvKargolar.DataSource = tablo;
        }
    }
}
