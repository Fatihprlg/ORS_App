using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORS_App
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-GROR92P\SQLEXPRESS;Initial Catalog=RandevuSis;Integrated Security=True");
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Dispose();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxCheck())
                {
                    connection.Open();
                    SqlCommand registerUser = new SqlCommand("insert into UserTable (isim, soyIsim, adres, telefon, kullaniciAdi, sifre, sonGiris) values (@isim, @soyIsim, @adres, @telefon, @kullaniciAdi, @sifre, @sonGiris)", connection);
                    registerUser.Parameters.AddWithValue("@isim", nameTxt.Text);
                    registerUser.Parameters.AddWithValue("@soyIsim", lastNameTxt.Text);
                    registerUser.Parameters.AddWithValue("@adres", adressTxt.Text);
                    registerUser.Parameters.AddWithValue("@telefon", phoneTxt.Text);
                    registerUser.Parameters.AddWithValue("@kullaniciAdi", userNameTxt.Text);
                    registerUser.Parameters.AddWithValue("@sifre", pwdTxt.Text);
                    registerUser.Parameters.AddWithValue("@sonGiris", DateTime.Now);
                    registerUser.ExecuteNonQuery();
                    connection.Close();
                    connection.Dispose();
                    registerUser.Dispose();
                    LoginPage loginPage = new LoginPage();
                    loginPage.Show();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("İşaretli Alanlar Boş Bırakılamaz!");
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private bool TextBoxCheck()
        {
            if (string.IsNullOrEmpty(nameTxt.Text) || string.IsNullOrEmpty(lastNameTxt.Text) || string.IsNullOrEmpty(phoneTxt.Text) || string.IsNullOrEmpty(userNameTxt.Text) || string.IsNullOrEmpty(pwdTxt.Text))
                return false;
            else return true;
        }
    }
}
