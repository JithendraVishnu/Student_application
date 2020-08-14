namespace Aug3
{
    partial class Form1
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
            this.Tabcontrol1 = new System.Windows.Forms.TabControl();
            this.Login = new System.Windows.Forms.TabPage();
            this.textpass = new System.Windows.Forms.TextBox();
            this.textuser = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.User_Id = new System.Windows.Forms.Label();
            this.Sign_Out = new System.Windows.Forms.Button();
            this.Sign_In = new System.Windows.Forms.Button();
            this.Attend = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Absent = new System.Windows.Forms.RadioButton();
            this.Present = new System.Windows.Forms.RadioButton();
            this.Attendence = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Save_Attendence = new System.Windows.Forms.Button();
            this.Marks = new System.Windows.Forms.TabPage();
            this.ComboSem = new System.Windows.Forms.ComboBox();
            this.Sem = new System.Windows.Forms.Label();
            this.ComboYear = new System.Windows.Forms.ComboBox();
            this.Year = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Marks1 = new System.Windows.Forms.TabPage();
            this.tv1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.Admin = new System.Windows.Forms.TabPage();
            this.Registration = new System.Windows.Forms.TabPage();
            this.R_Register = new System.Windows.Forms.Button();
            this.R_Name = new System.Windows.Forms.Label();
            this.R_textname = new System.Windows.Forms.TextBox();
            this.R_Mail = new System.Windows.Forms.Label();
            this.R_Pass = new System.Windows.Forms.Label();
            this.R_textmail = new System.Windows.Forms.TextBox();
            this.R_textpass = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.dgv5 = new System.Windows.Forms.DataGridView();
            this.A_Login = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.NewMarks = new System.Windows.Forms.TabPage();
            this.dgv4 = new System.Windows.Forms.DataGridView();
            this.tv2 = new System.Windows.Forms.TreeView();
            this.button5 = new System.Windows.Forms.Button();
            this.Tabcontrol1.SuspendLayout();
            this.Login.SuspendLayout();
            this.Attend.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Marks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.Marks1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.Admin.SuspendLayout();
            this.Registration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv5)).BeginInit();
            this.NewMarks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabcontrol1
            // 
            this.Tabcontrol1.Controls.Add(this.Login);
            this.Tabcontrol1.Controls.Add(this.Attend);
            this.Tabcontrol1.Controls.Add(this.Marks);
            this.Tabcontrol1.Controls.Add(this.Marks1);
            this.Tabcontrol1.Controls.Add(this.Admin);
            this.Tabcontrol1.Controls.Add(this.Registration);
            this.Tabcontrol1.Controls.Add(this.NewMarks);
            this.Tabcontrol1.Location = new System.Drawing.Point(12, 4);
            this.Tabcontrol1.Name = "Tabcontrol1";
            this.Tabcontrol1.SelectedIndex = 0;
            this.Tabcontrol1.Size = new System.Drawing.Size(754, 368);
            this.Tabcontrol1.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.Controls.Add(this.textpass);
            this.Login.Controls.Add(this.textuser);
            this.Login.Controls.Add(this.Password);
            this.Login.Controls.Add(this.User_Id);
            this.Login.Controls.Add(this.Sign_Out);
            this.Login.Controls.Add(this.Sign_In);
            this.Login.Location = new System.Drawing.Point(4, 22);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(3);
            this.Login.Size = new System.Drawing.Size(746, 342);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(206, 78);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(153, 20);
            this.textpass.TabIndex = 5;
            // 
            // textuser
            // 
            this.textuser.Location = new System.Drawing.Point(206, 34);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(153, 20);
            this.textuser.TabIndex = 4;
            this.textuser.TextChanged += new System.EventHandler(this.textuser_TextChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(102, 85);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // User_Id
            // 
            this.User_Id.AutoSize = true;
            this.User_Id.Location = new System.Drawing.Point(102, 37);
            this.User_Id.Name = "User_Id";
            this.User_Id.Size = new System.Drawing.Size(41, 13);
            this.User_Id.TabIndex = 2;
            this.User_Id.Text = "User Id";
            // 
            // Sign_Out
            // 
            this.Sign_Out.Location = new System.Drawing.Point(284, 143);
            this.Sign_Out.Name = "Sign_Out";
            this.Sign_Out.Size = new System.Drawing.Size(75, 23);
            this.Sign_Out.TabIndex = 1;
            this.Sign_Out.Text = "Sign Out";
            this.Sign_Out.UseVisualStyleBackColor = true;
            this.Sign_Out.Click += new System.EventHandler(this.Sign_Out_Click);
            // 
            // Sign_In
            // 
            this.Sign_In.Location = new System.Drawing.Point(187, 143);
            this.Sign_In.Name = "Sign_In";
            this.Sign_In.Size = new System.Drawing.Size(75, 23);
            this.Sign_In.TabIndex = 0;
            this.Sign_In.Text = "Sign In";
            this.Sign_In.UseVisualStyleBackColor = true;
            this.Sign_In.Click += new System.EventHandler(this.Sign_In_Click);
            // 
            // Attend
            // 
            this.Attend.Controls.Add(this.dgv3);
            this.Attend.Controls.Add(this.button2);
            this.Attend.Controls.Add(this.groupBox1);
            this.Attend.Controls.Add(this.Attendence);
            this.Attend.Controls.Add(this.Date);
            this.Attend.Controls.Add(this.dateTimePicker1);
            this.Attend.Controls.Add(this.Save_Attendence);
            this.Attend.Location = new System.Drawing.Point(4, 22);
            this.Attend.Name = "Attend";
            this.Attend.Padding = new System.Windows.Forms.Padding(3);
            this.Attend.Size = new System.Drawing.Size(746, 342);
            this.Attend.TabIndex = 1;
            this.Attend.Text = "Attendence";
            this.Attend.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Absent);
            this.groupBox1.Controls.Add(this.Present);
            this.groupBox1.Location = new System.Drawing.Point(87, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 30);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attended";
            // 
            // Absent
            // 
            this.Absent.AutoSize = true;
            this.Absent.Location = new System.Drawing.Point(120, 13);
            this.Absent.Name = "Absent";
            this.Absent.Size = new System.Drawing.Size(58, 17);
            this.Absent.TabIndex = 4;
            this.Absent.TabStop = true;
            this.Absent.Text = "Absent";
            this.Absent.UseVisualStyleBackColor = true;
            this.Absent.CheckedChanged += new System.EventHandler(this.Absent_CheckedChanged);
            // 
            // Present
            // 
            this.Present.AutoSize = true;
            this.Present.Location = new System.Drawing.Point(6, 13);
            this.Present.Name = "Present";
            this.Present.Size = new System.Drawing.Size(61, 17);
            this.Present.TabIndex = 3;
            this.Present.TabStop = true;
            this.Present.Text = "Present";
            this.Present.UseVisualStyleBackColor = true;
            this.Present.CheckedChanged += new System.EventHandler(this.Present_CheckedChanged);
            // 
            // Attendence
            // 
            this.Attendence.AutoSize = true;
            this.Attendence.Location = new System.Drawing.Point(3, 79);
            this.Attendence.Name = "Attendence";
            this.Attendence.Size = new System.Drawing.Size(62, 13);
            this.Attendence.TabIndex = 5;
            this.Attendence.Text = "Attendence";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(19, 38);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(36, 13);
            this.Date.TabIndex = 2;
            this.Date.Text = "Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Save_Attendence
            // 
            this.Save_Attendence.Location = new System.Drawing.Point(79, 116);
            this.Save_Attendence.Name = "Save_Attendence";
            this.Save_Attendence.Size = new System.Drawing.Size(75, 23);
            this.Save_Attendence.TabIndex = 0;
            this.Save_Attendence.Text = "Save";
            this.Save_Attendence.UseVisualStyleBackColor = true;
            this.Save_Attendence.Click += new System.EventHandler(this.button1_Click);
            // 
            // Marks
            // 
            this.Marks.Controls.Add(this.dgv1);
            this.Marks.Controls.Add(this.Display);
            this.Marks.Controls.Add(this.ComboSem);
            this.Marks.Controls.Add(this.Sem);
            this.Marks.Controls.Add(this.ComboYear);
            this.Marks.Controls.Add(this.Year);
            this.Marks.Location = new System.Drawing.Point(4, 22);
            this.Marks.Name = "Marks";
            this.Marks.Padding = new System.Windows.Forms.Padding(3);
            this.Marks.Size = new System.Drawing.Size(746, 342);
            this.Marks.TabIndex = 2;
            this.Marks.Text = "Marks";
            this.Marks.UseVisualStyleBackColor = true;
            this.Marks.Click += new System.EventHandler(this.Marks_Click);
            // 
            // ComboSem
            // 
            this.ComboSem.FormattingEnabled = true;
            this.ComboSem.Location = new System.Drawing.Point(371, 20);
            this.ComboSem.Name = "ComboSem";
            this.ComboSem.Size = new System.Drawing.Size(121, 21);
            this.ComboSem.TabIndex = 3;
            // 
            // Sem
            // 
            this.Sem.AutoSize = true;
            this.Sem.Location = new System.Drawing.Point(284, 20);
            this.Sem.Name = "Sem";
            this.Sem.Size = new System.Drawing.Size(28, 13);
            this.Sem.TabIndex = 2;
            this.Sem.Text = "Sem";
            this.Sem.Click += new System.EventHandler(this.label2_Click);
            // 
            // ComboYear
            // 
            this.ComboYear.FormattingEnabled = true;
            this.ComboYear.Location = new System.Drawing.Point(100, 20);
            this.ComboYear.Name = "ComboYear";
            this.ComboYear.Size = new System.Drawing.Size(121, 21);
            this.ComboYear.TabIndex = 1;
            this.ComboYear.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(65, 23);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(29, 13);
            this.Year.TabIndex = 0;
            this.Year.Text = "Year";
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(519, 13);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(75, 23);
            this.Display.TabIndex = 4;
            this.Display.Text = "Display";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(28, 65);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(563, 192);
            this.dgv1.TabIndex = 5;
            // 
            // Marks1
            // 
            this.Marks1.Controls.Add(this.dgv2);
            this.Marks1.Controls.Add(this.button1);
            this.Marks1.Controls.Add(this.tv1);
            this.Marks1.Location = new System.Drawing.Point(4, 22);
            this.Marks1.Name = "Marks1";
            this.Marks1.Padding = new System.Windows.Forms.Padding(3);
            this.Marks1.Size = new System.Drawing.Size(746, 342);
            this.Marks1.TabIndex = 3;
            this.Marks1.Text = "Marks1";
            this.Marks1.UseVisualStyleBackColor = true;
            // 
            // tv1
            // 
            this.tv1.Location = new System.Drawing.Point(6, 6);
            this.tv1.Name = "tv1";
            this.tv1.Size = new System.Drawing.Size(135, 336);
            this.tv1.TabIndex = 0;
            this.tv1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv1_AfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(327, 6);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(391, 330);
            this.dgv2.TabIndex = 2;
            // 
            // Admin
            // 
            this.Admin.Controls.Add(this.button4);
            this.Admin.Controls.Add(this.A_Login);
            this.Admin.Controls.Add(this.dgv5);
            this.Admin.Controls.Add(this.button3);
            this.Admin.Location = new System.Drawing.Point(4, 22);
            this.Admin.Name = "Admin";
            this.Admin.Padding = new System.Windows.Forms.Padding(3);
            this.Admin.Size = new System.Drawing.Size(746, 342);
            this.Admin.TabIndex = 4;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            // 
            // Registration
            // 
            this.Registration.Controls.Add(this.R_textpass);
            this.Registration.Controls.Add(this.R_textmail);
            this.Registration.Controls.Add(this.R_Pass);
            this.Registration.Controls.Add(this.R_Mail);
            this.Registration.Controls.Add(this.R_textname);
            this.Registration.Controls.Add(this.R_Name);
            this.Registration.Controls.Add(this.R_Register);
            this.Registration.Location = new System.Drawing.Point(4, 22);
            this.Registration.Name = "Registration";
            this.Registration.Padding = new System.Windows.Forms.Padding(3);
            this.Registration.Size = new System.Drawing.Size(746, 342);
            this.Registration.TabIndex = 5;
            this.Registration.Text = "Registration";
            this.Registration.UseVisualStyleBackColor = true;
            this.Registration.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // R_Register
            // 
            this.R_Register.Location = new System.Drawing.Point(190, 155);
            this.R_Register.Name = "R_Register";
            this.R_Register.Size = new System.Drawing.Size(75, 23);
            this.R_Register.TabIndex = 0;
            this.R_Register.Text = "Register";
            this.R_Register.UseVisualStyleBackColor = true;
            this.R_Register.Click += new System.EventHandler(this.R_Register_Click);
            // 
            // R_Name
            // 
            this.R_Name.AutoSize = true;
            this.R_Name.Location = new System.Drawing.Point(67, 30);
            this.R_Name.Name = "R_Name";
            this.R_Name.Size = new System.Drawing.Size(41, 13);
            this.R_Name.TabIndex = 2;
            this.R_Name.Text = "Name :";
            this.R_Name.Click += new System.EventHandler(this.R_Name_Click);
            // 
            // R_textname
            // 
            this.R_textname.Location = new System.Drawing.Point(134, 27);
            this.R_textname.Name = "R_textname";
            this.R_textname.Size = new System.Drawing.Size(185, 20);
            this.R_textname.TabIndex = 3;
            // 
            // R_Mail
            // 
            this.R_Mail.AutoSize = true;
            this.R_Mail.Location = new System.Drawing.Point(67, 69);
            this.R_Mail.Name = "R_Mail";
            this.R_Mail.Size = new System.Drawing.Size(29, 13);
            this.R_Mail.TabIndex = 4;
            this.R_Mail.Text = "Mail:";
            // 
            // R_Pass
            // 
            this.R_Pass.AutoSize = true;
            this.R_Pass.Location = new System.Drawing.Point(67, 113);
            this.R_Pass.Name = "R_Pass";
            this.R_Pass.Size = new System.Drawing.Size(56, 13);
            this.R_Pass.TabIndex = 5;
            this.R_Pass.Text = "Password:";
            // 
            // R_textmail
            // 
            this.R_textmail.Location = new System.Drawing.Point(134, 66);
            this.R_textmail.Name = "R_textmail";
            this.R_textmail.Size = new System.Drawing.Size(185, 20);
            this.R_textmail.TabIndex = 6;
            // 
            // R_textpass
            // 
            this.R_textpass.Location = new System.Drawing.Point(134, 106);
            this.R_textpass.Name = "R_textpass";
            this.R_textpass.Size = new System.Drawing.Size(185, 20);
            this.R_textpass.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Display Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv3
            // 
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Location = new System.Drawing.Point(22, 160);
            this.dgv3.Name = "dgv3";
            this.dgv3.Size = new System.Drawing.Size(707, 150);
            this.dgv3.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(47, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "All Attendence Report";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgv5
            // 
            this.dgv5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv5.Location = new System.Drawing.Point(243, 20);
            this.dgv5.Name = "dgv5";
            this.dgv5.Size = new System.Drawing.Size(497, 303);
            this.dgv5.TabIndex = 1;
            // 
            // A_Login
            // 
            this.A_Login.Location = new System.Drawing.Point(47, 90);
            this.A_Login.Name = "A_Login";
            this.A_Login.Size = new System.Drawing.Size(132, 23);
            this.A_Login.TabIndex = 2;
            this.A_Login.Text = "All Login Details";
            this.A_Login.UseVisualStyleBackColor = true;
            this.A_Login.Click += new System.EventHandler(this.A_Login_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(47, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "All Marks Report";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // NewMarks
            // 
            this.NewMarks.Controls.Add(this.button5);
            this.NewMarks.Controls.Add(this.tv2);
            this.NewMarks.Controls.Add(this.dgv4);
            this.NewMarks.Location = new System.Drawing.Point(4, 22);
            this.NewMarks.Name = "NewMarks";
            this.NewMarks.Padding = new System.Windows.Forms.Padding(3);
            this.NewMarks.Size = new System.Drawing.Size(746, 342);
            this.NewMarks.TabIndex = 6;
            this.NewMarks.Text = "New Marks";
            this.NewMarks.UseVisualStyleBackColor = true;
            // 
            // dgv4
            // 
            this.dgv4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv4.Location = new System.Drawing.Point(312, 6);
            this.dgv4.Name = "dgv4";
            this.dgv4.Size = new System.Drawing.Size(428, 330);
            this.dgv4.TabIndex = 0;
            // 
            // tv2
            // 
            this.tv2.Location = new System.Drawing.Point(6, 6);
            this.tv2.Name = "tv2";
            this.tv2.Size = new System.Drawing.Size(149, 330);
            this.tv2.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(197, 133);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Display";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tabcontrol1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tabcontrol1.ResumeLayout(false);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.Attend.ResumeLayout(false);
            this.Attend.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Marks.ResumeLayout(false);
            this.Marks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.Marks1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.Admin.ResumeLayout(false);
            this.Registration.ResumeLayout(false);
            this.Registration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv5)).EndInit();
            this.NewMarks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabcontrol1;
        private System.Windows.Forms.TabPage Login;
        private System.Windows.Forms.TabPage Attend;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label User_Id;
        private System.Windows.Forms.Button Sign_Out;
        private System.Windows.Forms.Button Sign_In;
        private System.Windows.Forms.Button Save_Attendence;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Attendence;
        private System.Windows.Forms.RadioButton Absent;
        private System.Windows.Forms.RadioButton Present;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TabPage Marks;
        private System.Windows.Forms.ComboBox ComboSem;
        private System.Windows.Forms.Label Sem;
        private System.Windows.Forms.ComboBox ComboYear;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.TabPage Marks1;
        private System.Windows.Forms.TreeView tv1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage Admin;
        private System.Windows.Forms.TabPage Registration;
        private System.Windows.Forms.TextBox R_textname;
        private System.Windows.Forms.Label R_Name;
        private System.Windows.Forms.Button R_Register;
        private System.Windows.Forms.TextBox R_textpass;
        private System.Windows.Forms.TextBox R_textmail;
        private System.Windows.Forms.Label R_Pass;
        private System.Windows.Forms.Label R_Mail;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button A_Login;
        private System.Windows.Forms.TabPage NewMarks;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TreeView tv2;
        private System.Windows.Forms.DataGridView dgv4;
    }
}

