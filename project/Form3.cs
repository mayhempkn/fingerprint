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
    public partial class Form3 : Form
    {
        // calling secuGen Class constructor
        //string imgLoc = "";
        private SecuBSPMx m_SecuBSP;
        private bool m_DeviceOpened;

        private string m_EnrollFIRText;
       
        string con = "Server=127.0.0.1 port=3306; Uid=root; Database=project; Password=";

        private string m_CaptureFIRText;


        public Form3()
        {
            InitializeComponent();
        }

       

        private void registerstudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 targetform = new Form2();
            targetform.Show();
        }

        private void validatestudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 targetform = new Form3();
            targetform.Show();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 targetform = new Form1();
            targetform.Show();
        }

        private void opendevice_Click(object sender, EventArgs e)
        {
            BSPError err;

            if (m_DeviceOpened)
            {
                m_SecuBSP.CloseDevice();
                m_DeviceOpened = false;
            }

            // Get Selected device by User
            string selected_device = DeviceIDCombo.Text;
            //  selected_device = selected_device.Substring(0, 6);
             // Int16 device_id = Convert.ToInt16(selected_device.Substring(0, 6), 16);

            //  m_SecuBSP.DeviceID = device_id;

            err = m_SecuBSP.OpenDevice();
            DisplaySecuBSPErrMsg("OpenDevice", err);
            if (err != BSPError.ERROR_NONE)
                return;

            m_DeviceOpened = true;
        }

        //----------------------------------------------------


        private void enumerate_Click(object sender, EventArgs e)
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

        private void Form3_Load(object sender, EventArgs e)
        {
            DeviceIDCombo.Items.Add("0x00FF (Auto Detect)");
            m_DeviceOpened = false;

            m_SecuBSP = new SecuBSPMx();

            m_EnrollFIRText = "";


            enumerate_Click(sender, e);

        }


        private void regno_Click(object sender, EventArgs e)
        {

        }

        private void studentname_Click(object sender, EventArgs e)
        {

        }

        private void course_Click(object sender, EventArgs e)
        {

        }

        private void year_Click(object sender, EventArgs e)
        {

        }

        private void studentphoto_Click(object sender, EventArgs e)
        {

        }

        private void fingerprint_Click(object sender, EventArgs e)
        {

        }

        private void verify_Click(object sender, EventArgs e)
        {

        }

        private void capture_Click(object sender, EventArgs e)
        {
            BSPError err;

            m_SecuBSP.CaptureWindowOption.WindowStyle = (int)WindowStyle.INVISIBLE;

            m_SecuBSP.CaptureWindowOption.ShowFPImage = true;

            m_SecuBSP.CaptureWindowOption.FingerWindow = (IntPtr)fingerprintbox.Handle;

            err = m_SecuBSP.Capture(FIRPurpose.VERIFY);
            if (err == BSPError.ERROR_NONE)
            {
                m_CaptureFIRText = m_SecuBSP.FIRTextData;
                string con = String.Empty;
                

                con = "Server=127.0.0.1; SslMode=none; port=3306; Uid=root; Database=project; Password=";
                string sql = string.Empty;
               // sql = @"SELECT * FROM register WHERE  fingerprint='"+ fingerprintbox + "' ";
                sql = @"SELECT * FROM register  ";

                using (MySqlConnection sqlcon = new MySqlConnection(con))
                {
                    sqlcon.Open();
                   
                    using (MySqlCommand com = new MySqlCommand(sql, sqlcon))
                    {
                        using (MySqlDataReader auth = com.ExecuteReader())
                        {
                            if (m_CaptureFIRText != "")
                                if (auth.HasRows)
                                {
                                while (auth.Read())
                                {
                                    m_EnrollFIRText = auth["fingerprint"].ToString();

                                    err = m_SecuBSP.VerifyMatch(m_CaptureFIRText, m_EnrollFIRText);
                                    

                                    if (err == BSPError.ERROR_NONE)
                                        {
                                        if (m_SecuBSP.IsMatched)
                                        {
                                                
                                            StatusBar.Text = "Fingerprint Matched";

                                                

                                                display_student_details();
                                                
                                            }
                                            else
                                            {
                                                
                                                StatusBar.Text = "Fingerprint Not Matched";
                                                
                                            }

                                            
                                        }
                                    else
                                    {
                                        DisplaySecuBSPErrMsg("VerifyMatch", err);
                                    }
                                        break;
                                    }

                                }
                            
                        }
                    }

                    DisplaySecuBSPErrMsg("Capture", err);
                }

            }
        }
        public void display_student_details()
        {
            string con = String.Empty;
            
            con = "Server=127.0.0.1; SslMode=none; port=3306; Uid=root; Database=project; Password=";
            string sql = string.Empty;
            // sql = @"SELECT * FROM register WHERE  fingerprint='"+ fingerprintbox + "' ";
            sql = @"SELECT * FROM register  ";

            using (MySqlConnection sqlcon = new MySqlConnection(con))
            {
                sqlcon.Open();
              
                using (MySqlCommand com = new MySqlCommand(sql, sqlcon))
                {
                    using (MySqlDataReader auth = com.ExecuteReader())
                    {
                       
                            if (auth.HasRows)
                            {
                                while (auth.Read())
                                {
                                regno.Text = auth.GetString("regno");
                                firstname.Text = auth.GetString("firstname");
                                lastname.Text = auth.GetString("lastname");
                                course.Text = auth.GetString("course");
                                year.Text = auth.GetString("year");
                                studentphoto.Text = auth.GetString("studentphoto").ToString();
                                //  MessageBox.Show("this is a test");
                                break;
                            }

                            }

                    }
                }

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lastname_Click(object sender, EventArgs e)
        {

        }

        private void firstname_Click(object sender, EventArgs e)
        {

        }

        private void StatusBar_Click(object sender, EventArgs e)
        {

        }

        private void Exit_btn_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
