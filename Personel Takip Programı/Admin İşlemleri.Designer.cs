
namespace BBP201_210111409_Muhammed_Eren_Dibek
{
    partial class Admin_İşlemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_İşlemleri));
            this.txt_admin_sifre = new System.Windows.Forms.TextBox();
            this.txt_admin_kul_adi = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.lbl_kul_adi = new System.Windows.Forms.Label();
            this.lbl_admin_liste = new System.Windows.Forms.Label();
            this.dg_admin_liste = new System.Windows.Forms.DataGridView();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_sifre_tekrar = new System.Windows.Forms.Label();
            this.txt_sifre_tekrar = new System.Windows.Forms.TextBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.txt_admn_ara = new System.Windows.Forms.TextBox();
            this.lbl_personel = new System.Windows.Forms.Label();
            this.gb_admin = new System.Windows.Forms.GroupBox();
            this.btn_kayitlar = new System.Windows.Forms.Button();
            this.gp_ara = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_admin_liste)).BeginInit();
            this.gb_admin.SuspendLayout();
            this.gp_ara.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_admin_sifre
            // 
            this.txt_admin_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_admin_sifre.Location = new System.Drawing.Point(173, 92);
            this.txt_admin_sifre.Name = "txt_admin_sifre";
            this.txt_admin_sifre.PasswordChar = '*';
            this.txt_admin_sifre.Size = new System.Drawing.Size(241, 27);
            this.txt_admin_sifre.TabIndex = 8;
            // 
            // txt_admin_kul_adi
            // 
            this.txt_admin_kul_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_admin_kul_adi.Location = new System.Drawing.Point(173, 35);
            this.txt_admin_kul_adi.Name = "txt_admin_kul_adi";
            this.txt_admin_kul_adi.Size = new System.Drawing.Size(241, 27);
            this.txt_admin_kul_adi.TabIndex = 7;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.Location = new System.Drawing.Point(109, 91);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(58, 25);
            this.lbl_sifre.TabIndex = 6;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // lbl_kul_adi
            // 
            this.lbl_kul_adi.AutoSize = true;
            this.lbl_kul_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kul_adi.Location = new System.Drawing.Point(42, 34);
            this.lbl_kul_adi.Name = "lbl_kul_adi";
            this.lbl_kul_adi.Size = new System.Drawing.Size(125, 25);
            this.lbl_kul_adi.TabIndex = 5;
            this.lbl_kul_adi.Text = "Kullanıcı Adı:";
            // 
            // lbl_admin_liste
            // 
            this.lbl_admin_liste.AutoSize = true;
            this.lbl_admin_liste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_admin_liste.Location = new System.Drawing.Point(779, 33);
            this.lbl_admin_liste.Name = "lbl_admin_liste";
            this.lbl_admin_liste.Size = new System.Drawing.Size(169, 25);
            this.lbl_admin_liste.TabIndex = 12;
            this.lbl_admin_liste.Text = "ADMİN LİSTESİ";
            // 
            // dg_admin_liste
            // 
            this.dg_admin_liste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dg_admin_liste.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dg_admin_liste.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dg_admin_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_admin_liste.Location = new System.Drawing.Point(593, 85);
            this.dg_admin_liste.Name = "dg_admin_liste";
            this.dg_admin_liste.RowHeadersWidth = 51;
            this.dg_admin_liste.RowTemplate.Height = 24;
            this.dg_admin_liste.Size = new System.Drawing.Size(432, 292);
            this.dg_admin_liste.TabIndex = 13;
            this.dg_admin_liste.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_admin_liste_CellDoubleClick);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.White;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guncelle.ImageKey = "5300106.png";
            this.btn_guncelle.ImageList = this.ımageList1;
            this.btn_guncelle.Location = new System.Drawing.Point(302, 201);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(175, 68);
            this.btn_guncelle.TabIndex = 16;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
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
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.ImageKey = "2484089.png";
            this.btn_kaydet.ImageList = this.ımageList1;
            this.btn_kaydet.Location = new System.Drawing.Point(16, 201);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(151, 68);
            this.btn_kaydet.TabIndex = 14;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.White;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sil.ImageKey = "2939478.png";
            this.btn_sil.ImageList = this.ımageList1;
            this.btn_sil.Location = new System.Drawing.Point(173, 201);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(123, 68);
            this.btn_sil.TabIndex = 15;
            this.btn_sil.Text = "SİL";
            this.btn_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbl_sifre_tekrar
            // 
            this.lbl_sifre_tekrar.AutoSize = true;
            this.lbl_sifre_tekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre_tekrar.Location = new System.Drawing.Point(42, 147);
            this.lbl_sifre_tekrar.Name = "lbl_sifre_tekrar";
            this.lbl_sifre_tekrar.Size = new System.Drawing.Size(120, 25);
            this.lbl_sifre_tekrar.TabIndex = 6;
            this.lbl_sifre_tekrar.Text = "Şifre Tekrar:";
            // 
            // txt_sifre_tekrar
            // 
            this.txt_sifre_tekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre_tekrar.Location = new System.Drawing.Point(173, 148);
            this.txt_sifre_tekrar.Name = "txt_sifre_tekrar";
            this.txt_sifre_tekrar.PasswordChar = '*';
            this.txt_sifre_tekrar.Size = new System.Drawing.Size(241, 27);
            this.txt_sifre_tekrar.TabIndex = 8;
            // 
            // btn_ara
            // 
            this.btn_ara.BackColor = System.Drawing.Color.White;
            this.btn_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ara.ImageKey = "7795401.png";
            this.btn_ara.ImageList = this.ımageList1;
            this.btn_ara.Location = new System.Drawing.Point(360, 22);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(95, 41);
            this.btn_ara.TabIndex = 42;
            this.btn_ara.Text = "ARA";
            this.btn_ara.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ara.UseVisualStyleBackColor = false;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // txt_admn_ara
            // 
            this.txt_admn_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_admn_ara.Location = new System.Drawing.Point(132, 30);
            this.txt_admn_ara.Name = "txt_admn_ara";
            this.txt_admn_ara.Size = new System.Drawing.Size(222, 27);
            this.txt_admn_ara.TabIndex = 41;
            // 
            // lbl_personel
            // 
            this.lbl_personel.AutoSize = true;
            this.lbl_personel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_personel.Location = new System.Drawing.Point(23, 33);
            this.lbl_personel.Name = "lbl_personel";
            this.lbl_personel.Size = new System.Drawing.Size(92, 20);
            this.lbl_personel.TabIndex = 40;
            this.lbl_personel.Text = "Admin Ara:";
            // 
            // gb_admin
            // 
            this.gb_admin.Controls.Add(this.lbl_kul_adi);
            this.gb_admin.Controls.Add(this.lbl_sifre);
            this.gb_admin.Controls.Add(this.lbl_sifre_tekrar);
            this.gb_admin.Controls.Add(this.btn_sil);
            this.gb_admin.Controls.Add(this.btn_guncelle);
            this.gb_admin.Controls.Add(this.txt_admin_kul_adi);
            this.gb_admin.Controls.Add(this.btn_kaydet);
            this.gb_admin.Controls.Add(this.txt_admin_sifre);
            this.gb_admin.Controls.Add(this.txt_sifre_tekrar);
            this.gb_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_admin.Location = new System.Drawing.Point(78, 120);
            this.gb_admin.Name = "gb_admin";
            this.gb_admin.Size = new System.Drawing.Size(492, 284);
            this.gb_admin.TabIndex = 43;
            this.gb_admin.TabStop = false;
            this.gb_admin.Text = "Admin Bilgileri";
            // 
            // btn_kayitlar
            // 
            this.btn_kayitlar.BackColor = System.Drawing.Color.White;
            this.btn_kayitlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayitlar.ImageKey = "6416106.png";
            this.btn_kayitlar.ImageList = this.ımageList1;
            this.btn_kayitlar.Location = new System.Drawing.Point(593, 28);
            this.btn_kayitlar.Name = "btn_kayitlar";
            this.btn_kayitlar.Size = new System.Drawing.Size(180, 41);
            this.btn_kayitlar.TabIndex = 55;
            this.btn_kayitlar.Text = "TÜM KAYITLAR";
            this.btn_kayitlar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kayitlar.UseVisualStyleBackColor = false;
            this.btn_kayitlar.Click += new System.EventHandler(this.btn_kayitlar_Click);
            // 
            // gp_ara
            // 
            this.gp_ara.Controls.Add(this.lbl_personel);
            this.gp_ara.Controls.Add(this.txt_admn_ara);
            this.gp_ara.Controls.Add(this.btn_ara);
            this.gp_ara.Location = new System.Drawing.Point(78, 28);
            this.gp_ara.Name = "gp_ara";
            this.gp_ara.Size = new System.Drawing.Size(492, 86);
            this.gp_ara.TabIndex = 57;
            this.gp_ara.TabStop = false;
            this.gp_ara.Text = "Admin Ara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(589, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Güncelleme için satıra çift tıkla, silmek için satır seç";
            // 
            // Admin_İşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1106, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gp_ara);
            this.Controls.Add(this.btn_kayitlar);
            this.Controls.Add(this.gb_admin);
            this.Controls.Add(this.dg_admin_liste);
            this.Controls.Add(this.lbl_admin_liste);
            this.Name = "Admin_İşlemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Kayıt_İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_Kayıt_İşlemleri_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Kayıt_İşlemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_admin_liste)).EndInit();
            this.gb_admin.ResumeLayout(false);
            this.gb_admin.PerformLayout();
            this.gp_ara.ResumeLayout(false);
            this.gp_ara.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_admin_sifre;
        private System.Windows.Forms.TextBox txt_admin_kul_adi;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Label lbl_kul_adi;
        private System.Windows.Forms.Label lbl_admin_liste;
        private System.Windows.Forms.DataGridView dg_admin_liste;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_sifre_tekrar;
        private System.Windows.Forms.TextBox txt_sifre_tekrar;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.TextBox txt_admn_ara;
        private System.Windows.Forms.Label lbl_personel;
        private System.Windows.Forms.GroupBox gb_admin;
        private System.Windows.Forms.Button btn_kayitlar;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox gp_ara;
        private System.Windows.Forms.Label label1;
    }
}