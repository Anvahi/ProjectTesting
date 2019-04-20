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
        }

        private void DisplayList_Click(object sender, EventArgs e)
        {
            RateList.Visible = true;
            
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide();
            TeacherMenu newTeacherMenu = new TeacherMenu();
            newTeacherMenu.Show();
        }

        private void ChangeProgress_Click(object sender, EventArgs e)
        {
           
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
            int count = 0;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("marks.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "login")
                {
                    foreach (XmlNode childlogin in xnode.ChildNodes)
                        count++;
                }
            }

            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "login")
                {
                    if (xnode.Attributes.Count > 0)
                    {
                        XmlNode attr = xnode.Attributes.GetNamedItem("id");
                        if (attr != null)
                            Console.WriteLine(attr.Value);
                    }
                    foreach (XmlNode childuser in xnode.ChildNodes)
                    {
                        XmlNode attr = childuser.Attributes.GetNamedItem("id");
                        int cou = Convert.ToInt32(attr.Value);
                        for (int i = 0; i < count; i++)
                        {
                            foreach (XmlNode childlogin in childuser.ChildNodes)
                            {
                                if (childlogin.Name == "name")
                                {
                                    string student = childlogin.InnerText;
                                    listBox1.Items.Add(student);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
