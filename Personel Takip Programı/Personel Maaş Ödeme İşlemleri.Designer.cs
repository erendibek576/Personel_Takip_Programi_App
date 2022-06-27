
namespace BBP201_210111409_Muhammed_Eren_Dibek
{
    partial class Personel_Maaş_Hesaplama_İşlemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel_Maaş_Hesaplama_İşlemleri));
            this.cb_yil = new System.Windows.Forms.ComboBox();
            this.cb_ay = new System.Windows.Forms.ComboBox();
            this.dg_maas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_maas_odeme_ekle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gb_personel = new System.Windows.Forms.GroupBox();
            this.label_id = new System.Windows.Forms.Label();
            this.cb_personel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_maas = new System.Windows.Forms.GroupBox();
            this.btn_maas_sil = new System.Windows.Forms.Button();
            this.btn_maas_odeme_iptal = new System.Windows.Forms.Button();
            this.btn_maas_odeme = new System.Windows.Forms.Button();
            this.txt_sgk_prim = new System.Windows.Forms.TextBox();
            this.txt_toplam_maas = new System.Windows.Forms.TextBox();
            this.lbl_maas_ve_sgk_prim = new System.Windows.Forms.Label();
            this.lbl_donem = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gb_personel_ara = new System.Windows.Forms.GroupBox();
            this.lbl_ara = new System.Windows.Forms.Label();
            this.btn_ara = new System.Windows.Forms.Button();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.btn_kayitlar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_maas)).BeginInit();
            this.gb_personel.SuspendLayout();
            this.gb_maas.SuspendLayout();
            this.gb_personel_ara.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_yil
            // 
            this.cb_yil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_yil.FormattingEnabled = true;
            this.cb_yil.Items.AddRange(new object[] {
            "Yil seçiniz..."});
            this.cb_yil.Location = new System.Drawing.Point(487, 46);
            this.cb_yil.Name = "cb_yil";
            this.cb_yil.Size = new System.Drawing.Size(189, 28);
            this.cb_yil.TabIndex = 17;
            // 
            // cb_ay
            // 
            this.cb_ay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_ay.FormattingEnabled = true;
            this.cb_ay.Items.AddRange(new object[] {
            "Ay seçiniz...",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cb_ay.Location = new System.Drawing.Point(310, 46);
            this.cb_ay.Name = "cb_ay";
            this.cb_ay.Size = new System.Drawing.Size(153, 28);
            this.cb_ay.TabIndex = 16;
            // 
            // dg_maas
            // 
            this.dg_maas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_maas.Location = new System.Drawing.Point(356, 496);
            this.dg_maas.Name = "dg_maas";
            this.dg_maas.RowHeadersWidth = 51;
            this.dg_maas.RowTemplate.Height = 24;
            this.dg_maas.Size = new System.Drawing.Size(1139, 335);
            this.dg_maas.TabIndex = 18;
            this.dg_maas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_maas_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(801, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "PERSONEL MAAŞ LİSTESİ";
            // 
            // btn_maas_odeme_ekle
            // 
            this.btn_maas_odeme_ekle.BackColor = System.Drawing.Color.White;
            this.btn_maas_odeme_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_maas_odeme_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_maas_odeme_ekle.ImageKey = "2484089.png";
            this.btn_maas_odeme_ekle.ImageList = this.ımageList1;
            this.btn_maas_odeme_ekle.Location = new System.Drawing.Point(7, 167);
            this.btn_maas_odeme_ekle.Name = "btn_maas_odeme_ekle";
            this.btn_maas_odeme_ekle.Size = new System.Drawing.Size(153, 80);
            this.btn_maas_odeme_ekle.TabIndex = 22;
            this.btn_maas_odeme_ekle.Text = "ÖDEME EKLE";
            this.btn_maas_odeme_ekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_maas_odeme_ekle.UseVisualStyleBackColor = false;
            this.btn_maas_odeme_ekle.Click += new System.EventHandler(this.btn_maas_odeme_ekle_Click);
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
            // gb_personel
            // 
            this.gb_personel.Controls.Add(this.label_id);
            this.gb_personel.Controls.Add(this.cb_personel);
            this.gb_personel.Controls.Add(this.label2);
            this.gb_personel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_personel.Location = new System.Drawing.Point(270, 158);
            this.gb_personel.Name = "gb_personel";
            this.gb_personel.Size = new System.Drawing.Size(519, 152);
            this.gb_personel.TabIndex = 40;
            this.gb_personel.TabStop = false;
            this.gb_personel.Text = "Personel Bilgileri";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(446, 69);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 20);
            this.label_id.TabIndex = 2;
            this.label_id.Text = "0";
            // 
            // cb_personel
            // 
            this.cb_personel.FormattingEnabled = true;
            this.cb_personel.Items.AddRange(new object[] {
            "Tüm Personeller"});
            this.cb_personel.Location = new System.Drawing.Point(167, 63);
            this.cb_personel.Name = "cb_personel";
            this.cb_personel.Size = new System.Drawing.Size(273, 28);
            this.cb_personel.TabIndex = 1;
            this.cb_personel.SelectedIndexChanged += new System.EventHandler(this.cb_personel_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Personeller:";
            // 
            // gb_maas
            // 
            this.gb_maas.Controls.Add(this.btn_maas_sil);
            this.gb_maas.Controls.Add(this.btn_maas_odeme_iptal);
            this.gb_maas.Controls.Add(this.btn_maas_odeme);
            this.gb_maas.Controls.Add(this.txt_sgk_prim);
            this.gb_maas.Controls.Add(this.txt_toplam_maas);
            this.gb_maas.Controls.Add(this.lbl_maas_ve_sgk_prim);
            this.gb_maas.Controls.Add(this.lbl_donem);
            this.gb_maas.Controls.Add(this.label3);
            this.gb_maas.Controls.Add(this.label4);
            this.gb_maas.Controls.Add(this.cb_yil);
            this.gb_maas.Controls.Add(this.btn_maas_odeme_ekle);
            this.gb_maas.Controls.Add(this.cb_ay);
            this.gb_maas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_maas.Location = new System.Drawing.Point(806, 158);
            this.gb_maas.Name = "gb_maas";
            this.gb_maas.Size = new System.Drawing.Size(737, 265);
            this.gb_maas.TabIndex = 0;
            this.gb_maas.TabStop = false;
            this.gb_maas.Text = "Maaş Bilgileri";
            // 
            // btn_maas_sil
            // 
            this.btn_maas_sil.BackColor = System.Drawing.Color.White;
            this.btn_maas_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_maas_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_maas_sil.ImageKey = "2939478.png";
            this.btn_maas_sil.ImageList = this.ımageList1;
            this.btn_maas_sil.Location = new System.Drawing.Point(166, 168);
            this.btn_maas_sil.Name = "btn_maas_sil";
            this.btn_maas_sil.Size = new System.Drawing.Size(181, 79);
            this.btn_maas_sil.TabIndex = 55;
            this.btn_maas_sil.Text = " ÖDEME SİL";
            this.btn_maas_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_maas_sil.UseVisualStyleBackColor = false;
            this.btn_maas_sil.Click += new System.EventHandler(this.btn_maas_sil_Click);
            // 
            // btn_maas_odeme_iptal
            // 
            this.btn_maas_odeme_iptal.BackColor = System.Drawing.Color.White;
            this.btn_maas_odeme_iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_maas_odeme_iptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_maas_odeme_iptal.ImageKey = "2939478.png";
            this.btn_maas_odeme_iptal.ImageList = this.ımageList1;
            this.btn_maas_odeme_iptal.Location = new System.Drawing.Point(547, 168);
            this.btn_maas_odeme_iptal.Name = "btn_maas_odeme_iptal";
            this.btn_maas_odeme_iptal.Size = new System.Drawing.Size(184, 79);
            this.btn_maas_odeme_iptal.TabIndex = 55;
            this.btn_maas_odeme_iptal.Text = " ÖDEME İPTAL ET";
            this.btn_maas_odeme_iptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_maas_odeme_iptal.UseVisualStyleBackColor = false;
            this.btn_maas_odeme_iptal.Click += new System.EventHandler(this.btn_maas_odeme_iptal_Click);
            // 
            // btn_maas_odeme
            // 
            this.btn_maas_odeme.BackColor = System.Drawing.Color.White;
            this.btn_maas_odeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_maas_odeme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_maas_odeme.ImageKey = "3231991.png";
            this.btn_maas_odeme.ImageList = this.ımageList1;
            this.btn_maas_odeme.Location = new System.Drawing.Point(353, 167);
            this.btn_maas_odeme.Name = "btn_maas_odeme";
            this.btn_maas_odeme.Size = new System.Drawing.Size(178, 79);
            this.btn_maas_odeme.TabIndex = 54;
            this.btn_maas_odeme.Text = "ÖDEME YAP";
            this.btn_maas_odeme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_maas_odeme.UseVisualStyleBackColor = false;
            this.btn_maas_odeme.Click += new System.EventHandler(this.btn_maas_odeme_Click);
            // 
            // txt_sgk_prim
            // 
            this.txt_sgk_prim.Enabled = false;
            this.txt_sgk_prim.Location = new System.Drawing.Point(513, 102);
            this.txt_sgk_prim.Name = "txt_sgk_prim";
            this.txt_sgk_prim.Size = new System.Drawing.Size(163, 27);
            this.txt_sgk_prim.TabIndex = 55;
            // 
            // txt_toplam_maas
            // 
            this.txt_toplam_maas.Enabled = false;
            this.txt_toplam_maas.Location = new System.Drawing.Point(310, 102);
            this.txt_toplam_maas.Name = "txt_toplam_maas";
            this.txt_toplam_maas.Size = new System.Drawing.Size(176, 27);
            this.txt_toplam_maas.TabIndex = 55;
            // 
            // lbl_maas_ve_sgk_prim
            // 
            this.lbl_maas_ve_sgk_prim.AutoSize = true;
            this.lbl_maas_ve_sgk_prim.Location = new System.Drawing.Point(92, 105);
            this.lbl_maas_ve_sgk_prim.Name = "lbl_maas_ve_sgk_prim";
            this.lbl_maas_ve_sgk_prim.Size = new System.Drawing.Size(198, 20);
            this.lbl_maas_ve_sgk_prim.TabIndex = 54;
            this.lbl_maas_ve_sgk_prim.Text = "Toplam Maaş / Sgk Prim:";
            // 
            // lbl_donem
            // 
            this.lbl_donem.AutoSize = true;
            this.lbl_donem.Location = new System.Drawing.Point(92, 49);
            this.lbl_donem.Name = "lbl_donem";
            this.lbl_donem.Size = new System.Drawing.Size(68, 20);
            this.lbl_donem.TabIndex = 24;
            this.lbl_donem.Text = "Dönem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(489, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(465, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "/";
            // 
            // gb_personel_ara
            // 
            this.gb_personel_ara.Controls.Add(this.lbl_ara);
            this.gb_personel_ara.Controls.Add(this.btn_ara);
            this.gb_personel_ara.Controls.Add(this.txt_ara);
            this.gb_personel_ara.Location = new System.Drawing.Point(270, 326);
            this.gb_personel_ara.Name = "gb_personel_ara";
            this.gb_personel_ara.Size = new System.Drawing.Size(519, 97);
            this.gb_personel_ara.TabIndex = 53;
            this.gb_personel_ara.TabStop = false;
            this.gb_personel_ara.Text = "Personel Arama";
            // 
            // lbl_ara
            // 
            this.lbl_ara.AutoSize = true;
            this.lbl_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ara.Location = new System.Drawing.Point(14, 41);
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
            this.btn_ara.Location = new System.Drawing.Point(412, 29);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(95, 44);
            this.btn_ara.TabIndex = 51;
            this.btn_ara.Text = "ARA";
            this.btn_ara.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ara.UseVisualStyleBackColor = false;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // txt_ara
            // 
            this.txt_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ara.Location = new System.Drawing.Point(141, 38);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(265, 27);
            this.txt_ara.TabIndex = 50;
            // 
            // btn_kayitlar
            // 
            this.btn_kayitlar.BackColor = System.Drawing.Color.White;
            this.btn_kayitlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayitlar.ImageKey = "6416106.png";
            this.btn_kayitlar.ImageList = this.ımageList1;
            this.btn_kayitlar.Location = new System.Drawing.Point(359, 440);
            this.btn_kayitlar.Name = "btn_kayitlar";
            this.btn_kayitlar.Size = new System.Drawing.Size(212, 44);
            this.btn_kayitlar.TabIndex = 54;
            this.btn_kayitlar.Text = "TÜM KAYITLAR";
            this.btn_kayitlar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kayitlar.UseVisualStyleBackColor = false;
            this.btn_kayitlar.Click += new System.EventHandler(this.btn_kayitlar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(352, 841);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(397, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Güncelleme için satıra çift tıkla, silmek için satır seç";
            // 
            // Personel_Maaş_Hesaplama_İşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(1924, 870);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_kayitlar);
            this.Controls.Add(this.gb_personel_ara);
            this.Controls.Add(this.gb_maas);
            this.Controls.Add(this.gb_personel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_maas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Personel_Maaş_Hesaplama_İşlemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel_Maaş_Ödeme_İşlemleri";
            this.Load += new System.EventHandler(this.Personel_Maaş_Hesaplama_İşlemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_maas)).EndInit();
            this.gb_personel.ResumeLayout(false);
            this.gb_personel.PerformLayout();
            this.gb_maas.ResumeLayout(false);
            this.gb_maas.PerformLayout();
            this.gb_personel_ara.ResumeLayout(false);
            this.gb_personel_ara.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_yil;
        private System.Windows.Forms.ComboBox cb_ay;
        private System.Windows.Forms.DataGridView dg_maas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_maas_odeme_ekle;
        private System.Windows.Forms.GroupBox gb_personel;
        private System.Windows.Forms.GroupBox gb_maas;
        private System.Windows.Forms.ComboBox cb_personel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_personel_ara;
        private System.Windows.Forms.Label lbl_ara;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.TextBox txt_toplam_maas;
        private System.Windows.Forms.Label lbl_maas_ve_sgk_prim;
        private System.Windows.Forms.Label lbl_donem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button btn_maas_odeme;
        private System.Windows.Forms.Button btn_kayitlar;
        private System.Windows.Forms.Button btn_maas_odeme_iptal;
        private System.Windows.Forms.Button btn_maas_sil;
        private System.Windows.Forms.TextBox txt_sgk_prim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label5;
    }
}