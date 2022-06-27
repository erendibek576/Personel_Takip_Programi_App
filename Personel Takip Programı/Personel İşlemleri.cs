using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;



namespace BBP201_210111409_Muhammed_Eren_Dibek
{
    public partial class Personel_İşlemleri : Form
    {
        public Personel_İşlemleri()
        {
            InitializeComponent();
        }


        Veritabanı bgl = new Veritabanı();


        String resimPath; //resmin eklendiği yol
        String sql = "SELECT p.personel_id,p.tc_kimlik,p.sicil_no,p.ad,p.soyad,p.email,p.dogum_yer,p.dogum_tarih,p.cinsiyet,p.adres,p.cep_telefon,p.ev_telefon,p.askerlik_durum,d.departman_adi,p.durum,p.is_baslangic_tarih,p.iban_no,p.maas,p.yol_yardim,p.yemek_yardim,p.sgk_prim,p.personel_resim FROM personel as p INNER JOIN departman as d ON p.departman_id = d.departman_id";

        void listele()
        {
            try
            {
                DataTable personel = new DataTable();
                SqlDataAdapter prsnl = new SqlDataAdapter(sql, bgl.baglanti());
                prsnl.Fill(personel);
                dg_personel.DataSource = personel;
                bgl.baglanti().Close();
            }
            catch
            {
                MessageBox.Show("Personel bilgileri listelenemedi!", "Personel Bilgileri Listeleme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        void ResimKaydet()
        {
            try
            {
                pb_personel_resim.Image.Save(".\\personel_resim\\" + openFileDialog1.SafeFileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (BadImageFormatException e)
            {
                Console.WriteLine("Unable to load {0}.", resimPath);
                Console.WriteLine(e.Message.Substring(0,
                                  e.Message.IndexOf(".") + 1));
            }
        }

        void Temizle()
        {
            dt_dogum_tarih.Value = DateTime.Now;
            dt_is_baslangic.Value = DateTime.Now;
            cb_departman.Text = "";
            pb_personel_resim.Image = null;

            foreach (Control item in gp_kisi_bilgi.Controls)
            {
                if (item is TextBox)
                {

                    item.Text = "";

                }
                if (item is MaskedTextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
                if (item is RichTextBox)
                {
                    item.Text = "";
                }

            }

            foreach (Control item in gb_maas_bilgi.Controls)
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
        DataTable departmanGetir()
        {

            DataTable departman = new DataTable();
            SqlDataAdapter dprtmn = new SqlDataAdapter("SELECT * FROM departman", bgl.baglanti());
            dprtmn.Fill(departman);
            cb_departman.DataSource = departman;
            cb_departman.ValueMember = "departman_id";
            cb_departman.DisplayMember = "departman_adi";
            bgl.baglanti().Close();
            return departman;

        }

        private void Personel_İşlemleri_Load(object sender, EventArgs e)
        {
            listele();
            departmanGetir();
        }



        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            resimPath = ".\\personel_resim\\" + openFileDialog1.SafeFileName;

            try
            {
                SqlCommand komut = new SqlCommand("insert into personel(tc_kimlik,sicil_no,ad,soyad,email,dogum_yer,dogum_tarih,cinsiyet,adres,cep_telefon,ev_telefon,askerlik_durum,departman_id,durum,is_baslangic_tarih,iban_no,maas,yol_yardim,yemek_yardim,sgk_prim,personel_resim)" +
       "values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20,@p21)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", mb_kimlik.Text);
                komut.Parameters.AddWithValue("@p2", mb_sicil.Text);
                komut.Parameters.AddWithValue("@p3", txt_ad.Text);
                komut.Parameters.AddWithValue("@p4", txt_soyad.Text);
                komut.Parameters.AddWithValue("@p5", txt_email.Text);
                komut.Parameters.AddWithValue("@p6", txt_dogum_yer.Text);
                komut.Parameters.AddWithValue("@p7", SqlDbType.Date).Value = dt_dogum_tarih.Value;
                komut.Parameters.AddWithValue("@p8", cb_cinsiyet.Text);
                komut.Parameters.AddWithValue("@p9", txt_adres.Text);
                komut.Parameters.AddWithValue("@p10", mb_cep_tel.Text);
                komut.Parameters.AddWithValue("@p11", mb_ev_tel.Text);
                komut.Parameters.AddWithValue("@p12", cb_asker_durum.Text);
                komut.Parameters.AddWithValue("@p13", (int)cb_departman.SelectedValue);
                komut.Parameters.AddWithValue("@p14", cb_durum.Text);
                komut.Parameters.AddWithValue("@p15", SqlDbType.Date).Value = dt_is_baslangic.Value;
                komut.Parameters.AddWithValue("@p16", mb_iban.Text);
                komut.Parameters.AddWithValue("@p17", SqlDbType.Decimal).Value = decimal.Parse(txt_maas.Text);
                komut.Parameters.AddWithValue("@p18", SqlDbType.Decimal).Value = decimal.Parse(txt_yol.Text);
                komut.Parameters.AddWithValue("@p19", SqlDbType.Decimal).Value = decimal.Parse(txt_yemek.Text);
                komut.Parameters.AddWithValue("@p20", SqlDbType.Decimal).Value = decimal.Parse(txt_sigorta.Text);
                komut.Parameters.AddWithValue("@p21", resimPath);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                ResimKaydet();
                listele();
                Temizle();

                MessageBox.Show("Tebrikler ! Personel bilgileri başarıyla eklendi.", "Personel Bilgileri Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Personel bilgileri eklenemedi, Lütfen bütün bilgileri doldurunuz!", "Personel Bilgileri Kayıt Ekleme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(dg_personel.CurrentRow.Cells[21].Value.ToString());

                SqlCommand komut = new SqlCommand("Delete from personel  where personel_id=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", int.Parse(dg_personel.CurrentRow.Cells[0].Value.ToString()));

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                listele();
                Temizle();
                MessageBox.Show("Tebrikler ! Personel bilgileri başarıyla silindi.", "Personel Bilgileri Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Personel bilgileri silinmedi!", "Personel Bilgileri Kayıt Silme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(dg_personel.CurrentRow.Cells[21].Value.ToString());
                resimPath = @".\personel_resim\" + dg_personel.CurrentRow.Cells[0].Value + "_" + openFileDialog1.SafeFileName;

                SqlCommand komut = new SqlCommand("Update personel Set tc_kimlik=@p1,sicil_no=@p2,ad=@p3,soyad=@p4,email=@p5,dogum_yer=@p6,dogum_tarih=@p7,cinsiyet=@p8,adres=@p9,cep_telefon=@p10,ev_telefon=@p11,askerlik_durum=@p12,departman_id=@p13,durum=@p14,is_baslangic_tarih=@p15,iban_no=@p16,maas=@p17,yol_yardim=@p18,yemek_yardim=@p19,sgk_prim=@p20,personel_resim=@p21 where personel_id=@p22", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", mb_kimlik.Text);
                komut.Parameters.AddWithValue("@p2", mb_sicil.Text);
                komut.Parameters.AddWithValue("@p3", txt_ad.Text);
                komut.Parameters.AddWithValue("@p4", txt_soyad.Text);
                komut.Parameters.AddWithValue("@p5", txt_email.Text);
                komut.Parameters.AddWithValue("@p6", txt_dogum_yer.Text);
                komut.Parameters.AddWithValue("@p7", SqlDbType.Date).Value = dt_dogum_tarih.Value;
                komut.Parameters.AddWithValue("@p8", cb_cinsiyet.Text);
                komut.Parameters.AddWithValue("@p9", txt_adres.Text);
                komut.Parameters.AddWithValue("@p10", mb_cep_tel.Text);
                komut.Parameters.AddWithValue("@p11", mb_ev_tel.Text);
                komut.Parameters.AddWithValue("@p12", cb_asker_durum.Text);
                komut.Parameters.AddWithValue("@p13", (int)cb_departman.SelectedValue);
                komut.Parameters.AddWithValue("@p14", cb_durum.Text);
                komut.Parameters.AddWithValue("@p15", SqlDbType.Date).Value = dt_is_baslangic.Value;
                komut.Parameters.AddWithValue("@p16", mb_iban.Text);
                komut.Parameters.AddWithValue("@p17", SqlDbType.Decimal).Value = decimal.Parse(txt_maas.Text);
                komut.Parameters.AddWithValue("@p18", SqlDbType.Decimal).Value = decimal.Parse(txt_yol.Text);
                komut.Parameters.AddWithValue("@p19", SqlDbType.Decimal).Value = decimal.Parse(txt_yemek.Text);
                komut.Parameters.AddWithValue("@p20", SqlDbType.Decimal).Value = decimal.Parse(txt_sigorta.Text);
                komut.Parameters.AddWithValue("@p21", resimPath);
                komut.Parameters.AddWithValue("@p22", dg_personel.CurrentRow.Cells[0].Value);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                pb_personel_resim.Image.Save(".\\personel_resim\\" + dg_personel.CurrentRow.Cells[0].Value + "_" + openFileDialog1.SafeFileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                listele();
                Temizle();


                MessageBox.Show("Tebrikler ! Personel bilgileri başarıyla güncellendi.", "Personel Bilgileri Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Personel bilgileri güncellenemedi!", "Personel Bilgileri Kayıt Güncelleme Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_p_resim_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Resim Yükleme Alanı";
                openFileDialog1.FileName = "Resim Seç";
                openFileDialog1.InitialDirectory = @"C:\Masaüstü";
                openFileDialog1.Filter = "Resim Dosyası (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png|Tüm Dosyalar|*.*";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    if (Image.FromFile(openFileDialog1.FileName).Width <= 256 && Image.FromFile(openFileDialog1.FileName).Height <= 256)
                    {
                        String resim = openFileDialog1.FileName.ToString();
                        pb_personel_resim.Image = Image.FromFile(resim);



                    }
                    else
                    {
                        MessageBox.Show("Resim boyutu çok büyük !", "Resim Boyutu Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch
            {
                MessageBox.Show("Lütfen resim seçiniz!", "Personel Resim Seçme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
        private void dg_personel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mb_kimlik.Text = dg_personel.CurrentRow.Cells[1].Value.ToString();
            mb_sicil.Text = dg_personel.CurrentRow.Cells[2].Value.ToString();
            txt_ad.Text = dg_personel.CurrentRow.Cells[3].Value.ToString();
            txt_soyad.Text = dg_personel.CurrentRow.Cells[4].Value.ToString();
            txt_email.Text = dg_personel.CurrentRow.Cells[5].Value.ToString();
            txt_dogum_yer.Text = dg_personel.CurrentRow.Cells[6].Value.ToString();
            dt_dogum_tarih.Value = DateTime.Parse(dg_personel.CurrentRow.Cells[7].Value.ToString());
            cb_cinsiyet.Text = dg_personel.CurrentRow.Cells[8].Value.ToString();
            txt_adres.Text = dg_personel.CurrentRow.Cells[9].Value.ToString();
            mb_cep_tel.Text = dg_personel.CurrentRow.Cells[10].Value.ToString();
            mb_ev_tel.Text = dg_personel.CurrentRow.Cells[11].Value.ToString();
            cb_asker_durum.Text = dg_personel.CurrentRow.Cells[12].Value.ToString();
            cb_departman.Text = dg_personel.CurrentRow.Cells[13].Value.ToString();
            cb_durum.Text = dg_personel.CurrentRow.Cells[14].Value.ToString();


            dt_is_baslangic.Value = DateTime.Parse(dg_personel.CurrentRow.Cells[15].Value.ToString());
            mb_iban.Text = dg_personel.CurrentRow.Cells[16].Value.ToString();
            txt_maas.Text = dg_personel.CurrentRow.Cells[17].Value.ToString();
            txt_yol.Text = dg_personel.CurrentRow.Cells[18].Value.ToString();
            txt_yemek.Text = dg_personel.CurrentRow.Cells[19].Value.ToString();
            txt_sigorta.Text = dg_personel.CurrentRow.Cells[20].Value.ToString();


            pb_personel_resim.ImageLocation = dg_personel.CurrentRow.Cells[21].Value.ToString();

        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "SELECT p.personel_id,p.tc_kimlik,p.sicil_no,p.ad,p.soyad,p.email,p.dogum_yer,p.dogum_tarih,p.cinsiyet,p.adres,p.cep_telefon,p.ev_telefon,p.askerlik_durum,d.departman_adi,p.durum,p.is_baslangic_tarih,p.iban_no,p.maas,p.yol_yardim,p.yemek_yardim,p.sgk_prim,p.personel_resim FROM personel as p INNER JOIN departman as d ON p.departman_id = d.departman_id where p.ad='" + txt_p_ara.Text + "'";
                DataTable personel = new DataTable();
                SqlDataAdapter prsnl = new SqlDataAdapter(sql, bgl.baglanti());
                prsnl.Fill(personel);
                dg_personel.DataSource = personel;
                bgl.baglanti().Close();
            }
            catch
            {
                MessageBox.Show("Personel bilgileri aranamadı!", "Personel Bilgileri Kayıt Ara Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_kayitlar_Click(object sender, EventArgs e)
        {
            listele();
            Temizle();

        }




    }
}
