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
    public partial class Admin_Paneli : Form
    {
        public Admin_Paneli()
        {
            InitializeComponent();
        }

        Veritabanı bgl = new Veritabanı();
        void admin()
        {
            try
            {

                SqlCommand komut = new SqlCommand("Select * From admin where k_adi=@p1 and sifre=@p2", bgl.baglanti());

                komut.Parameters.Add("@p1", txt_kul_adi.Text);
                komut.Parameters.Add("@p2", txt_sifre.Text);

                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    Personel_Takip_Programı personel = new Personel_Takip_Programı();
                    personel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı !" + Environment.NewLine, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                bgl.baglanti().Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı bağlantısı başarısız!" + Environment.NewLine, "Veritabanı Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(txt_kul_adi.Text) || String.IsNullOrEmpty(txt_sifre.Text))
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş bırakılamaz!" + Environment.NewLine, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                admin();

            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Admin_Paneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
