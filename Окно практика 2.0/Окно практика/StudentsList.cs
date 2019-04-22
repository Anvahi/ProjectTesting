using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Окно_практика
{
    public partial class StudentsList : Form
    {
        public StudentsList()
        {
            InitializeComponent();
            listBox1.Items.Clear();
           // RateList.Items.Clear();
            
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("users.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            string student_marks = "";

            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "students")
                {
                    foreach (XmlNode childstudents in xnode.ChildNodes)
                    {
                        if (childstudents.Name == "user")
                        {
                            XmlNode attr = childstudents.Attributes.GetNamedItem("id");
                            foreach (XmlNode childuser in childstudents.ChildNodes)
                            {
                                if (childuser.Name == "name")
                                {
                                    int cou = 0;
                                    cou += Convert.ToInt32(attr.Value);
                                }
                            }
                        }
                    }
                }
            }

            //foreach (XmlNode xnode in xRoot)
            //{
            //    if (xnode.Name == "students")
            //    {
            //        foreach (XmlNode childstudents in xnode.ChildNodes)
            //        {
            //            if (childstudents.Name == "user")
            //            {
            //                foreach (XmlNode childuser in childstudents.ChildNodes)
            //                {
            //                    if (childuser.Name == "name")
            //                    {
            //                        string student = childuser.InnerText;
            //                        listBox1.Items.Add(student);
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}

            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "students")
                {
                    foreach (XmlNode childstudents in xnode.ChildNodes)
                    {
                        if (childstudents.Name == "user")
                        {
                            foreach (XmlNode childuser in childstudents.ChildNodes)
                            {
                                if (childuser.Name == "name")
                                {
                                    student_marks = childuser.InnerText + ": ";
                                }
                                if (childuser.Name == "test")
                                {
                                    foreach (XmlNode childtest in childuser.ChildNodes)
                                    {
                                        student_marks += childtest.InnerText/* +" (" + childtest.Name + ")"*/ + ", " ;
                                    }
                                }
                                if (childuser.Name == "total")
                                {
                                    student_marks += childuser.InnerText /*+ " (" + childuser.Name + ")"*/ + ", ";
                                }
                                if (childuser.Name == "grade")
                                {
                                    student_marks += childuser.InnerText /*+ " (" + childuser.Name + ")"*/ + ".";
                                    listBox1.Items.Add(student_marks);
                                }
                            }
                        }
                    }
                }
            }


        }

        private void DisplayList_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    listBox1.Items.Clear();
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load("users.xml");
                    XmlElement xRoot = xDoc.DocumentElement;
                    string student_marks = "";
                    foreach (XmlNode xnode in xRoot)
                    {
                        if (xnode.Name == "students")
                        {
                            foreach (XmlNode childstudents in xnode.ChildNodes)
                            {
                                if (childstudents.Name == "user")
                                {
                                    foreach (XmlNode childuser in childstudents.ChildNodes)
                                    {
                                        if (childuser.Name == "name")
                                        {
                                            student_marks = childuser.InnerText + ": ";
                                        }
                                        if (childuser.Name == "test")
                                        {
                                            foreach (XmlNode childtest in childuser.ChildNodes)
                                            {
                                                if (childtest.Name == "dynamic")
                                                {
                                                    student_marks += childtest.InnerText/* +" (" + childtest.Name + ")"*/ + ".";
                                                    listBox1.Items.Add(student_marks);
                                                }
                                                else
                                                {
                                                    student_marks += childtest.InnerText/* +" (" + childtest.Name + ")"*/ + ", ";
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide();
            TeacherMenu newTeacherMenu = new TeacherMenu();
            newTeacherMenu.Show();
        }

        private void ChangeProgress_Click(object sender, EventArgs e)
        {
            newProgress.Visible = true;
            ProgressOk.Visible = true;
            ProgressNo.Visible = true;

            SekondNameStudent.Visible = false;
            NameStudent.Visible = false;
            NewLogin.Visible = false;
            newPassword.Visible = false;
            SignNo.Visible = false;
            SignOk.Visible = false;

            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            numericUpDown1.Visible = false;
            comboBox1.Visible = false;
            DisplayList.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void StudentsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ListStudents_Click(object sender, EventArgs e)
        {
            //this button was deleted1
        }

        private void listBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            newProgress.Visible = false;
            ProgressOk.Visible = false;
            ProgressNo.Visible = false;

            SekondNameStudent.Visible = false;
            NameStudent.Visible = false;
            NewLogin.Visible = false;
            newPassword.Visible = false;
            SignNo.Visible = false;
            SignOk.Visible = false;

            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            numericUpDown1.Visible = false;
            comboBox1.Visible = false;
            DisplayList.Visible = false;


        }

        private void buttonStList_Click(object sender, EventArgs e)
        {
            //this button was deleted2
        }

        private void RateList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void NewLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentsList_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Filter_Click(object sender, EventArgs e)
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            numericUpDown1.Visible = true;
            comboBox1.Visible = true;
            DisplayList.Visible = true;

            newProgress.Visible = false;
            ProgressOk.Visible = false;
            ProgressNo.Visible = false;

            SekondNameStudent.Visible = false;
            NameStudent.Visible = false;
            NewLogin.Visible = false;
            newPassword.Visible = false;
            SignNo.Visible = false;
            SignOk.Visible = false;
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            SekondNameStudent.Visible = true;
            NameStudent.Visible = true;
            NewLogin.Visible = true;
            newPassword.Visible = true;
            SignNo.Visible = true;
            SignOk.Visible = true;

            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            numericUpDown1.Visible = false;
            comboBox1.Visible = false;
            DisplayList.Visible = false;

            newProgress.Visible = false;
            ProgressOk.Visible = false;
            ProgressNo.Visible = false;

        }
    }
}
