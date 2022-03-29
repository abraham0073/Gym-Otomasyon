using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymProje
{
    public partial class Ekipman : Form
    {
        public Ekipman()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string EkipmanAdı = txtEkipmanAdı.Text;
            string Açıklama = txtAçıklama.Text;
            string KullanılanKaslar = txtKullanılanKaslar.Text;
            string TeslimatTarihi = dateTimePickerTeslimatTarihi.Text;
            Int64 Maliyet = Int64.Parse(txtMaliyet.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= (localdb)\\MSSQLLocalDB; database = dbGYM; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = string.Format("insert into Ekipman(EkipmanAdı,Açıklama,KullanılanKaslar,TeslimatTarihi,Maliyet) values ('{0}','{1}','{2}','{3}','{4}')", EkipmanAdı, Açıklama, KullanılanKaslar, TeslimatTarihi, Maliyet);


            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Veri Kaydedildi.","Eklendi",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEkipmanAdı.Clear();
            txtAçıklama.Clear();
            txtKullanılanKaslar.Clear();
            txtMaliyet.Clear();
            dateTimePickerTeslimatTarihi.Value = DateTime.Now;

        }

        private void btnEkipmanKontrol_Click(object sender, EventArgs e)
        {
            EkipmanKontrol EK = new EkipmanKontrol();
            EK.Show();

        }
    }
}
