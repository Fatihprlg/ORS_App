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

namespace ORS_App
{
    public partial class LoginPage : Form
    {
        public static BusinessAdmin currentBAdmin = new BusinessAdmin();
        public static StandartUser currentSUser = new StandartUser();
        public LoginPage()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-GROR92P\SQLEXPRESS;Initial Catalog=RandevuSis;Integrated Security=True");

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nickTxt.Text == "admin" && pwdTxt.Text == "nimda")
                {
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                }
                else
                {
                    bool isBussAdmin = false;
                    connection.Open();
                    SqlCommand checkBussAdmin = new SqlCommand("select * from BusinessAdmin", connection);
                    SqlDataReader adminReader = checkBussAdmin.ExecuteReader();
                    while (adminReader.Read())
                    {
                        if (nickTxt.Text == adminReader["kullaniciAdi"].ToString() && pwdTxt.Text == adminReader["sifre"].ToString())
                        {
                            isBussAdmin = true;
                            currentBAdmin = new BusinessAdmin();
                            currentBAdmin.Username = adminReader["kullaniciAdi"].ToString();
                            currentBAdmin.Name = adminReader["isim"].ToString();
                            currentBAdmin.Surname = adminReader["soyIsım"].ToString();
                            currentBAdmin.Email = adminReader["eMail"].ToString();
                            currentBAdmin.BusinessID = int.Parse(adminReader["isYeriID"].ToString());
                            BusinessPanel businessPanel = new BusinessPanel();
                            businessPanel.Show();
                            break;
                        }
                    }
                    connection.Close();

                    checkBussAdmin.Dispose();

                    if (!isBussAdmin)
                    {
                        connection.Open();
                        SqlCommand checkUser = new SqlCommand("select kullaniciAdi, sifre, isim from UserTable", connection);
                        SqlDataReader userReader = checkUser.ExecuteReader();
                        while (userReader.Read())
                        {
                            if (nickTxt.Text == userReader["kullaniciAdi"].ToString() && pwdTxt.Text == userReader["sifre"].ToString())
                            {
                                currentSUser.Name = userReader["isim"].ToString();
                                currentSUser.Username = userReader["kullaniciAdi"].ToString();
                                currentSUser.UpdateLastSeen();
                                UserPanel userPanel = new UserPanel();
                                userPanel.Show();
                                break;
                            }
                        }
                        connection.Close();

                    }
                    connection.Dispose();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void registerLink_Click(object sender, EventArgs e)
        {
            RegisterPage registerPage = new RegisterPage();
            registerPage.Show();
            this.Hide();
        }
    }
}