using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loom.offer.Model
{
    class SQLCon
    {

        public List<Language> Languages { get; set; }
        
        //private List<Language> ListLang;

        public SQLCon()
        {

        }

        public void CreateLanguage()
        {

            Languages = new List<Language>();

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "192.168.1.53, 1433";
                builder.UserID = "loom_user";
                builder.Password = "Peri_123";
                builder.InitialCatalog = "LOOM_OFFER";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * FROM LOOM.Language;");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Language lng = new Language();
                                lng.ID = reader.GetInt32(0);
                                lng.Description = reader.GetString(1);
                                Languages.Add(lng);
                            }
                        }

                    }
                }






            }

            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
        }
    }
}
