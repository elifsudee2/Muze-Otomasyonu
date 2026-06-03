using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MuzeOtomasyonu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MuzeDbContext db = new MuzeDbContext();

        private void btnlist_Click(object sender, EventArgs e)
        {
            try
            {
                // Select komutu ile o boş gelen köprü sütunlarını iptal edip, sadece ID rakamlarını alıyoruz
                var list = db.Eserler
                    .Select(x => new
                    {
                        EserNo = x.EserID,
                        EserAdı = x.EserAdı,
                        YapımYılı = x.Yılı,
                        SanatçıKodu = x.SanatciID,
                        KategoriKodu = x.KategoriID,
                        MüzeKodu = x.MuzeID
                    }).ToList();

                // DataGridView'a bağla ve ekranı kapla
                dataGridView1.DataSource = list;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası: " + ex.Message);
            }

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Yeni bir Eser nesnesi (instance) üretiyoruz ve içini formdaki araçlardan dolduruyoruz
                Eserler yeniEser = new Eserler()
                {
                    EserAdı = txt_ad.Text, // Metin kutusundan gelen direkt string

                    Yılı = Convert.ToInt32(txtyili.Text), // int olduğu için sayıya çeviriyoruz

                    // ComboBox'lardan seçilen verilerin arka plandaki ID'sini (SelectedValue) alıp sayıya çeviriyoruz
                    SanatciID = Convert.ToInt32(cmb_sanatci.SelectedValue),
                    KategoriID = Convert.ToInt32(cmb_kategori.SelectedValue), // Senin bahsettiğin cmb_kategori
                    MuzeID = Convert.ToInt32(cmb_muze.SelectedValue)
                };

                // 2. Oluşturduğumuz bu yeni eseri veritabanındaki Eserler tablomuza ekliyoruz
                db.Eserler.Add(yeniEser);

                // 3. Değişiklikleri kaydediyoruz (Hocanın da özellikle belirttiği SaveChanges metodu)
                db.SaveChanges();

                // 4. Kullanıcıya başarılı olduğuna dair mesaj veriyoruz
                MessageBox.Show("Yeni eser başarıyla eklendi!", "Bilgi");

                btnlist.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Metin kutularını doldur
                txt_ad.Text = dataGridView1.Rows[e.RowIndex].Cells["EserAdı"].Value.ToString();
                txtyili.Text = dataGridView1.Rows[e.RowIndex].Cells["YapımYılı"].Value.ToString();

                // ComboBox'ları ID (rakam) değerlerine göre otomatik seçtir (Çok daha profesyonel yöntem)
                cmb_sanatci.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["SanatçıKodu"].Value;
                cmb_kategori.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["KategoriKodu"].Value;
                cmb_muze.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["MüzeKodu"].Value;
            }
        }

        private void btngncl_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Önce kullanıcının tablodan bir satır seçip seçmediğini kontrol ediyoruz
                if (dataGridView1.CurrentRow != null)
                {
                    // 2. Seçili satırdaki gizli "EserID" değerini alıyoruz
                    int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["EserNo"].Value);

                    // 3. Veritabanında o ID'ye sahip olan eseri buluyoruz (Find metodu)
                    Eserler guncellenecekEser = db.Eserler.Find(secilenId);

                    // 4. Eğer veritabanında o eser gerçekten varsa güncelleme işlemini başlatıyoruz
                    if (guncellenecekEser != null)
                    {
                        // Veritabanındaki eski verilerin üzerine formdaki yeni verileri yazıyoruz
                        guncellenecekEser.EserAdı = txt_ad.Text;
                        guncellenecekEser.Yılı = Convert.ToInt32(txtyili.Text);

                        // ComboBox'lardan gelen ID değerlerini de güncelliyoruz
                        guncellenecekEser.SanatciID = Convert.ToInt32(cmb_sanatci.SelectedValue);
                        guncellenecekEser.KategoriID = Convert.ToInt32(cmb_kategori.SelectedValue);
                        guncellenecekEser.MuzeID = Convert.ToInt32(cmb_muze.SelectedValue);

                        db.SaveChanges(); // bu kodla güncelleme işlemi gerçekleştiriliyor.
                        MessageBox.Show("Eser başarıyla güncellendi!"); // bu kodla, güncelleme işlemi başarılıysa eğer mesaj verilir.
                        btnlist.PerformClick(); // bu kodla da güncelleme işleminden sonra yeni değerler listelenir.

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Önce kullanıcıya silmek istediğinden emin olup olmadığını soruyoruz
                DialogResult sonuc = MessageBox.Show(
                    "Bu eseri silmek istediğinize emin misiniz?", // Soru metni
                    "Silme Onayı", // Pencere başlığı
                    MessageBoxButtons.YesNo, // Evet ve Hayır butonları
                    MessageBoxIcon.Question); // Soru işareti simgesi

                // 2. Eğer kullanıcı "Evet" (Yes) butonuna bastıysa silme işlemlerini başlatıyoruz
                if (sonuc == DialogResult.Yes)
                {
                    // 3. Tabloda gerçekten bir satır seçilmiş mi kontrol ediyoruz (Güncellemedeki gibi)
                    if (dataGridView1.CurrentRow != null)
                    {
                        // 4. Seçili satırdaki gizli "EserID" değerini alıp veritabanında buluyoruz
                        int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["EserNo"].Value);
                        Eserler silinecekEser = db.Eserler.Find(secilenId);

                        // 5. Eğer veritabanında o eser bulunduysa silme işlemini yapıyoruz
                        if (silinecekEser != null)
                        {
                            // Eseri veritabanından kaldırıyoruz (Add yerine Remove kullanıyoruz)
                            db.Eserler.Remove(silinecekEser);

                            // Hocanın PDF'inin devamında (son sayfada yazdığı gibi) değişiklikleri kaydedip mesaj veriyoruz
                            db.SaveChanges();
                            MessageBox.Show("Eser başarıyla silindi!", "Bilgi");

                            // Listeyi anında yeniliyoruz ki silinen satır ekrandan da kaybolsun
                            btnlist.PerformClick();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void btn_form_gecis_Click(object sender, EventArgs e)
        {
            Form_EserIslemleri yeniForm = new Form_EserIslemleri();

            // 2. Mevcut ana formu gizle
            this.Hide();

            // 3. Yeni formu aç ve kullanıcı o formu kapatana kadar bekle
            yeniForm.ShowDialog();

            // 4. Yeni form kapatıldığında ana formu tekrar göster
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. SANATÇILARI YÜKLEME
                // (Eğer ComboBox ismin farklıysa comboBox1 yazan yerleri kendi isminle değiştir)
                cmb_sanatci.DataSource = db.Sanatcılar
                    .OrderBy(s => s.Ad)
                    .Select(s => new
                    {
                        s.SanatciID,
                        GorunenIsim = s.Ad
                    }).ToList();
                cmb_sanatci.DisplayMember = "GorunenIsim";
                cmb_sanatci.ValueMember = "SanatciID";

                // 2. MÜZELERİ YÜKLEME
                // (Eğer ComboBox ismin farklıysa comboBox2 yazan yerleri kendi isminle değiştir)
                cmb_muze.DataSource = db.Muzeler
                    .OrderBy(m => m.MuzeAdı)
                    .Select(m => new
                    {
                        m.MuzeID,
                        GorunenIsim = m.MuzeAdı
                    }).ToList();
                cmb_muze.DisplayMember = "GorunenIsim";
                cmb_muze.ValueMember = "MuzeID";

                // 3. KATEGORİLERİ YÜKLEME
                // (Eğer ComboBox ismin farklıysa comboBox3 yazan yerleri kendi isminle değiştir)
                cmb_kategori.DataSource = db.Kategoriler
                    .OrderBy(k => k.TurAd)
                    .Select(k => new
                    {
                        k.KategoriID,
                        GorunenIsim = k.TurAd
                    }).ToList();
                cmb_kategori.DisplayMember = "GorunenIsim";
                cmb_kategori.ValueMember = "KategoriID";

                // Form açılır açılmaz tablo dolsun diye listeleme butonuna otomatik tıklatıyoruz
                // Eğer listele butonunun adı farklıysa (örn: btnListele) onu yazmalısın.
                btnlist.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Açılır kutular yüklenirken hata: " + ex.Message);
            }
        }

        
    }
}
