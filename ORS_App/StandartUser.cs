using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORS_App
{
    public class StandartUser : User
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-GROR92P\SQLEXPRESS;Initial Catalog=RandevuSis;Integrated Security=True");
        public List<Message> Messages { get; set; } = new List<Message>();
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();
        public void UpdateLastSeen()
        {
            connection.Open();
            SqlCommand update = new SqlCommand("update UserTable set sonGiris = @sonGiris where kullaniciAdi = @kullaniciAdi", connection);
            update.Parameters.AddWithValue("@sonGiris", DateTime.Now);
            update.Parameters.AddWithValue("@kullaniciAdi", this.Username);
            update.ExecuteNonQuery();
            connection.Close();
        }
        public override void GetMessages()
        {
            try
            {
                connection.Open();
                SqlCommand getMessages = new SqlCommand("select * from message where gonderilenKisi = @kullaniciAdi", connection);
                getMessages.Parameters.AddWithValue("@kullaniciAdi", this.Username);
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
            SqlCommand loadList = new SqlCommand("select * from Appointment where kullaniciAdi = @kullaniciAdi", connection);
            loadList.Parameters.AddWithValue("@kullaniciAdi", this.Username);
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

    }
}
