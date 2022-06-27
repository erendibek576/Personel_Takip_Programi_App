using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BBP201_210111409_Muhammed_Eren_Dibek
{
    public partial class Personel_Kıdem_Tazminatı_Hesaplama_İşlemleri : Form
    {
        public Personel_Kıdem_Tazminatı_Hesaplama_İşlemleri()
        {
            InitializeComponent();
        }

        Veritabanı bgl = new Veritabanı();

        double maas = 0, yol = 0, yemek = 0, t_maas = 12.5, damga_vergi = 0;

        DateTime ise_baslama, isi_birakma;
        long kac_gun = 0;
        double alacagi_tazminat;
        void listele()
        {
            try
            {
                DataTable tazminat = new DataTable();
                SqlDataAdapter veri = new SqlDataAdapter("SELECT t.kidem_tazminat_id,p.ad,p.soyad,p.is_baslangic_tarih,t.is_ayrilis_tarih,p.maas,p.yol_yardim,p.yemek_yardim,t.esas_gun,t.esas_ucret,t.brut_tutar,t.damga_vergi_tutar,t.net_tutar,t.tazminat_odeme,t.tarih" +
                " FROM kidem_tazminat as t INNER JOIN personel as p ON p.personel_id = t.personel_id ", bgl.baglanti());
                veri.Fill(tazminat);
                dg_kidem.DataSource = tazminat;


            }
            catch
            {

                MessageBox.Show("Kıdem Tazminat bilgileri listelenemedi!", "Kıdem Tazminat bilgileri Listeleme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        void Temizle()
        {
            dt_is_baslangic_tarih.Value = DateTime.Now;
            dt_is_ayrilis_tarih.Value = DateTime.Now;
            cb_personel.SelectedIndex = 0;
            txt_ara.Text = "";

            foreach (Control item in gb_personel.Controls)
            {
                if (item is TextBox)
                {

                    item.Text = "";

                }
            }

            foreach (Control item in gb_tazminat_bilgiler.Controls)
            {
                lbl_kidem_gun.Text = "   - ";
                lbl_esas_ucret.Text = "   - ";
                lbl_brut_ucret.Text = "   - ";
                lbl_damga_vergisi.Text = "   - ";
                lbl_net_tutar.Text = "   - ";

            }
            foreach (Control item in gb_personel_ara.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        SqlDataReader PersonelIDGetir()
        {

            SqlCommand prsnl = new SqlCommand("SELECT personel_id,ad,soyad FROM personel", bgl.baglanti());
            SqlDataReader dr = prsnl.ExecuteReader();
            while (dr.Read())
            {
                if (cb_personel.SelectedItem.ToString() == dr[1] + " " + dr[2])
                {
                    label_id.Text = dr[0].ToString();
                }
            }
            bgl.baglanti().Close();
            return dr;
        }
        SqlDataReader ComboPersonelGetir()
        {
            SqlCommand prsnl = new SqlCommand("SELECT personel_id,ad,soyad FROM personel", bgl.baglanti());
            SqlDataReader dr = prsnl.ExecuteReader();
            while (dr.Read())
            {
                label_id.Text = dr[0].ToString();
                cb_personel.Items.Add(dr[1] + " " + dr[2]);
            }
            bgl.baglanti().Close();
            return dr;
        }
        SqlDataReader PersonelSec()
        {

            SqlCommand prsnl = new SqlCommand("SELECT personel_id,ad,soyad FROM personel", bgl.baglanti());
            SqlDataReader dr = prsnl.ExecuteReader();
            while (dr.Read())
            {
                label_id.Text = dr[0].ToString();
                cb_personel.Text = (dr[1] + " " + dr[2]).ToString();

            }
            bgl.baglanti().Close();
            return dr;
        }
        SqlDataReader IsBaslangicTarihGetir()
        {

            SqlCommand prsnl = new SqlCommand("SELECT is_baslangic_tarih  FROM  personel where personel_id ='" + label_id.Text + "'", bgl.baglanti());
            SqlDataReader dr = prsnl.ExecuteReader();
            while (dr.Read())
            {
                dt_is_baslangic_tarih.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
            return dr;
        }
        SqlDataReader MaasBilgileriGetir()
        {

            SqlCommand prsnl = new SqlCommand("SELECT maas,yol_yardim,yemek_yardim  FROM  personel where personel_id ='" + label_id.Text + "'", bgl.baglanti());
            SqlDataReader dr = prsnl.ExecuteReader();
            while (dr.Read())
            {
                txt_maas.Text = dr[0].ToString();
                txt_yol.Text = dr[1].ToString();
                txt_yemek.Text = dr[2].ToString();
            }
            bgl.baglanti().Close();
            return dr;
        }
        private void Personel_Kıdem_Tazminatı_Hesaplama_İşlemleri_Load(object sender, EventArgs e)
        {
            ComboPersonelGetir();
            listele();
            cb_personel.SelectedIndex = 0;
        }



        private void btn_kayitlar_Click(object sender, EventArgs e)
        {
            listele();
            Temizle();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "SELECT t.kidem_tazminat_id,p.ad,p.soyad,p.is_baslangic_tarih,t.is_ayrilis_tarih,p.maas,p.yol_yardim,p.yemek_yardim,t.esas_gun,t.esas_ucret,t.brut_tutar,t.damga_vergi_tutar,t.net_tutar,t.tazminat_odeme,t.tarih" +
                    " FROM kidem_tazminat as t INNER JOIN personel as p ON p.personel_id = t.personel_id where ad='" + txt_ara.Text + "'";
                DataTable kidem = new DataTable();
                SqlDataAdapter kd = new SqlDataAdapter(sql, bgl.baglanti());
                kd.Fill(kidem);
                dg_kidem.DataSource = kidem;
            }
            catch
            {
                MessageBox.Show("Kıdem Tazminat bilgileri aranamadı!", "Kıdem Tazminat bilgileri Ara Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dg_kidem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PersonelSec();
            dt_is_baslangic_tarih.Text = dg_kidem.CurrentRow.Cells["is_baslangic_tarih"].Value.ToString();
            dt_is_ayrilis_tarih.Text = dg_kidem.CurrentRow.Cells["is_ayrilis_tarih"].Value.ToString();

            txt_maas.Text = dg_kidem.CurrentRow.Cells["maas"].Value.ToString();
            txt_yol.Text = dg_kidem.CurrentRow.Cells["yol_yardim"].Value.ToString();
            txt_yemek.Text = dg_kidem.CurrentRow.Cells["yemek_yardim"].Value.ToString();

            lbl_kidem_gun.Text = dg_kidem.CurrentRow.Cells["esas_gun"].Value.ToString();
            lbl_esas_ucret.Text = dg_kidem.CurrentRow.Cells["esas_ucret"].Value.ToString();
            lbl_brut_ucret.Text = dg_kidem.CurrentRow.Cells["brut_tutar"].Value.ToString();
            lbl_damga_vergisi.Text = dg_kidem.CurrentRow.Cells["damga_vergi_tutar"].Value.ToString();
            lbl_net_tutar.Text = dg_kidem.CurrentRow.Cells["net_tutar"].Value.ToString();
        }

        private void btn_kidem_tazminat_ode_Click(object sender, EventArgs e)
        {
            try
            {
                String odenmeDurumu = "ödemesi yapıldı";
                SqlCommand komut = new SqlCommand("Update kidem_tazminat Set tazminat_odeme = @p1 where kidem_tazminat_id= @p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", odenmeDurumu);
                komut.Parameters.AddWithValue("@p2", dg_kidem.CurrentRow.Cells[0].Value);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                listele();
                Temizle();

                MessageBox.Show("Kıdem tazminat ödemesi yapıldı!" + Environment.NewLine, "Kıdem Tazminat Ödeme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Kıdem Tazminat ödenemedi!", "Kıdem Tazminat Ödeme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cb_personel_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cb_personel.SelectedIndex == 0)
            {
                label_id.Text = "0";
                dt_is_baslangic_tarih.Text = DateTime.Now.ToString();
                txt_maas.Clear();
                txt_yol.Clear();
                txt_yemek.Clear();
                return;
            }
            else
            {
                PersonelIDGetir();
                IsBaslangicTarihGetir();
                MaasBilgileriGetir();
            }
        }


        private void btn_kidem_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into kidem_tazminat (personel_id,is_ayrilis_tarih,esas_gun,esas_ucret,brut_tutar,damga_vergi_tutar,net_tutar,tarih) values(@p1, @p2, @p3, @p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", label_id.Text);
                komut.Parameters.AddWithValue("@p2", dt_is_ayrilis_tarih.Text);
                komut.Parameters.AddWithValue("@p3", lbl_kidem_gun.Text);
                komut.Parameters.AddWithValue("@p4", SqlDbType.Decimal).Value = Decimal.Parse(lbl_esas_ucret.Text);
                komut.Parameters.AddWithValue("@p5", SqlDbType.Decimal).Value = Decimal.Parse(lbl_brut_ucret.Text);
                komut.Parameters.AddWithValue("@p6", SqlDbType.Decimal).Value = Decimal.Parse(lbl_damga_vergisi.Text);
                komut.Parameters.AddWithValue("@p7", SqlDbType.Decimal).Value = Decimal.Parse(lbl_net_tutar.Text);
                komut.Parameters.AddWithValue("@p8", SqlDbType.Date).Value = DateTime.Now;

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                listele();
                Temizle();

                MessageBox.Show("Kıdem tazminatı başarıyla eklendi.", "Kıdem Tazminatı Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Kıdem Tazminat bilgileri eklenemedi!", "Kıdem Tazminat bilgileri Ekleme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_kidem_sil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Delete from kidem_tazminat  where kidem_tazminat_id=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", dg_kidem.CurrentRow.Cells[0].Value);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                listele();
                Temizle();

                MessageBox.Show("Kıdem tazminatı başarıyla silindi.", "Kıdem Tazminatı Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Kıdem Tazminat bilgileri silinemedi!", "Kıdem Tazminat bilgileri Silme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_kidem_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Update kidem_tazminat Set is_ayrilis_tarih=@p1, esas_gun=@p2, esas_ucret=@p3, brut_tutar=@p4, damga_vergi_tutar=@p5, net_tutar=@p6, tarih=@p7 where kidem_tazminat_id=@p8", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", dt_is_ayrilis_tarih.Text);
                komut.Parameters.AddWithValue("@p2", lbl_kidem_gun.Text);
                komut.Parameters.AddWithValue("@p3", SqlDbType.Decimal).Value = Decimal.Parse(lbl_esas_ucret.Text);
                komut.Parameters.AddWithValue("@p4", SqlDbType.Decimal).Value = Decimal.Parse(lbl_brut_ucret.Text);
                komut.Parameters.AddWithValue("@p5", SqlDbType.Decimal).Value = Decimal.Parse(lbl_damga_vergisi.Text);
                komut.Parameters.AddWithValue("@p6", SqlDbType.Decimal).Value = Decimal.Parse(lbl_net_tutar.Text);
                komut.Parameters.AddWithValue("@p7", SqlDbType.Date).Value = DateTime.Now;

                komut.Parameters.AddWithValue("@p8", dg_kidem.CurrentRow.Cells[0].Value);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                listele();
                Temizle();

                MessageBox.Show("Kıdem tazminatı başarıyla güncellendi.", "Kıdem Tazminatı Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Kıdem Tazminat bilgileri güncellenemedi!", "Kıdem Tazminat bilgileri Güncelleme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        private void btn_kidem_hesapla_Click(object sender, EventArgs e)
        {
            try
            {
                ise_baslama = DateTime.Parse(dt_is_baslangic_tarih.Text);
                isi_birakma = DateTime.Parse(dt_is_ayrilis_tarih.Text);

                TimeSpan fark = isi_birakma - ise_baslama;
                kac_gun = fark.Days;

                maas = double.Parse(txt_maas.Text);
                yol = double.Parse(txt_yol.Text);
                yemek = double.Parse(txt_yemek.Text);

                t_maas = Convert.ToDouble(maas + yol + yemek);
                damga_vergi = t_maas * 8.25 / 1000;


                lbl_kidem_gun.Text = Convert.ToString(kac_gun);

                if (isi_birakma.ToOADate() > ise_baslama.ToOADate())
                {
                    lbl_kidem_gun.Text = String.Format("{0} gün", kac_gun);
                    if (kac_gun >= 365)
                    {

                        lbl_esas_ucret.Text = t_maas.ToString();
                        alacagi_tazminat = kac_gun / 365 * t_maas;

                        alacagi_tazminat += 12.5;
                        lbl_brut_ucret.Text = alacagi_tazminat.ToString();

                        lbl_damga_vergisi.Text = (alacagi_tazminat * 8.25 / 1000).ToString();


                        alacagi_tazminat = kac_gun / 365 * t_maas - damga_vergi;
                        lbl_net_tutar.Text = alacagi_tazminat.ToString();

                    }

                    else
                    {
                        MessageBox.Show("Tam seneniz dolduğu zaman tazminatınızı alabilirsiniz!", "Kıdem Tazminatı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen işe başlangıç tarihinden itibaren bir tarih seçiniz !", "Kıdem Tazminatı Hesaplama", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Kıdem Tazminat bilgileri hesaplanamadı!", "Kıdem Tazminat bilgileri Hesaplama Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}


