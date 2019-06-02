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
        int temp = -1;

        public StudentsList()
        {
            InitializeComponent();
            listofStudents.Items.Clear();
            ListBoxTitle();           
        }

        private void ProgressVisibleFalse()
        {
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
            textBox9.Visible = false;
        }

        private void RegistrationVisibleFalse()
        {
            SecondNameStudent.Visible = false;
            NameStudent.Visible = false;
            NewLogin.Visible = false;
            newPassword.Visible = false;
            SignNo.Visible = false;
            SignOk.Visible = false;
        }

        private void ThemesVisibleFalse()
        {
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            radioButton12.Visible = false;
            button1.Visible = false;
        }

        private void FiltrationVisibleFalse()
        {
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            Filtr.Visible = false;
        }
        
        private void ListBoxTitle()
        {
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
                                        student_marks += childtest.InnerText/* +" (" + childtest.Name + ")"*/ + ", ";
                                    }
                                }
                                if (childuser.Name == "total")
                                {
                                    student_marks += childuser.InnerText /*+ " (" + childuser.Name + ")"*/ + ".";
                                    listofStudents.Items.Add(student_marks);
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
            listofStudents.Items.Clear();
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
                                            student_marks += childtest.InnerText + ".";
                                            listofStudents.Items.Add(student_marks);
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
            listofStudents.Items.Clear();
            ListBoxTitle();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("users.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            string student_marks = "";
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    listofStudents.Items.Clear();
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
                                                    student_marks += childtest.InnerText + ".";
                                                    listofStudents.Items.Add(student_marks);
                                                }
                                                else
                                                {
                                                    student_marks += childtest.InnerText + ", ";
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
                    FiltrationVisibleFalse();

                    radioButton5.Visible = true;
                    radioButton6.Visible = true;
                    radioButton7.Visible = true;
                    radioButton8.Visible = true;
                    radioButton9.Visible = true;
                    radioButton10.Visible = true;
                    radioButton11.Visible = true;
                    radioButton12.Visible = true;
                    button1.Visible = true;
                }
                if (radioButton3.Checked == true)
                {
                    listofStudents.Items.Clear();
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
                                            student_marks += childuser.InnerText + ".";
                                            listofStudents.Items.Add(student_marks);
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

        private void listofStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k = listofStudents.SelectedIndex;
            temp = k;
            if (k > -1)
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("users.xml");
                XmlElement xRoot = xDoc.DocumentElement;

                XmlNode get;
                get = xRoot.ChildNodes[1];
                XmlNodeList node = get.ChildNodes;
                XmlNodeList user = node[k].ChildNodes;
                XmlNodeList test = user[3].ChildNodes;

                textBox1.Text = test[0].InnerText;
                cycText = test[0].InnerText;
                textBox2.Text = test[1].InnerText;
                arrText = test[1].InnerText;
                textBox3.Text = test[2].InnerText;
                strText = test[2].InnerText;
                textBox4.Text = test[3].InnerText;
                recText = test[3].InnerText;
                textBox5.Text = test[4].InnerText;
                structText = test[4].InnerText;
                textBox6.Text = test[5].InnerText;
                filText = test[5].InnerText;
                textBox7.Text = test[6].InnerText;
                pointText = test[6].InnerText;
                textBox8.Text = test[7].InnerText;
                dynText = test[7].InnerText;
                textBox9.Text = user[4].InnerText;
                totText = user[4].InnerText;
            }
        }

        string cycText, arrText, strText, recText, structText, filText, pointText, dynText, totText;

        private void ChangeProgress_Click(object sender, EventArgs e)
        {
            RegistrationVisibleFalse();
            FiltrationVisibleFalse();
            
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
            textBox1.Visible = true;//cycles
            textBox2.Visible = true;//arrays
            textBox3.Visible = true;//strings
            textBox4.Visible = true;//recursion
            textBox5.Visible = true;//structs
            textBox6.Visible = true;//files
            textBox7.Visible = true;//pointers
            textBox8.Visible = true;//dynamic
            textBox9.Visible = true;//total
            int k = listofStudents.SelectedIndex;
            temp = k;
        }

        private void ProgressOk_Click(object sender, EventArgs e)
        {
            int k = listofStudents.SelectedIndex;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("users.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            XmlNode get;
            get = xRoot.ChildNodes[1];
            XmlNodeList node = get.ChildNodes;
            XmlNodeList user = node[k].ChildNodes;
            XmlNodeList test = user[3].ChildNodes;

            test[0].InnerText = textBox1.Text;
            test[1].InnerText = textBox2.Text;
            test[2].InnerText = textBox3.Text;
            test[3].InnerText = textBox4.Text;
            test[4].InnerText = textBox5.Text;
            test[5].InnerText = textBox6.Text;
            test[6].InnerText = textBox7.Text;
            test[7].InnerText = textBox8.Text;
            user[4].InnerText = textBox9.Text;

            xDoc.Save("users.xml");
            listofStudents.Items.Clear();
            ListBoxTitle();
            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void StudentsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            ProgressVisibleFalse();
            ThemesVisibleFalse();
            RegistrationVisibleFalse();
            FiltrationVisibleFalse();

            int k = listofStudents.SelectedIndex;
            if (k > -1)
            {
                listofStudents.Items.RemoveAt(k);
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("users.xml");
                XmlElement xRoot = xDoc.DocumentElement;

                XmlNode Del;
                Del = xRoot.ChildNodes[1];
                XmlNodeList node = Del.ChildNodes;
                XmlNode a = node[k];
                Del.RemoveChild(a);
                xDoc.Save("users.xml");
            }
        }
       
        private void Filter_Click(object sender, EventArgs e)
        {
            listofStudents.Items.Clear();
            ListBoxTitle();
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            Filtr.Visible = true;

            ThemesVisibleFalse();
            ProgressVisibleFalse();
            RegistrationVisibleFalse();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            listofStudents.Items.Clear();
            ListBoxTitle();
            SecondNameStudent.Visible = true;
            NameStudent.Visible = true;
            NewLogin.Visible = true;
            newPassword.Visible = true;
            SignNo.Visible = true;
            SignOk.Visible = true;

            ThemesVisibleFalse();
            FiltrationVisibleFalse();
            ProgressVisibleFalse();
        }

        private void SignOk_Click(object sender, EventArgs e)
        {
            string Fam = "", Nam = "", Log = "", Pas = "";
            if (SecondNameStudent.Text != "Фамилия")
                Fam = SecondNameStudent.Text;
            if (NameStudent.Text != "Имя")
                Nam = NameStudent.Text;
            if (NewLogin.Text != "Логин")
                Log = NewLogin.Text;
            if (newPassword.Text != "Пароль")
                Pas = newPassword.Text;

            if (Fam != "" && Nam != "" && Log != "" && Pas != "" && Fam != " " && Nam != " " && Log != " " && Pas != " ")
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("users.xml");
                XmlElement xRoot = xDoc.DocumentElement;

                XmlNode Reg;
                Reg = xRoot.ChildNodes[1];
                XmlNodeList node = Reg.ChildNodes;
                int Number_of_Students = Convert.ToInt32(Reg.LastChild.Attributes["id"].Value);

                XmlElement user = xDoc.CreateElement("user");
                XmlAttribute attr = xDoc.CreateAttribute("id");
                XmlText idname = xDoc.CreateTextNode(Convert.ToString(Number_of_Students + 1));
                XmlElement login = xDoc.CreateElement("login");
                XmlText log = xDoc.CreateTextNode(Log);
                XmlElement password = xDoc.CreateElement("password");
                XmlText pass = xDoc.CreateTextNode(Pas);
                XmlElement Inform = xDoc.CreateElement("name");
                XmlText Inf = xDoc.CreateTextNode(Fam + " " + Nam);

                XmlElement test = xDoc.CreateElement("test");
                XmlElement cycles = xDoc.CreateElement("cycles");
                XmlText cyc = xDoc.CreateTextNode("нет");
                XmlElement array = xDoc.CreateElement("arrays");
                XmlText arr = xDoc.CreateTextNode("нет");
                XmlElement strings = xDoc.CreateElement("strings");
                XmlText str = xDoc.CreateTextNode("нет");
                XmlElement recursion = xDoc.CreateElement("recursion");
                XmlText rec = xDoc.CreateTextNode("нет");
                XmlElement structures = xDoc.CreateElement("structures");
                XmlText structs = xDoc.CreateTextNode("нет");
                XmlElement files = xDoc.CreateElement("files");
                XmlText fil = xDoc.CreateTextNode("нет");
                XmlElement pointers = xDoc.CreateElement("pointers");
                XmlText point = xDoc.CreateTextNode("нет");
                XmlElement dynamic = xDoc.CreateElement("dynamic");
                XmlText dyn = xDoc.CreateTextNode("нет");

                XmlElement total = xDoc.CreateElement("total");
                XmlText tot = xDoc.CreateTextNode("нет");
                XmlElement grade = xDoc.CreateElement("grade");
                XmlText gr = xDoc.CreateTextNode("нет");

                attr.AppendChild(idname);
                login.AppendChild(log);
                password.AppendChild(pass);
                Inform.AppendChild(Inf);
                cycles.AppendChild(cyc);
                array.AppendChild(arr);
                strings.AppendChild(str);
                recursion.AppendChild(rec);
                structures.AppendChild(structs);
                files.AppendChild(fil);
                pointers.AppendChild(point);
                dynamic.AppendChild(dyn);
                total.AppendChild(tot);
                grade.AppendChild(gr);

                user.Attributes.Append(attr);
                user.AppendChild(login);
                user.AppendChild(password);
                user.AppendChild(Inform);
                user.AppendChild(test);
                test.AppendChild(cycles);
                test.AppendChild(array);
                test.AppendChild(strings);
                test.AppendChild(recursion);
                test.AppendChild(structures);
                test.AppendChild(files);
                test.AppendChild(pointers);
                test.AppendChild(dynamic);
                user.AppendChild(total);
                user.AppendChild(grade);

                Reg.AppendChild(user);

                xDoc.Save("users.xml");

                listofStudents.Items.Clear();
                ListBoxTitle();
            }
            registrNo();
        }

        private void registrNo()
        {
            SecondNameStudent.Text = "Фамилия";
            NameStudent.Text = "Имя";
            NewLogin.Text = "Логин";
            newPassword.Text = "Пароль";
        }

        private void SignNo_Click(object sender, EventArgs e)
        {
            registrNo();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listofStudents.Items.Clear();
            ListBoxTitle();
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

        private void button1_Click(object sender, EventArgs e)
        {
            ThemesVisibleFalse();
            listofStudents.Items.Clear();
            ListBoxTitle();
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            Filtr.Visible = true;
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listofStudents.Items.Clear();
            ListBoxTitle();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listofStudents.Items.Clear();
            ListBoxTitle();
        }

        private void progressNo()
        {
            if (temp > -1)
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("users.xml");
                XmlElement xRoot = xDoc.DocumentElement;

                XmlNode get;
                get = xRoot.ChildNodes[1];
                XmlNodeList node = get.ChildNodes;
                XmlNodeList user = node[temp].ChildNodes;
                XmlNodeList test = user[3].ChildNodes;

                textBox1.Text = test[0].InnerText;
                textBox2.Text = test[1].InnerText;
                textBox3.Text = test[2].InnerText;
                textBox4.Text = test[3].InnerText;
                textBox5.Text = test[4].InnerText;
                textBox6.Text = test[5].InnerText;
                textBox7.Text = test[6].InnerText;
                textBox8.Text = test[7].InnerText;
                textBox9.Text = user[4].InnerText;
            }
        }

        private void ProgressNo_Click(object sender, EventArgs e)
        {
            progressNo();
        }
    }
}