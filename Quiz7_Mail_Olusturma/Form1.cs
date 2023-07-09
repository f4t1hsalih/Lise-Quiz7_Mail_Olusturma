using System;
using System.Windows.Forms;

namespace Quiz7_Mail_Olusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mail mail = new Mail();
            mail.Ad = textBox1.Text;
            mail.Soyad = textBox2.Text;
            mail.Adres = textBox3.Text;

            mail.Ekle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mail mail = new Mail(textBox4.Text);
            MessageBox.Show(mail.PinGoster());
        }
    }
}
