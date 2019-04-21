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
    public partial class Меню_для_студента : Form
    {
        public Меню_для_студента()
        {
            InitializeComponent();
        }

        private void Training_Click(object sender, EventArgs e)
        {
            Hide();
            Training newTraining = new Training();
            newTraining.Show();
        }

        private void Меню_для_студента_Load(object sender, EventArgs e)
        {

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            Hide();
            Test newTest = new Test();
            newTest.Show();
        }

        private void buttonFinalTest_Click(object sender, EventArgs e)
        {
            Hide();
            FinalTest newFinalTest = new FinalTest();
            newFinalTest.Show();
        }

        private void Меню_для_студента_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
		{
			MainForm.isOpenWindow_Form = false;

			Hide();
            MainForm newMainForm = new MainForm();
            newMainForm.Show();
        }
    }
}
