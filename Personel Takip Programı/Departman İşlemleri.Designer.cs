
namespace BBP201_210111409_Muhammed_Eren_Dibek
{
    partial class Departman_İşlemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departman_İşlemleri));
            this.lbl_departman = new System.Windows.Forms.Label();
            this.txt_departman = new System.Windows.Forms.TextBox();
            this.btn_dprtmn_ekle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_dprtmn_sil = new System.Windows.Forms.Button();
            this.btn_dprtmn_guncelle = new System.Windows.Forms.Button();
            this.dg_departman = new System.Windows.Forms.DataGridView();
            this.lbl_dp_liste = new System.Windows.Forms.Label();
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_kayitlar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rt_departman = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_departman)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_departman
            // 
            this.lbl_departman.AutoSize = true;
            this.lbl_departman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_departman.Location = new System.Drawing.Point(57, 47);
            this.lbl_departman.Name = "lbl_departman";
            this.lbl_departman.Size = new System.Drawing.Size(148, 25);
            this.lbl_departman.TabIndex = 0;
            this.lbl_departman.Text = "Departman Adı:";
            // 
            // txt_departman
            // 
            this.txt_departman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_departman.Location = new System.Drawing.Point(223, 48);
            this.txt_departman.Name = "txt_departman";
            this.txt_departman.Size = new System.Drawing.Size(293, 27);
            this.txt_departman.TabIndex = 1;
            // 
            // btn_dprtmn_ekle
            // 
            this.btn_dprtmn_ekle.BackColor = System.Drawing.Color.White;
            this.btn_dprtmn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dprtmn_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dprtmn_ekle.ImageKey = "2484089.png";
            this.btn_dprtmn_ekle.ImageList = this.ımageList1;
            this.btn_dprtmn_ekle.Location = new System.Drawing.Point(62, 203);
            this.btn_dprtmn_ekle.Name = "btn_dprtmn_ekle";
            this.btn_dprtmn_ekle.Size = new System.Drawing.Size(143, 54);
            this.btn_dprtmn_ekle.TabIndex = 2;
            this.btn_dprtmn_ekle.Text = "EKLE";
            this.btn_dprtmn_ekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dprtmn_ekle.UseVisualStyleBackColor = false;
            this.btn_dprtmn_ekle.Click += new System.EventHandler(this.btn_dprtmn_ekle_Click);
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
            // btn_dprtmn_sil
            // 
            this.btn_dprtmn_sil.BackColor = System.Drawing.Color.White;
            this.btn_dprtmn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dprtmn_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dprtmn_sil.ImageKey = "2939478.png";
            this.btn_dprtmn_sil.ImageList = this.ımageList1;
            this.btn_dprtmn_sil.Location = new System.Drawing.Point(259, 203);
            this.btn_dprtmn_sil.Name = "btn_dprtmn_sil";
            this.btn_dprtmn_sil.Size = new System.Drawing.Size(143, 54);
            this.btn_dprtmn_sil.TabIndex = 3;
            this.btn_dprtmn_sil.Text = "SİL";
            this.btn_dprtmn_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dprtmn_sil.UseVisualStyleBackColor = false;
            this.btn_dprtmn_sil.Click += new System.EventHandler(this.btn_dprtmn_sil_Click);
            // 
            // btn_dprtmn_guncelle
            // 
            this.btn_dprtmn_guncelle.BackColor = System.Drawing.Color.White;
            this.btn_dprtmn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dprtmn_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dprtmn_guncelle.ImageKey = "5300106.png";
            this.btn_dprtmn_guncelle.ImageList = this.ımageList1;
            this.btn_dprtmn_guncelle.Location = new System.Drawing.Point(444, 203);
            this.btn_dprtmn_guncelle.Name = "btn_dprtmn_guncelle";
            this.btn_dprtmn_guncelle.Size = new System.Drawing.Size(173, 54);
            this.btn_dprtmn_guncelle.TabIndex = 4;
            this.btn_dprtmn_guncelle.Text = "GÜNCELLE";
            this.btn_dprtmn_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dprtmn_guncelle.UseVisualStyleBackColor = false;
            this.btn_dprtmn_guncelle.Click += new System.EventHandler(this.btn_dprtmn_guncelle_Click);
            // 
            // dg_departman
            // 
            this.dg_departman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_departman.Location = new System.Drawing.Point(93, 354);
            this.dg_departman.Name = "dg_departman";
            this.dg_departman.RowHeadersWidth = 51;
            this.dg_departman.RowTemplate.Height = 24;
            this.dg_departman.Size = new System.Drawing.Size(475, 251);
            this.dg_departman.TabIndex = 5;
            this.dg_departman.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_departman_CellDoubleClick);
            // 
            // lbl_dp_liste
            // 
            this.lbl_dp_liste.AutoSize = true;
            this.lbl_dp_liste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dp_liste.Location = new System.Drawing.Point(254, 295);
            this.lbl_dp_liste.Name = "lbl_dp_liste";
            this.lbl_dp_liste.Size = new System.Drawing.Size(234, 25);
            this.lbl_dp_liste.TabIndex = 6;
            this.lbl_dp_liste.Text = "DEPARTMAN LİSTESİ";
            // 
            // btn_ara
            // 
            this.btn_ara.BackColor = System.Drawing.Color.White;
            this.btn_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ara.ImageKey = "7795401.png";
            this.btn_ara.ImageList = this.ımageList1;
            this.btn_ara.Location = new System.Drawing.Point(522, 39);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(113, 45);
            this.btn_ara.TabIndex = 7;
            this.btn_ara.Text = "Ara";
            this.btn_ara.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ara.UseVisualStyleBackColor = false;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_kayitlar
            // 
            this.btn_kayitlar.BackColor = System.Drawing.Color.White;
            this.btn_kayitlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayitlar.ImageKey = "6416106.png";
            this.btn_kayitlar.ImageList = this.ımageList1;
            this.btn_kayitlar.Location = new System.Drawing.Point(62, 281);
            this.btn_kayitlar.Name = "btn_kayitlar";
            this.btn_kayitlar.Size = new System.Drawing.Size(174, 51);
            this.btn_kayitlar.TabIndex = 54;
            this.btn_kayitlar.Text = "TÜM KAYITLAR";
            this.btn_kayitlar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kayitlar.UseVisualStyleBackColor = false;
            this.btn_kayitlar.Click += new System.EventHandler(this.btn_kayitlar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(90, 622);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Güncelleme için satıra çift tıkla, silmek için satır seç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(107, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Açıklama:";
            // 
            // rt_departman
            // 
            this.rt_departman.Location = new System.Drawing.Point(223, 95);
            this.rt_departman.Name = "rt_departman";
            this.rt_departman.Size = new System.Drawing.Size(293, 75);
            this.rt_departman.TabIndex = 56;
            this.rt_departman.Text = "";
            // 
            // Departman_İşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 656);
            this.Controls.Add(this.rt_departman);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kayitlar);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.lbl_dp_liste);
            this.Controls.Add(this.dg_departman);
            this.Controls.Add(this.btn_dprtmn_guncelle);
            this.Controls.Add(this.btn_dprtmn_sil);
            this.Controls.Add(this.btn_dprtmn_ekle);
            this.Controls.Add(this.txt_departman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_departman);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Departman_İşlemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departman_İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Departman_İşlemleri_FormClosed);
            this.Load += new System.EventHandler(this.Departman_İşlemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_departman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_departman;
        private System.Windows.Forms.TextBox txt_departman;
        private System.Windows.Forms.Button btn_dprtmn_ekle;
        private System.Windows.Forms.Button btn_dprtmn_sil;
        private System.Windows.Forms.Button btn_dprtmn_guncelle;
        private System.Windows.Forms.DataGridView dg_departman;
        private System.Windows.Forms.Label lbl_dp_liste;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_kayitlar;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rt_departman;
    }
}