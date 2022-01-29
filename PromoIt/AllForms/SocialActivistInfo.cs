using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PromoIt
{
    public partial class SocialActivistInfo : Form
    {
        tweetinvi test = new tweetinvi();
        TweetCountActivist test1 = new TweetCountActivist();

        Functions functions = new Functions();
        const string connectionString = @"server=localhost;userid=root;password=admin;database=promoitdb";
        public MySqlConnection connection = new MySqlConnection(connectionString);
        public SocialActivistInfo()
        {
            InitializeComponent();
        }

        private void SA_Enter_Info_button_Click(object sender, EventArgs e)
        {
            functions.send_data_to_sql_activist_information(SA_Email_textBox.Text, SA_Address_textBox.Text,
                SA_PhoneNumber_textBox.Text);

            MessageBox.Show("Data successfully sent");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoAcBuyProduct SABP = new SoAcBuyProduct();
            this.Hide();
            SABP.ShowDialog();
            this.Close();
        }
    }
}
