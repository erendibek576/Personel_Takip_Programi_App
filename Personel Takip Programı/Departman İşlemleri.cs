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
    public partial class Departman_İşlemleri : Form
    {
        public Departman_İşlemleri()
        {
            InitializeComponent();
        }

        Veritabanı bgl = new Veritabanı();
        void listele()
        {
            try
            {
                DataTable departman = new DataTable();
                SqlDataAdapter veri = new SqlDataAdapter("SELECT * FROM departman", bgl.baglanti());
                veri.Fill(departman);
                dg_departman.DataSource = departman;


            }
            catch
            {
                MessageBox.Show("Departman bilgileri listelenemedi!", "Departman Listeleme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        void Temizle()
        {
            txt_departman.Text = "";
            rt_departman.Text = "";
        }

        private void Departman_İşlemleri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Departman_İşlemleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form personel = Application.OpenForms["Personel_Takip_Programı"];
            personel.Show();
            this.Hide();
        }

        private void btn_dprtmn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into departman(departman_adi,aciklama) values(@p1,@p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txt_departman.Text);
                komut.Parameters.AddWithValue("@p2", rt_departman.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                listele();
                Temizle();
                MessageBox.Show("Tebrikler ! Departmanı başarıyla Yüklediniz.", "Departman Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Departman bilgileri eklenemedi!", "Departman Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_dprtmn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Delete from departman  where departman_id=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", dg_departman.CurrentRow.Cells[0].Value);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                listele();
                Temizle();
                MessageBox.Show("Tebrikler ! Departmanı başarıyla Sildiniz", "Departman Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Departman bilgileri silinemedi!", "Departman Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_dprtmn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Update departman Set departman_adi=@p1, aciklama=@p2 where departman_id=@p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txt_departman.Text);
                komut.Parameters.AddWithValue("@p2", rt_departman.Text);
                komut.Parameters.AddWithValue("@p3", dg_departman.CurrentRow.Cells[0].Value);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                listele();
                Temizle();
                MessageBox.Show("Tebrikler ! Departman başarıyla Güncellendi.", "Hes Kodu Sorgulama", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Departman bilgileri güncellenemedi!", "Departman Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btn_ara_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable departman = new DataTable();
                SqlDataAdapter veri = new SqlDataAdapter("SELECT * FROM departman where departman_adi ='" + txt_departman.Text + "'", bgl.baglanti());
                veri.Fill(departman);
                dg_departman.DataSource = departman;
            }
            catch
            {
                MessageBox.Show("Departman bilgileri aranamadı!", "Departman Ara", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_kayitlar_Click(object sender, EventArgs e)
        {
            Temizle();
            listele();
        }

        private void dg_departman_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_departman.Text = dg_departman.CurrentRow.Cells[1].Value.ToString();
            rt_departman.Text = dg_departman.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
