
namespace BBP201_210111409_Muhammed_Eren_Dibek
{
    partial class Personel_Kıdem_Tazminatı_Hesaplama_İşlemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel_Kıdem_Tazminatı_Hesaplama_İşlemleri));
            this.btn_kidem_hesapla = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_esas_ucret = new System.Windows.Forms.Label();
            this.lbl_damga_vergisi = new System.Windows.Forms.Label();
            this.lbl_net_tutar = new System.Windows.Forms.Label();
            this.btn_kidem_ekle = new System.Windows.Forms.Button();
            this.btn_kidem_sil = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dg_kidem = new System.Windows.Forms.DataGridView();
            this.btn_kidem_guncelle = new System.Windows.Forms.Button();
            this.lbl_kidem_gun = new System.Windows.Forms.Label();
            this.lbl_is_ayrilis = new System.Windows.Forms.Label();
            this.lbl_is_baslangic = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_brut_ucret = new System.Windows.Forms.Label();
            this.lbl_maas = new System.Windows.Forms.Label();
            this.lbl_yemek = new System.Windows.Forms.Label();
            this.lbl_yol = new System.Windows.Forms.Label();
            this.dt_is_baslangic_tarih = new System.Windows.Forms.DateTimePicker();
            this.dt_is_ayrilis_tarih = new System.Windows.Forms.DateTimePicker();
            this.gb_personel = new System.Windows.Forms.GroupBox();
            this.txt_yemek = new System.Windows.Forms.TextBox();
            this.txt_yol = new System.Windows.Forms.TextBox();
            this.txt_maas = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.cb_personel = new System.Windows.Forms.ComboBox();
            this.lbl_personel = new System.Windows.Forms.Label();
            this.gb_tazminat_bilgiler = new System.Windows.Forms.GroupBox();
            this.btn_kidem_tazminat_ode = new System.Windows.Forms.Button();
            this.gb_personel_ara = new System.Windows.Forms.GroupBox();
            this.lbl_ara = new System.Windows.Forms.Label();
            this.btn_ara = new System.Windows.Forms.Button();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.btn_kayitlar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_kidem)).BeginInit();
            this.gb_personel.SuspendLayout();
            this.gb_tazminat_bilgiler.SuspendLayout();
            this.gb_personel_ara.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_kidem_hesapla
            // 
            this.btn_kidem_hesapla.BackColor = System.Drawing.Color.White;
            this.btn_kidem_hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kidem_hesapla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kidem_hesapla.ImageKey = "3231991.png";
            this.btn_kidem_hesapla.ImageList = this.ımageList1;
            this.btn_kidem_hesapla.Location = new System.Drawing.Point(178, 371);
            this.btn_kidem_hesapla.Name = "btn_kidem_hesapla";
            this.btn_kidem_hesapla.Size = new System.Drawing.Size(308, 65);
            this.btn_kidem_hesapla.TabIndex = 16;
            this.btn_kidem_hesapla.Text = "KIDEM TAZMİNATI HESAPLA";
            this.btn_kidem_hesapla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kidem_hesapla.UseVisualStyleBackColor = false;
            this.btn_kidem_hesapla.Click += new System.EventHandler(this.btn_kidem_hesapla_Click);
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
            this.ımageList1.Images.SetKeyName(5, "3231991.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(61, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hesaplamaya Esas Gün:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = " Kıdem Tazminatı Esas Ücret:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(83, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Damga Vergisi Tutarı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(38, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Net Kıdem Tazminatı Tutarı:";
            // 
            // lbl_esas_ucret
            // 
            this.lbl_esas_ucret.AutoSize = true;
            this.lbl_esas_ucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_esas_ucret.Location = new System.Drawing.Point(297, 96);
            this.lbl_esas_ucret.Name = "lbl_esas_ucret";
            this.lbl_esas_ucret.Size = new System.Drawing.Size(15, 20);
            this.lbl_esas_ucret.TabIndex = 24;
            this.lbl_esas_ucret.Text = "-";
            // 
            // lbl_damga_vergisi
            // 
            this.lbl_damga_vergisi.AutoSize = true;
            this.lbl_damga_vergisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_damga_vergisi.Location = new System.Drawing.Point(297, 191);
            this.lbl_damga_vergisi.Name = "lbl_damga_vergisi";
            this.lbl_damga_vergisi.Size = new System.Drawing.Size(15, 20);
            this.lbl_damga_vergisi.TabIndex = 25;
            this.lbl_damga_vergisi.Text = "-";
            // 
            // lbl_net_tutar
            // 
            this.lbl_net_tutar.AutoSize = true;
            this.lbl_net_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_net_tutar.Location = new System.Drawing.Point(297, 240);
            this.lbl_net_tutar.Name = "lbl_net_tutar";
            this.lbl_net_tutar.Size = new System.Drawing.Size(15, 20);
            this.lbl_net_tutar.TabIndex = 26;
            this.lbl_net_tutar.Text = "-";
            // 
            // btn_kidem_ekle
            // 
            this.btn_kidem_ekle.BackColor = System.Drawing.Color.White;
            this.btn_kidem_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kidem_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kidem_ekle.ImageKey = "2484089.png";
            this.btn_kidem_ekle.ImageList = this.ımageList1;
            this.btn_kidem_ekle.Location = new System.Drawing.Point(6, 284);
            this.btn_kidem_ekle.Name = "btn_kidem_ekle";
            this.btn_kidem_ekle.Size = new System.Drawing.Size(138, 81);
            this.btn_kidem_ekle.TabIndex = 27;
            this.btn_kidem_ekle.Text = "EKLE";
            this.btn_kidem_ekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kidem_ekle.UseVisualStyleBackColor = false;
            this.btn_kidem_ekle.Click += new System.EventHandler(this.btn_kidem_ekle_Click);
            // 
            // btn_kidem_sil
            // 
            this.btn_kidem_sil.BackColor = System.Drawing.Color.White;
            this.btn_kidem_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kidem_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kidem_sil.ImageKey = "2939478.png";
            this.btn_kidem_sil.ImageList = this.ımageList1;
            this.btn_kidem_sil.Location = new System.Drawing.Point(150, 284);
            this.btn_kidem_sil.Name = "btn_kidem_sil";
            this.btn_kidem_sil.Size = new System.Drawing.Size(127, 81);
            this.btn_kidem_sil.TabIndex = 28;
            this.btn_kidem_sil.Text = "SİL";
            this.btn_kidem_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kidem_sil.UseVisualStyleBackColor = false;
            this.btn_kidem_sil.Click += new System.EventHandler(this.btn_kidem_sil_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(720, 591);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(411, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "PERSONEL KIDEM TAZMİNATI LİSTESİ";
            // 
            // dg_kidem
            // 
            this.dg_kidem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_kidem.Location = new System.Drawing.Point(251, 657);
            this.dg_kidem.Name = "dg_kidem";
            this.dg_kidem.RowHeadersWidth = 51;
            this.dg_kidem.RowTemplate.Height = 24;
            this.dg_kidem.Size = new System.Drawing.Size(1296, 238);
            this.dg_kidem.TabIndex = 30;
            this.dg_kidem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_kidem_CellDoubleClick);
            // 
            // btn_kidem_guncelle
            // 
            this.btn_kidem_guncelle.BackColor = System.Drawing.Color.White;
            this.btn_kidem_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kidem_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kidem_guncelle.ImageKey = "5300106.png";
            this.btn_kidem_guncelle.ImageList = this.ımageList1;
            this.btn_kidem_guncelle.Location = new System.Drawing.Point(283, 282);
            this.btn_kidem_guncelle.Name = "btn_kidem_guncelle";
            this.btn_kidem_guncelle.Size = new System.Drawing.Size(177, 81);
            this.btn_kidem_guncelle.TabIndex = 28;
            this.btn_kidem_guncelle.Text = "GÜNCELLE";
            this.btn_kidem_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kidem_guncelle.UseVisualStyleBackColor = false;
            this.btn_kidem_guncelle.Click += new System.EventHandler(this.btn_kidem_guncelle_Click);
            // 
            // lbl_kidem_gun
            // 
            this.lbl_kidem_gun.AutoSize = true;
            this.lbl_kidem_gun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kidem_gun.Location = new System.Drawing.Point(297, 51);
            this.lbl_kidem_gun.Name = "lbl_kidem_gun";
            this.lbl_kidem_gun.Size = new System.Drawing.Size(15, 20);
            this.lbl_kidem_gun.TabIndex = 35;
            this.lbl_kidem_gun.Text = "-";
            // 
            // lbl_is_ayrilis
            // 
            this.lbl_is_ayrilis.AutoSize = true;
            this.lbl_is_ayrilis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_is_ayrilis.Location = new System.Drawing.Point(49, 165);
            this.lbl_is_ayrilis.Name = "lbl_is_ayrilis";
            this.lbl_is_ayrilis.Size = new System.Drawing.Size(158, 20);
            this.lbl_is_ayrilis.TabIndex = 3;
            this.lbl_is_ayrilis.Text = "İşten Ayrılma Tarihi:";
            // 
            // lbl_is_baslangic
            // 
            this.lbl_is_baslangic.AutoSize = true;
            this.lbl_is_baslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_is_baslangic.Location = new System.Drawing.Point(49, 114);
            this.lbl_is_baslangic.Name = "lbl_is_baslangic";
            this.lbl_is_baslangic.Size = new System.Drawing.Size(154, 20);
            this.lbl_is_baslangic.TabIndex = 2;
            this.lbl_is_baslangic.Text = "İşe Başlama Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(31, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = " Kıdem Tazminatı Tutarı (Brüt):";
            // 
            // lbl_brut_ucret
            // 
            this.lbl_brut_ucret.AutoSize = true;
            this.lbl_brut_ucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_brut_ucret.Location = new System.Drawing.Point(297, 143);
            this.lbl_brut_ucret.Name = "lbl_brut_ucret";
            this.lbl_brut_ucret.Size = new System.Drawing.Size(15, 20);
            this.lbl_brut_ucret.TabIndex = 24;
            this.lbl_brut_ucret.Text = "-";
            // 
            // lbl_maas
            // 
            this.lbl_maas.AutoSize = true;
            this.lbl_maas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_maas.Location = new System.Drawing.Point(148, 219);
            this.lbl_maas.Name = "lbl_maas";
            this.lbl_maas.Size = new System.Drawing.Size(55, 20);
            this.lbl_maas.TabIndex = 10;
            this.lbl_maas.Text = "Maaş:";
            // 
            // lbl_yemek
            // 
            this.lbl_yemek.AutoSize = true;
            this.lbl_yemek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yemek.Location = new System.Drawing.Point(82, 328);
            this.lbl_yemek.Name = "lbl_yemek";
            this.lbl_yemek.Size = new System.Drawing.Size(121, 20);
            this.lbl_yemek.TabIndex = 10;
            this.lbl_yemek.Text = "Yemek Yardım:";
            // 
            // lbl_yol
            // 
            this.lbl_yol.AutoSize = true;
            this.lbl_yol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yol.Location = new System.Drawing.Point(109, 272);
            this.lbl_yol.Name = "lbl_yol";
            this.lbl_yol.Size = new System.Drawing.Size(94, 20);
            this.lbl_yol.TabIndex = 10;
            this.lbl_yol.Text = "Yol Yardım:";
            // 
            // dt_is_baslangic_tarih
            // 
            this.dt_is_baslangic_tarih.Enabled = false;
            this.dt_is_baslangic_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dt_is_baslangic_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_is_baslangic_tarih.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dt_is_baslangic_tarih.Location = new System.Drawing.Point(220, 109);
            this.dt_is_baslangic_tarih.Name = "dt_is_baslangic_tarih";
            this.dt_is_baslangic_tarih.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dt_is_baslangic_tarih.Size = new System.Drawing.Size(266, 27);
            this.dt_is_baslangic_tarih.TabIndex = 36;
            this.dt_is_baslangic_tarih.Value = new System.DateTime(2022, 4, 10, 22, 3, 0, 0);
            // 
            // dt_is_ayrilis_tarih
            // 
            this.dt_is_ayrilis_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dt_is_ayrilis_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_is_ayrilis_tarih.Location = new System.Drawing.Point(222, 160);
            this.dt_is_ayrilis_tarih.Name = "dt_is_ayrilis_tarih";
            this.dt_is_ayrilis_tarih.Size = new System.Drawing.Size(264, 27);
            this.dt_is_ayrilis_tarih.TabIndex = 37;
            // 
            // gb_personel
            // 
            this.gb_personel.Controls.Add(this.txt_yemek);
            this.gb_personel.Controls.Add(this.txt_yol);
            this.gb_personel.Controls.Add(this.txt_maas);
            this.gb_personel.Controls.Add(this.label_id);
            this.gb_personel.Controls.Add(this.cb_personel);
            this.gb_personel.Controls.Add(this.lbl_personel);
            this.gb_personel.Controls.Add(this.btn_kidem_hesapla);
            this.gb_personel.Controls.Add(this.dt_is_ayrilis_tarih);
            this.gb_personel.Controls.Add(this.dt_is_baslangic_tarih);
            this.gb_personel.Controls.Add(this.lbl_is_baslangic);
            this.gb_personel.Controls.Add(this.lbl_is_ayrilis);
            this.gb_personel.Controls.Add(this.lbl_maas);
            this.gb_personel.Controls.Add(this.lbl_yemek);
            this.gb_personel.Controls.Add(this.lbl_yol);
            this.gb_personel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_personel.Location = new System.Drawing.Point(256, 85);
            this.gb_personel.Name = "gb_personel";
            this.gb_personel.Size = new System.Drawing.Size(561, 469);
            this.gb_personel.TabIndex = 41;
            this.gb_personel.TabStop = false;
            this.gb_personel.Text = "Personel Bilgileri";
            // 
            // txt_yemek
            // 
            this.txt_yemek.Enabled = false;
            this.txt_yemek.Location = new System.Drawing.Point(220, 325);
            this.txt_yemek.Name = "txt_yemek";
            this.txt_yemek.Size = new System.Drawing.Size(264, 27);
            this.txt_yemek.TabIndex = 56;
            // 
            // txt_yol
            // 
            this.txt_yol.Enabled = false;
            this.txt_yol.Location = new System.Drawing.Point(220, 269);
            this.txt_yol.Name = "txt_yol";
            this.txt_yol.Size = new System.Drawing.Size(264, 27);
            this.txt_yol.TabIndex = 56;
            // 
            // txt_maas
            // 
            this.txt_maas.Enabled = false;
            this.txt_maas.Location = new System.Drawing.Point(220, 216);
            this.txt_maas.Name = "txt_maas";
            this.txt_maas.Size = new System.Drawing.Size(266, 27);
            this.txt_maas.TabIndex = 56;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(466, 51);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 20);
            this.label_id.TabIndex = 58;
            this.label_id.Text = "0";
            // 
            // cb_personel
            // 
            this.cb_personel.FormattingEnabled = true;
            this.cb_personel.Items.AddRange(new object[] {
            "Tüm Personeller"});
            this.cb_personel.Location = new System.Drawing.Point(178, 48);
            this.cb_personel.Name = "cb_personel";
            this.cb_personel.Size = new System.Drawing.Size(273, 28);
            this.cb_personel.TabIndex = 57;
            this.cb_personel.SelectedIndexChanged += new System.EventHandler(this.cb_personel_SelectedIndexChanged);
            // 
            // lbl_personel
            // 
            this.lbl_personel.AutoSize = true;
            this.lbl_personel.Location = new System.Drawing.Point(78, 51);
            this.lbl_personel.Name = "lbl_personel";
            this.lbl_personel.Size = new System.Drawing.Size(80, 20);
            this.lbl_personel.TabIndex = 56;
            this.lbl_personel.Text = "Personel:";
            // 
            // gb_tazminat_bilgiler
            // 
            this.gb_tazminat_bilgiler.Controls.Add(this.label3);
            this.gb_tazminat_bilgiler.Controls.Add(this.btn_kidem_tazminat_ode);
            this.gb_tazminat_bilgiler.Controls.Add(this.label2);
            this.gb_tazminat_bilgiler.Controls.Add(this.lbl_kidem_gun);
            this.gb_tazminat_bilgiler.Controls.Add(this.label8);
            this.gb_tazminat_bilgiler.Controls.Add(this.label4);
            this.gb_tazminat_bilgiler.Controls.Add(this.btn_kidem_ekle);
            this.gb_tazminat_bilgiler.Controls.Add(this.label6);
            this.gb_tazminat_bilgiler.Controls.Add(this.lbl_esas_ucret);
            this.gb_tazminat_bilgiler.Controls.Add(this.btn_kidem_guncelle);
            this.gb_tazminat_bilgiler.Controls.Add(this.lbl_brut_ucret);
            this.gb_tazminat_bilgiler.Controls.Add(this.btn_kidem_sil);
            this.gb_tazminat_bilgiler.Controls.Add(this.lbl_damga_vergisi);
            this.gb_tazminat_bilgiler.Controls.Add(this.lbl_net_tutar);
            this.gb_tazminat_bilgiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_tazminat_bilgiler.Location = new System.Drawing.Point(875, 85);
            this.gb_tazminat_bilgiler.Name = "gb_tazminat_bilgiler";
            this.gb_tazminat_bilgiler.Size = new System.Drawing.Size(672, 379);
            this.gb_tazminat_bilgiler.TabIndex = 42;
            this.gb_tazminat_bilgiler.TabStop = false;
            this.gb_tazminat_bilgiler.Text = "Kıdem Tazminat Bilgileri";
            // 
            // btn_kidem_tazminat_ode
            // 
            this.btn_kidem_tazminat_ode.BackColor = System.Drawing.Color.White;
            this.btn_kidem_tazminat_ode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kidem_tazminat_ode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kidem_tazminat_ode.ImageKey = "3231991.png";
            this.btn_kidem_tazminat_ode.ImageList = this.ımageList1;
            this.btn_kidem_tazminat_ode.Location = new System.Drawing.Point(466, 284);
            this.btn_kidem_tazminat_ode.Name = "btn_kidem_tazminat_ode";
            this.btn_kidem_tazminat_ode.Size = new System.Drawing.Size(200, 81);
            this.btn_kidem_tazminat_ode.TabIndex = 56;
            this.btn_kidem_tazminat_ode.Text = "TAZMİNAT ÖDE";
            this.btn_kidem_tazminat_ode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kidem_tazminat_ode.UseVisualStyleBackColor = false;
            this.btn_kidem_tazminat_ode.Click += new System.EventHandler(this.btn_kidem_tazminat_ode_Click);
            // 
            // gb_personel_ara
            // 
            this.gb_personel_ara.Controls.Add(this.lbl_ara);
            this.gb_personel_ara.Controls.Add(this.btn_ara);
            this.gb_personel_ara.Controls.Add(this.txt_ara);
            this.gb_personel_ara.Location = new System.Drawing.Point(875, 479);
            this.gb_personel_ara.Name = "gb_personel_ara";
            this.gb_personel_ara.Size = new System.Drawing.Size(672, 75);
            this.gb_personel_ara.TabIndex = 55;
            this.gb_personel_ara.TabStop = false;
            this.gb_personel_ara.Text = "Personel Arama";
            // 
            // lbl_ara
            // 
            this.lbl_ara.AutoSize = true;
            this.lbl_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ara.Location = new System.Drawing.Point(77, 32);
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
            this.btn_ara.Location = new System.Drawing.Point(513, 25);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(104, 35);
            this.btn_ara.TabIndex = 51;
            this.btn_ara.Text = "ARA";
            this.btn_ara.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ara.UseVisualStyleBackColor = false;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // txt_ara
            // 
            this.txt_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ara.Location = new System.Drawing.Point(204, 29);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(303, 27);
            this.txt_ara.TabIndex = 50;
            // 
            // btn_kayitlar
            // 
            this.btn_kayitlar.BackColor = System.Drawing.Color.White;
            this.btn_kayitlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayitlar.ImageKey = "6416106.png";
            this.btn_kayitlar.ImageList = this.ımageList1;
            this.btn_kayitlar.Location = new System.Drawing.Point(251, 577);
            this.btn_kayitlar.Name = "btn_kayitlar";
            this.btn_kayitlar.Size = new System.Drawing.Size(208, 56);
            this.btn_kayitlar.TabIndex = 57;
            this.btn_kayitlar.Text = "TÜM KAYITLAR";
            this.btn_kayitlar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kayitlar.UseVisualStyleBackColor = false;
            this.btn_kayitlar.Click += new System.EventHandler(this.btn_kayitlar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(247, 909);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Güncelleme için satıra çift tıkla, silmek için satır seç";
            // 
            // Personel_Kıdem_Tazminatı_Hesaplama_İşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1771, 938);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kayitlar);
            this.Controls.Add(this.gb_personel_ara);
            this.Controls.Add(this.gb_tazminat_bilgiler);
            this.Controls.Add(this.gb_personel);
            this.Controls.Add(this.dg_kidem);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Personel_Kıdem_Tazminatı_Hesaplama_İşlemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel_Kıdem_Tazminatı_Hesaplama_İşlemleri";
            this.Load += new System.EventHandler(this.Personel_Kıdem_Tazminatı_Hesaplama_İşlemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_kidem)).EndInit();
            this.gb_personel.ResumeLayout(false);
            this.gb_personel.PerformLayout();
            this.gb_tazminat_bilgiler.ResumeLayout(false);
            this.gb_tazminat_bilgiler.PerformLayout();
            this.gb_personel_ara.ResumeLayout(false);
            this.gb_personel_ara.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_kidem_hesapla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_esas_ucret;
        private System.Windows.Forms.Label lbl_damga_vergisi;
        private System.Windows.Forms.Label lbl_net_tutar;
        private System.Windows.Forms.Button btn_kidem_ekle;
        private System.Windows.Forms.Button btn_kidem_sil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dg_kidem;
        private System.Windows.Forms.Button btn_kidem_guncelle;
        private System.Windows.Forms.Label lbl_kidem_gun;
        private System.Windows.Forms.Label lbl_is_ayrilis;
        private System.Windows.Forms.Label lbl_is_baslangic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_brut_ucret;
        private System.Windows.Forms.Label lbl_maas;
        private System.Windows.Forms.Label lbl_yemek;
        private System.Windows.Forms.Label lbl_yol;
        private System.Windows.Forms.DateTimePicker dt_is_baslangic_tarih;
        private System.Windows.Forms.DateTimePicker dt_is_ayrilis_tarih;
        private System.Windows.Forms.GroupBox gb_personel;
        private System.Windows.Forms.GroupBox gb_tazminat_bilgiler;
        private System.Windows.Forms.GroupBox gb_personel_ara;
        private System.Windows.Forms.Label lbl_ara;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.ComboBox cb_personel;
        private System.Windows.Forms.Label lbl_personel;
        private System.Windows.Forms.TextBox txt_yemek;
        private System.Windows.Forms.TextBox txt_yol;
        private System.Windows.Forms.TextBox txt_maas;
        private System.Windows.Forms.Button btn_kidem_tazminat_ode;
        private System.Windows.Forms.Button btn_kayitlar;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label1;
    }
}