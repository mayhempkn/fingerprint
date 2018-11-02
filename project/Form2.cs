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
using System.IO;


namespace project
{
    public partial class Form2 : Form
    {
        // calling secuGen Class constructor
        string imgLoc = " ";
        private SecuBSPMx m_SecuBSP;
        private bool m_DeviceOpened;

        private string m_EnrollFIRText;


        public Form2()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BSPError err;

            if (m_DeviceOpened)
            {
                m_SecuBSP.CloseDevice();
                m_DeviceOpened = false;
            }

            // Get Selected device by User
            string selected_device = DeviceIDCombo.Text;
            selected_device = selected_device.Substring(0, 6);
            Int16 device_id = Convert.ToInt16(selected_device.Substring(0, 6), 16);

            m_SecuBSP.DeviceID = device_id;

            err = m_SecuBSP.OpenDevice();
            DisplaySecuBSPErrMsg("OpenDevice", err);
            if (err != BSPError.ERROR_NONE)
                return;

            m_DeviceOpened = true;
        }

        //----------------------------------------------------


        private void button1_Click(object sender, EventArgs e)
        {

            BSPError err;
            DeviceIDCombo.Items.Clear();

            DeviceIDCombo.Items.Add("0x00ff (Auto Detect)");
            err = m_SecuBSP.EnumerateDevice();
            if (err == BSPError.ERROR_NONE)
            {
                for (int i = 0; i < m_SecuBSP.DeviceNum; i++)
                {
                    Int16 device_id = m_SecuBSP.GetDeviceID(i);

                    string device_id_info;
                    device_id_info = "0x" + MakeHexaDecimal(device_id, 4) + "  ("
                       + m_SecuBSP.GetDeviceName(device_id) + ","
                       + m_SecuBSP.GetDeviceInstanceNum(device_id) + ")";

                    DeviceIDCombo.Items.Add(device_id_info);

                }
            }
            DisplaySecuBSPErrMsg("EnumerateDevice", err);
        }
        //----------------------------------------------------


        private void DisplaySecuBSPErrMsg(string funcName, BSPError errNum)
        {
            if (errNum == 0)
                StatusBar.Text = funcName + "()" + " :Success";
            else
                StatusBar.Text = funcName + "()" + " :Error occurred. Err# = " + Convert.ToString(errNum);
        }

        //----------------------------------------------------
        string MakeHexaDecimal(Int32 numbers, Int32 digit)
        {
            string dest_str = "0000000000000000"; // digit can not exceed 16

            string str = Convert.ToString(numbers, 16);
            Int32 len = str.Length;

            if (len > digit)
                dest_str = "";
            else
                dest_str = dest_str.Substring(0, digit - len) + str;

            return dest_str;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DeviceIDCombo.Items.Add("0x00FF (Auto Detect)");
            m_DeviceOpened = false;

            m_SecuBSP = new SecuBSPMx();

            m_EnrollFIRText = "";


            button1_Click(sender, e);


        }

        private void submit_Click(object sender, EventArgs e)
        {

            try
            {
                // post browsed image to database
                string sql = string.Empty;
                string con = string.Empty;
                byte[] imageData = null;
                FileStream mfilestream = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader bireader = new BinaryReader(mfilestream);
                imageData = bireader.ReadBytes((int)mfilestream.Length);
                bireader.Close();
                mfilestream.Close();

                // check connection and connect to the database
                //String con = string.Empty;
                con = "Server=127.0.0.1; port=3306; Uid=root; Database=project; Password=";
                //string sql = string.Empty;
                sql = @"INSERT  INTO register (regno, firstname,lastname,course, year,studentphoto, fingerprint)VALUES (@regno,@firstname,@lastname, @course,@Year, @studentphoto, @fingerprint)";
                using (MySqlConnection sqlcon = new MySqlConnection(con))
                {
                    sqlcon.Open();
                    using (MySqlCommand com = new MySqlCommand(sql, sqlcon))
                    {
                        if (regno.Text != "" || firstname.Text != "" || lastname.Text != "" || course.Text != "" || year.Text != "" || studentphoto.Text != "" || fingerprint.Text != "" )
                        {
                            ////get values from users
                            com.Parameters.AddWithValue("@regno", regno.Text);
                            com.Parameters.AddWithValue("@firstname", firstname.Text);
                            com.Parameters.AddWithValue("@lastname", lastname.Text);
                            com.Parameters.AddWithValue("@course", course.Text);
                            com.Parameters.AddWithValue("@studentphoto", studentphoto); // in place of image
                            com.Parameters.AddWithValue("@year", year.Text);
                            com.Parameters.AddWithValue("@fingerprint", fingerprint.Text);
                            

                            MySqlConnection sqlcon2 = new MySqlConnection(con);
                            sqlcon2.Open();
                            string Select;
                            Select = "SELECT * FROM register WHERE regno='" + regno.Text + "'";
                            using (MySqlCommand cm = new MySqlCommand(Select, sqlcon2))
                            {
                                using (MySqlDataReader auth = cm.ExecuteReader())
                                {
                                    if (auth.HasRows)
                                    {
                                        MessageBox.Show("Your details already exists in our database,Thank you");
                                        sqlcon.Close();
                                    }
                                    else
                                    {


                                        com.ExecuteNonQuery();
                                        sqlcon2.Close();
                                    }
                                }

                            }
                            //if successful
                            MessageBox.Show("Processing Complete.....You are registered successfully!");

                        }
                        else
                        {
                            MessageBox.Show("other fields apart from image and course must be filled");
                        }
                    }
                }
                //clear text boxes
                regno.Text = " ";
                firstname.Text = " ";
                lastname.Text = " ";
                course.Text = " ";
                studentphoto.Text = " ";
                year.Text = " ";
                fingerprint.Text = " ";
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem Adding to database" + ex);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void regno_TextChanged(object sender, EventArgs e)
        {

        }

        private void course_TextChanged(object sender, EventArgs e)
        {

        }

        private void year_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentphoto_Click(object sender, EventArgs e)
        {

        }

        private void fingerprint_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {

        }

        private void registerstudent_Click(object sender, EventArgs e)
        {

        }

        private void validatestudent_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BSPError err;
            err = m_SecuBSP.Enroll(regno.Text);

            if (err == BSPError.ERROR_NONE)
            {
                m_EnrollFIRText = m_SecuBSP.FIRTextData;
                fingerprint.Text = m_EnrollFIRText;
            }

            DisplaySecuBSPErrMsg("Enroll", err);
        }

       

        private void takephoto_Click(object sender, EventArgs e)
        {

        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void StatusBar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_btn_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }



}


