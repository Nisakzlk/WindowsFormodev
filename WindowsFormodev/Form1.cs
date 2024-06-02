using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormodev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtkulAdi.Text == "nisakızılkaya" && txtSifre.Text == "1234");
            {
                MessageBox.Show("Kullanıcı giriş başarlı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
            }
            else
            {
                MessageBox.Show("Yanlış kullaıcı Adı ya da şifre girdiniz.", "Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
