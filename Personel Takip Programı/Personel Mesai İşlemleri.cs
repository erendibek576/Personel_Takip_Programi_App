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
    public partial class Personel_Mesai_İşlemleri : Form
    {
        public Personel_Mesai_İşlemleri()
        {
            InitializeComponent();
        }

        Veritabanı bgl = new Veritabanı();

        void listele()
        {
            try
            {
                DataTable mesai = new DataTable();
                SqlDataAdapter veri = new SqlDataAdapter("SELECT m.mesai_id,p.ad,p.soyad,m.baslangic_saat,m.bitis_saat,m.mesai_saat_ucret,m.tutar,m.donem,m.mesai_odeme,m.tarih" +
                " FROM mesai as m INNER JOIN personel as p ON m.personel_id = p.personel_id", bgl.baglanti());
                veri.Fill(mesai);
                dg_mesai.DataSource = mesai;


            }
            catch
            {
                MessageBox.Show("Personel Mesai bilgileri listelenemedi!", "Personel Mesai bilgileri Listeleme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        void Temizle()
        {
            dt_baslangic.Value = DateTime.Now;
            dt_bitis.Value = DateTime.Now;
            cb_ay.SelectedIndex = 0;
            cb_yil.SelectedIndex = 0;
            cb_personel.SelectedIndex = 0;
            txt_mesai_ucret.Text = "0";

            foreach (Control item in gb_personel.Controls)
            {
                if (item is TextBox)
                {

                    item.Text = "";

                }
            }

            foreach (Control item in gb_mesai.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is MaskedTextBox)
                {
                    item.Text = "";
                }
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

        private void Personel_Mesai_İşlemleri_Load(object sender, EventArgs e)
        {
            listele();
            ComboPersonelGetir();
            cb_ay.SelectedIndex = 0;
            cb_yil.SelectedIndex = 0;
            cb_personel.SelectedIndex = 0;



            int yil = int.Parse(DateTime.Now.Year.ToString());
            for (int i = yil; i >= (yil - 10); i--)
            {
                cb_yil.Items.Add(i);
            }
        }
        private void Personel_Mesai_İşlemleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            Personel_Takip_Programı personel = new Personel_Takip_Programı();
            personel.Show();
            this.Hide();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into mesai(personel_id,baslangic_saat,bitis_saat,mesai_saat_ucret,tutar,donem,tarih) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", label_id.Text);
                komut.Parameters.AddWithValue("@p2", dt_baslangic.Text + " " + mb_baslangic_saat.Text);
                komut.Parameters.AddWithValue("@p3", dt_bitis.Text + " " + mb_bitis_saat.Text);
                komut.Parameters.AddWithValue("@p4", SqlDbType.Decimal).Value = decimal.Parse(txt_mesai_ucret.Text);
                komut.Parameters.AddWithValue("@p5", SqlDbType.Decimal).Value = decimal.Parse(txt_tutar.Text);
                komut.Parameters.AddWithValue("@p6", cb_ay.Text + "/" + cb_yil.Text);
                komut.Parameters.AddWithValue("@p7", SqlDbType.Date).Value = DateTime.Now;

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                listele();
                Temizle();

                MessageBox.Show("Mesai başarıyla kaydedildi.", "Mesai Kaydetme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Personel Mesai bilgileri kaydedilemedi!", "Personel Mesai bilgileri Kaydetme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Delete from mesai  where mesai_id=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", dg_mesai.CurrentRow.Cells[0].Value);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                listele();
                Temizle();

                MessageBox.Show("Mesai başarıyla silindi.", "Mesai Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Personel Mesai bilgileri silinemedi!", "Personel Mesai bilgileri Silme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {

                String baslangic = dt_baslangic.Value.ToString() + "/" + mb_baslangic_saat.Text;
                String bitis = dt_bitis.Value.ToString() + "/" + mb_bitis_saat.Text;

                SqlCommand komut = new SqlCommand("Update mesai Set baslangic_saat=@p2,bitis_saat=@p3,mesai_saat_ucret=@p4,tutar=@p5,donem=@p6,tarih=@p7 where mesai_id=@p8", bgl.baglanti());

                komut.Parameters.AddWithValue("@p2", baslangic);
                komut.Parameters.AddWithValue("@p3", bitis);
                komut.Parameters.AddWithValue("@p4", SqlDbType.Decimal).Value = decimal.Parse(txt_mesai_ucret.Text);
                komut.Parameters.AddWithValue("@p5", SqlDbType.Decimal).Value = decimal.Parse(txt_tutar.Text);
                komut.Parameters.AddWithValue("@p6", cb_ay.Text + "/" + cb_yil.Text);
                komut.Parameters.AddWithValue("@p7", SqlDbType.Date).Value = DateTime.Now;

                komut.Parameters.AddWithValue("@p8", dg_mesai.CurrentRow.Cells[0].Value);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                listele();
                Temizle();

                MessageBox.Show("Mesai başarıyla güncellendi.", "Mesai Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Personel Mesai bilgileri güncellenemedi!", "Personel Mesai bilgileri Güncelleme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void cb_personel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_personel.SelectedIndex == 0)
            {
                label_id.Text = "0";
                return;
            }
            else
            {
                PersonelIDGetir();
            }
        }

        private void txt_tutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_mesai_ucret_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dt_bitis.Value >= dt_baslangic.Value)
                {
                    string baslangic = dt_baslangic.Text + " " + mb_baslangic_saat.Text;
                    string bitis = dt_bitis.Text + " " + mb_bitis_saat.Text;
                    TimeSpan saatFark = DateTime.Parse(bitis) - DateTime.Parse(baslangic);
                    double MSaatiUcret = Convert.ToDouble(txt_mesai_ucret.Text);
                    double tutar = saatFark.TotalHours * MSaatiUcret;
                    txt_tutar.Text = tutar.ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Başlangıç tarihi, bitiş tarihinden büyük olamaz !", "Tarih Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Personel Mesai ücreti hesaplanamadı, bilgileri kontrol ediniz!", "Personel Mesai Ücret Hesaplama Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dg_mesai_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            PersonelSec();
            txt_mesai_ucret.Text = dg_mesai.CurrentRow.Cells["mesai_saat_ucret"].Value.ToString();

            string baslangic = dg_mesai.CurrentRow.Cells["baslangic_saat"].Value.ToString();
            string bitis = dg_mesai.CurrentRow.Cells["bitis_saat"].Value.ToString();
            string donem = dg_mesai.CurrentRow.Cells["donem"].Value.ToString();


            dt_baslangic.Text = baslangic.Substring(0, 10);
            mb_baslangic_saat.Text = baslangic.Substring(11);


            dt_bitis.Text = bitis.Substring(0, 10);
            mb_bitis_saat.Text = bitis.Substring(11);

            int ayrac = donem.IndexOf("/");
            cb_ay.Text = donem.Substring(0, ayrac);
            cb_yil.Text = donem.Substring(ayrac + 1);
        }


        private void btn_mesai_ode_Click(object sender, EventArgs e)
        {
            try
            {
                String odenmeDurumu = "ödemesi yapıldı";
                SqlCommand komut = new SqlCommand("Update mesai Set mesai_odeme = @p1 where mesai_id= @p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", odenmeDurumu);
                komut.Parameters.AddWithValue("@p2", dg_mesai.CurrentRow.Cells[0].Value);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                listele();
                Temizle();

                MessageBox.Show("Mesai ödemesi yapıldı!", "Mesai Ödeme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Personel Mesai ücreti ödenemedi!", "Personel Mesai Ücreti Ödeme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_tum_mesai_ode_Click(object sender, EventArgs e)
        {
            try
            {
                String odenmeDurumu = "ödemesi yapıldı";
                SqlCommand komut = new SqlCommand("Update mesai Set mesai_odeme = @p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", odenmeDurumu);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                listele();
                Temizle();

                MessageBox.Show("Tüm mesailer ödenmiştir.", "Tüm Mesaileri Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Personel Tüm Mesai ücreti ödenemedi!", "Personel Tüm Mesai Ücreti Ödeme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_mesai_odeme_iptal_Click(object sender, EventArgs e)
        {
            try
            {
                String odenmeDurumu = "ödemesi iptal edildi";
                SqlCommand komut = new SqlCommand("Update mesai Set mesai_odeme = @p1 where mesai_id= @p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", odenmeDurumu);
                komut.Parameters.AddWithValue("@p2", dg_mesai.CurrentRow.Cells[0].Value);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                listele();
                Temizle();

                MessageBox.Show("Mesai ödemesi iptal edildi!", "Mesai Ödeme İptal Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Personel Mesai ücreti ödeme iptal edilemedi!", "Personel  Mesai Ücreti Ödeme İptal Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                String sql = "SELECT m.mesai_id,p.ad,p.soyad,m.baslangic_saat,m.bitis_saat,m.mesai_saat_ucret,m.tutar,m.donem,m.mesai_odeme,m.tarih" +
                    " FROM mesai as m INNER JOIN personel as p ON m.personel_id = p.personel_id where ad='" + txt_ara.Text + "'";
                DataTable mesai = new DataTable();
                SqlDataAdapter mi = new SqlDataAdapter(sql, bgl.baglanti());
                mi.Fill(mesai);
                dg_mesai.DataSource = mesai;

            }
            catch
            {
                MessageBox.Show("Personel Mesai bilgileri aranamadı!", "Personel  Mesai Ara Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}


