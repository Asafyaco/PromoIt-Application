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
using Tweetinvi;

namespace PromoIt
{
    public partial class CampaignByHashtag : Form
    {
        tweetinvi test = new tweetinvi();
        TweetCountActivist test1 = new TweetCountActivist();

        Functions functions = new Functions();
        const string connectionString = @"server=localhost;userid=root;password=admin;database=promoitdb";
        public MySqlConnection connection = new MySqlConnection(connectionString);

      
            

            public CampaignByHashtag()
        {
            InitializeComponent();
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        public string name123()
        {
            return hashtag_box.Text;

        }
        
        string fdsfsd => hashtag_box.Text;
        

        public async void button2_Click(object sender, EventArgs e)
        {
            var userClient = new TwitterClient("0Yyca8qlXJ9TRoeId8PR9Dd1x",
                "dpDSsL9DMxtPGJ4uUVcBQeFgQSZnq8DpbghQlZuRUVdID9Wlrf",
                "1445124752767692811-Whd0Ayd1sibvdCBdoNNMrSsfGSeqaA",
                "lSPOi2OTYsJjJbWOzNeFynuJNnA34eevac0kMskUNlDHo");
            var searchResponse = await userClient.SearchV2.SearchTweetsAsync(fdsfsd);

            textBox2.Text += new EventHandler(textBox2_TextChanged);
        }





        public async void textBox2_TextChanged(object sender, EventArgs e)
        {
            var userClient = new TwitterClient("0Yyca8qlXJ9TRoeId8PR9Dd1x",
                "dpDSsL9DMxtPGJ4uUVcBQeFgQSZnq8DpbghQlZuRUVdID9Wlrf",
                "1445124752767692811-Whd0Ayd1sibvdCBdoNNMrSsfGSeqaA",
                "lSPOi2OTYsJjJbWOzNeFynuJNnA34eevac0kMskUNlDHo");

            var searchResponse = await userClient.SearchV2.SearchTweetsAsync(fdsfsd);
            var tweets5 = searchResponse.Tweets;

            textBox2.Text = string.Join(Environment.NewLine, tweets5.Select(x => x.Text));
        }

        

        public void hashtag_box_TextChanged(object sender, EventArgs e)
        {
          
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
