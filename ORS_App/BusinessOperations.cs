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
    public partial class BusinessOperations : Form
    {
        public BusinessOperations()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-GROR92P\SQLEXPRESS;Initial Catalog=RandevuSis;Integrated Security=True");
        private void BusinessOperations_Load(object sender, EventArgs e)
        {
            this.workPlaceTableAdapter.Fill(this.randevuSisDataSet.workPlace);
            GetBusinesses();
            toolTip1.SetToolTip(this.workplaceData, "Güncelleme yaparken tablo üzerinden istediğiniz bilgiyi değiştirdikten sonra kaydetme tuşuna basınız.");

        }



        #region ADD_BUSINESS_TAB
        private void addBusiness_Click(object sender, EventArgs e)
        {
            if (TextBoxCheck())
            {
                try
                {
                    connection.Open();
                    SqlCommand addCommand = new SqlCommand("insert into workPlace (isYeriAdi, isYeriAdres, isYeriTelefon, isYeriTuru) values (@isYeriAdi, @isYeriAdres, @isYeriTelefon, @isYeriTuru)", connection);
                    addCommand.Parameters.AddWithValue("@isYeriAdi", bNameTxt.Text);
                    addCommand.Parameters.AddWithValue("@isYeriAdres", bAdressTxt.Text);
                    addCommand.Parameters.AddWithValue("@isYeriTuru", bTypeTxt.Text);
                    addCommand.Parameters.AddWithValue("@isYeriTelefon", bPhoneTxt.Text);
                    addCommand.ExecuteNonQuery();
                    connection.Close();

                    connection.Open();
                    SqlCommand selectLast = new SqlCommand("select isYeriID from workPlace where isYeriTelefon = @isyeriTel", connection);
                    selectLast.Parameters.AddWithValue("@isyeriTel", bPhoneTxt.Text);
                    SqlDataReader reader = selectLast.ExecuteReader();
                    reader.Read();
                    int businessID = Convert.ToInt32(reader["isYeriID"]);
                    connection.Close();


                    connection.Open();
                    SqlCommand addHours = new SqlCommand("insert into WorkingHours (isyeriID, pztBaslangic, pztBitis, saliBaslangic, saliBitis, " +
                "crsBaslangic, crsBitis, prsBaslangic, prsBitis, cumaBaslangic, cumaBitis) values (@isyeriID, @pztBaslangic, @pztBitis, @saliBaslangic, @saliBitis, " +
                "@crsBaslangic, @crsBitis, @prsBaslangic, @prsBitis, @cumaBaslangic, @cumaBitis)", connection);
                    addHours.Parameters.AddWithValue("@isyeriID", businessID);
                    addHours.Parameters.AddWithValue("@pztBaslangic", "09:00:00");
                    addHours.Parameters.AddWithValue("@pztBitis", "18:00:00");
                    addHours.Parameters.AddWithValue("@saliBaslangic", "09:00:00");
                    addHours.Parameters.AddWithValue("@saliBitis", "18:00:00");
                    addHours.Parameters.AddWithValue("@crsBaslangic", "09:00:00");
                    addHours.Parameters.AddWithValue("@crsBitis", "18:00:00");
                    addHours.Parameters.AddWithValue("@prsBaslangic", "09:00:00");
                    addHours.Parameters.AddWithValue("@prsBitis", "18:00:00");
                    addHours.Parameters.AddWithValue("@cumaBaslangic", "09:00:00");
                    addHours.Parameters.AddWithValue("@cumaBitis", "18:00:00");

                    addHours.ExecuteNonQuery();
                    connection.Close();
                    this.workPlaceTableAdapter.Fill(this.randevuSisDataSet.workPlace);
                    GetBusinesses();
                    MessageBox.Show("Kayıt Başarılı!");



                }
                catch (Exception addEx)
                {
                    MessageBox.Show(addEx.Message);
                }

            }
        }

        private bool TextBoxCheck()
        {
            if (string.IsNullOrEmpty(bNameTxt.Text) || string.IsNullOrEmpty(bAdressTxt.Text) || string.IsNullOrEmpty(bPhoneTxt.Text) || string.IsNullOrEmpty(bTypeTxt.Text))
                return false;
            else return true;
        }
        #endregion

        #region DELETE_BUSINESS_TAB
        private void workPlaceBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.workPlaceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.randevuSisDataSet);

        }

        private void businessOpTabCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (businessOpTabCtrl.SelectedTab.Name == "deleteBusinessTab")
            {
                workPlaceBindingNavigator.Visible = true;
            }
            else
            {
                workPlaceBindingNavigator.Visible = false;
            }
        }
        #endregion

        #region ADD_ADMIN_TAB
        int businessID;
        private void GetBusinesses()
        {
            businessList.Items.Clear();
            connection.Open();
            SqlCommand getBusinesses = new SqlCommand("select * from workPlace", connection);
            SqlDataReader businessReader = getBusinesses.ExecuteReader();
            while (businessReader.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = businessReader["isYeriID"].ToString();
                lvi.SubItems.Add(businessReader["isYeriAdi"].ToString());
                lvi.SubItems.Add(businessReader["isYeriTelefon"].ToString());
                lvi.SubItems.Add(businessReader["isYeriTuru"].ToString());
                businessList.Items.Add(lvi);
            }
            connection.Close();
        }
        private void AdminListFill(int _businessID)
        {
            try
            {
                bAdminsList.Items.Clear();
                connection.Open();
                SqlCommand getBusinessAdmins = new SqlCommand("select kullaniciAdi, eMail, isim, soyIsım, telefon from BusinessAdmin where isYeriID = @isyeriID", connection);
                getBusinessAdmins.Parameters.AddWithValue("@isyeriID", _businessID);
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
        private void businessList_SelectedIndexChanged(object sender, EventArgs e)
        {
            businessID = Convert.ToInt32(businessList.SelectedItems[0].Text);
            AdminListFill(businessID);
        }

        private void addAdminBtn_Click(object sender, EventArgs e)
        {

            SqlCommand addAdmin = new SqlCommand("insert into BusinessAdmin (isYeriID, isim, soyIsım, eMail, sifre, adres, telefon, tcKimNo, kullaniciAdi, dogumTarihi) values (@isYeriID, @isim, @soyIsım, @eMail, @sifre, @adres, @telefon, @tcKimNo, @kullaniciAdi, @dogumTarihi)", connection);

            if (TextBoxCheck2())
            {
                try
                {
                    connection.Open();
                    addAdmin.Parameters.AddWithValue("@isYeriID", businessID);
                    addAdmin.Parameters.AddWithValue("@isim", nameTxt.Text);
                    addAdmin.Parameters.AddWithValue("@soyIsım", lastNameTxt.Text);
                    addAdmin.Parameters.AddWithValue("@eMail", eMailTxt.Text);
                    addAdmin.Parameters.AddWithValue("@sifre", pwdTxt.Text);
                    addAdmin.Parameters.AddWithValue("@adres", adressTxt.Text);
                    addAdmin.Parameters.AddWithValue("@telefon", phoneTxt.Text);
                    addAdmin.Parameters.AddWithValue("@tcKimNo", tcTxt.Text);
                    addAdmin.Parameters.AddWithValue("@kullaniciAdi", usernameTxt.Text);
                    addAdmin.Parameters.AddWithValue("@dogumTarihi", birthDate.Value);
                    addAdmin.ExecuteNonQuery();
                    connection.Close();
                    addAdmin.Dispose();
                    AdminListFill(businessID);
                }
                catch (Exception adminEx)
                {
                    MessageBox.Show(adminEx.Message);
                    throw;
                }


            }
        }
        private bool TextBoxCheck2()
        {
            if (string.IsNullOrEmpty(usernameTxt.Text) || string.IsNullOrEmpty(nameTxt.Text) || string.IsNullOrEmpty(lastNameTxt.Text) || string.IsNullOrEmpty(pwdTxt.Text) ||
                string.IsNullOrEmpty(eMailTxt.Text) || string.IsNullOrEmpty(tcTxt.Text) || string.IsNullOrEmpty(phoneTxt.Text))
                return false;
            else return true;
        }
        #endregion


    }
}
