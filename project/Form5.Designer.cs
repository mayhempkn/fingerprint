namespace project
{
    partial class Form5
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
            this.Exit_btn_Click = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StatusBar = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.Label();
            this.verify = new System.Windows.Forms.Button();
            this.fingerprint = new System.Windows.Forms.PictureBox();
            this.capture = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.studentphoto = new System.Windows.Forms.PictureBox();
            this.year = new System.Windows.Forms.Label();
            this.course = new System.Windows.Forms.Label();
            this.regno = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enumerate = new System.Windows.Forms.Button();
            this.opendevice = new System.Windows.Forms.Button();
            this.DeviceIDCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.validatestudent = new System.Windows.Forms.Button();
            this.registerstudent = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fingerprint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentphoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit_btn_Click
            // 
            this.Exit_btn_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit_btn_Click.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Exit_btn_Click.Location = new System.Drawing.Point(778, -8);
            this.Exit_btn_Click.Name = "Exit_btn_Click";
            this.Exit_btn_Click.Size = new System.Drawing.Size(75, 23);
            this.Exit_btn_Click.TabIndex = 18;
            this.Exit_btn_Click.Text = "Exit";
            this.Exit_btn_Click.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StatusBar);
            this.groupBox2.Controls.Add(this.lastname);
            this.groupBox2.Controls.Add(this.firstname);
            this.groupBox2.Controls.Add(this.verify);
            this.groupBox2.Controls.Add(this.fingerprint);
            this.groupBox2.Controls.Add(this.capture);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.studentphoto);
            this.groupBox2.Controls.Add(this.year);
            this.groupBox2.Controls.Add(this.course);
            this.groupBox2.Controls.Add(this.regno);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(196, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 498);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Validation";
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(10, 427);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(179, 38);
            this.StatusBar.TabIndex = 30;
            this.StatusBar.Visible = false;
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lastname.Location = new System.Drawing.Point(482, 251);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(73, 16);
            this.lastname.TabIndex = 28;
            this.lastname.Text = "Last Name";
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.firstname.Location = new System.Drawing.Point(482, 201);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(73, 16);
            this.firstname.TabIndex = 27;
            this.firstname.Text = "First Name";
            // 
            // verify
            // 
            this.verify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.verify.Location = new System.Drawing.Point(259, 418);
            this.verify.Name = "verify";
            this.verify.Size = new System.Drawing.Size(85, 35);
            this.verify.TabIndex = 26;
            this.verify.Text = "Verify";
            this.verify.UseVisualStyleBackColor = true;
            // 
            // fingerprint
            // 
            this.fingerprint.Location = new System.Drawing.Point(31, 212);
            this.fingerprint.Name = "fingerprint";
            this.fingerprint.Size = new System.Drawing.Size(158, 148);
            this.fingerprint.TabIndex = 25;
            this.fingerprint.TabStop = false;
            // 
            // capture
            // 
            this.capture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.capture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.capture.Location = new System.Drawing.Point(61, 171);
            this.capture.Name = "capture";
            this.capture.Size = new System.Drawing.Size(85, 35);
            this.capture.TabIndex = 24;
            this.capture.Text = "Capture";
            this.capture.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(276, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Student photo";
            // 
            // studentphoto
            // 
            this.studentphoto.Location = new System.Drawing.Point(238, 223);
            this.studentphoto.Name = "studentphoto";
            this.studentphoto.Size = new System.Drawing.Size(154, 148);
            this.studentphoto.TabIndex = 21;
            this.studentphoto.TabStop = false;
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.year.Location = new System.Drawing.Point(502, 355);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(37, 16);
            this.year.TabIndex = 14;
            this.year.Text = "Year";
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.course.Location = new System.Drawing.Point(496, 304);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(51, 16);
            this.course.TabIndex = 13;
            this.course.Text = "Course";
            // 
            // regno
            // 
            this.regno.AutoSize = true;
            this.regno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.regno.Location = new System.Drawing.Point(459, 158);
            this.regno.Name = "regno";
            this.regno.Size = new System.Drawing.Size(131, 16);
            this.regno.TabIndex = 11;
            this.regno.Text = "Registration Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enumerate);
            this.groupBox1.Controls.Add(this.opendevice);
            this.groupBox1.Controls.Add(this.DeviceIDCombo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(31, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 86);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initialization";
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
            this.enumerate.Click += new System.EventHandler(this.enumerate_Click);
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
            this.opendevice.Click += new System.EventHandler(this.opendevice_Click);
            // 
            // DeviceIDCombo
            // 
            this.DeviceIDCombo.FormattingEnabled = true;
            this.DeviceIDCombo.Location = new System.Drawing.Point(168, 41);
            this.DeviceIDCombo.Name = "DeviceIDCombo";
            this.DeviceIDCombo.Size = new System.Drawing.Size(121, 24);
            this.DeviceIDCombo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(64, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Device";
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.validatestudent);
            this.panel1.Controls.Add(this.registerstudent);
            this.panel1.Controls.Add(this.home);
            this.panel1.Location = new System.Drawing.Point(9, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 524);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(472, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Validate Student";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(905, 580);
            this.Controls.Add(this.Exit_btn_Click);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fingerprint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentphoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit_btn_Click;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label StatusBar;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.Button verify;
        private System.Windows.Forms.PictureBox fingerprint;
        private System.Windows.Forms.Button capture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox studentphoto;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label course;
        private System.Windows.Forms.Label regno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button enumerate;
        private System.Windows.Forms.Button opendevice;
        private System.Windows.Forms.ComboBox DeviceIDCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button validatestudent;
        private System.Windows.Forms.Button registerstudent;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}