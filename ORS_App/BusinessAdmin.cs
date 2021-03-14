using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORS_App
{
    public class BusinessAdmin : User
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-GROR92P\SQLEXPRESS;Initial Catalog=RandevuSis;Integrated Security=True");

        public string TCKNo { get; set; }
        public DateTime BirthDate { get; set; }
        public int BusinessID { get; set; }
        public List<Message> Messages { get; private set; } = new List<Message>();
        public List<Appointment> Appointments { get; private set; } = new List<Appointment>();
        public WorkingHours WorkingHours { get; set; } = new WorkingHours();
        public override void GetMessages()
        {
            try
            {
                connection.Open();
                SqlCommand getMessages = new SqlCommand("select * from message where gonderilenKisi = @yetkiliKAdi", connection);
                getMessages.Parameters.AddWithValue("@yetkiliKAdi", this.Username);
                SqlDataReader messagesReader = getMessages.ExecuteReader();
                while (messagesReader.Read())
                {
                    Message message = new Message();
                    message.MessageID = Convert.ToInt32(messagesReader["messageID"]);
                    message.Subject = messagesReader["konu"].ToString();
                    message.Content = messagesReader["icerik"].ToString();
                    message.SenderName = messagesReader["gonderenKisi"].ToString();
                    message.SendDate = Convert.ToDateTime(messagesReader["gonderilmeTarihi"]);
                    message.RecieverName = messagesReader["gonderilenKisi"].ToString();
                    Messages.Add(message);
                }
                connection.Close();
                getMessages.Dispose();
            }
            catch (Exception messageEx)
            {
                System.Windows.Forms.MessageBox.Show(messageEx.Message);
                throw;
            }

        }

        public void GetAppointments()
        {
            connection.Open();
            SqlCommand loadList = new SqlCommand("select * from Appointment where alıcıAdi = @aliciAdi", connection);
            loadList.Parameters.AddWithValue("@aliciAdi", this.Username);
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
                Appointments.Add(appointment);
            }
            connection.Close();
            loadList.Dispose();
        }
        public void GetAppointmentHours()
        {
            connection.Open();
            SqlCommand getHours = new SqlCommand("select * from WorkingHours where isyeriID = @isyeriID", connection);
            getHours.Parameters.AddWithValue("@isyeriID", this.BusinessID);
            SqlDataReader hoursReader = getHours.ExecuteReader();
            hoursReader.Read();
            WorkingHours.mdyStart = Convert.ToDateTime(hoursReader["pztBaslangic"].ToString());
            WorkingHours.mdyEnd = Convert.ToDateTime(hoursReader["pztBitis"].ToString());
            WorkingHours.tsdyStart = Convert.ToDateTime(hoursReader["saliBaslangic"].ToString());
            WorkingHours.tsdyEnd = Convert.ToDateTime(hoursReader["saliBitis"].ToString());
            WorkingHours.wdsdyStart = Convert.ToDateTime(hoursReader["crsBaslangic"].ToString());
            WorkingHours.wdsdyEnd = Convert.ToDateTime(hoursReader["crsBitis"].ToString());
            WorkingHours.thsdyStart = Convert.ToDateTime(hoursReader["prsBaslangic"].ToString());
            WorkingHours.thsdyEnd = Convert.ToDateTime(hoursReader["prsBitis"].ToString());
            WorkingHours.fdyStart = Convert.ToDateTime(hoursReader["cumaBaslangic"].ToString());
            WorkingHours.fdyEnd = Convert.ToDateTime(hoursReader["cumaBitis"].ToString());
            connection.Close();
        }

    }
}
