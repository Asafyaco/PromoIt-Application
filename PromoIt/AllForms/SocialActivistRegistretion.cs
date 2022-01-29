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
    public partial class SocialActivistRegistretion : Form
    {
        tweetinvi test = new tweetinvi();
        TweetCountActivist test1 = new TweetCountActivist();

        Functions functions = new Functions();
        const string connectionString = @"server=localhost;userid=root;password=admin;database=promoitdb";
        public MySqlConnection connection = new MySqlConnection(connectionString);

        public SocialActivistRegistretion()
        {
            InitializeComponent();
        }

        private void SA_Enter_Reg_button_Click(object sender, EventArgs e)
        {
            functions.send_data_to_sql_activist_registration(SA_UserName_textBox.Text, SA_Password_textBox.Text);

            SocialActivistInfo SAI = new SocialActivistInfo();
            this.Hide();
            SAI.ShowDialog();
            this.Close();

        }
    }
}
