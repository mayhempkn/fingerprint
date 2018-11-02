using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecuGen.SecuBSPPro.Windows;
using MySql.Data.MySqlClient;

namespace project
{


    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // check connection to the database
                // initialize connection to an empty string
                String con = string.Empty;
                con = "Server=127.0.0.1; port=3306; Uid=root; Database=project; Password=";
                string sql = string.Empty;
                sql = @"SELECT securityid,password FROM signup WHERE securityid='" + securityid.Text + "' and password='" + password.Text + "'";
                using (MySqlConnection sqlcon = new MySqlConnection(con))
                {
                    sqlcon.Open();
                    string[] Item = new string[1];
                    using (MySqlCommand com = new MySqlCommand(sql, sqlcon))
                    {

                        using (MySqlDataReader auth = com.ExecuteReader())
                        {

                            // if (securityid.Text != "")
                            if (auth.HasRows)
                            {

                                Form2 mm = new Form2();
                                mm.Show();
                                this.Hide();

                            }

                            

                            
                            else
                            {
                                MessageBox.Show("username or password is incorect. Please Try Again" +
                                    "");
                                securityid.Text = "";
                                password.Text = "";
                            }


                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error()" + ex);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Form4 targetform = new Form4();
            targetform.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_btn_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_frm_Load_Click(object sender, EventArgs e)
        {
            DateTime tm = DateTime.Now;

            time.Text = tm.ToString("yyyy-MM-dd");
        }

       


        //----------------------------------------------------
    }

}

