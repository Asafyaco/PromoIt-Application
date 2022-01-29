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


    public partial class BusinessCompanyRegistretion : Form
    {
        tweetinvi test = new tweetinvi();
        TweetCountActivist test1 = new TweetCountActivist();

        Functions functions = new Functions();
        const string connectionString = @"server=localhost;userid=root;password=admin;database=promoitdb";
        public MySqlConnection connection = new MySqlConnection(connectionString);

        public BusinessCompanyRegistretion()
        {
            InitializeComponent();
        }

        private void BCR_registretion_enter_button_Click(object sender, EventArgs e)
        {
            functions.send_data_to_sql_business_company_registration(UserNameBC_textBox.Text, PASS_BC_TEXTBOX.Text);
            Business_CompanyDonation BCI = new Business_CompanyDonation();
            this.Hide();
            BCI.ShowDialog();
            this.Close();

        }

        private void UserNameBC_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
