using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Tweetinvi;
using Tweetinvi.Models.V2;

namespace PromoIt
{
    public partial class SoAcBuyProduct : Form
    {
        public CampaignByHashtag usingTweets = new CampaignByHashtag();
        tweetinvi test1 = new tweetinvi();


        public SoAcBuyProduct()
        {
            InitializeComponent();

        }
 
       

        //we need to fix it here... we couldn't pass the value of the string from the FORM...
        //string fdsfsd => hashtag_box.Text;

        //public async void filterUsers()
        //{

        //    var userClient = new TwitterClient("0Yyca8qlXJ9TRoeId8PR9Dd1x",
        //        "dpDSsL9DMxtPGJ4uUVcBQeFgQSZnq8DpbghQlZuRUVdID9Wlrf",
        //        "1445124752767692811-Whd0Ayd1sibvdCBdoNNMrSsfGSeqaA",
        //        "lSPOi2OTYsJjJbWOzNeFynuJNnA34eevac0kMskUNlDHo");

        //    var searchResponse = await userClient.SearchV2.SearchTweetsAsync(fdsfsd);
        //    var tweets5 = searchResponse.Tweets;
        //}

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}
