namespace project
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.enumerate = new System.Windows.Forms.Button();
            this.opendevice = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DeviceIDCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StatusBar = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.takephoto = new System.Windows.Forms.Button();
            this.capture = new System.Windows.Forms.Button();
            this.fingerprint = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.studentphoto = new System.Windows.Forms.PictureBox();
            this.year = new System.Windows.Forms.TextBox();
            this.course = new System.Windows.Forms.TextBox();
            this.regno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.validatestudent = new System.Windows.Forms.Button();
            this.registerstudent = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.Exit_btn_Click = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fingerprint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentphoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(412, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Identification System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // enumerate
            // 
            this.enumerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enumerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.enumerate.Location = new System.Drawing.Point(474, 41);
            this.enumerate.Name = "enumerate";
            this.enumerate.Size = new System.Drawing.Size(85, 23);
            this.enumerate.TabIndex = 1;
            this.enumerate.Text = "Enumerate ";
            this.enumerate.UseVisualStyleBackColor = true;
            this.enumerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // opendevice
            // 
            this.opendevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opendevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.opendevice.Location = new System.Drawing.Point(335, 41);
            this.opendevice.Name = "opendevice";
            this.opendevice.Size = new System.Drawing.Size(84, 26);
            this.opendevice.TabIndex = 2;
            this.opendevice.Text = "Open Device";
            this.opendevice.UseVisualStyleBackColor = true;
            this.opendevice.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(80, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Device";
            // 
            // DeviceIDCombo
            // 
            this.DeviceIDCombo.FormattingEnabled = true;
            this.DeviceIDCombo.Location = new System.Drawing.Point(168, 41);
            this.DeviceIDCombo.Name = "DeviceIDCombo";
            this.DeviceIDCombo.Size = new System.Drawing.Size(121, 24);
            this.DeviceIDCombo.TabIndex = 4;
            this.DeviceIDCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enumerate);
            this.groupBox1.Controls.Add(this.opendevice);
            this.groupBox1.Controls.Add(this.DeviceIDCombo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(111, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 86);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initialization";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StatusBar);
            this.groupBox2.Controls.Add(this.lastname);
            this.groupBox2.Controls.Add(this.firstname);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.submit);
            this.groupBox2.Controls.Add(this.takephoto);
            this.groupBox2.Controls.Add(this.capture);
            this.groupBox2.Controls.Add(this.fingerprint);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.studentphoto);
            this.groupBox2.Controls.Add(this.year);
            this.groupBox2.Controls.Add(this.course);
            this.groupBox2.Controls.Add(this.regno);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(188, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 559);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(20, 504);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(179, 38);
            this.StatusBar.TabIndex = 29;
            this.StatusBar.Visible = false;
            this.StatusBar.Click += new System.EventHandler(this.StatusBar_Click);
            // 
            // lastname
            // 
            this.lastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastname.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.ForeColor = System.Drawing.Color.White;
            this.lastname.Location = new System.Drawing.Point(244, 277);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(228, 25);
            this.lastname.TabIndex = 28;
            this.lastname.TextChanged += new System.EventHandler(this.lastname_TextChanged);
            // 
            // firstname
            // 
            this.firstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.firstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstname.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.ForeColor = System.Drawing.Color.White;
            this.firstname.Location = new System.Drawing.Point(244, 220);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(228, 25);
            this.firstname.TabIndex = 27;
            this.firstname.TextChanged += new System.EventHandler(this.firstname_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(68, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "First Name";
            // 
            // submit
            // 
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.submit.Location = new System.Drawing.Point(618, 480);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(85, 35);
            this.submit.TabIndex = 25;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // takephoto
            // 
            this.takephoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takephoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.takephoto.Location = new System.Drawing.Point(403, 460);
            this.takephoto.Name = "takephoto";
            this.takephoto.Size = new System.Drawing.Size(94, 31);
            this.takephoto.TabIndex = 24;
            this.takephoto.Text = "Take Photo";
            this.takephoto.UseVisualStyleBackColor = true;
            this.takephoto.Click += new System.EventHandler(this.takephoto_Click);
            // 
            // capture
            // 
            this.capture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.capture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.capture.Location = new System.Drawing.Point(566, 203);
            this.capture.Name = "capture";
            this.capture.Size = new System.Drawing.Size(85, 35);
            this.capture.TabIndex = 23;
            this.capture.Text = "Capture";
            this.capture.UseVisualStyleBackColor = true;
            this.capture.Click += new System.EventHandler(this.button3_Click);
            // 
            // fingerprint
            // 
            this.fingerprint.Location = new System.Drawing.Point(523, 247);
            this.fingerprint.Name = "fingerprint";
            this.fingerprint.Size = new System.Drawing.Size(180, 148);
            this.fingerprint.TabIndex = 22;
            this.fingerprint.TabStop = false;
            this.fingerprint.Click += new System.EventHandler(this.fingerprint_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(563, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Fingerprint";
            // 
            // studentphoto
            // 
            this.studentphoto.Location = new System.Drawing.Point(228, 410);
            this.studentphoto.Name = "studentphoto";
            this.studentphoto.Size = new System.Drawing.Size(158, 132);
            this.studentphoto.TabIndex = 20;
            this.studentphoto.TabStop = false;
            this.studentphoto.Click += new System.EventHandler(this.studentphoto_Click);
            // 
            // year
            // 
            this.year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.year.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.ForeColor = System.Drawing.Color.White;
            this.year.Location = new System.Drawing.Point(244, 370);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(228, 25);
            this.year.TabIndex = 19;
            this.year.TextChanged += new System.EventHandler(this.year_TextChanged);
            // 
            // course
            // 
            this.course.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.course.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.course.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course.ForeColor = System.Drawing.Color.White;
            this.course.Location = new System.Drawing.Point(244, 319);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(228, 25);
            this.course.TabIndex = 17;
            this.course.TextChanged += new System.EventHandler(this.course_TextChanged);
            // 
            // regno
            // 
            this.regno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.regno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regno.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regno.ForeColor = System.Drawing.Color.White;
            this.regno.Location = new System.Drawing.Point(244, 165);
            this.regno.Name = "regno";
            this.regno.Size = new System.Drawing.Size(228, 25);
            this.regno.TabIndex = 15;
            this.regno.TextChanged += new System.EventHandler(this.regno_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(68, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Student photo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(68, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(68, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(68, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(68, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Registration Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.validatestudent);
            this.panel1.Controls.Add(this.registerstudent);
            this.panel1.Controls.Add(this.home);
            this.panel1.Location = new System.Drawing.Point(1, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 524);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // validatestudent
            // 
            this.validatestudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validatestudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.validatestudent.Location = new System.Drawing.Point(7, 330);
            this.validatestudent.Name = "validatestudent";
            this.validatestudent.Size = new System.Drawing.Size(167, 35);
            this.validatestudent.TabIndex = 26;
            this.validatestudent.Text = "Validate Students";
            this.validatestudent.UseVisualStyleBackColor = true;
            this.validatestudent.Click += new System.EventHandler(this.validatestudent_Click);
            // 
            // registerstudent
            // 
            this.registerstudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerstudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.registerstudent.Location = new System.Drawing.Point(7, 245);
            this.registerstudent.Name = "registerstudent";
            this.registerstudent.Size = new System.Drawing.Size(167, 35);
            this.registerstudent.TabIndex = 25;
            this.registerstudent.Text = "Register Students";
            this.registerstudent.UseVisualStyleBackColor = true;
            this.registerstudent.Click += new System.EventHandler(this.registerstudent_Click);
            // 
            // home
            // 
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.home.Location = new System.Drawing.Point(3, 165);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(167, 35);
            this.home.TabIndex = 24;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // Exit_btn_Click
            // 
            this.Exit_btn_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit_btn_Click.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Exit_btn_Click.Location = new System.Drawing.Point(853, 12);
            this.Exit_btn_Click.Name = "Exit_btn_Click";
            this.Exit_btn_Click.Size = new System.Drawing.Size(75, 23);
            this.Exit_btn_Click.TabIndex = 13;
            this.Exit_btn_Click.Text = "Exit";
            this.Exit_btn_Click.UseVisualStyleBackColor = true;
            this.Exit_btn_Click.Click += new System.EventHandler(this.Exit_btn_Click_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(949, 637);
            this.Controls.Add(this.Exit_btn_Click);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fingerprint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentphoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enumerate;
        private System.Windows.Forms.Button opendevice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DeviceIDCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox course;
        private System.Windows.Forms.TextBox regno;
        private System.Windows.Forms.Button takephoto;
        private System.Windows.Forms.Button capture;
        private System.Windows.Forms.PictureBox fingerprint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox studentphoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button validatestudent;
        private System.Windows.Forms.Button registerstudent;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label StatusBar;
        private System.Windows.Forms.Button Exit_btn_Click;
    }
}