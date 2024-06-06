using MySql.Data.MySqlClient;

public class UserRepository
{
    private string _connectionString;

    public UserRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void StorePublicKey(string username, string publicKey)
    {
        using (MySqlConnection conn = new MySqlConnection(_connectionString))
        {
            conn.Open();
            string query = "INSERT INTO Users (Username, PublicKey) VALUES (@username, @publicKey) ON DUPLICATE KEY UPDATE PublicKey = @publicKey";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@publicKey", publicKey);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public string RetrievePublicKey(string username)
    {
        using (MySqlConnection conn = new MySqlConnection(_connectionString))
        {
            conn.Open();
            string query = "SELECT PublicKey FROM Users WHERE Username = @username";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetString("PublicKey");
                    }
                    else
                    {
                        throw new Exception("User not found");
                    }
                }
            }
        }
    }
}
