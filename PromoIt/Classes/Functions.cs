
using System.Data;
using MySql.Data.MySqlClient;

namespace PromoIt
{
    public class Functions
    {
        const string connectionString = @"server=localhost;userid=root;password=admin;database=promoitdb";
        public MySqlConnection connection = new MySqlConnection(connectionString);

        public void send_data_to_sql(string user_name, string password)
        {
            //Connecting to MySQL first block of user name and password for Non profit organization representative.
            using (connection)
            {
                var con = new MySqlConnection(connectionString);
                con.Open();

                MySqlCommand command = new MySqlCommand("data_impliment_NP", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("p_username", user_name));
                command.Parameters.Add(new MySqlParameter("p_password_un", password));

                command.Connection.Open();
                var result = command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }

        public void send_data_to_sql_NP_company_info(string name, string email, string link)
        {
            //Connecting to MySQL second block of Non profit organization information(name of company, email, and link).
            using (connection)
            {
                var con = new MySqlConnection(connectionString);
                con.Open();

                MySqlCommand command = new MySqlCommand("company_info_NP", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("p_name", name));
                command.Parameters.Add(new MySqlParameter("p_company_email", email));
                command.Parameters.Add(new MySqlParameter("p_Link", link));

                command.Connection.Open();
                var result = command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }

        public void send_data_to_sql_business_company_registration(string company_name, string company_password)
        {
            //Connecting to MySQL third block of business organization registration.
            using (connection)
            {
                var con = new MySqlConnection(connectionString);
                con.Open();

                MySqlCommand command = new MySqlCommand("business_company_registration", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("p_username1", company_name));
                command.Parameters.Add(new MySqlParameter("p_password_BCR", company_password));

                command.Connection.Open();
                var result = command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }

        public void send_data_to_sql_business_company_donation(string product, int amount, int value,
            string chosen_campaign)
        {
            //Connecting to MySQL fourth block of business organization product donation.
            using (connection)
            {
                var con = new MySqlConnection(connectionString);
                con.Open();

                MySqlCommand command = new MySqlCommand("bcr_product_donation", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("p_product", product));
                command.Parameters.Add(new MySqlParameter("p_amount", amount));
                command.Parameters.Add(new MySqlParameter("p_value_of_product", value));
                command.Parameters.Add(new MySqlParameter("p_chosen_campaign", chosen_campaign));

                command.Connection.Open();
                var result = command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }

        public void send_data_to_sql_activist_registration(string username1234, string password1234)
        {
            //Connecting to MySQL fourth block of business organization product donation.
            using (connection)
            {
                var con = new MySqlConnection(connectionString);
                con.Open();

                MySqlCommand command = new MySqlCommand("Social_Activist_Registration", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("p_username12", username1234));
                command.Parameters.Add(new MySqlParameter("p_password12", password1234));



                command.Connection.Open();
                var result = command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }

        public void send_data_to_sql_activist_information(string p_activist_email, string p_activist_address, string p_activist_phone)
        {
            //Connecting to MySQL fourth block of business organization product donation.
            using (connection)
            {
                var con = new MySqlConnection(connectionString);
                con.Open();

                MySqlCommand command = new MySqlCommand("p_social_activist_information", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("p_activist_email", p_activist_email));
                command.Parameters.Add(new MySqlParameter("p_activist_address", p_activist_address));
                command.Parameters.Add(new MySqlParameter("p_activist_phone", p_activist_phone));



                command.Connection.Open();
                var result = command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }

     

    }
}