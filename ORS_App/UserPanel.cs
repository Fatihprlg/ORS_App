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
    public partial class UserPanel : Form
    {
        List<BusinessAdmin> selectedBusinessAdmins = new List<BusinessAdmin>();
        List<Business> searchingBusinesses = new List<Business>();
        List<Business> businesses = new List<Business>();
        StandartUser currentUser = LoginPage.currentSUser;
        public UserPanel()
        {
            InitializeComponent();
            GetBusinesses();
            GetAnswers();
            GetAppointments();
            GetAdmins();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-GROR92P\SQLEXPRESS;Initial Catalog=RandevuSis;Integrated Security=True");
        #region APPOINTMENT_OPS_TAB

        private void appointmentBtn_Click(object sender, EventArgs e)
        {
            string reciever = "";
            selectedBusinessAdmins.ForEach(x =>
            {
                if (x.Name.Contains(bAdminCBox.Text.Substring(0, bAdminCBox.Text.IndexOf(" "))))
                {
                    reciever = x.Username;
                }
            });
            Appointment appointment = new Appointment();
            appointment.State = States.Waiting;
            appointment.Hour = hourPicker.Value;
            appointment.Date = datePicker.Value;
            appointment.Note = noteTxt.Text;
            appointment.RecieverNick = reciever;
            appointment.RequestingName = currentUser.Name;
            appointment.RequestingNick = currentUser.Username;
            appointment.Post();
            
        }

        private void GetBusinesses()
        {
            try
            {
                businessList.Items.Clear();
                Business business = new Business();
                connection.Open();
                SqlCommand getBusiness = new SqlCommand("select * from workPlace", connection);
                SqlDataReader businessReader = getBusiness.ExecuteReader();
                while (businessReader.Read())
                {
                    business.ID = Convert.ToInt32(businessReader["isYeriID"]);
                    business.Name = businessReader["isYeriAdi"].ToString();
                    business.Adress = businessReader["isYeriAdres"].ToString();
                    business.Phone = businessReader["isYeriTelefon"].ToString();
                    business.Type = businessReader["isYeriTuru"].ToString();
                    businesses.Add(business);
                }
                connection.Close();
                getBusiness.Dispose();
                businesses.ForEach(x =>
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = x.ID.ToString();
                    lvi.SubItems.Add(x.Name);
                    lvi.SubItems.Add(x.Type);
                    lvi.SubItems.Add(x.Adress);
                    lvi.SubItems.Add(x.Phone);
                    businessList.Items.Add(lvi);
                });

            }
            catch (Exception getBusinessEx)
            {
                MessageBox.Show(getBusinessEx.Message);
                throw;
            }
        }

        private void businessList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int businessID = Convert.ToInt32(businessList.SelectedItems[0].SubItems[0].Text);
            connection.Open();
            selectedBusinessAdmins.Clear();
            bAdminCBox.Items.Clear();
            SqlCommand getAdmins = new SqlCommand("select kullaniciAdi, isim, soyIsım from BusinessAdmin where isYeriID = @isYeriID", connection);
            getAdmins.Parameters.Clear();
            getAdmins.Parameters.AddWithValue("@isYeriID", businessID);
            SqlDataReader adminReader = getAdmins.ExecuteReader();
            while (adminReader.Read())
            {
                BusinessAdmin businessAdmin = new BusinessAdmin();
                businessAdmin.Username = adminReader["kullaniciAdi"].ToString();
                businessAdmin.Name = adminReader["isim"].ToString();
                businessAdmin.Surname = adminReader["soyIsım"].ToString();
                bAdminCBox.Items.Add(businessAdmin.Name + " " + businessAdmin.Surname);
                selectedBusinessAdmins.Add(businessAdmin);
            }
            connection.Close();
            getAdmins.Dispose();
        }

        private void searchBusiness_Click(object sender, EventArgs e)
        {
            searchingBusinesses.Clear();
            searchingBusinesses = businesses.FindAll(x => x.Name.ToLower().Contains(businessSearchTxt.Text.ToLower()));
            businessList.Items.Clear();
            searchingBusinesses.ForEach(a =>
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = a.ID.ToString();
                lvi.SubItems.Add(a.Name);
                lvi.SubItems.Add(a.Type);
                lvi.SubItems.Add(a.Adress);
                lvi.SubItems.Add(a.Phone);
                businessList.Items.Add(lvi);
            });
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            GetBusinesses();
        }

        private void searchCategory_Click(object sender, EventArgs e)
        {
            searchingBusinesses.Clear();
            searchingBusinesses = businesses.FindAll(x => x.Type.ToLower().Contains(categorySearchTxt.Text.ToLower()));
            businessList.Items.Clear();
            searchingBusinesses.ForEach(a =>
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = a.ID.ToString();
                lvi.SubItems.Add(a.Name);
                lvi.SubItems.Add(a.Type);
                lvi.SubItems.Add(a.Adress);
                lvi.SubItems.Add(a.Phone);
                businessList.Items.Add(lvi);
            });
        }
        #endregion

        #region MESSAGES_TAB

        private void GetAnswers()
        {
            currentUser.GetMessages();
            currentUser.Messages.ForEach(x =>
            {
                ListViewItem item = new ListViewItem();
                item.Text = x.SenderName;
                item.SubItems.Add(x.Subject);
                item.SubItems.Add(x.Content);
                messagesList.Items.Add(item);
            });
        }

        private void messagesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(messagesList.SelectedItems[0].SubItems[3].Text);
        }
        #endregion

        #region APPOINTMENTS_TAB
        private void GetAppointments()
        {
            currentUser.GetAppointments();
            currentUser.Appointments.ForEach(x =>
            {
                ListViewItem item = new ListViewItem();
                item.Text = x.RecieverNick;
                item.SubItems.Add(x.Date.ToString("dd:MM:yyyy"));
                item.SubItems.Add(x.Hour.ToString("t"));
                if (x.State == States.Waiting) 
                { 
                    item.SubItems.Add("Onay Bekliyor"); 
                    item.BackColor = Color.LightGoldenrodYellow;
                }
                else if(x.State == States.Accepted)
                { 
                    item.SubItems.Add("Onaylandı"); 
                    item.BackColor = Color.PaleGreen; 
                }
                appointmentsList.Items.Add(item);
            });
        }
        #endregion

        #region SEND_MESSAGE_TAB
        private void GetAdmins()
        {
            connection.Open();
            SqlCommand getAdmins = new SqlCommand("select * from BusinessAdmin", connection);
            SqlDataReader adminReader = getAdmins.ExecuteReader();
            while (adminReader.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = adminReader["isim"].ToString();
                lvi.SubItems.Add(adminReader["kullaniciAdi"].ToString());
                lvi.SubItems.Add(adminReader["telefon"].ToString());
                lvi.SubItems.Add(adminReader["eMail"].ToString());
                adminList.Items.Add(lvi);
            }
            connection.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Message sendMessage = new Message();
            sendMessage.Content = messageContent.Text;
            sendMessage.Subject = messageSubject.Text;
            sendMessage.RecieverName = adminList.SelectedItems[0].SubItems[1].Text;
            sendMessage.SendDate = DateTime.Now;
            sendMessage.SenderName = currentUser.Username;
            sendMessage.Post();
        }

        #endregion


    }
}
