using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonWeb.Data
{
    public class LikeContext
    {
        public string ConnectionString { get; set; }

        public LikeContext(string connection)
        {
            this.ConnectionString = connection;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        //A method to get record of like count from the db
        public int GetLikesCount()
        {
            int likesCount = 0;

            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT likesCount FROM tbl_like", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        likesCount = Convert.ToInt32(reader["likesCount"]); 
                    }
                }
            }
            return likesCount;
        }

        public bool PostLikesCount(LikeModel model)
        {
            //LikeModel model = new LikeModel();
            bool hasRow = false;
            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("UPDATE tbl_like SET likesCount = " + model.likeCount, connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                hasRow = dataReader.HasRows;
                return hasRow;
            }
        }
    }
}
