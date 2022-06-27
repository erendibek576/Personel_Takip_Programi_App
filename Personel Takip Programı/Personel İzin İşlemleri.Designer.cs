
namespace BBP201_210111409_Muhammed_Eren_Dibek
{
    partial class Personel_İzin_İşlemleri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel_İzin_İşlemleri));
            this.dg_izin = new System.Windows.Forms.DataGridView();
            this.lbl_personel_izin_liste = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.gb_izin = new System.Windows.Forms.GroupBox();
            this.dt_izin_bitis = new System.Windows.Forms.DateTimePicker();
            this.dt_izin_baslangic = new System.Windows.Forms.DateTimePicker();
            this.cb_izin_tur = new System.Windows.Forms.ComboBox();
            this.lbl_izin_bitis = new System.Windows.Forms.Label();
            this.lbl_izin_baslangic = new System.Windows.Forms.Label();
            this.lbl_izin_tur = new System.Windows.Forms.Label();
            this.gb_personel = new System.Windows.Forms.GroupBox();
            this.label_id = new System.Windows.Forms.Label();
            this.cb_personel = new System.Windows.Forms.ComboBox();
            this.lbl_personel = new System.Windows.Forms.Label();
            this.gb_personel_ara = new System.Windows.Forms.GroupBox();
            this.lbl_ara = new System.Windows.Forms.Label();
            this.btn_ara = new System.Windows.Forms.Button();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.btn_kayitlar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_izin)).BeginInit();
            this.gb_izin.SuspendLayout();
            this.gb_personel.SuspendLayout();
            this.gb_personel_ara.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_izin
            // 
            this.dg_izin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_izin.Location = new System.Drawing.Point(324, 541);
            this.dg_izin.Name = "dg_izin";
            this.dg_izin.RowHeadersWidth = 51;
            this.dg_izin.RowTemplate.Height = 24;
            this.dg_izin.Size = new System.Drawing.Size(1140, 254);
            this.dg_izin.TabIndex = 15;
            this.dg_izin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_izin_CellDoubleClick);
            // 
            // lbl_personel_izin_liste
            // 
            this.lbl_personel_izin_liste.AutoSize = true;
            this.lbl_personel_izin_liste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_personel_izin_liste.Location = new System.Drawing.Point(732, 474);
            this.lbl_personel_izin_liste.Name = "lbl_personel_izin_liste";
            this.lbl_personel_izin_liste.Size = new System.Drawing.Size(261, 25);
            this.lbl_personel_izin_liste.TabIndex = 14;
            this.lbl_personel_izin_liste.Text = "PERSONEL İZİN LİSTESİ";
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.White;
            this.btn_sil.FlatAppearance.BorderSize = 0;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sil.ImageKey = "2939478.png";
            this.btn_sil.ImageList = this.ımageList1;
            this.btn_sil.Location = new System.Drawing.Point(203, 221);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(104, 69);
            this.btn_sil.TabIndex = 13;
            this.btn_sil.Text = "SİL";
            this.btn_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "2484089.png");
            this.ımageList1.Images.SetKeyName(1, "2939478.png");
            this.ımageList1.Images.SetKeyName(2, "5300106.png");
            this.ımageList1.Images.SetKeyName(3, "6416106.png");
            this.ımageList1.Images.SetKeyName(4, "7795401.png");
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.White;
            this.btn_kaydet.FlatAppearance.BorderSize = 0;
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.ImageKey = "2484089.png";
            this.btn_kaydet.ImageList = this.ımageList1;
            this.btn_kaydet.Location = new System.Drawing.Point(30, 221);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(150, 69);
            this.btn_kaydet.TabIndex = 12;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.White;
            this.btn_guncelle.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guncelle.ImageKey = "5300106.png";
            this.btn_guncelle.ImageList = this.ımageList1;
            this.btn_guncelle.Location = new System.Drawing.Point(331, 221);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(194, 69);
            this.btn_guncelle.TabIndex = 12;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // gb_izin
            // 
            this.gb_izin.Controls.Add(this.dt_izin_bitis);
            this.gb_izin.Controls.Add(this.dt_izin_baslangic);
            this.gb_izin.Controls.Add(this.cb_izin_tur);
            this.gb_izin.Controls.Add(this.lbl_izin_bitis);
            this.gb_izin.Controls.Add(this.lbl_izin_baslangic);
            this.gb_izin.Controls.Add(this.lbl_izin_tur);
            this.gb_izin.Controls.Add(this.btn_kaydet);
            this.gb_izin.Controls.Add(this.btn_sil);
            this.gb_izin.Controls.Add(this.btn_guncelle);
            this.gb_izin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_izin.Location = new System.Drawing.Point(891, 115);
            this.gb_izin.Name = "gb_izin";
            this.gb_izin.Size = new System.Drawing.Size(578, 320);
            this.gb_izin.TabIndex = 44;
            this.gb_izin.TabStop = false;
            this.gb_izin.Text = "İzin Bilgileri";
            // 
            // dt_izin_bitis
            // 
            this.dt_izin_bitis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_izin_bitis.Location = new System.Drawing.Point(189, 151);
            this.dt_izin_bitis.Name = "dt_izin_bitis";
            this.dt_izin_bitis.Size = new System.Drawing.Size(336, 27);
            this.dt_izin_bitis.TabIndex = 16;
            // 
            // dt_izin_baslangic
            // 
            this.dt_izin_baslangic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_izin_baslangic.Location = new System.Drawing.Point(189, 94);
            this.dt_izin_baslangic.Name = "dt_izin_baslangic";
            this.dt_izin_baslangic.Size = new System.Drawing.Size(336, 27);
            this.dt_izin_baslangic.TabIndex = 15;
            // 
            // cb_izin_tur
            // 
            this.cb_izin_tur.FormattingEnabled = true;
            this.cb_izin_tur.Items.AddRange(new object[] {
            "izin türü",
            "Ücretsiz izin",
            "Ücretli izin",
            "Yıllık izin"});
            this.cb_izin_tur.Location = new System.Drawing.Point(189, 34);
            this.cb_izin_tur.Name = "cb_izin_tur";
            this.cb_izin_tur.Size = new System.Drawing.Size(336, 28);
            this.cb_izin_tur.TabIndex = 14;
            // 
            // lbl_izin_bitis
            // 
            this.lbl_izin_bitis.AutoSize = true;
            this.lbl_izin_bitis.Location = new System.Drawing.Point(101, 156);
            this.lbl_izin_bitis.Name = "lbl_izin_bitis";
            this.lbl_izin_bitis.Size = new System.Drawing.Size(79, 20);
            this.lbl_izin_bitis.TabIndex = 2;
            this.lbl_izin_bitis.Text = "İzin Bitiş:";
            // 
            // lbl_izin_baslangic
            // 
            this.lbl_izin_baslangic.AutoSize = true;
            this.lbl_izin_baslangic.Location = new System.Drawing.Point(61, 99);
            this.lbl_izin_baslangic.Name = "lbl_izin_baslangic";
            this.lbl_izin_baslangic.Size = new System.Drawing.Size(119, 20);
            this.lbl_izin_baslangic.TabIndex = 1;
            this.lbl_izin_baslangic.Text = "İzin Başlangıç:";
            // 
            // lbl_izin_tur
            // 
            this.lbl_izin_tur.AutoSize = true;
            this.lbl_izin_tur.Location = new System.Drawing.Point(87, 37);
            this.lbl_izin_tur.Name = "lbl_izin_tur";
            this.lbl_izin_tur.Size = new System.Drawing.Size(93, 20);
            this.lbl_izin_tur.TabIndex = 0;
            this.lbl_izin_tur.Text = "İzin Türleri:";
            // 
            // gb_personel
            // 
            this.gb_personel.Controls.Add(this.label_id);
            this.gb_personel.Controls.Add(this.cb_personel);
            this.gb_personel.Controls.Add(this.lbl_personel);
            this.gb_personel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_personel.Location = new System.Drawing.Point(334, 115);
            this.gb_personel.Name = "gb_personel";
            this.gb_personel.Size = new System.Drawing.Size(551, 122);
            this.gb_personel.TabIndex = 49;
            this.gb_personel.TabStop = false;
            this.gb_personel.Text = "Personel Bilgileri";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(441, 55);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 20);
            this.label_id.TabIndex = 55;
            this.label_id.Text = "0";
            // 
            // cb_personel
            // 
            this.cb_personel.FormattingEnabled = true;
            this.cb_personel.Items.AddRange(new object[] {
            "Tüm Personeller"});
            this.cb_personel.Location = new System.Drawing.Point(153, 52);
            this.cb_personel.Name = "cb_personel";
            this.cb_personel.Size = new System.Drawing.Size(273, 28);
            this.cb_personel.TabIndex = 3;
            this.cb_personel.SelectedIndexChanged += new System.EventHandler(this.cb_personel_SelectedIndexChanged);
            // 
            // lbl_personel
            // 
            this.lbl_personel.AutoSize = true;
            this.lbl_personel.Location = new System.Drawing.Point(53, 55);
            this.lbl_personel.Name = "lbl_personel";
            this.lbl_personel.Size = new System.Drawing.Size(80, 20);
            this.lbl_personel.TabIndex = 2;
            this.lbl_personel.Text = "Personel:";
            // 
            // gb_personel_ara
            // 
            this.gb_personel_ara.Controls.Add(this.lbl_ara);
            this.gb_personel_ara.Controls.Add(this.btn_ara);
            this.gb_personel_ara.Controls.Add(this.txt_ara);
            this.gb_personel_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_personel_ara.Location = new System.Drawing.Point(324, 327);
            this.gb_personel_ara.Name = "gb_personel_ara";
            this.gb_personel_ara.Size = new System.Drawing.Size(561, 108);
            this.gb_personel_ara.TabIndex = 55;
            this.gb_personel_ara.TabStop = false;
            this.gb_personel_ara.Text = "Personel Arama";
            // 
            // lbl_ara
            // 
            this.lbl_ara.AutoSize = true;
            this.lbl_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ara.Location = new System.Drawing.Point(15, 49);
            this.lbl_ara.Name = "lbl_ara";
            this.lbl_ara.Size = new System.Drawing.Size(111, 20);
            this.lbl_ara.TabIndex = 49;
            this.lbl_ara.Text = "Personel Ara:";
            // 
            // btn_ara
            // 
            this.btn_ara.BackColor = System.Drawing.Color.White;
            this.btn_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ara.ImageKey = "7795401.png";
            this.btn_ara.ImageList = this.ımageList1;
            this.btn_ara.Location = new System.Drawing.Point(413, 40);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(128, 38);
            this.btn_ara.TabIndex = 51;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = false;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // txt_ara
            // 
            this.txt_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ara.Location = new System.Drawing.Point(142, 46);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(265, 27);
            this.txt_ara.TabIndex = 50;
            // 
            // btn_kayitlar
            // 
            this.btn_kayitlar.BackColor = System.Drawing.Color.White;
            this.btn_kayitlar.CausesValidation = false;
            this.btn_kayitlar.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_kayitlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayitlar.ImageKey = "6416106.png";
            this.btn_kayitlar.ImageList = this.ımageList1;
            this.btn_kayitlar.Location = new System.Drawing.Point(324, 457);
            this.btn_kayitlar.Name = "btn_kayitlar";
            this.btn_kayitlar.Size = new System.Drawing.Size(209, 63);
            this.btn_kayitlar.TabIndex = 56;
            this.btn_kayitlar.Text = "TÜM KAYITLAR";
            this.btn_kayitlar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kayitlar.UseVisualStyleBackColor = false;
            this.btn_kayitlar.Click += new System.EventHandler(this.btn_kayitlar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(320, 807);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Güncelleme için satıra çift tıkla, silmek için satır seç";
            // 
            // Personel_İzin_İşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1660, 836);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kayitlar);
            this.Controls.Add(this.gb_personel_ara);
            this.Controls.Add(this.gb_personel);
            this.Controls.Add(this.gb_izin);
            this.Controls.Add(this.dg_izin);
            this.Controls.Add(this.lbl_personel_izin_liste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Personel_İzin_İşlemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel_İzin_İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Personel_İzin_İşlemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_izin)).EndInit();
            this.gb_izin.ResumeLayout(false);
            this.gb_izin.PerformLayout();
            this.gb_personel.ResumeLayout(false);
            this.gb_personel.PerformLayout();
            this.gb_personel_ara.ResumeLayout(false);
            this.gb_personel_ara.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_izin;
        private System.Windows.Forms.Label lbl_personel_izin_liste;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.GroupBox gb_izin;
        private System.Windows.Forms.GroupBox gb_personel;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.ComboBox cb_personel;
        private System.Windows.Forms.Label lbl_personel;
        private System.Windows.Forms.GroupBox gb_personel_ara;
        private System.Windows.Forms.Label lbl_ara;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.Label lbl_izin_bitis;
        private System.Windows.Forms.Label lbl_izin_baslangic;
        private System.Windows.Forms.Label lbl_izin_tur;
        private System.Windows.Forms.DateTimePicker dt_izin_bitis;
        private System.Windows.Forms.DateTimePicker dt_izin_baslangic;
        private System.Windows.Forms.ComboBox cb_izin_tur;
        private System.Windows.Forms.Button btn_kayitlar;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label1;
    }
}