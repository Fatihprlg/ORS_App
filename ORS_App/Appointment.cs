using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORS_App
{
    public enum States
    {
        Waiting,
        Rejected,
        Accepted
    }
    public class Appointment
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-GROR92P\SQLEXPRESS;Initial Catalog=RandevuSis;Integrated Security=True");

        public DateTime Date { get; set; }
        public DateTime Hour { get; set; }
        public string RequestingName { get; set; }
        public string RequestingNick { get; set; }
        public string Note { get; set; }
        public string RecieverNick { get; set; }
        public States State { get; set; }
        public void Post()
        {
            try
            {
                connection.Open();
                SqlCommand postAppointment = new SqlCommand("insert into Appointment (tarih, note, isim, kullaniciAdi, durum, alıcıAdi, saat) " +
                    "values (@tarih, @note, @isim, @kullaniciAdi, @durum, @alıcıAdi, @saat)", connection);
                postAppointment.Parameters.AddWithValue("@tarih", Date);
                postAppointment.Parameters.AddWithValue("@note", Note);
                postAppointment.Parameters.AddWithValue("@isim", RequestingName);
                postAppointment.Parameters.AddWithValue("@kullaniciAdi", RequestingNick);
                postAppointment.Parameters.AddWithValue("@durum", (int)State);
                postAppointment.Parameters.AddWithValue("@alıcıAdi", RecieverNick);
                postAppointment.Parameters.AddWithValue("@saat", Hour);
                postAppointment.ExecuteNonQuery();
                connection.Close();
                postAppointment.Dispose();

            }
            catch (Exception postEx)
            {
                System.Windows.Forms.MessageBox.Show(postEx.Message);
                throw;
            }
        }
    }
}
