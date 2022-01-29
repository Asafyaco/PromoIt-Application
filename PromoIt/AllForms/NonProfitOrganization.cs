using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridview_Connect_DB;
using MySql.Data.MySqlClient;

namespace PromoIt
{
    public partial class NonProfitOrganization : Form
    {
        public NonProfitOrganization()
        {
            InitializeComponent();
        }
        GetRepoSocialActivistDB con = new GetRepoSocialActivistDB();



        private static ArrayList ListUserName1 = new ArrayList();

        private static ArrayList ListPassword1 = new ArrayList();
        private static ArrayList ListCompanyName = new ArrayList();
        private static ArrayList ListEmail1 = new ArrayList();
        private static ArrayList ListLink = new ArrayList();


        private void button1_Click(object sender, EventArgs e)
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
        private void button2_Click(object sender, EventArgs e)
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
                string query = "select User_Name,Password_un from users_registration_np";


                MySqlDataReader row;
                row = con.ExecuteReader(query);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        ListUserName1.Add(row["User_Name"].ToString());
                        ListPassword1.Add(row["Password_un"].ToString());

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
                string query = "select Company_Name,Email,Link from company_info_np";


                MySqlDataReader row;
                row = con.ExecuteReader(query);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        ListCompanyName.Add(row["Company_Name"].ToString());
                        ListEmail1.Add(row["Email"].ToString());
                        ListLink.Add(row["Link"].ToString());

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
            for (int i = 0; i < ListCompanyName.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dataGridView2);
                newRow.Cells[0].Value = ListCompanyName[i];
                newRow.Cells[1].Value = ListEmail1[i];
                newRow.Cells[2].Value = ListLink[i];

                dataGridView2.Rows.Add(newRow);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetReports GOBACK1 = new GetReports();
            this.Hide();
            GOBACK1.ShowDialog();
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    


