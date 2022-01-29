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
    public partial class NonProfitRegister : Form
    {
        tweetinvi test = new tweetinvi();
        TweetCountActivist test1 = new TweetCountActivist();

        Functions functions = new Functions();
        const string connectionString = @"server=localhost;userid=root;password=admin;database=promoitdb";
        public MySqlConnection connection = new MySqlConnection(connectionString);

        public NonProfitRegister()
        {
            InitializeComponent();
        }

        private void np_registretion_Enter_Button_Click(object sender, EventArgs e)
        {
            functions.send_data_to_sql(UserNameNP_textBox.Text, Password_textBox.Text);

            NonProfitInfo NPI = new NonProfitInfo();
            this.Hide();
            NPI.ShowDialog();
            this.Close();

        }
    }
}
