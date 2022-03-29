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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean b = true; // Boolean tipinde br 'b'  değişkeni oluşturduk.
        //amaç menünün durumuna göre yatay veya dikey olarak ayarlamak

        private void toolStripMenuItem1_Click(object sender, EventArgs e) // menü işlemi burada gerçekleşti
        {
            if (b)// b true olduğu müddetçe çalış.
            {
                menuStrip1.Dock = DockStyle.Left; // Burada menü çubuğunu üst kısımdan sol kısıma aldık.
                b=false ;

                toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\ibrahim\Desktop\images\SagOk.png");// icon yolunu belirttik
            }
            else
            {
                menuStrip1.Dock = DockStyle.Top; // Burada menü çubuğunu sol kısımdan üst kısıma aldık.
                b = true;

                toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\ibrahim\Desktop\images\AltOk.png");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form1 ' imiz Load olduğunda ;
            toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\ibrahim\Desktop\images\SagOk.png");// icon yolunu belirttik
        }

        private void yeniÜyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniKullanici yeniKullanici = new YeniKullanici(); // YeniKullanıcı From nesnesini türettik
            yeniKullanici.Show(); // Türettiğimiz nesneyei ekrana verdik.
        }

        private void yeniPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniPersonelMenu ns = new YeniPersonelMenu();
            ns.Show();

        }

        private void ekipmanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ekipman eq = new Ekipman();
            eq.Show();


        }

        private void üyeBulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜyeBul ÜB = new ÜyeBul();
            ÜB.Show();

        }

        private void üyeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜyeSil üs = new ÜyeSil();
            üs.Show();

        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulamadan çıkmak istediğinizden Emin misiniz?.Onaylıyor Musunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Tekrar Hoş geldiniz", "Merhaba", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Oturumdan Çıkış!! Onaylıyor Musunuz?","Oturumdan Çıkış",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                this.Close();
                Giriş gr = new Giriş();
                gr.Show();

            }
        }
    }
}
