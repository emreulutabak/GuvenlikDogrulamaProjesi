using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Güvelik_Dogrulamasi
{
    public partial class Form1 : Form
    {
        public int kod;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDogrulamaKodu_Click(object sender, EventArgs e)
        {
            if (BtnDogrulamaKodu.Text == "Doğrulama Kodu Al")
            {
                kod = rnd.Next(10000000, 99999999);
                MailMessage mesaj = new MailMessage();
                mesaj.From = new MailAddress("example@example.com", "E-Mail Title");
                mesaj.To.Add("example2@example.com");//Hangi Mail'e gönderilecek?
                mesaj.Subject = "Güvenlik Doğrulaması";//Mail Başlık
                mesaj.Body = "Doğrulama Kodunuz: " + kod.ToString();
                SmtpClient a = new SmtpClient();
                a.Credentials = new System.Net.NetworkCredential("example@example.com", "MailPassword");
                a.Port = 587;
                a.Host = "example.com";
                a.EnableSsl = true;
                object userState = mesaj;
                try
                {
                    a.SendAsync(mesaj, (object)mesaj);
                    MessageBox.Show("Doğrulama kodunuz ilgili mail adresinize gönderilmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnDogrulamaKodu.Text = "Doğrula";
                }
                catch (SmtpException ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string girilenkod = TxtDogrulamaKodu.Text;               
                if (girilenkod == kod.ToString())
                {
                    MessageBox.Show("Güvenlik doğrulama işlemi başarıyla tamamlanmıştır.", "Doğrulama Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);                                       

                }
                else
                {
                    MessageBox.Show("Güvenlik doğrulaması başarısız olarak sonuçlanmıştır.", "Doğrulama Hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
            }

        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {

        }
    }
}
