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

		public int amount = 0;
		public int[] isOpened = new int[MAX_QUESTIONS_TRAIN];

		private int cur_theme = 0;
		private string cur_answer;
		private string cur_question;
		private bool cur_isAnswered = true;
		private int answered = -1;

		// get (Number of theme - 1)
		// return Number of question
		// or -1 if question list is empty
		private void GetQuestion(int theme)
		{
			string questNodeName = "";

			switch (theme)
			{
				case 0:
					questNodeName = "cycles";
					break;
				case 1:
					questNodeName = "arrays";
					break;
				case 2:
					questNodeName = "lines";
					break;
				case 3:
					questNodeName = "recursion";
					break;
				case 4:
					questNodeName = "struct";
					break;
				case 5:
					questNodeName = "file";
					break;
				case 6:
					questNodeName = "addresses_and_pointers";
					break;
				case 7:
					questNodeName = "dynamic_memory";
					break;

				default:
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
			XmlNode rootNode = doc.DocumentElement; // <testing>


			foreach (XmlNode themeNode in rootNode)
			{
				if (themeNode.Name == questNodeName)
				{
					Random rnd = new Random();
					int question = rnd.Next() % themeNode.ChildNodes.Count;

					bool exit = false;
					while (!exit)
					{
						int i;
						for (i = 0; i < amount; i++)
						{
							if (isOpened[i] == question)
							{
								question = rnd.Next() % themeNode.ChildNodes.Count;
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

					foreach (XmlNode questionNode in themeNode.ChildNodes[question])
					{
						if (questionNode.Name == "quest")
						{
							cur_question = questionNode.InnerText;
						}
						else if (questionNode.Name == "true")
						{
							cur_answer = questionNode.InnerText;
						}
						else if (questionNode.Name == "answer")
						{
							XmlNode answerID = questionNode.Attributes.GetNamedItem("id");
							switch (Convert.ToInt32(answerID.Value))
							{
								case 1:

									Answer1.Text = "Ответ 1:\n" + questionNode.InnerText;
									break;

								case 2:

									Answer2.Text = "Ответ 2:\n" + questionNode.InnerText;
									break;

								case 3:

									Answer3.Text = "Ответ 3:\n" + questionNode.InnerText;
									break;

								case 4:

									Answer4.Text = "Ответ 4:\n" + questionNode.InnerText;
									break;
							}
						}
					}
				}
			}

			
		}

		private void ClearRecord()
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
				Answer1.Text = "Ответ 1";
				Answer2.Text = "Ответ 2";
				Answer3.Text = "Ответ 3";
				Answer4.Text = "Ответ 4";

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

		private void Answer1_CheckedChanged(object sender, EventArgs e)
		{
			
		}
	}
}
