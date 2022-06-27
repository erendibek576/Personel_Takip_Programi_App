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
    public partial class Personel_Takip_Programı : Form
    {
        public Personel_Takip_Programı()
        {
            InitializeComponent();
        }

        Veritabanı bgl = new Veritabanı();


        void FormGetir(Form form, Panel panel)
        {
            panel.Controls.Clear();
            form.TopLevel = false;
            panel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            form.Show();
            form.FormBorderStyle = FormBorderStyle.None;
        }

        private void Personel_Takip_Programı_Load(object sender, EventArgs e)
        {
            panel_islemler.Width = 70;
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (panel_islemler.Width == 70)
            {
                panel_islemler.Width = 185;
            }
            else if (panel_islemler.Width == 185)
            {
                panel_islemler.Width = 70;
            }

        }
        private void btn_admin_kayit_Click(object sender, EventArgs e)
        {
            Admin_İşlemleri admin = new Admin_İşlemleri();
            admin.Show();
            this.Hide();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Personel_Takip_Programı_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_personel_mesai_Click(object sender, EventArgs e)
        {
            Personel_Mesai_İşlemleri mesai = new Personel_Mesai_İşlemleri();
            mesai.Show();
            FormGetir(Personel_Mesai_İşlemleri.ActiveForm, panel_formlar);
        }

        private void btn_personel_islem_Click(object sender, EventArgs e)
        {
            Personel_İşlemleri personel = new Personel_İşlemleri();
            personel.Show();
            FormGetir(Personel_İşlemleri.ActiveForm, panel_formlar);
        }

        private void btn_personel_izin_Click(object sender, EventArgs e)
        {
            Personel_İzin_İşlemleri izin = new Personel_İzin_İşlemleri();
            izin.Show();
            FormGetir(Personel_İzin_İşlemleri.ActiveForm, panel_formlar);
        }

        private void btn_personel_maas_Click(object sender, EventArgs e)
        {
            Personel_Maaş_Hesaplama_İşlemleri maas = new Personel_Maaş_Hesaplama_İşlemleri();
            maas.Show();
            FormGetir(Personel_Maaş_Hesaplama_İşlemleri.ActiveForm, panel_formlar);
        }

        private void btn_personel_kıdem_tazminat_Click(object sender, EventArgs e)
        {
            Personel_Kıdem_Tazminatı_Hesaplama_İşlemleri tazminat = new Personel_Kıdem_Tazminatı_Hesaplama_İşlemleri();
            tazminat.Show();
            FormGetir(Personel_Kıdem_Tazminatı_Hesaplama_İşlemleri.ActiveForm, panel_formlar);
        }

        private void btn_dprtmn_islemleri_Click(object sender, EventArgs e)
        {
            Departman_İşlemleri departman = new Departman_İşlemleri();
            departman.Show();
            this.Hide();

        }


    }
}
