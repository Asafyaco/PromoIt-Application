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
    public partial class ProLobbyOwner1 : Form
    {
        tweetinvi test = new tweetinvi();
        TweetCountActivist test1 = new TweetCountActivist();

        Functions functions = new Functions();
        const string connectionString = @"server=localhost;userid=root;password=admin;database=promoitdb";
        public MySqlConnection connection = new MySqlConnection(connectionString);

        public ProLobbyOwner1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //functions.send_data_to_sql_pro_lobby_owner(textBox1.Text, textBox2.Text);
            if (textBox1.Text != "asaf" && textBox2.Text != "amit")
            {
                MessageBox.Show("Sorry, are you sure that you are the Owner?");
            }
            else
            {
                GetReports GR = new GetReports();
                this.Hide();
                GR.ShowDialog();
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnteryWindow GOBACKMENU = new EnteryWindow();
            this.Hide();
            GOBACKMENU.ShowDialog();
            this.Close();
        }
    }
}
