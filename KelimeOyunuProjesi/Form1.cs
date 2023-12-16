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
        string kelime;
        int uzunluk;
        string[] harfler;

      

        private void Form1_Load(object sender, EventArgs e)
        {
            kelime = "Mert Ağralı";
            uzunluk = kelime.Length;
            harfler = new string[uzunluk];
            
        }
        public void LabelGetir()
        {
            label1.Text = " ";
            for (int i = 0; i <= uzunluk; i++)
            {
                label1.Text += " _ ";
            }
        }

        private void BtnBasla_Click(object sender, EventArgs e)
        {

            LabelGetir();

           



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnTahminEt_Click(object sender, EventArgs e)
        {
            
        }
    }
}
