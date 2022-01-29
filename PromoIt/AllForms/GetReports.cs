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
    public partial class GetReports : Form
    {
        public GetReports()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetReportsSoAc GRSA = new GetReportsSoAc();
            this.Hide();
            GRSA.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NonProfitOrganization NPOGR = new NonProfitOrganization();
            this.Hide();
            NPOGR.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetReportsBussinessCompany GRBC = new GetReportsBussinessCompany();
            this.Hide();
            GRBC.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProLobbyOwner1 GRBC11 = new ProLobbyOwner1();
            this.Hide();
            GRBC11.ShowDialog();
            this.Close();
        }
    }
}
