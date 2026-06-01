using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;




namespace MuzeOtomasyonu2
{
    public partial class Form_EserIslemleri : Form
    {
        public Form_EserIslemleri()
        {
            InitializeComponent();
        }

        MuzeDbContext db = new MuzeDbContext();


        private void btn_listele_Click_1(object sender, EventArgs e)
        {
            try
            {
                // 1. Verileri birleştir (.Include) ve sütunları Türkçe isimlendir (.Select)
                var list = db.Eserler
                    .Include("Kategori")
                    .Include("Sanatci")
                    .Include("Muze")
                    .Select(x => new
                    {
                        EserNo = x.EserID,
                        EserAdı = x.EserAdı,
                        ÇıkışYılı = x.Yılı,
                        Sanatcılar = x.Sanatci.Ad,
                        Kategori = x.Kategori.TurAd,
                        Müze = x.Muze.MuzeAdı
                    })
                    .ToList();

                // 2. Özel listeyi DataGridView'a bağla
                dataGridView1.DataSource = list;

                // 3. Sütunların ekranı tam kaplamasını sağla
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show("Asıl Hata: " + ex.InnerException.Message);
                }
                else
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void Form_EserIslemleri_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. KATEGORİLERİ YÜKLEME (cmb_kategori)
                cmb_kategori.DataSource = db.Kategoriler
                    .OrderBy(k => k.TurAd) // İsme göre A-Z sırala
                    .Select(k => new
                    {
                        k.KategoriID,
                        GorunenIsim = k.TurAd
                    }).ToList();
                cmb_kategori.DisplayMember = "GorunenIsim"; // Kullanıcının göreceği metin
                cmb_kategori.ValueMember = "KategoriID";    // Arka planda tutulan ID

                // 2. SANATÇILARI YÜKLEME (cmb_sanatci)
                cmb_sanatci.DataSource = db.Sanatcılar
                    .OrderBy(s => s.Ad)
                    .Select(s => new
                    {
                        s.SanatciID,
                        GorunenIsim = s.Ad
                    }).ToList();
                cmb_sanatci.DisplayMember = "GorunenIsim";
                cmb_sanatci.ValueMember = "SanatciID";

                // 3. MÜZELERİ YÜKLEME (cmb_muze)
                cmb_muze.DataSource = db.Muzeler
                    .OrderBy(m => m.MuzeAdı)
                    .Select(m => new
                    {
                        m.MuzeID,
                        GorunenIsim = m.MuzeAdı
                    }).ToList();
                cmb_muze.DisplayMember = "GorunenIsim";
                cmb_muze.ValueMember = "MuzeID";

                // Form açılır açılmaz tablo da dolsun diye listeleme butonuna otomatik tıklatıyoruz:
                btn_listele.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Açılır kutular yüklenirken hata: " + ex.Message);
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Yeni bir Eser kaydı oluşturuyoruz
                Eserler yeniEser = new Eserler();

                // 2. Formda Textbox olmadığı için SQL'in hata vermesini engelliyoruz
                // Bu değerleri otomatik olarak biz atıyoruz:
                yeniEser.EserAdı = "Belirtilmeyen Eser";
                yeniEser.Yılı = 2024;

                // 3. Ekranda var olan ComboBox'lardan seçilen gizli ID'leri alıyoruz
                yeniEser.KategoriID = (int)cmb_kategori.SelectedValue;
                yeniEser.SanatciID = (int)cmb_sanatci.SelectedValue;
                yeniEser.MuzeID = (int)cmb_muze.SelectedValue;

                // 4. Veritabanına ekle ve kaydet
                db.Eserler.Add(yeniEser);
                db.SaveChanges();

                MessageBox.Show("Yeni eser başarıyla eklendi!");

                // Tabloyu anında güncellemek için listele butonuna kodla tıklatıyoruz
                btn_listele.PerformClick();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show("Asıl Hata: " + ex.InnerException.Message);
                }
                else
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kullanıcıdan silme onayı alıyoruz
                DialogResult sonuc = MessageBox.Show("Bu eseri silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // 2. Kullanıcı "Evet" (Yes) butonuna bastıysa işlemlere başla
                if (sonuc == DialogResult.Yes)
                {
                    // Tabloda gerçekten bir satır seçilmiş mi diye kontrol ediyoruz
                    if (dataGridView1.CurrentRow != null)
                    {
                        // ÇOK ÖNEMLİ: Listeleme kodunda ID sütununa "EserNo" adını vermiştik. O yüzden buradan çekiyoruz.
                        int secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["EserNo"].Value);

                        // Veritabanından o ID'ye sahip eseri buluyoruz
                        var silinecekEser = db.Eserler.Find(secilenID);

                        // Eğer eser veritabanında gerçekten varsa sil
                        if (silinecekEser != null)
                        {
                            db.Eserler.Remove(silinecekEser); // Listeden çıkar
                            db.SaveChanges();                 // Veritabanına kalıcı olarak kaydet

                            MessageBox.Show("Eser başarıyla silindi.");

                            // Tablonun son halini görmek için listele butonuna otomatik tıklatıyoruz
                            btn_listele.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Silinecek kayıt veritabanında bulunamadı.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen silmek için önce tablodan bir eserin üzerine tıklayın.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi sırasında hata oluştu: " + ex.Message);
            }
        }

        private void rd_1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // Eğer radioButton1 seçiliyse işlem yap
                if (rd_1.Checked)
                {
                    // Eserler tablosunu sanatçıya göre grupla
                    var result = db.Eserler
                        .GroupBy(x => new
                        {
                            x.Sanatci.SanatciID,
                            x.Sanatci.Ad
                        })
                        // Her grup için sanatçı adı ve toplam eser sayısını al
                        .Select(g => new
                        {
                            SanatciAdi = g.Key.Ad,
                            TotalCount = g.Count()
                        })
                        // Eser sayısına göre azalan sırala (en çok eser veren en üstte)
                        .OrderByDescending(x => x.TotalCount)
                        // En çok eseri olan sanatçıyı al
                        .FirstOrDefault();

                    // Eğer sonuç varsa label1'e yaz
                    if (result != null)
                    {
                        // Hocanın istediği $ string formatı
                        lbl_1.Text = $"{result.SanatciAdi} adlı sanatçı {result.TotalCount} eser üretmiş";
                    }
                    else
                    {
                        lbl_1.Text = "Kayıt bulunamadı.";
                    }
                }
            }
            catch (Exception ex)
            {
                // Hocanın istediği hata formatı
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void rd_2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // Eğer radioButton2 seçiliyse işlem yap
                if (rd_2.Checked)
                {
                    // Eserler tablosunu, ilişkili Müze bilgisiyle dahil edip Müzeye göre grupla
                    var result = db.Eserler
                        .Include("Muze") // Hocanın Include mantığı: Müze tablosuna eriştik
                        .GroupBy(x => new
                        {
                            x.Muze.MuzeID,
                            x.Muze.MuzeAdı
                        })
                        // Her grup için müze adını ve o müzedeki EN ESKİ eserin yılını al (Sum yerine Min)
                        .Select(g => new
                        {
                            MuzeAdi = g.Key.MuzeAdı,
                            EnEskiYil = g.Min(x => x.Yılı)
                        })
                        // Yılı en küçük olanı (en eskiyi) en üste al (Ascending sıralama)
                        .OrderBy(x => x.EnEskiYil)
                        // En eski esere sahip olan müzeyi al
                        .FirstOrDefault();

                    // Eğer sonuç varsa label2'ye yaz
                    if (result != null)
                    {
                        // Hocanın istediği $ string formatı
                        lbl_2.Text = $"{result.MuzeAdi} müzesindeki en eski eser {result.EnEskiYil} yılına ait.";
                    }
                    else
                    {
                        lbl_2.Text = "Kayıt bulunamadı.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }
    }
}

