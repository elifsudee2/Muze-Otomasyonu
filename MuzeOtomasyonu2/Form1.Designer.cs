namespace MuzeOtomasyonu2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngncl = new System.Windows.Forms.Button();
            this.btnlist = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_kategori = new System.Windows.Forms.Label();
            this.cmb_kategori = new System.Windows.Forms.ComboBox();
            this.cmb_muze = new System.Windows.Forms.ComboBox();
            this.cmb_sanatci = new System.Windows.Forms.ComboBox();
            this.txtyili = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_muze = new System.Windows.Forms.Label();
            this.txt_sanatci = new System.Windows.Forms.Label();
            this.txt_yil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_form_gecis = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.OldLace;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(30, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1232, 303);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Wheat;
            this.btnekle.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnekle.ForeColor = System.Drawing.Color.Black;
            this.btnekle.Location = new System.Drawing.Point(56, 37);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(95, 50);
            this.btnekle.TabIndex = 1;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Wheat;
            this.btnsil.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsil.ForeColor = System.Drawing.Color.Black;
            this.btnsil.Location = new System.Drawing.Point(56, 250);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(95, 42);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngncl
            // 
            this.btngncl.BackColor = System.Drawing.Color.Wheat;
            this.btngncl.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngncl.ForeColor = System.Drawing.Color.Black;
            this.btngncl.Location = new System.Drawing.Point(56, 187);
            this.btngncl.Name = "btngncl";
            this.btngncl.Size = new System.Drawing.Size(112, 44);
            this.btngncl.TabIndex = 3;
            this.btngncl.Text = "GÜNCELLE";
            this.btngncl.UseVisualStyleBackColor = false;
            this.btngncl.Click += new System.EventHandler(this.btngncl_Click);
            // 
            // btnlist
            // 
            this.btnlist.BackColor = System.Drawing.Color.Wheat;
            this.btnlist.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlist.ForeColor = System.Drawing.Color.Black;
            this.btnlist.Location = new System.Drawing.Point(56, 108);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(95, 48);
            this.btnlist.TabIndex = 4;
            this.btnlist.Text = "LİSTELE";
            this.btnlist.UseVisualStyleBackColor = false;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_kategori);
            this.groupBox1.Controls.Add(this.cmb_kategori);
            this.groupBox1.Controls.Add(this.cmb_muze);
            this.groupBox1.Controls.Add(this.cmb_sanatci);
            this.groupBox1.Controls.Add(this.txtyili);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Controls.Add(this.txt_muze);
            this.groupBox1.Controls.Add(this.txt_sanatci);
            this.groupBox1.Controls.Add(this.txt_yil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(69, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 350);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eser Bilgileri";
            // 
            // txt_kategori
            // 
            this.txt_kategori.AutoSize = true;
            this.txt_kategori.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txt_kategori.Location = new System.Drawing.Point(29, 285);
            this.txt_kategori.Name = "txt_kategori";
            this.txt_kategori.Size = new System.Drawing.Size(74, 23);
            this.txt_kategori.TabIndex = 9;
            this.txt_kategori.Text = "Kategori";
            // 
            // cmb_kategori
            // 
            this.cmb_kategori.BackColor = System.Drawing.Color.OldLace;
            this.cmb_kategori.FormattingEnabled = true;
            this.cmb_kategori.Location = new System.Drawing.Point(137, 282);
            this.cmb_kategori.Name = "cmb_kategori";
            this.cmb_kategori.Size = new System.Drawing.Size(183, 31);
            this.cmb_kategori.TabIndex = 8;
            // 
            // cmb_muze
            // 
            this.cmb_muze.BackColor = System.Drawing.Color.OldLace;
            this.cmb_muze.FormattingEnabled = true;
            this.cmb_muze.Location = new System.Drawing.Point(137, 219);
            this.cmb_muze.Name = "cmb_muze";
            this.cmb_muze.Size = new System.Drawing.Size(230, 31);
            this.cmb_muze.TabIndex = 7;
            // 
            // cmb_sanatci
            // 
            this.cmb_sanatci.BackColor = System.Drawing.Color.OldLace;
            this.cmb_sanatci.FormattingEnabled = true;
            this.cmb_sanatci.Location = new System.Drawing.Point(137, 158);
            this.cmb_sanatci.Name = "cmb_sanatci";
            this.cmb_sanatci.Size = new System.Drawing.Size(230, 31);
            this.cmb_sanatci.TabIndex = 6;
            // 
            // txtyili
            // 
            this.txtyili.BackColor = System.Drawing.Color.OldLace;
            this.txtyili.Location = new System.Drawing.Point(137, 105);
            this.txtyili.Name = "txtyili";
            this.txtyili.Size = new System.Drawing.Size(230, 30);
            this.txtyili.TabIndex = 5;
            // 
            // txt_ad
            // 
            this.txt_ad.BackColor = System.Drawing.Color.OldLace;
            this.txt_ad.Location = new System.Drawing.Point(137, 50);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(230, 30);
            this.txt_ad.TabIndex = 4;
            // 
            // txt_muze
            // 
            this.txt_muze.AutoSize = true;
            this.txt_muze.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_muze.Location = new System.Drawing.Point(39, 222);
            this.txt_muze.Name = "txt_muze";
            this.txt_muze.Size = new System.Drawing.Size(52, 23);
            this.txt_muze.TabIndex = 3;
            this.txt_muze.Text = "Müze";
            // 
            // txt_sanatci
            // 
            this.txt_sanatci.AutoSize = true;
            this.txt_sanatci.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_sanatci.Location = new System.Drawing.Point(29, 166);
            this.txt_sanatci.Name = "txt_sanatci";
            this.txt_sanatci.Size = new System.Drawing.Size(65, 23);
            this.txt_sanatci.TabIndex = 2;
            this.txt_sanatci.Text = "Sanatçı";
            // 
            // txt_yil
            // 
            this.txt_yil.AutoSize = true;
            this.txt_yil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_yil.Location = new System.Drawing.Point(20, 108);
            this.txt_yil.Name = "txt_yil";
            this.txt_yil.Size = new System.Drawing.Size(82, 23);
            this.txt_yil.TabIndex = 1;
            this.txt_yil.Text = "Yapım Yılı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(29, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eser Adı";
            // 
            // btn_form_gecis
            // 
            this.btn_form_gecis.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_form_gecis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_form_gecis.Location = new System.Drawing.Point(52, 118);
            this.btn_form_gecis.Name = "btn_form_gecis";
            this.btn_form_gecis.Size = new System.Drawing.Size(157, 35);
            this.btn_form_gecis.TabIndex = 6;
            this.btn_form_gecis.Text = "Eser Detay İşlemleri";
            this.btn_form_gecis.UseVisualStyleBackColor = true;
            this.btn_form_gecis.Click += new System.EventHandler(this.btn_form_gecis_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_form_gecis);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(974, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 255);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FORMLARA GEÇİŞ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnekle);
            this.groupBox3.Controls.Add(this.btnsil);
            this.groupBox3.Controls.Add(this.btngncl);
            this.groupBox3.Controls.Add(this.btnlist);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(686, 363);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 309);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hızlı Eylemler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1396, 737);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngncl;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtyili;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label txt_muze;
        private System.Windows.Forms.Label txt_sanatci;
        private System.Windows.Forms.Label txt_yil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_kategori;
        private System.Windows.Forms.ComboBox cmb_kategori;
        private System.Windows.Forms.ComboBox cmb_muze;
        private System.Windows.Forms.ComboBox cmb_sanatci;
        private System.Windows.Forms.Button btn_form_gecis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

