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
    public partial class Admin_İşlemleri : Form
    {
        public Admin_İşlemleri()
        {
            InitializeComponent();
        }

        Veritabanı bgl = new Veritabanı();

        void listele()
        {
            try
            {
                DataTable admin = new DataTable();
                SqlDataAdapter veri = new SqlDataAdapter("SELECT * FROM admin", bgl.baglanti());
                veri.Fill(admin);
                dg_admin_liste.DataSource = admin;


            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    Console.WriteLine("Index #" + i + "\n" +
                    "Message: " + ex.Errors[i].Message + "\n" +
                    "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                    "Source: " + ex.Errors[i].Source + "\n");

                }

            }

        }
        void Temizle()
        {
            txt_admn_ara.Text = "";

            foreach (Control item in gb_admin.Controls)
            {
                if (item is TextBox)
                {

                    item.Text = "";

                }
            }

        }
        private void Admin_Kayıt_İşlemleri_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void Admin_Kayıt_İşlemleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form personel = Application.OpenForms["Personel_Takip_Programı"];
            personel.Show();
            this.Hide();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_admin_sifre.Text == txt_sifre_tekrar.Text)
            {
                SqlCommand komut = new SqlCommand("insert into admin(k_adi,sifre,sifre_tekrar) values(@p1,@p2,@p3)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txt_admin_kul_adi.Text);
                komut.Parameters.AddWithValue("@p2", txt_admin_sifre.Text);
                komut.Parameters.AddWithValue("@p3", txt_sifre_tekrar.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                listele();
                Temizle();
                MessageBox.Show("Tebrikler ! Admin bilgileri başarıyla eklendi.", "Admin Bilgileri Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Uyarı ! Şifreler birbiriyle uyuşmuyor.", "Admin Şifre Tekrarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from admin  where admin_id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", dg_admin_liste.CurrentRow.Cells[0].Value);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            listele();
            Temizle();
            MessageBox.Show("Tebrikler ! Admin bilgileri başarıyla silindi.", "Admin Bilgileri Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (txt_admin_sifre.Text == txt_sifre_tekrar.Text)
            {
                SqlCommand komut = new SqlCommand("Update admin Set k_adi=@p1 ,sifre=@p2, sifre_tekrar=@p3 where admin_id=@p4", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txt_admin_kul_adi.Text);
                komut.Parameters.AddWithValue("@p2", txt_admin_sifre.Text);
                komut.Parameters.AddWithValue("@p3", txt_sifre_tekrar.Text);
                komut.Parameters.AddWithValue("@p4", dg_admin_liste.CurrentRow.Cells[0].Value);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                listele();
                Temizle();
                MessageBox.Show("Tebrikler ! Admin bilgileri başarıyla güncellendi.", "Admin Bilgileri Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Uyarı ! Şifreler birbiriyle uyuşmuyor.", "Admin Şifre Tekrarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    private void dg_admin_liste_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_admin_kul_adi.Text = dg_admin_liste.CurrentRow.Cells[1].Value.ToString();
            txt_admin_sifre.Text = dg_admin_liste.CurrentRow.Cells[2].Value.ToString();
            txt_sifre_tekrar.Text = dg_admin_liste.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {

            DataTable admin = new DataTable();
            SqlDataAdapter veri = new SqlDataAdapter("SELECT * FROM admin where k_adi ='" + txt_admn_ara.Text + "'", bgl.baglanti());
            veri.Fill(admin);
            dg_admin_liste.DataSource = admin;
        }

        private void btn_kayitlar_Click(object sender, EventArgs e)
        {
            listele();
            Temizle();
        }
    }
}
