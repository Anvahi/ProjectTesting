using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Окно_практика
{
	public partial class Training : Form
	{
		public Training()
		{
			InitializeComponent();
		}

		public const int MAX_QUESTIONS_TRAIN = 10;

		public static int amount = 0;
		public static int[] isOpened = new int[MAX_QUESTIONS_TRAIN];

		private static int cur_theme = 0;
		private static string cur_answer;
		private static string cur_question;
		private static bool cur_isAnswered = true;
		private static int answered = -1;

		// get (Number of theme - 1)
		// return Number of question
		// or -1 if question list is empty
		private static void GetQuestion(int theme)
		{
			if (theme == -1)
			{
				return;
			}

			if (amount == 0)
			{
				for (int i = 0; i < MAX_QUESTIONS_TRAIN; i++)
				{
					isOpened[i] = -1;
				}
			}

			XmlDocument doc = new XmlDocument();
			doc.Load("testing.xml");
			XmlNode root = doc.DocumentElement;

			Random rnd = new Random();
			int question = rnd.Next() % root.ChildNodes[theme].ChildNodes.Count; // вне безопасного программирования

			bool exit = false;
			while (!exit)
			{
				int i;
				for (i = 0; i < amount; i++)
				{
					if (isOpened[i] == question)
					{
						question = rnd.Next() % root.ChildNodes[theme].ChildNodes.Count; // вне безопасного программирования
						break;
					}
				}

				if (i == amount)
				{
					exit = true;
				}
			}

			isOpened[amount] = question;
			amount++;

			cur_question = root.ChildNodes[theme].ChildNodes[question].ChildNodes[0].InnerText; // вне безопасного программирования
			cur_answer = root.ChildNodes[theme].ChildNodes[question].ChildNodes[1].InnerText; // вне безопасного программирования
		}

		private static void ClearRecord()
		{
			amount = 0;
			for (int i = 0; i < MAX_QUESTIONS_TRAIN; i++)
			{
				isOpened[i] = -1;
			}

			cur_theme = 0;
			cur_answer = null;
			//cur_question = null;
			cur_isAnswered = true;
			answered = -1;
		}

		private void NextQuestion()
		{
			if (answered >= 10 - 1)
			{
				Question.Text = "Вы справились с темой!";
				ClearRecord();

				return;
			}

			answered++;

			GetQuestion(cur_theme - 1);
			if (cur_theme != 0 && (cur_question != null && cur_isAnswered == true))
			{
				Question.Text = cur_question;
				cur_isAnswered = false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			/*XmlDocument xTraining = new XmlDocument();
            xTraining.Load("testing.xml");*/

			if (Cycles.Checked == true)
			{
				cur_theme = 1;
			}
			else if (Arrays.Checked == true)
			{
				cur_theme = 2;
			}
			else if (Strings.Checked == true)
			{
				cur_theme = 3;
			}
			else if (Recursion.Checked == true)
			{
				cur_theme = 4;
			}
			else if (Structs.Checked == true)
			{
				cur_theme = 5;
			}
			else if (Files.Checked == true)
			{
				cur_theme = 6;
			}
			else if (Pointers.Checked == true)
			{
				cur_theme = 7;
			}
			else if (Dynamic.Checked == true)
			{
				cur_theme = 8;
			}

			NextQuestion();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Hide();
			Меню_для_студента newForm = new Меню_для_студента();
			newForm.Show();
		}

		private void Training_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (cur_answer == null)
			{
				return;
			}

			switch (Convert.ToInt32(cur_answer))
			{
				case 1:
					if (Answer1.Checked == true)
					{
						cur_isAnswered = true;
					}
					break;
				case 2:
					if (Answer2.Checked == true)
					{
						cur_isAnswered = true;
					}
					break;
				case 3:
					if (Answer3.Checked == true)
					{
						cur_isAnswered = true;
					}
					break;
				case 4:
					if (Answer4.Checked == true)
					{
						cur_isAnswered = true;
					}
					break;
			}

			if (cur_isAnswered)
			{
				NextQuestion();
			}
		}
	}
}
