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
    public partial class Business_CompanyDonation : Form
    {
        tweetinvi test = new tweetinvi();
        TweetCountActivist test1 = new TweetCountActivist();

        Functions functions = new Functions();
        const string connectionString = @"server=localhost;userid=root;password=admin;database=promoitdb";
        public MySqlConnection connection = new MySqlConnection(connectionString);

        public Business_CompanyDonation()
        {
            InitializeComponent();
        }

        private void BCR_pro_donation_enter_Button_Click(object sender, EventArgs e)
        {
            functions.send_data_to_sql_business_company_donation(BC_PRO_PRODUCT_TEXT_BOX.Text,
                Int32.Parse(BC_PRO_AMOUNT_TEXT_BOX.Text), Int32.Parse(BC_PRO_VALUE_TEXT_BOX.Text),
                BC_PRO_CHOSEN_DONATION_TEXT_BOX.Text);
            MessageBox.Show("Data successfully sent");

        }

       
    }
}
