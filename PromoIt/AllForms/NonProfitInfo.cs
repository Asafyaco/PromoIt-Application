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
    public partial class NonProfitInfo : Form
    {
        tweetinvi test = new tweetinvi();
        TweetCountActivist test1 = new TweetCountActivist();

        Functions functions = new Functions();
        const string connectionString = @"server=localhost;userid=root;password=admin;database=promoitdb";
        public MySqlConnection connection = new MySqlConnection(connectionString);
        public NonProfitInfo()
        {
            InitializeComponent();
        }

        private void np_company_info_enter_button_Click(object sender, EventArgs e)
        {
            functions.send_data_to_sql_NP_company_info(NP_COMPANYName_textBox.Text, NP_COMPANYEmail_textBox.Text,
                NP_COMPANYLink_textBox.Text);
            MessageBox.Show("Data successfully sent");
            CampaignByHashtag CBH = new CampaignByHashtag();
            this.Hide();
            CBH.ShowDialog();
            this.Close();
        }
    }
}
