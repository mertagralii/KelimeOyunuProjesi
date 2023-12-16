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
            BtnHarfAl.Visible = false;
            txtTahmin.Visible = false;
            

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
                int pozisyon = 0;
                for (int i = 1; i <= Kelime.Length; i++)
                {
                    
                    Button btn = new Button(); // butonun oluşturulması
                    btn.Name = "btnKelime" + i.ToString();
                    btn.Location = new Point(450 + pozisyon, 250); // butonun koordinatları
                    btn.Height = 50; // butonun yüksekliği
                    btn.Width = 50; // butonun genişliği
                    btn.BackColor = Color.Fuchsia; // butonun rengi
                    Controls.Add((Button)btn); // butonun eklenmesi
                    pozisyon = pozisyon + 70;
                }

                BtnTahminEt.Visible = true;
                BtnHarfAl.Visible = true;
                txtTahmin.Visible = true;
               
            }
            
        }

        private void BtnTahminEt_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int index = random.Next(1, Kelime.Length + 1);
            string harf = Kelime[index -1].ToString();
            this.Controls.Find("btnKelime" + index.ToString(), true).FirstOrDefault().Text = harf;

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
