using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Parameters.V2;

namespace PromoIt
{
    public class tweetinvi
    {

        public async void API_Keys()
        {
            EnteryWindow dfds = new EnteryWindow();

            //  we create a client with your user's credentials
            var userClient = new TwitterClient("0Yyca8qlXJ9TRoeId8PR9Dd1x",
                "dpDSsL9DMxtPGJ4uUVcBQeFgQSZnq8DpbghQlZuRUVdID9Wlrf",
                "1445124752767692811-Whd0Ayd1sibvdCBdoNNMrSsfGSeqaA",
                "lSPOi2OTYsJjJbWOzNeFynuJNnA34eevac0kMskUNlDHo");
            // request the user's information from Twitter API
            var user = await userClient.Users.GetAuthenticatedUserAsync();
            Console.WriteLine("Hello " + user);

            //string nameinprog = test.name123();

            //var searchResponse = await userClient.SearchV2.SearchTweetsAsync(typeof(Form1)
            //    .GetMethod("HashTagNameBox_TextChanged", BindingFlags.NonPublic | BindingFlags.Instance)
            //    .Invoke(new Form1(), null).ToString());
            var searchResponse = await userClient.SearchV2.SearchTweetsAsync("hello");
            //var searchResponse = await userClient.SearchV2.SearchTweetsAsync(nameinprog);
            var tweets5 = searchResponse.Tweets;

            foreach (var VARIABLE in tweets5)
            {
                Console.WriteLine("{0} ", VARIABLE.Text);

            }
        }
    }
}





