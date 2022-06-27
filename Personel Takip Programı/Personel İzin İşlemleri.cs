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
    public partial class Personel_İzin_İşlemleri : Form
    {
        public Personel_İzin_İşlemleri()
        {
            InitializeComponent();
        }

        Veritabanı bgl = new Veritabanı();

        void listele()
        {
            try
            {
                DataTable izin = new DataTable();
                SqlDataAdapter veri = new SqlDataAdapter("SELECT i.izin_id,p.ad,p.soyad,i.izin_tur,i.izin_baslangic,i.izin_bitis,i.tarih,i.saat" +
                " FROM izin as i INNER JOIN personel as p ON i.personel_id = p.personel_id", bgl.baglanti());
                veri.Fill(izin);
                dg_izin.DataSource = izin;


            }
            catch
            {
                MessageBox.Show("İzin bilgileri listelenemedi!", "İzin Bilgileri Listeleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        void Temizle()
        {
            dt_izin_baslangic.Value = DateTime.Now;
            dt_izin_bitis.Value = DateTime.Now;
            cb_personel.SelectedIndex = 0;
            cb_izin_tur.SelectedIndex = 0;
            txt_ara.Text = "";

            foreach (Control item in gb_personel.Controls)
            {
                if (item is TextBox)
                {

                    item.Text = "";

                }
            }

            foreach (Control item in gb_izin.Controls)
            {
                if (item is TextBox)
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
        private void Personel_İzin_İşlemleri_Load(object sender, EventArgs e)
        {
            ComboPersonelGetir();
            listele();
            cb_personel.SelectedIndex = 0;
            cb_izin_tur.SelectedIndex = 0;
        }


        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (dt_izin_bitis.Value >= dt_izin_baslangic.Value)
                {
                    SqlCommand komut = new SqlCommand("insert into izin(personel_id,izin_tur,izin_baslangic,izin_bitis,tarih,saat) values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", label_id.Text);
                    komut.Parameters.AddWithValue("@p2", cb_izin_tur.Text);
                    komut.Parameters.AddWithValue("@p3", dt_izin_baslangic.Text);
                    komut.Parameters.AddWithValue("@p4", dt_izin_bitis.Text);
                    komut.Parameters.AddWithValue("@p5", SqlDbType.Date).Value = DateTime.Now;
                    komut.Parameters.AddWithValue("@p6", SqlDbType.DateTime).Value = DateTime.Now;

                    komut.ExecuteNonQuery();

                    bgl.baglanti().Close();

                    listele();
                    Temizle();

                    MessageBox.Show("İzin başarıyla kaydedildi.", "İzin Kaydetme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("İzin başlangıç tarihi, bitiş tarihinden büyük olmalıdır!", "İzin Tarih Bilgisi Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("İzin bilgileri kaydedilemedi!", "İzin Kaydetme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Delete from izin  where izin_id=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", dg_izin.CurrentRow.Cells[0].Value);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                listele();
                Temizle();

                MessageBox.Show("İzin başarıyla silindi.", "İzin Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("İzin bilgileri silinemedi!", "İzin Silme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dt_izin_bitis.Value >= dt_izin_baslangic.Value)
                {
                    SqlCommand komut = new SqlCommand("Update izin Set izin_tur=@p1, izin_baslangic=@p2 ,izin_bitis=@p3, tarih=@p4 ,saat=@p5 where izin_id=@p6", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", cb_izin_tur.Text);
                    komut.Parameters.AddWithValue("@p2", dt_izin_baslangic.Text);
                    komut.Parameters.AddWithValue("@p3", dt_izin_bitis.Text);
                    komut.Parameters.AddWithValue("@p4", SqlDbType.Date).Value = DateTime.Now;
                    komut.Parameters.AddWithValue("@p5", SqlDbType.DateTime).Value = DateTime.Now;

                    komut.Parameters.AddWithValue("@p6", dg_izin.CurrentRow.Cells[0].Value);

                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();

                    listele();
                    Temizle();

                    MessageBox.Show("İzin başarıyla güncellendi.", "İzin Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("İzin başlangıç tarihi, bitiş tarihinden büyük olmalıdır!", "İzin Tarih Bilgisi Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("İzin bilgileri güncellenemedi!", "İzin Güncelleme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                String sql = "SELECT izin_id,p.ad,p.soyad,i.izin_tur,i.izin_baslangic,i.izin_bitis,i.tarih,i.saat" +
                    " FROM izin as i INNER JOIN personel as p ON i.personel_id = p.personel_id where ad='" + txt_ara.Text + "'";
                DataTable izin = new DataTable();
                SqlDataAdapter iz = new SqlDataAdapter(sql, bgl.baglanti());
                iz.Fill(izin);
                dg_izin.DataSource = izin;
            }
            catch
            {
                MessageBox.Show("İzin bilgileri aranamadı!", "İzin Ara Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dg_izin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PersonelSec();
            cb_izin_tur.Text = dg_izin.CurrentRow.Cells["izin_tur"].Value.ToString();
            dt_izin_baslangic.Text = dg_izin.CurrentRow.Cells["izin_baslangic"].Value.ToString();
            dt_izin_bitis.Text = dg_izin.CurrentRow.Cells["izin_bitis"].Value.ToString();
        }
    }
}
