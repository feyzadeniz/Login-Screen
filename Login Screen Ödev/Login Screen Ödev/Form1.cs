using System.Windows.Forms;

namespace Login_Screen_Ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_giris_Click(object sender, EventArgs e)
        {
            string KullaniciAdi=textBox_kullanici.Text;
            string Sifre=textBox_sifre.Text;
            
            if(KullaniciAdi=="feyzadeniz" && Sifre == "28102003")
            {
               this.Hide(); //this.Close yazdığım zaman Form2 açılmıyor, this.Hide kullan!!!
               Form2 form = new Form2();
               form.Show();
               
            }

             else if(KullaniciAdi == "" && Sifre == "")
             {
                string message = "Lütfen istenen bilgileri giriniz.";
                string title = "Uyarı";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, title, button, MessageBoxIcon.Error);
             }


            else
            {
                string message2 = "Girdiğiniz şifre yanlış!";
                string title2 = "Uyarı";
                MessageBoxButtons button2 = MessageBoxButtons.OK;
                MessageBox.Show(message2, title2, button2, MessageBoxIcon.Warning);
                

            }
        }

        private void linkLabel_sifre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message3 = "Şifre yenileme linki e-postanıza gönderilmiştir.";
            string title3 = "Bilgilendirme";
            MessageBoxButtons button3 = MessageBoxButtons.OK;
            MessageBox.Show(message3, title3, button3);
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox_sifre.PasswordChar = '\0'; //çift tırnakla değil tek tırnakla kullanılınca çalışıyor.
                label1.Text = "şifreyi gizle";

            }
            else
            {
                textBox_sifre.PasswordChar = '*';
                label1.Text = "şifreyi göster";

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}