using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORS_App
{
    public class Message
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-GROR92P\SQLEXPRESS;Initial Catalog=RandevuSis;Integrated Security=True");

        public string Subject { get; set; }
        public string Content { get; set; }
        public int MessageID { get; set; }
        public DateTime SendDate { get; set; }
        public string SenderName { get; set; }
        public string RecieverName { get; set; }
        public void Post()
        {
            try
            {
                connection.Open();
                SqlCommand postMessage = new SqlCommand("insert into message (konu, icerik, gonderilmeTarihi, gonderilenKisi, gonderenKisi) " +
                    "values (@konu, @icerik, @gonderilmeTarihi, @gonderilenKisi, @gonderenKisi)", connection);
                postMessage.Parameters.AddWithValue("@konu", Subject);
                postMessage.Parameters.AddWithValue("@icerik", Content);
                postMessage.Parameters.AddWithValue("@gonderilmeTarihi", SendDate);
                postMessage.Parameters.AddWithValue("@gonderilenKisi", RecieverName);
                postMessage.Parameters.AddWithValue("@gonderenKisi", SenderName);
                postMessage.ExecuteNonQuery();
                connection.Close();
                connection.Dispose();
                postMessage.Dispose();
            }
            catch (Exception postEx)
            {
                System.Windows.Forms.MessageBox.Show(postEx.Message);
                throw;
            }
        }
    }
}
