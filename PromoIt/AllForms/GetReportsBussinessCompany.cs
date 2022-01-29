using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;
using DataGridview_Connect_DB;

namespace PromoIt
{
     public partial class GetReportsBussinessCompany : Form
    {
        GetRepoSocialActivistDB con = new GetRepoSocialActivistDB();



        private static ArrayList ListUserName1 = new ArrayList();

        private static ArrayList ListPassword1 = new ArrayList();
        private static ArrayList ListChosen_campaign = new ArrayList();
        private static ArrayList ListProduct = new ArrayList();
        private static ArrayList ListAmount = new ArrayList();
        private static ArrayList ListValueOfProduct = new ArrayList();

        public GetReportsBussinessCompany()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                GetData();
                if (ListUserName1.Count > 0)
                {
                    updateDatagrid();
                }
                else
                {
                    MessageBox.Show("Data not found");
                }
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                GetData2();
                if (ListUserName1.Count > 0)
                {
                    updateDatagrid2();
                }
                else
                {
                    MessageBox.Show("Data not found");
                }
            }
        }
        private void GetData()
        {
            try
            {
                con.Open();
                string query = "select Company_User_Name,Password_BCR from business_company_representative_regestration";


                MySqlDataReader row;
                row = con.ExecuteReader(query);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        ListUserName1.Add(row["Company_User_Name"].ToString());
                        ListPassword1.Add(row["Password_BCR"].ToString());

                    }
                }
                else
                {
                    MessageBox.Show("Data not found");
                }

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }
        private void GetData2()
        {
            try
            {
                con.Open();
                string query = "select Chosen_Campaign,product,Amount,Value_of_product from bcr_product_donation";


                MySqlDataReader row;
                row = con.ExecuteReader(query);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        ListChosen_campaign.Add(row["Chosen_Campaign"].ToString());
                        ListProduct.Add(row["product"].ToString());
                        ListAmount.Add(row["Amount"].ToString());
                        ListValueOfProduct.Add(row["Value_of_product"].ToString());

                    }
                }
                else
                {
                    MessageBox.Show("Data not found");
                }

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }

        private void updateDatagrid()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < ListUserName1.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dataGridView1);
                newRow.Cells[0].Value = ListUserName1[i];
                newRow.Cells[1].Value = ListPassword1[i];

                dataGridView1.Rows.Add(newRow);
            }
        }
        private void updateDatagrid2()
        {
            dataGridView2.Rows.Clear();
            for (int i = 0; i < ListChosen_campaign.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dataGridView2);
                newRow.Cells[0].Value = ListChosen_campaign[i];
                newRow.Cells[1].Value = ListProduct[i];
                newRow.Cells[2].Value = ListAmount[i];
                newRow.Cells[3].Value = ListValueOfProduct[i];

                dataGridView2.Rows.Add(newRow);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetReports GOBACK2 = new GetReports();
            this.Hide();
            GOBACK2.ShowDialog();
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}