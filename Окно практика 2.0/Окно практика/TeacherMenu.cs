using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Окно_практика
{
    public partial class TeacherMenu : Form
    {
        public TeacherMenu()
        {
            InitializeComponent();
        }

        private void listStudent_Click(object sender, EventArgs e)
        {
            Hide();
            StudentsList newStudentList = new StudentsList();
            newStudentList.Show();
        }

        private void editing_Click(object sender, EventArgs e)
        {
            Hide();
            EditingQuestion newEditingQuestion = new EditingQuestion();
            newEditingQuestion.Show();
        }

        private void TeacherMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm newMainForm = new MainForm();
            newMainForm.Show();
        }
    }
}
