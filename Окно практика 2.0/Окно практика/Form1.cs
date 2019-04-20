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
    public partial class MainForm : Form
    {
        bool log = false, pass = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("users.xml");
            //XmlDocument xText = new XmlDocument();
            //xText.Load("1.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "teachers")
                {
                    foreach (XmlNode childteacher in xnode.ChildNodes)
                    {
                        log = false;
                        pass = false;
                        foreach (XmlNode childlogpass in childteacher.ChildNodes)
                        {

                            if (childlogpass.Name == "login" && childlogpass.InnerText == Login.Text)
                                log = true;
                            else if (childlogpass.Name == "password" && childlogpass.InnerText == Parol.Text)
                                pass = true;
                            if (log && pass)
                            {
                                Hide();
                                TeacherMenu newTeacherMenu = new TeacherMenu();
                                newTeacherMenu.Show();
                            }
                        }
                    }
                }
                else if (xnode.Name == "students")
                {
                    foreach (XmlNode childstudents in xnode.ChildNodes)
                    {
                        log = false;
                        pass = false;

                        foreach (XmlNode childlogpass in childstudents.ChildNodes)
                        {

                            if (childlogpass.Name == "login" && childlogpass.InnerText == Login.Text)
                                log = true;
                            else if (childlogpass.Name == "password" && childlogpass.InnerText == Parol.Text)
                                pass = true;
                            if (log && pass)
                            {
                                Hide();
                                Меню_для_студента newForm = new Меню_для_студента();
                                newForm.Show();
                            }
                        }
                    }
                }

            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
