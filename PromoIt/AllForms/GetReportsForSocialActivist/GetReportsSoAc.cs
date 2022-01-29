using System;
using System.Collections.Generic;
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
    public partial class GetReportsSoAc : Form
    {
        GetRepoSocialActivistDB con = new GetRepoSocialActivistDB();

        private static ArrayList ListUserName = new ArrayList();

        private static ArrayList ListPassword = new ArrayList();
        private static ArrayList ListEmail = new ArrayList();
        private static ArrayList Listaddress = new ArrayList();
        private static ArrayList Listphone_number = new ArrayList();

        public GetReportsSoAc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                GetData();
                if (ListUserName.Count > 0)
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
                if (ListUserName.Count > 0)
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
                string query = "select Activist_User_Name,Activist_Password from social_activist_registration";

                 
                MySqlDataReader row;
                row = con.ExecuteReader(query);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        ListUserName.Add(row["Activist_User_Name"].ToString());
                        ListPassword.Add(row["Activist_Password"].ToString());
                       
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
                string query = "select activist_email,activist_address,activist_phone_number from social_activist_information";

                 
                MySqlDataReader row;
                row = con.ExecuteReader(query);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        ListEmail.Add(row["activist_email"].ToString());
                        Listaddress.Add(row["activist_address"].ToString());
                        Listphone_number.Add(row["activist_phone_number"].ToString());
                        
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
            for (int i = 0; i < ListUserName.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dataGridView1);
                newRow.Cells[0].Value = ListUserName[i];
                newRow.Cells[1].Value = ListPassword[i];
              
                dataGridView1.Rows.Add(newRow);
            }
        }
        private void updateDatagrid2()
        {
            dataGridView2.Rows.Clear();
            for (int i = 0; i < ListEmail.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dataGridView2);
                newRow.Cells[0].Value = ListEmail[i];
                newRow.Cells[1].Value = Listaddress[i];
                newRow.Cells[2].Value = Listphone_number[i];
                
                dataGridView2.Rows.Add(newRow);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetReports GOBACK3 = new GetReports();
            this.Hide();
            GOBACK3.ShowDialog();
            this.Close();
        }
    }
}