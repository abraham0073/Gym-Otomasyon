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
    public partial class ÜyeBul : Form
    {
        public ÜyeBul()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtArama.Text !="")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = (localdb)\\MSSQLLocalDB; database = dbGYM; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select *from YeniUye where UID =" + txtArama.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Lütfen bir değer giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

          
                

        }

        private void ÜyeBul_Load(object sender, EventArgs e)
        {

        }
    }
}
