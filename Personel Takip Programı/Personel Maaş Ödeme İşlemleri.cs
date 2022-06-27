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
    public partial class Personel_Maaş_Hesaplama_İşlemleri : Form
    {
        public Personel_Maaş_Hesaplama_İşlemleri()
        {
            InitializeComponent();
        }

        Veritabanı bgl = new Veritabanı();
        String sql = "SELECT m.maas_id,m.donem,p.ad,p.soyad,m.toplam_maas,p.sgk_prim,m.tarih,m.maas_odeme FROM maas as m INNER JOIN personel as p ON p.personel_id = m.personel_id  ";

        void listele()
        {
            try
            {
                DataTable maas = new DataTable();
                SqlDataAdapter veri = new SqlDataAdapter(sql, bgl.baglanti());
                veri.Fill(maas);
                dg_maas.DataSource = maas;


            }
            catch 
            {
                MessageBox.Show("Personel Maaş Ödeme bilgileri listelenemedi!", "Personel Maaş Ödeme bilgileri Listeleme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        void Temizle()
        {


            cb_personel.SelectedIndex = 0;
            cb_ay.SelectedIndex = 0;
            cb_yil.SelectedIndex = 0;
            txt_ara.Text = "";

            foreach (Control item in gb_personel.Controls)
            {
                if (item is TextBox)
                {

                    item.Text = "";

                }
            }

            foreach (Control item in gb_maas.Controls)
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
        SqlDataReader ComboPersonelGetir()
        {
            
            SqlCommand prsnl = new SqlCommand("SELECT personel_id,ad,soyad FROM personel", bgl.baglanti());
            SqlDataReader dr = prsnl.ExecuteReader();
            while (dr.Read())
            {
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
        SqlDataReader ToplamMaasGetir()
        {
            DataTable personel = new DataTable();
            SqlCommand prsnl = new SqlCommand("SELECT SUM(maas+yol_yardim+yemek_yardim) as toplam_maas FROM  personel where personel_id ='" + label_id.Text + "'" + "GROUP BY personel_id", bgl.baglanti());
            SqlDataReader dr = prsnl.ExecuteReader();
            while (dr.Read())
            {
                txt_toplam_maas.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
            return dr;
        }

        SqlDataReader SgkPrimGetir()
        {
            DataTable personel = new DataTable();
            SqlCommand prsnl = new SqlCommand("SELECT sgk_prim as sgk_prim FROM  personel where personel_id ='" + label_id.Text + "'", bgl.baglanti());
            SqlDataReader dr = prsnl.ExecuteReader();
            while (dr.Read())
            {
                txt_sgk_prim.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
            return dr;
        }




        private void Personel_Maaş_Hesaplama_İşlemleri_Load(object sender, EventArgs e)
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



        private void cb_personel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_personel.SelectedIndex == 0)
            {
                label_id.Text = "0";
                txt_toplam_maas.Clear();
                txt_sgk_prim.Clear();
                return;
            }
            else
            {
                PersonelIDGetir();
            }
            ToplamMaasGetir();
            SgkPrimGetir();
        }

        private void btn_maas_odeme_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into maas (personel_id,donem,toplam_maas,tarih) values(@p1,@p2,@p3,@p4)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", label_id.Text);
                komut.Parameters.AddWithValue("@p2", cb_ay.Text + "/" + cb_yil.Text);
                komut.Parameters.AddWithValue("@p3", SqlDbType.Decimal).Value = Decimal.Parse(txt_toplam_maas.Text);
                komut.Parameters.AddWithValue("@p4", SqlDbType.Date).Value = DateTime.Now;

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                listele();
                Temizle();

                MessageBox.Show("Maaş ödeme bilgisi eklendi!" + Environment.NewLine, "Maaş Ödeme Bilgisi Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Personel Maaş Ödeme bilgileri eklenemedi!", "Personel Maaş Ödeme bilgileri Ekleme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_maas_odeme_Click(object sender, EventArgs e)
        {
            try
            {
                String odenmeDurumu = "ödemesi yapıldı";
                SqlCommand komut = new SqlCommand("Update maas Set maas_odeme = @p1 where maas_id= @p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", odenmeDurumu);
                komut.Parameters.AddWithValue("@p2", dg_maas.CurrentRow.Cells[0].Value);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                listele();
                Temizle();

                MessageBox.Show("Maaş ödemesi yapıldı!" + Environment.NewLine, "Maaş Ödeme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Personel Maaş ödenemedi!", "Personel Maaş Ödeme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "SELECT m.maas_id,m.donem,p.ad,p.soyad,m.toplam_maas,p.sgk_prim,m.tarih,m.maas_odeme FROM maas as m INNER JOIN personel as p ON p.personel_id = m.personel_id where ad='" + txt_ara.Text + "'";
                DataTable maas = new DataTable();
                SqlDataAdapter ms = new SqlDataAdapter(sql, bgl.baglanti());
                ms.Fill(maas);
                dg_maas.DataSource = maas;
            }
            catch
            {
                MessageBox.Show("Personel Maaş Ödeme bilgileri aranamadı!", "Personel Maaş Ödeme bilgileri Ara Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_kayitlar_Click(object sender, EventArgs e)
        {
            listele();
            Temizle();
        }

        private void btn_maas_odeme_iptal_Click(object sender, EventArgs e)
        {
            try
            {
                String odenmeDurumu = "ödemesi iptal edildi";
                SqlCommand komut = new SqlCommand("Update maas Set maas_odeme = @p1 where maas_id= @p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", odenmeDurumu);
                komut.Parameters.AddWithValue("@p2", dg_maas.CurrentRow.Cells[0].Value);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                listele();
                Temizle();

                MessageBox.Show("Maaş ödemesi iptal edildi!" + Environment.NewLine, "Maaş Ödeme İptal Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Personel Maaş ödemesi iptal edilemedi!", "Personel Maaş Ödeme İptal Etme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_maas_sil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Delete from maas  where maas_id=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", dg_maas.CurrentRow.Cells[0].Value);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                listele();
                Temizle();

                MessageBox.Show("Maaş başarıyla silindi.", "Maaş Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Personel Maaş Ödeme bilgileri silinemedi!", "Personel Maaş Ödeme bilgileri Silme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dg_maas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PersonelSec();

            String donem = dg_maas.CurrentRow.Cells["donem"].Value.ToString();
            int ayrac = donem.IndexOf("/");
            cb_ay.Text = donem.Substring(0, ayrac);
            cb_yil.Text = donem.Substring(ayrac + 1);

            txt_toplam_maas.Text = dg_maas.CurrentRow.Cells["toplam_maas"].Value.ToString();
            txt_sgk_prim.Text = dg_maas.CurrentRow.Cells["sgk_prim"].Value.ToString();
        }

   
    }
}
