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
	public partial class Training : Form
	{
		public Training()
		{
			InitializeComponent();
		}

		const int MAX_QUESTIONS = 240;
		const int MAX_THEMES = 8;
		const int MAX_THEME_QUESTIONS = 30;

		private static int amount = 0;
		private static readonly bool[] isNotOpened = new bool[MAX_QUESTIONS];

		private static int cur_theme = 0;
		private static string cur_answer;
		private static string cur_question;
		private static bool cur_isAnswered = true;
		private static int answered = -1;

		// get (Number of theme - 1)
		// return Number of question
		// or -1 if question list is empty
		private static int GetAnswerNumber(int theme)
		{

			if (amount == 0)
			{
				for (int i = 0; i < MAX_QUESTIONS; i++)
				{
					isNotOpened[i] = true;
				}
			}

			if (theme == -1)
			{
				return -1;
			}

			if (amount == MAX_QUESTIONS)
			{
				Console.WriteLine("No questions\n");
				return -1;
			}

			Random rnd = new Random();
			int question = theme * MAX_THEME_QUESTIONS + rnd.Next() % MAX_THEME_QUESTIONS;
			while (!isNotOpened[question])
			{
				question = theme * MAX_THEME_QUESTIONS + rnd.Next() % MAX_THEME_QUESTIONS;
			}

			amount++;
			isNotOpened[question] = false;

			return question;
		}
		private static void UploadQuestionData(int question)
		{
			XmlDocument doc = new XmlDocument();
			doc.Load("testing.xml");

			XmlElement root = doc.DocumentElement;
			foreach (XmlNode nodes in root)
			{
				foreach (XmlNode questNode in nodes)
				{
					if (questNode.Attributes.Count > 0)
					{
						XmlNode attr = questNode.Attributes.GetNamedItem("id");
						if (attr.Value == question.ToString())
						{
							foreach (XmlNode quest in questNode.ChildNodes)
							{
								if (quest.Name == "quest")
								{
									cur_question = quest.InnerText;
								}
								if (quest.Name == "true")
								{
									cur_answer = quest.InnerText;
								}
							}
						}
					}
				}
			}
		}

		private static void ClearRecord()
		{
			amount = 0;
			for (int i = 0; i < MAX_QUESTIONS; i++)
			{
				isNotOpened[i] = false;
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

			UploadQuestionData(GetAnswerNumber(cur_theme - 1));
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
			if (Arrays.Checked == true)
			{
				cur_theme = 2;
			}
			if (Strings.Checked == true)
			{
				cur_theme = 3;
			}
			if (Recursion.Checked == true)
			{
				cur_theme = 4;
			}
			if (Structs.Checked == true)
			{
				cur_theme = 5;
			}
			if (Files.Checked == true)
			{
				cur_theme = 6;
			}
			if (Pointers.Checked == true)
			{
				cur_theme = 7;
			}
			if (Dynamic.Checked == true)
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

			switch (cur_answer[0])
			{
				case '1':
					if (Answer1.Checked == true)
					{
						cur_isAnswered = true;
					}
					break;
				case '2':
					if (Answer2.Checked == true)
					{
						cur_isAnswered = true;
					}
					break;
				case '3':
					if (Answer3.Checked == true)
					{
						cur_isAnswered = true;
					}
					break;
				case '4':
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
