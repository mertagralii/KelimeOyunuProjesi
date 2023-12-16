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
        public List<int> harfler = new List<int>();
        public List<string> Butonlar = new List<string>();
     
        private void _acilisAtamalari() 
        {
            BtnBasla.Visible = true;
            BtnTahminEt.Visible = false;
            BtnHarfAl.Visible = false;
            txtTahmin.Visible = false;
            Butonlar.ForEach(x => this.Controls.RemoveByKey(x));
            txtTahmin.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _acilisAtamalari();
        }

        private void BtnBasla_Click(object sender, EventArgs e)
        {
            harfler = new List<int>();
            Butonlar = new List<string>();
            Entity entity = new Entity();

            //Kelime = entity.getirKelime();
            Kelime = "ARABA";

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
                    harfler.Add(i);
                    Button btn = new Button(); // butonun oluşturulması
                    btn.Name = "btnKelime" + i.ToString();
                    Butonlar.Add(btn.Name);
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
            if (txtTahmin.Text.ToUpper() == Kelime.ToUpper())
            {
                MessageBox.Show("Tebrikler !");
                _acilisAtamalari();
      
            }
            else 
            {
                MessageBox.Show("Yanlış !");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnHarfAl_Click(object sender, EventArgs e)
        {
            int x = harfler.Count();
            Random random = new Random();
            int index = random.Next(0, harfler.Count);
            int index2 = harfler[index];
            string harf = Kelime[index2 - 1].ToString();
            harfler.Remove(index2);
            this.Controls.Find("btnKelime" + (index2).ToString(), true).FirstOrDefault().Text = harf;

            if (harfler.Count == 0)
            {
                MessageBox.Show("Oyun Bitti.");
                _acilisAtamalari();
            }
        }
    }
}
