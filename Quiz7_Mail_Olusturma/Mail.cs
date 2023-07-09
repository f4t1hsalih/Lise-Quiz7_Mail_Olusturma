using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Quiz7_Mail_Olusturma
{
    class Mail
    {
        public Mail()
        {
        }

        public Mail(string adres)
        {
            this.adres = adres;
        }

        private string ad;
        public string Ad
        {
            get
            {
                return ad;
            }

            set
            {
                ad = value;
            }
        }

        private string soyad;
        public string Soyad
        {
            get
            {
                return soyad;
            }

            set
            {
                soyad = value;
            }
        }

        private string adres;
        public string Adres
        {
            get
            {
                return adres;
            }

            set
            {
                adres = value;
            }
        }

        string SifreUret()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1000, 10000);

            return sayi.ToString();
        }

        public bool kontrol(string adres1)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\data.txt", Encoding.Default);
            bool var = false;

            while (!sr.EndOfStream)
            {
                string[] dizi = sr.ReadLine().Split(';');
                if (dizi[2] == adres1) var = true;
            }

            return var;
        }

        public bool kontrol(string adres1, string sifre)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\data.txt", Encoding.Default);
            bool var = false;

            while (!sr.EndOfStream)
            {
                string[] dizi = sr.ReadLine().Split(';');
                if ((dizi[2] == adres1) && (dizi[3] == sifre)) var = true;
            }

            return var;
        }

        public string PinGoster()
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\data.txt", Encoding.Default);

            string st = "";
            while (!sr.EndOfStream)
            {
                string[] dizi = sr.ReadLine().Split(';');
                if (dizi[2] == adres) st = dizi[3];
            }

            return st;
        }

        public void Ekle()
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\data.txt", true, Encoding.Default);

            sw.WriteLine(ad + ";" + soyad + ";" + adres + ";" + SifreUret());
            sw.Close();
        }

    }
}
