using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORS_App
{
    class Business
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-GROR92P\SQLEXPRESS;Initial Catalog=RandevuSis;Integrated Security=True");
        public int ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Type { get; set; }
        public string Phone { get; set; }
        public List<BusinessAdmin> Admins { get; set; } = new List<BusinessAdmin>();
        public void GetAdmins()
        {
            connection.Open();
            SqlCommand getAdmins = new SqlCommand("select isYeriID, kullaniciAdi from BusinessAdmin where isYeriID = @id", connection);
            getAdmins.Parameters.AddWithValue("@id", ID);
            SqlDataReader adminReader = getAdmins.ExecuteReader();
            while (adminReader.Read())
            {
                BusinessAdmin admin = new BusinessAdmin();
                admin.BusinessID = Convert.ToInt32(adminReader["isYeriID"]);
                admin.Username = adminReader["kullaniciAdi"].ToString();
                Admins.Add(admin);
            }
            connection.Close();
        }
    }
}
