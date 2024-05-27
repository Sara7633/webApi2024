using Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RatingRepository : IRatingRepository
    {
        private readonly IConfiguration configuration;
        public RatingRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public async Task<int> AddRating(Rating rating)
        {
            //"Data Source=SRV2\\PUPILS;Initial Catalog=214346710_DB;Integrated Security=True;Encrypt=False"
            //"Data Source=srv2\\PUPILS;Initial Catalog=214346710_DB;Trusted_Connection=True;TrustServerCertificate=True"
            string s = configuration.GetConnectionString("School");
            string query = "INSERT INTO RATING(HOST, METHOD, [PATH],REFERER,USER_AGENT,Record_Date)" +
                           "VALUES(@HOST, @METHOD, @PATH, @REFERER, @USER_AGENT, @Record_Date)";
            using (SqlConnection cn = new SqlConnection(configuration.GetConnectionString("School")))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.AddWithValue("@HOST", rating.Host);
                cmd.Parameters.AddWithValue("@METHOD", rating.Method);
                cmd.Parameters.AddWithValue("@PATH", rating.Path);
                cmd.Parameters.AddWithValue("@REFERER", rating.Referer);
                cmd.Parameters.AddWithValue("@USER_AGENT", rating.UserAgent);
                cmd.Parameters.AddWithValue("@Record_Date", rating.RecordDate);

                cn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                cn.Close();

                return rowsAffected;
            }

        }
    }
}
