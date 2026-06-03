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
                
                Eserler yeniEser = new Eserler()
                {
                    EserAdı = txt_ad.Text, 

                    Yılı = Convert.ToInt32(txtyili.Text), 

                    
                    SanatciID = Convert.ToInt32(cmb_sanatci.SelectedValue),
                    KategoriID = Convert.ToInt32(cmb_kategori.SelectedValue), 
                    MuzeID = Convert.ToInt32(cmb_muze.SelectedValue)
                };

                
                db.Eserler.Add(yeniEser);

                
                db.SaveChanges();

               
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
                
                txt_ad.Text = dataGridView1.Rows[e.RowIndex].Cells["EserAdı"].Value.ToString();
                txtyili.Text = dataGridView1.Rows[e.RowIndex].Cells["YapımYılı"].Value.ToString();

                
                cmb_sanatci.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["SanatçıKodu"].Value;
                cmb_kategori.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["KategoriKodu"].Value;
                cmb_muze.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["MüzeKodu"].Value;
            }
        }

        private void btngncl_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (dataGridView1.CurrentRow != null)
                {
                    
                    int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["EserNo"].Value);

                    
                    Eserler guncellenecekEser = db.Eserler.Find(secilenId);

                    
                    if (guncellenecekEser != null)
                    {
                        
                        guncellenecekEser.EserAdı = txt_ad.Text;
                        guncellenecekEser.Yılı = Convert.ToInt32(txtyili.Text);

                        
                        guncellenecekEser.SanatciID = Convert.ToInt32(cmb_sanatci.SelectedValue);
                        guncellenecekEser.KategoriID = Convert.ToInt32(cmb_kategori.SelectedValue);
                        guncellenecekEser.MuzeID = Convert.ToInt32(cmb_muze.SelectedValue);

                        db.SaveChanges(); 
                        MessageBox.Show("Eser başarıyla güncellendi!"); 
                        btnlist.PerformClick();

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
                
                DialogResult sonuc = MessageBox.Show(
                    "Bu eseri silmek istediğinize emin misiniz?", 
                    "Silme Onayı", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question); 

                
                if (sonuc == DialogResult.Yes)
                {
                    
                    if (dataGridView1.CurrentRow != null)
                    {
                        
                        int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["EserNo"].Value);
                        Eserler silinecekEser = db.Eserler.Find(secilenId);

                        
                        if (silinecekEser != null)
                        {
                            
                            db.Eserler.Remove(silinecekEser);

                            
                            db.SaveChanges();
                            MessageBox.Show("Eser başarıyla silindi!", "Bilgi");

                            
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

            
            this.Hide();

            
            yeniForm.ShowDialog();

            
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                
                cmb_sanatci.DataSource = db.Sanatcılar
                    .OrderBy(s => s.Ad)
                    .Select(s => new
                    {
                        s.SanatciID,
                        GorunenIsim = s.Ad
                    }).ToList();
                cmb_sanatci.DisplayMember = "GorunenIsim";
                cmb_sanatci.ValueMember = "SanatciID";

                
                cmb_muze.DataSource = db.Muzeler
                    .OrderBy(m => m.MuzeAdı)
                    .Select(m => new
                    {
                        m.MuzeID,
                        GorunenIsim = m.MuzeAdı
                    }).ToList();
                cmb_muze.DisplayMember = "GorunenIsim";
                cmb_muze.ValueMember = "MuzeID";

                
                cmb_kategori.DataSource = db.Kategoriler
                    .OrderBy(k => k.TurAd)
                    .Select(k => new
                    {
                        k.KategoriID,
                        GorunenIsim = k.TurAd
                    }).ToList();
                cmb_kategori.DisplayMember = "GorunenIsim";
                cmb_kategori.ValueMember = "KategoriID";

               
                btnlist.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Açılır kutular yüklenirken hata: " + ex.Message);
            }
        }

        
    }
}
