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

namespace project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {
            try
            {
                // post browsed image to database
                string sql = string.Empty;
                string con = string.Empty;
                byte[] imageData = null;

                // check connection and connect to the database
                //String con = string.Empty;
                con = "Server=127.0.0.1; port=3306; Uid=root; Database=project; Password=";
                //string sql = string.Empty;
                sql = @"INSERT  INTO signup (securityid, firstname,lastname,password)VALUES (@securityid,@firstname,@lastname, @password)";
                using (MySqlConnection sqlcon = new MySqlConnection(con))
                {
                    sqlcon.Open();
                    using (MySqlCommand com = new MySqlCommand(sql, sqlcon))
                    {
                        if (securityid.Text != "" && firstname.Text != "" && lastname.Text != "" && password.Text != "" )
                        {
                            ////get values from users
                            com.Parameters.AddWithValue("@securityid", securityid.Text);
                            com.Parameters.AddWithValue("@firstname", firstname.Text);
                            com.Parameters.AddWithValue("@lastname", lastname.Text);
                            com.Parameters.AddWithValue("@password", password.Text);
                          //  com.Parameters.AddWithValue("@confirmpassword", confirmpassword.Text);
                            com.ExecuteNonQuery();

                            Form1 fm = new Form1();
                            fm.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("All fields are required to be filled");
                        }


                    }
                   

                }
                //clear text boxes
                securityid.Text = " ";
                firstname.Text = " ";
                lastname.Text = " ";
                password.Text = " ";
            //    confirmpassword.Text = " ";



            }
            catch(Exception ex)
            {
                MessageBox.Show("Problem Adding to database" + ex);


            }



        }
        private void Exit_btn_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void securityid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_btn_Click_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
