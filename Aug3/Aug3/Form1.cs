using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Aug3
{
    public partial class Form1 : Form
    {
        String Attend_class;
        public Form1()
        {
            InitializeComponent();
            Attend.Enabled = false;
            Marks.Enabled = false;
            Marks1.Enabled = false;
            Admin.Enabled = false;

            // OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\vishnu\\source\\repos\\NewApplication\\Db\\LoginDb.accdb");
            //OleDbCommand cmd = con.CreateCommand();
            //con.Open();
            // cmd.CommandText = "Select * from LoginTable where name='" + textuser.Text + "' and password='" + textpassword.Text + "' ";
            //cmd.Connection = con;
            //OleDbDataReader reader = cmd.ExecuteReader();
        }

        private void Sign_In_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\vishnu\\source\\repos\\Aug3\\database\\StudentDb.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            if (textuser.Text == "admin" && textpass.Text == "1234")
            {
                Admin.Enabled = true;
               // Attend.Enabled = true;
               // Marks.Enabled = true;
               // Marks1.Enabled = true;
            }
            cmd.CommandText = "select * from Login_Table where User_Mail='" + textuser.Text + "' and User_Password='" + textpass.Text + "'";
            cmd.Connection = con;
            OleDbDataAdapter adapter1 = new OleDbDataAdapter(cmd.CommandText, con);
            DataTable dt2 = new DataTable();
            adapter1.Fill(dt2);
            cmd.ExecuteNonQuery();
            if (dt2.Rows.Count>0)
            {
                Attend.Enabled = true;
                Marks.Enabled = true;
                Marks1.Enabled = true;
                for (int i = 1; i <= 4; i++)
                {
                    ComboYear.Items.Add(i);
                }
                for (int i = 1; i <= 2; i++)
                {
                    ComboSem.Items.Add(i);
                }


                tv2.Nodes.Add("Year1"); 
                tv2.Nodes[0].Nodes.Add("Sem1");
                tv2.Nodes[0].Nodes.Add("Sem2");
                tv2.Nodes.Add("Year2");
                tv2.Nodes[1].Nodes.Add("Sem1");
                tv2.Nodes[1].Nodes.Add("Sem2");
                tv2.Nodes.Add("Year3");
                tv2.Nodes[2].Nodes.Add("Sem1");
                tv2.Nodes[2].Nodes.Add("Sem2");
                tv2.Nodes.Add("Year4");
                tv2.Nodes[3].Nodes.Add("Sem1");
                tv2.Nodes[3].Nodes.Add("Sem2");


                tv1.Nodes.Add("Year-Sem");
                tv1.Nodes[0].Nodes.Add("1-1");
                tv1.Nodes[0].Nodes.Add("1-2");
                tv1.Nodes[0].Nodes.Add("2-1");
                tv1.Nodes[0].Nodes.Add("2-2");
                tv1.Nodes[0].Nodes.Add("3-1");
                tv1.Nodes[0].Nodes.Add("3-2");
                tv1.Nodes[0].Nodes.Add("4-1");
                tv1.Nodes[0].Nodes.Add("4-2");
                /*tv1.Nodes[0][0].Nodes.Add("1");
                tv1.Nodes[0][0].Nodes.Add("2");
                tv1.Nodes[0][1].Nodes.Add("1");
                tv1.Nodes[0][1].Nodes.Add("2");
                tv1.Nodes[0][2].Nodes.Add("1");
                tv1.Nodes[0][2].Nodes.Add("2");
                tv1.Nodes[0][3].Nodes.Add("1");
                tv1.Nodes[0][3].Nodes.Add("2");*/
            }
            
            else
            {
                Attend.Enabled=false;
                Marks.Enabled = false;
                Marks1.Enabled = false;
            }
        }

        private void Sign_Out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\vishnu\\source\\repos\\Aug3\\database\\StudentDb.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Insert into Attend_Table (Present_Date, Class_Attended, User_Mail) values('"+ dateTimePicker1.Value.ToString() +"' , '"+ Attend_class +"' , '"+ textuser.Text+"') ";
            cmd.Connection = con;
            //OleDbDataReader reader = cmd.ExecuteReader();
            cmd.ExecuteNonQuery();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Present_CheckedChanged(object sender, EventArgs e)
        {
           
            Attend_class = "Present";
        }

        private void Absent_CheckedChanged(object sender, EventArgs e)
        {
           
            Attend_class = "Absent";
        }

        private void textuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                          
        }

        private void Marks_Click(object sender, EventArgs e)
        {

        }

        private void Display_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\vishnu\\source\\repos\\Aug3\\database\\StudentDb.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "select * from Marks_Table where User_Name='"+ textuser.Text +"' ";
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd.CommandText, con);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            //cmd.Connection = con;
            BindingSource bs = new BindingSource();
            bs.DataSource = dt1;
            //dgv1.DataSource = adapter;
            dgv1.DataSource = bs;
            //OleDbDataReader reader = cmd.ExecuteReader();
            //cmd.ExecuteNonQuery();

        }

        private void tv1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\vishnu\\source\\repos\\Aug3\\database\\StudentDb.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            if (tv1.SelectedNode.Text == "1-1")
            {
                cmd.CommandText = "select Maths1,Maths2,C from Marks_Table where User_Mail='"+ textuser.Text +"' ";
            }
            else if (tv1.SelectedNode.Text == "1-2")
            {
                cmd.CommandText = "select Python,Maths3,Mechanics from Marks_Table where User_Mail='" + textuser.Text + "' ";
            }
            else if (tv1.SelectedNode.Text == "2-1")
            {
                cmd.CommandText = "select R,DLD,DS from Marks_Table where User_Mail='" + textuser.Text + "' ";
            }
            else if (tv1.SelectedNode.Text == "2-2")
            {
                cmd.CommandText = "select Java,Flat,CO from Marks_Table where User_Mail='" + textuser.Text + "' ";
            }
            else if (tv1.SelectedNode.Text == "3-1")
            {
                cmd.CommandText = "select CD,DBMS,OS from Marks_Table where User_Mail='" + textuser.Text + "' ";
            }
            else if (tv1.SelectedNode.Text == "3-2")
            {
                cmd.CommandText = "select CN,DAA,AI from Marks_Table where User_Mail='" + textuser.Text + "' ";
            }
            else if (tv1.SelectedNode.Text == "4-1")
            {
                cmd.CommandText = "select SADP,WT,MEFA from Marks_Table where User_Mail='" + textuser.Text + "' ";
            }
            else if (tv1.SelectedNode.Text == "4-2")
            {
                cmd.CommandText = "select MS,ML,ANN from Marks_Table where User_Mail='" + textuser.Text + "' ";
            }
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd.CommandText, con);
            DataTable dt3 = new DataTable();
            adapter.Fill(dt3);
            BindingSource bs1 = new BindingSource();
            bs1.DataSource = dt3;
            dgv2.DataSource = bs1;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void R_Name_Click(object sender, EventArgs e)
        {

        }

        private void R_Register_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\vishnu\\source\\repos\\Aug3\\database\\StudentDb.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Insert into Login_Table (User_Name,User_Mail,User_Password) values('"+ R_textname.Text +"','"+ R_textmail.Text +"','"+ R_textpass.Text +"') ";
            cmd.Connection = con;
            //OleDbDataReader reader = cmd.ExecuteReader();
            cmd.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\vishnu\\source\\repos\\Aug3\\database\\StudentDb.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "select Present_Date,Class_Attended from Attend_Table where User_Mail='" + textuser.Text + "' ";
            OleDbDataAdapter adapter4 = new OleDbDataAdapter(cmd.CommandText, con);
            DataTable dt4 = new DataTable();
            adapter4.Fill(dt4);
            //cmd.Connection = con;
            BindingSource bs4 = new BindingSource();
            bs4.DataSource = dt4;
            //dgv1.DataSource = adapter;
            dgv3.DataSource = bs4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\vishnu\\source\\repos\\Aug3\\database\\StudentDb.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "select * from Attend_Table ";
            OleDbDataAdapter adapter5 = new OleDbDataAdapter(cmd.CommandText, con);
            DataTable dt5 = new DataTable();
            adapter5.Fill(dt5);
            //cmd.Connection = con;
            BindingSource bs5 = new BindingSource();
            bs5.DataSource = dt5;
            //dgv1.DataSource = adapter;
            dgv5.DataSource = bs5;
        }

        private void A_Login_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\vishnu\\source\\repos\\Aug3\\database\\StudentDb.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "select * from Login_Table ";
            OleDbDataAdapter adapter5 = new OleDbDataAdapter(cmd.CommandText, con);
            DataTable dt5 = new DataTable();
            adapter5.Fill(dt5);
            //cmd.Connection = con;
            BindingSource bs5 = new BindingSource();
            bs5.DataSource = dt5;
            //dgv1.DataSource = adapter;
            dgv5.DataSource = bs5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\vishnu\\source\\repos\\Aug3\\database\\StudentDb.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "select * from Marks_Table ";
            OleDbDataAdapter adapter5 = new OleDbDataAdapter(cmd.CommandText, con);
            DataTable dt5 = new DataTable();
            adapter5.Fill(dt5);
            //cmd.Connection = con;
            BindingSource bs5 = new BindingSource();
            bs5.DataSource = dt5;
            //dgv1.DataSource = adapter;
            dgv5.DataSource = bs5;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\vishnu\\source\\repos\\Aug3\\database\\StudentDb.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            if(tv2.SelectedNode.Text=="Sem1" && tv2.SelectedNode.Parent.Text=="Year1")
            {
                cmd.CommandText = "select Subject_Table.Subject_Name,NewMarks_Table.Subject_Marks from Subject_Table INNER JOIN  NewMarks_Table ON Subject_Table.Student_Id = NewMarks_Table.ID where NewMarks_Table.User_Mail='" + textuser.Text + "' AND Subject_Table.Subject_Year=1 AND Subject_Table.Subject_Sem=1";
            }

           else if (tv2.SelectedNode.Text == "Sem2" && tv2.SelectedNode.Parent.Text == "Year1")
            {
                cmd.CommandText = "select Subject_Table.Subject_Name,NewMarks_Table.Subject_Marks from Subject_Table INNER JOIN  NewMarks_Table ON Subject_Table.Student_Id = NewMarks_Table.ID where NewMarks_Table.User_Mail='" + textuser.Text + "' AND Subject_Table.Subject_Year=1 AND Subject_Table.Subject_Sem=2";
            }

           else if (tv2.SelectedNode.Text == "Sem1" && tv2.SelectedNode.Parent.Text == "Year2")
            {
                cmd.CommandText = "select Subject_Table.Subject_Name,NewMarks_Table.Subject_Marks from Subject_Table INNER JOIN  NewMarks_Table ON Subject_Table.Student_Id = NewMarks_Table.ID where NewMarks_Table.User_Mail='" + textuser.Text + "' AND Subject_Table.Subject_Year=2 AND Subject_Table.Subject_Sem=1";
            }

           else if (tv2.SelectedNode.Text == "Sem2" && tv2.SelectedNode.Parent.Text == "Year2")
            {
                cmd.CommandText = "select Subject_Table.Subject_Name,NewMarks_Table.Subject_Marks from Subject_Table INNER JOIN  NewMarks_Table ON Subject_Table.Student_Id = NewMarks_Table.ID where NewMarks_Table.User_Mail='" + textuser.Text + "' AND Subject_Table.Subject_Year=2 AND Subject_Table.Subject_Sem=2";
            }

           else if (tv2.SelectedNode.Text == "Sem1" && tv2.SelectedNode.Parent.Text == "Year3")
            {
                cmd.CommandText = "select Subject_Table.Subject_Name,NewMarks_Table.Subject_Marks from Subject_Table INNER JOIN  NewMarks_Table ON Subject_Table.Student_Id = NewMarks_Table.ID where NewMarks_Table.User_Mail='" + textuser.Text + "' AND Subject_Table.Subject_Year=3 AND Subject_Table.Subject_Sem=1";
            }

           else if (tv2.SelectedNode.Text == "Sem2" && tv2.SelectedNode.Parent.Text == "Year3")
            {
                cmd.CommandText = "select Subject_Table.Subject_Name,NewMarks_Table.Subject_Marks from Subject_Table INNER JOIN  NewMarks_Table ON Subject_Table.Student_Id = NewMarks_Table.ID where NewMarks_Table.User_Mail='" + textuser.Text + "' AND Subject_Table.Subject_Year=3 AND Subject_Table.Subject_Sem=2";
            }

           else if (tv2.SelectedNode.Text == "Sem1" && tv2.SelectedNode.Parent.Text == "Year4")
            {
                cmd.CommandText = "select Subject_Table.Subject_Name,NewMarks_Table.Subject_Marks from Subject_Table INNER JOIN  NewMarks_Table ON Subject_Table.Student_Id = NewMarks_Table.ID where NewMarks_Table.User_Mail='" + textuser.Text + "' AND Subject_Table.Subject_Year=4 AND Subject_Table.Subject_Sem=1";
            }

           else if (tv2.SelectedNode.Text == "Sem2" && tv2.SelectedNode.Parent.Text == "Year4")
            {
                cmd.CommandText = "select Subject_Table.Subject_Name,NewMarks_Table.Subject_Marks from Subject_Table INNER JOIN  NewMarks_Table ON Subject_Table.Student_Id = NewMarks_Table.ID where NewMarks_Table.User_Mail='" + textuser.Text + "' AND Subject_Table.Subject_Year=4 AND Subject_Table.Subject_Sem=2";
            }
            else
            {
                MessageBox.Show("Select Year and Sem");
            }
            OleDbDataAdapter adapter7 = new OleDbDataAdapter(cmd.CommandText, con);
            DataTable dt7 = new DataTable();
            adapter7.Fill(dt7);
            BindingSource bs7 = new BindingSource();
            bs7.DataSource = dt7;
            dgv4.DataSource = bs7;
        }
    }
}
