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



namespace KelimeOyunuProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string Kelime { get; set; }
        public int Uzunluk { get; set; }

        private void _acilisAtamalari() 
        {
            BtnBasla.Visible = true;
            BtnTahminEt.Visible = false;
            BtnKelimeAl.Visible = false;
            txtTahmin.Visible = false;
            lblkelime.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _acilisAtamalari();
        }

        private void BtnBasla_Click(object sender, EventArgs e)
        {

            Entity entity = new Entity();

            Kelime = entity.getirKelime();

            if (string.IsNullOrEmpty(Kelime))
            {
                MessageBox.Show("Kelime alınırken sorun yaşandı!");
                _acilisAtamalari();
            }
            else
            {
                BtnTahminEt.Visible = true;
                BtnKelimeAl.Visible = true;
                txtTahmin.Visible = true;
                lblkelime.Visible = true;
            }
            
        }

        private void BtnTahminEt_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
