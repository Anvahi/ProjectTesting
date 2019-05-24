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

        private void Filtration (string a)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("users.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            string student_marks = "";
            listBox1.Items.Clear();
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
                                        if (childtest.Name == a)
                                        {
                                            student_marks += childtest.InnerText/* +" (" + childtest.Name + ")"*/ + ".";
                                            listBox1.Items.Add(student_marks);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void DisplayList_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("users.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            string student_marks = "";
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    listBox1.Items.Clear();
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
                if (radioButton2.Checked == true)
                {
                    radioButton1.Visible = false;
                    radioButton2.Visible = false;
                    radioButton3.Visible = false;
                    radioButton4.Visible = false;
                    DisplayList.Visible = false;

                    radioButton5.Visible = true;
                    radioButton6.Visible = true;
                    radioButton7.Visible = true;
                    radioButton8.Visible = true;
                    radioButton9.Visible = true;
                    radioButton10.Visible = true;
                    radioButton11.Visible = true;
                    radioButton12.Visible = true;
                }
                if (radioButton3.Checked == true)
                {
                    listBox1.Items.Clear();
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
                                        if (childuser.Name == "total")
                                        {
                                            student_marks += childuser.InnerText/* +" (" + childtest.Name + ")"*/ + ".";
                                            listBox1.Items.Add(student_marks);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (radioButton4.Checked == true)
                {
                    listBox1.Items.Clear();
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
                                        if (childuser.Name == "grade")
                                        {
                                            student_marks += childuser.InnerText/* +" (" + childtest.Name + ")"*/ + ".";
                                            listBox1.Items.Add(student_marks);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void DisplayList2_Click(object sender, EventArgs e)
        {
            
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
            label2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;

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
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;

            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            radioButton12.Visible = false;

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
            DisplayList.Visible = true;

            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            radioButton12.Visible = false;

            newProgress.Visible = false;
            ProgressOk.Visible = false;
            ProgressNo.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;

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

            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            radioButton12.Visible = false;

            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            DisplayList.Visible = false;

            newProgress.Visible = false;
            ProgressOk.Visible = false;
            ProgressNo.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            string Choice;
            Choice = "cycles";
            Filtration(Choice);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            string Choice;
            Choice = "arrays";
            Filtration(Choice);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            string Choice;
            Choice = "strings";
            Filtration(Choice);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            string Choice;
            Choice = "recursion";
            Filtration(Choice);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            string Choice;
            Choice = "structures";
            Filtration(Choice);
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            string Choice;
            Choice = "files";
            Filtration(Choice);
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            string Choice;
            Choice = "pointers";
            Filtration(Choice);
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            string Choice;
            Choice = "dynamic";
            Filtration(Choice);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
