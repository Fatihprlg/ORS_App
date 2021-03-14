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
    public partial class BusinessAdminsList : Form
    {
        public BusinessAdminsList()
        {
            InitializeComponent();
        }


        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-GROR92P\SQLEXPRESS;Initial Catalog=RandevuSis;Integrated Security=True");

        private void BusinessAdminsList_Load(object sender, EventArgs e)
        {
            AdminListFill();
        }
        private void AdminListFill()
        {
            try
            {
                bAdminsList.Items.Clear();
                connection.Open();
                SqlCommand getBusinessAdmins = new SqlCommand("select kullaniciAdi, eMail, isim, soyIsım, telefon from BusinessAdmin ", connection);
                SqlDataReader adminReader = getBusinessAdmins.ExecuteReader();
                while (adminReader.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = adminReader["kullaniciAdi"].ToString();
                    item.SubItems.Add(adminReader["isim"].ToString() + " " + adminReader["soyIsım"].ToString());
                    item.SubItems.Add(adminReader["eMail"].ToString());
                    item.SubItems.Add(adminReader["telefon"].ToString());
                    bAdminsList.Items.Add(item);
                }
                connection.Close();
                getBusinessAdmins.Dispose();
            }
            catch (Exception dataEx)
            {
                MessageBox.Show(dataEx.Message);
                throw;
            }


        }
    }
}
