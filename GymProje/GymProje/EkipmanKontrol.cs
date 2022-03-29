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
    public partial class EkipmanKontrol : Form
    {
        public EkipmanKontrol()
        {
            InitializeComponent();
        }


        private void EkipmanKontrol_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= (localdb)\\MSSQLLocalDB; database = dbGYM; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select *from Ekipman";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet Ds = new DataSet();
            DA.Fill(Ds);

            dataGridView1.DataSource = Ds.Tables[0];
        }
    }
}
