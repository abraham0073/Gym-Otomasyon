using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymProje
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(txtKullanıcıAdı.Text =="admin" && txtSifre.Text =="admin")
            {
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Yanlış Kullanıcı Adı Veya Şifre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
