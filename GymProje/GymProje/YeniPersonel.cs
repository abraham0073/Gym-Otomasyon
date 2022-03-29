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
    public partial class YeniPersonelMenu : Form
    {
        public YeniPersonelMenu()
        {
            InitializeComponent();
        }

        private void YeniPersonelMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            string isim = textİsim.Text;
            string soyisim = textSoyİsim.Text;

            string cinsiyet = "";
            bool ischecked = radioButton1.Checked;

            if (ischecked)
            {
                cinsiyet = radioButton1.Text;

            }
            else
            {
                cinsiyet = radioButton2.Text;
            }
            string DogumTarihi = dateTimePickerDogumTarihi.Text;
            Int64 telefon = Int64.Parse(texTelefon.Text);
            string Email = textEmail.Text;
            string ÜyelikTarihi = dateTimePickerÜyelikTarihi.Text;
            string Durum = textDurum.Text;
            string Sehir = txtSehir.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= (localdb)\\MSSQLLocalDB; database = dbGYM; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = string.Format("insert into YeniPersonel(isim,soyisim,cinsiyet,DT,TelefonNo,Email,UyelikTarihi,Durum,Sehir) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", isim, soyisim, cinsiyet, DogumTarihi, telefon, Email, ÜyelikTarihi, Durum, Sehir);


            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved.");

        }
         private void btnsıfırla_Click(object sender, EventArgs e)
        {
            textİsim.Clear();
            textSoyİsim.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            texTelefon.Clear();
            textEmail.Clear();
            textDurum.Clear();
            txtSehir.Clear();
            dateTimePickerDogumTarihi.Value = DateTime.Now;
            dateTimePickerÜyelikTarihi.Value = DateTime.Now;
        }
      

    }
}
