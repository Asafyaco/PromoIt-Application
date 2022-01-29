using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromoIt
{
    public partial class EnteryWindow : Form
    {
        public EnteryWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NonProfitRegister NPR = new NonProfitRegister();
            this.Hide();
            NPR.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BusinessCompanyRegistretion BCR = new BusinessCompanyRegistretion();
            this.Hide();
            BCR.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SocialActivistRegistretion SAR = new SocialActivistRegistretion();
            this.Hide();
            SAR.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProLobbyOwner1 PLO = new ProLobbyOwner1();
            this.Hide();
            PLO.ShowDialog();
            this.Close();
        }
    }
}
