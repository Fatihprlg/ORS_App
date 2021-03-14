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
    public partial class BusinessPanel : Form
    {
        BusinessAdmin currentAdmin = LoginPage.currentBAdmin;
        Business currentBusiness = new Business();
        List<Appointment> businessAppointments = new List<Appointment>();
        public BusinessPanel()
        {
            InitializeComponent();
            LoadAppointments();
            LoadMessages();
           GetAppointmentHours();
            currentBusiness.ID = currentAdmin.BusinessID;
            currentBusiness.GetAdmins();
            GetBusinessAppointments();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-GROR92P\SQLEXPRESS;Initial Catalog=RandevuSis;Integrated Security=True");
        #region APPOINTMENT_REQUESTS_TAB
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (!(appointmentList.SelectedItems == null))
            {
                try
                {
                    connection.Open();
                    SqlCommand acceptAppointment = new SqlCommand("update Appointment set Durum = 2 where kullaniciAdi = @kullaniciAdi", connection);
                    acceptAppointment.Parameters.AddWithValue("@kullaniciAdi", appointmentList.SelectedItems[0].Text);
                    acceptAppointment.ExecuteNonQuery();
                    connection.Close();
                    acceptAppointment.Dispose();
                    LoadAppointments();
                }
                catch (Exception acceptEx)
                {
                    MessageBox.Show(acceptEx.Message);
                    throw;
                }
            }
            else MessageBox.Show("İşlem yapılacak randevu isteğini seçiniz!");
        }
        private void LoadAppointments()
        {
            try
            {
                appointmentList.Items.Clear();
                currentAdmin.GetAppointments();
                currentAdmin.Appointments.ForEach(a =>
                {
                    ListViewItem viewItem = new ListViewItem();
                    viewItem.Text = a.RequestingNick;
                    viewItem.SubItems.Add(a.Date.ToString("dd:MM:yyyy"));
                    viewItem.SubItems.Add(a.Hour.ToString("t"));
                    viewItem.SubItems.Add(a.RequestingName);
                    viewItem.SubItems.Add(a.Note);
                    switch ((States)a.State)
                    {
                        case States.Waiting:
                            viewItem.SubItems.Add("Onay Bekliyor");
                            viewItem.BackColor = Color.LightGoldenrodYellow;
                            break;
                        case States.Accepted:
                            viewItem.SubItems.Add("Onaylandı");
                            viewItem.BackColor = Color.PaleGreen;
                            break;
                        default:
                            break;
                    }
                    appointmentList.Items.Add(viewItem);
                });

            }
            catch (Exception loadEx)
            {
                MessageBox.Show(loadEx.Message);
                throw;
            }

        }

        private void rejectBtn_Click(object sender, EventArgs e)
        {
            if (!(appointmentList.SelectedItems == null))
            {
                try
                {
                    connection.Open();
                    SqlCommand rejectAppointment = new SqlCommand("delete from Appointment where kullaniciAdi = @kullaniciAdi", connection);
                    rejectAppointment.Parameters.AddWithValue("@kullaniciAdi", appointmentList.SelectedItems[0].Text);
                    rejectAppointment.ExecuteNonQuery();
                    connection.Close();
                    rejectAppointment.Dispose();
                    LoadAppointments();
                }
                catch (Exception rejectEx)
                {
                    MessageBox.Show(rejectEx.Message);
                    throw;
                }
            }
            else MessageBox.Show("İşlem yapılacak randevu isteğini seçiniz");

        }
        #endregion

        #region MESSAGES_TAB

        private void LoadMessages()
        {
            try
            {
                messageList.Items.Clear();
                currentAdmin.GetMessages();
                currentAdmin.Messages.ForEach(a =>
                {
                    ListViewItem viewItem = new ListViewItem();
                    viewItem.Text = a.MessageID.ToString();
                    viewItem.SubItems.Add(a.SenderName);
                    viewItem.SubItems.Add(a.SendDate.ToString());
                    viewItem.SubItems.Add(a.Subject);
                    viewItem.SubItems.Add(a.Content);
                    messageList.Items.Add(viewItem);
                });
            }
            catch (Exception loadMessageEx)
            {
                MessageBox.Show(loadMessageEx.Message);
                throw;
            }
        }


        private void answerBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(answerTxt.Text))
            {
                if (!(messageList.SelectedItems[0] == null))
                {
                    Message answer = new Message();
                    answer.Content = answerTxt.Text;
                    answer.SenderName = currentAdmin.Username;
                    answer.SendDate = DateTime.Now;
                    answer.RecieverName = messageList.SelectedItems[0].Text;
                    answer.Subject = "Re: " + messageList.SelectedItems[0].SubItems[2].ToString();
                    answer.Post();
                }
                else MessageBox.Show("Cevap vermek için bir mesaj seçiniz.");

            }
            else MessageBox.Show("Cevap kutucuğunu doldurunuz.");
        }

        private void deleteMsgBtn_Click(object sender, EventArgs e)
        {
            if (!(messageList.SelectedItems[0] == null))
            {
                try
                {
                    connection.Open();
                    SqlCommand deleteMessage = new SqlCommand("delete from message where messageID = @messageID", connection);
                    deleteMessage.Parameters.AddWithValue("@messageID", messageList.SelectedItems[0].Text);
                    deleteMessage.ExecuteNonQuery();
                    connection.Close();
                    LoadMessages();
                }
                catch (Exception deleteMsgEx)
                {
                    MessageBox.Show(deleteMsgEx.Message);
                    throw;
                }
            }
            else MessageBox.Show("Cevap vermek için bir mesaj seçiniz.");
        }
        private void messageList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(messageList.SelectedItems[0].SubItems[4].Text, messageList.SelectedItems[0].SubItems[3].Text);
        }
        #endregion

        #region APPOINTMENT_HOURS_TAB


        private void saveBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand saveHours = new SqlCommand("update WorkingHours set pztBaslangic = @pztBas, pztBitis = @pztBit, saliBaslangic = @saliBas, saliBitis = @saliBit, " +
                "crsBaslangic = @crsBas, crsBitis= @crsBit, prsBaslangic = @prsBas, prsBitis = @prsBit, cumaBaslangic = @cumaBas, cumaBitis = @cumaBit where isyeriID = @isyeriID", connection);
            saveHours.Parameters.AddWithValue("@pztBas", mdyStart.Value);
            saveHours.Parameters.AddWithValue("@pztBit", mdyEnd.Value);
            saveHours.Parameters.AddWithValue("@saliBas", tsdyStart.Value);
            saveHours.Parameters.AddWithValue("@saliBit", tsdyEnd.Value);
            saveHours.Parameters.AddWithValue("@crsBas", wsdyStart.Value);
            saveHours.Parameters.AddWithValue("@crsBit", wsdyEnd.Value);
            saveHours.Parameters.AddWithValue("@prsBas", thsdyStart.Value);
            saveHours.Parameters.AddWithValue("@prsBit", thsdyEnd.Value);
            saveHours.Parameters.AddWithValue("@cumaBas", fdyStart.Value);
            saveHours.Parameters.AddWithValue("@cumaBit", fdyEnd.Value);
            saveHours.Parameters.AddWithValue("@isyeriID", currentAdmin.BusinessID);
            saveHours.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kayıt Başarılı");
        }
        private void GetAppointmentHours()
        {
            try
            {
                currentAdmin.GetAppointmentHours();
                mdyStart.Value =  currentAdmin.WorkingHours.mdyStart;
                mdyEnd.Value = currentAdmin.WorkingHours.mdyEnd;
                tsdyStart.Value = currentAdmin.WorkingHours.tsdyStart;
                tsdyEnd.Value = currentAdmin.WorkingHours.tsdyEnd;
                wsdyStart.Value = currentAdmin.WorkingHours.wdsdyStart;
                wsdyEnd.Value = currentAdmin.WorkingHours.wdsdyEnd;
                thsdyStart.Value = currentAdmin.WorkingHours.thsdyStart;
                thsdyEnd.Value = currentAdmin.WorkingHours.thsdyEnd;
                fdyStart.Value = currentAdmin.WorkingHours.fdyStart;
                fdyEnd.Value = currentAdmin.WorkingHours.fdyEnd;
            }
            catch (Exception hoursEx)
            {
                MessageBox.Show(hoursEx.Message);
                throw;
            }


        }
        #endregion

        #region BUSINESS_APPOINTMENTS_TAB
        private void GetBusinessAppointments()
        {
            bAppointmentsList.Items.Clear();
            foreach (BusinessAdmin admin in currentBusiness.Admins)
            {
                connection.Open();
                SqlCommand loadList = new SqlCommand("select * from Appointment where alıcıAdi = @aliciAdi", connection);
                loadList.Parameters.AddWithValue("@aliciAdi", admin.Username);
                SqlDataReader loadReader = loadList.ExecuteReader();
                while (loadReader.Read())
                {
                    Appointment appointment = new Appointment();
                    appointment.RequestingNick = loadReader["kullaniciAdi"].ToString();
                    appointment.Date = Convert.ToDateTime(loadReader["tarih"]);
                    appointment.RequestingName = loadReader["isim"].ToString();
                    appointment.Hour = Convert.ToDateTime(loadReader["saat"]);
                    appointment.Note = loadReader["note"].ToString();
                    appointment.RecieverNick = loadReader["alıcıAdi"].ToString();
                    appointment.State = (States)Convert.ToInt32(loadReader["Durum"]);
                    businessAppointments.Add(appointment);
                }
                connection.Close();
                loadList.Dispose();
                businessAppointments.ForEach(a =>
                {
                    ListViewItem viewItem = new ListViewItem();
                    viewItem.Text = a.RequestingNick;
                    viewItem.SubItems.Add(a.Date.ToString("dd:MM:yyyy"));
                    viewItem.SubItems.Add(a.Hour.ToString("t"));
                    viewItem.SubItems.Add(a.RequestingName);
                    viewItem.SubItems.Add(a.Note);
                    switch ((States)a.State)
                    {
                        case States.Waiting:
                            viewItem.SubItems.Add("Onay Bekliyor");
                            viewItem.BackColor = Color.LightGoldenrodYellow;
                            break;
                        case States.Accepted:
                            viewItem.SubItems.Add("Onaylandı");
                            viewItem.BackColor = Color.PaleGreen;
                            break;
                        default:
                            break;
                    }
                    bAppointmentsList.Items.Add(viewItem);
                });

            }

        }

        #endregion
    }
}
