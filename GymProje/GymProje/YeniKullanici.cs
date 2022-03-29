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
    public partial class YeniKullanici : Form
    {
        public YeniKullanici()
        {
            InitializeComponent();
        }


        private void YeniKullanici_Load(object sender, EventArgs e)
        {

        }



        private void btnkaydet_Click(object sender, EventArgs e)
        {
            string isim = txtad.Text;
            string soyad = txtsoyad.Text;

            string cinsiyet = "";

            bool isChacked = radioButton1.Checked;
             
            if (isChacked)
            {
                cinsiyet = radioButton1.Text;

            }
            else
            {
                cinsiyet = radioButton2.Text; 
            }

            string dt = dateTimePickerdogumtarıhı.Text;
            Int64 telefon = Int64.Parse(txttelefon.Text);
            string Email = txtemail.Text;
            string UyelikTarihi = dateTimePickeruyelıktarıhı.Text;
            string SporZamani = comboBoxsporzamanı.Text;
            string Adres = adres.Text;
            string Abonelik = comboBoxabonelik.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= (localdb)\\MSSQLLocalDB; database = dbGYM; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
           // cmd.CommandText="insert into YeniUye(isim,soyisim,cinsiyet,DT,TelefonNo,Email,UyelikTarihi,SporZamanı,Adres,Aboneliksuresi) values ('" + isim + "','"+ soyad + "','" + cinsiyet + "','" + dt + "'," + telefon + ",'" + Email + "','"+ UyelikTarihi + "','" + SporZamani+"'+'"+Adres+"','" + Abonelik + "')";
            cmd.CommandText = string.Format("insert into YeniUye(isim,soyisim,cinsiyet,DT,TelefonNo,Email,UyelikTarihi,SporZamanı,Adres,Aboneliksuresi) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", isim,soyad,cinsiyet,dt,telefon,Email,UyelikTarihi,SporZamani,Adres,Abonelik);


            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved.");

               

        }

        private void btnsıfırla_Click(object sender, EventArgs e)
        {
            txtad.Clear();
            txtsoyad.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            txttelefon.Clear();
            txtemail.Clear();
            comboBoxsporzamanı.ResetText();
            comboBoxabonelik.ResetText();
            adres.Clear();
            dateTimePickerdogumtarıhı.Value = DateTime.Now;
            dateTimePickeruyelıktarıhı.Value = DateTime.Now;




        }
    }
}
