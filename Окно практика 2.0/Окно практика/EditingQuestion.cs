using System;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Окно_практика
{
    public partial class EditingQuestion : Form
    {
        public EditingQuestion()
        {
            InitializeComponent();
        }
        //
        

        //
        private void button1_Click(object sender, EventArgs e)
        {
            
            int count = 0, i= 1;
            CH_RichTextBox.Text = "";
            CH_TextBoxAnswer1.Text = "";
            CH_TextBoxAnswer2.Text = "";
            CH_TextBoxAnswer3.Text = "";
            CH_TextBoxAnswer4.Text = "";
            CH_TextBoxAnswerTrue.Text = "";
            LabelQuest.Text = "Вопрос успешно удалён.";

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("testing.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNode Child;
            Child = xRoot.ChildNodes[0];
            if (RB_Arryes.Checked)
                Child = xRoot.ChildNodes[1];
            else if (RB_Strings.Checked)
                Child = xRoot.ChildNodes[2];
            else if (RB_Recursion.Checked)
                Child = xRoot.ChildNodes[3];
            else if (RB_Structures.Checked)
                Child = xRoot.ChildNodes[4];
            else if (RB_Files.Checked)
                Child = xRoot.ChildNodes[5];
            else if (RB_AddrAndP.Checked)
                Child = xRoot.ChildNodes[6];
            else if (RB_DymanicMemory.Checked)
                Child = xRoot.ChildNodes[7];

            XmlNodeList nodes = Child.ChildNodes;
            XmlNode a = nodes[ListQuest.SelectedIndex];
            Child.RemoveChild(a);
            xDoc.Save("testing.xml");
            ListQuest.Items.Clear();
            foreach (XmlNode childcycles in Child.ChildNodes)
            {

                if (childcycles.Attributes.Count > 0)
                {

                    i++;
                    ListQuest.Items.Insert(count, "Вопрос №" + i);
                    count++;
                }
            }
            CH_RichTextBox.Enabled = false;
            CH_TextBoxAnswer1.Enabled = false;
            CH_TextBoxAnswer2.Enabled = false;
            CH_TextBoxAnswer3.Enabled = false;
            CH_TextBoxAnswer4.Enabled = false;
            CH_TextBoxAnswerTrue.Enabled = false;
            LabelQuest.Focus();
            ButtonRemove.Visible = false;
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide();
            TeacherMenu newTeacherMenu = new TeacherMenu();
            newTeacherMenu.Show();
        }

        private void EditingQuestion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e) // циклы
        {
            ButtonRemove.Visible = false;
            ListQuest.Enabled = true;
            ListQuest.Items.Clear();
            int count = 0, i = 1;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("testing.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "cycles")
                {
                    foreach (XmlNode childcycles in xnode.ChildNodes)
                    {

                        if (childcycles.Attributes.Count > 0)
                        {

                            ListQuest.Items.Insert(count, "Вопрос №" + i);
                            count++;
                            i++;
                        }
                    }


                }
                else
                    break;
            }
        }

        private void RB_DymanicMemory_CheckedChanged(object sender, EventArgs e) 
        {
            ButtonRemove.Visible = false;
            ListQuest.Enabled = true;
            ListQuest.Items.Clear();
            int count = 0, i = 1;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("testing.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "dynamic_memory")
                {
                    foreach (XmlNode childdynamic_memory in xnode.ChildNodes)
                    {

                        if (childdynamic_memory.Attributes.Count > 0)
                        {
                            ListQuest.Items.Insert(count, "Вопрос №" + i);
                            count++;
                            i++;
                        }
                    }


                }
            }

        }

        private void RB_Arryes_CheckedChanged(object sender, EventArgs e)
        {
            ButtonRemove.Visible = false;
            ListQuest.Enabled = true;
            ListQuest.Items.Clear();
            int count = 0, i = 1;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("testing.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "arrays")
                {
                    foreach (XmlNode childarrays in xnode.ChildNodes)
                    {
                        if (childarrays.Attributes.Count > 0)
                        {
                            ListQuest.Items.Insert(count, "Вопрос №" + i);
                            count++;
                            i++;
                        }
                    }


                }
            }
        }

        private void RB_Strings_CheckedChanged(object sender, EventArgs e)
        {
            ButtonRemove.Visible = false;
            ListQuest.Enabled = true;
            ListQuest.Items.Clear();
            int count = 0, i=1;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("testing.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "lines")
                {
                    foreach (XmlNode childlines in xnode.ChildNodes)
                    {

                        if (childlines.Attributes.Count > 0)
                        {

                            ListQuest.Items.Insert(count, "Вопрос №" + i);
                            count++;
                            i++;
                        }
                    }


                }
            }
        }

        private void RB_Recursion_CheckedChanged(object sender, EventArgs e)
        {
            ButtonRemove.Visible = false;
            ListQuest.Enabled = true;
            ListQuest.Items.Clear();
            int count = 0, i=1;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("testing.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "recursion")
                {
                    foreach (XmlNode childrecursion in xnode.ChildNodes)
                    {

                        if (childrecursion.Attributes.Count > 0)
                        {

                            ListQuest.Items.Insert(count, "Вопрос №" + i);
                            count++;
                            i++;
                        }
                    }


                }
            }
        }

        private void RB_Structures_CheckedChanged(object sender, EventArgs e)
        {
            ButtonRemove.Visible = false;
            ListQuest.Enabled = true;
            ListQuest.Items.Clear();
            int count = 0, i = 1;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("testing.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "struct")
                {
                    foreach (XmlNode childstruct in xnode.ChildNodes)
                    {

                        if (childstruct.Attributes.Count > 0)
                        {

                            ListQuest.Items.Insert(count, "Вопрос №" + i);
                            count++;
                            i++;
                        }
                    }


                }
            }
        }

        private void RB_Files_CheckedChanged(object sender, EventArgs e)
        {
            ButtonRemove.Visible = false;
            ListQuest.Items.Clear();
            int count = 0, i = 1;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("testing.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "file")
                {
                    foreach (XmlNode childfile in xnode.ChildNodes)
                    {

                        if (childfile.Attributes.Count > 0)
                        {

                            ListQuest.Items.Insert(count, "Вопрос №" + i);
                            count++;
                            i++;
                        }
                    }


                }
            }
            ListQuest.Enabled = true;
        }

        private void RB_AddrAndP_CheckedChanged(object sender, EventArgs e)
        {
            ButtonRemove.Visible = false;
            ListQuest.Enabled = true;
            ListQuest.Items.Clear();
            int count = 0, i = 1;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("testing.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "addresses_and_pointers")
                {
                    foreach (XmlNode childaddresses_and_pointers in xnode.ChildNodes)
                    {

                        if (childaddresses_and_pointers.Attributes.Count > 0)
                        {

                            
                            ListQuest.Items.Insert(count, "Вопрос №" + i);
                            count++;
                            i++;
                        }
                    }


                }
            }
        }

        private void ListQuest_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonRemove.Visible = true;
            CH_RichTextBox.Enabled = true;
            CH_TextBoxAnswer1.Enabled = true;
            CH_TextBoxAnswer2.Enabled = true;
            CH_TextBoxAnswer3.Enabled = true;
            CH_TextBoxAnswer4.Enabled = true;
            CH_TextBoxAnswerTrue.Enabled = true;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("testing.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNode xNode = xRoot, Child, Child_ml;
            string question, answer1, answer2, answer3, answer4, answerTrue;
            Child = xNode.ChildNodes[0];
            if (RB_Arryes.Checked)
                Child = xNode.ChildNodes[1];
            else if (RB_Strings.Checked)
                Child = xNode.ChildNodes[2];
            else if (RB_Recursion.Checked)
                Child = xNode.ChildNodes[3];
            else if (RB_Structures.Checked)
                Child = xNode.ChildNodes[4];
            else if (RB_Files.Checked)
                Child = xNode.ChildNodes[5];
            else if (RB_AddrAndP.Checked)
                Child = xNode.ChildNodes[6];
            else if (RB_DymanicMemory.Checked)
                Child = xNode.ChildNodes[7];
            Child_ml = Child.ChildNodes[ListQuest.SelectedIndex];
            question = Child_ml.ChildNodes[0].InnerText;
            answer1 = Child_ml.ChildNodes[1].InnerText;
            answer2 = Child_ml.ChildNodes[2].InnerText;
            answer3 = Child_ml.ChildNodes[3].InnerText;
            answer4 = Child_ml.ChildNodes[4].InnerText;
            answerTrue = Child_ml.ChildNodes[5].InnerText;
            LabelQuest.Text = question + "\n" +
               "1)" + answer1 + "\n" +
               "2)" + answer2 + "\n" +
               "3)" + answer3 + "\n" +
               "4)" + answer4 + "\n" +
                "Верный ответ: " + answerTrue;
            CH_RichTextBox.Text = question;
            CH_TextBoxAnswer1.Text = answer1;
            CH_TextBoxAnswer2.Text = answer2;
            CH_TextBoxAnswer3.Text = answer3;
            CH_TextBoxAnswer4.Text = answer4;
            CH_TextBoxAnswerTrue.Text = answerTrue;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            //ButtonAdd.BackColor = Color.FromArgb(111, 121, 131);
        }

        private void ButtonAdd_Enter(object sender, EventArgs e)
        {
            ButtonAdd.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            ButtonChange.BackColor = System.Drawing.Color.FromArgb(180, 180, 180);
            NameAct.Text = "Добавление вопроса";
            // RadioButton
            RB_Cyrcles.Enabled = false;
            RB_Arryes.Enabled = false;
            RB_Strings.Enabled = false;
            RB_Recursion.Enabled = false;
            RB_Structures.Enabled = false;
            RB_Files.Enabled = false;
            RB_AddrAndP.Enabled = false;
            RB_DymanicMemory.Enabled = false;

            RB_Cyrcles.Checked = false;
            RB_Arryes.Checked = false;
            RB_Strings.Checked = false;
            RB_Recursion.Checked = false;
            RB_Structures.Checked = false;
            RB_Files.Checked = false;
            RB_AddrAndP.Checked = false;
            RB_DymanicMemory.Checked = false;
            // List_Questions
            ListQuest.Enabled = false;
            // Add questions
            ADD_labelComboBoxTema.Visible = true;
            ADD_LabelQuest.Visible = true;
            ADD_LavelAsnwers.Visible = true;
            ADD_ComboBoxTema.Visible = true;
            ADD_RichTextBox.Visible = true;
            ADD_Label_1.Visible = true;
            ADD_Label_2.Visible = true;
            ADD_Label_3.Visible = true;
            ADD_Label_4.Visible = true;
            ADD_answer1.Visible = true;
            ADD_answer2.Visible = true;
            ADD_answer3.Visible = true;
            ADD_answer4.Visible = true;
            ADD_LabelTrue.Visible = true;
            ADD_answerTrue.Visible = true;

            CH_ChangeLabel.Visible = false;
            CH_RichTextBox.Visible = false;
            CH_LabelOtred.Visible = false;
            CH_Label1.Visible = false;
            CH_Label2.Visible = false;
            CH_Label3.Visible = false;
            CH_Label4.Visible = false;
            CH_LabelTrue.Visible = false;
            CH_TextBoxAnswer1.Visible = false;
            CH_TextBoxAnswer2.Visible = false;
            CH_TextBoxAnswer3.Visible = false;
            CH_TextBoxAnswer4.Visible = false;
            CH_TextBoxAnswerTrue.Visible = false;

            CH_RichTextBox.Enabled = false;
            CH_TextBoxAnswer1.Enabled = false;
            CH_TextBoxAnswer2.Enabled = false;
            CH_TextBoxAnswer3.Enabled = false;
            CH_TextBoxAnswer4.Enabled = false;
            CH_TextBoxAnswerTrue.Enabled = false;
            // Remove_Button
            ButtonRemove.Visible = false;
            // Windows_Change
            CH_RichTextBox.Enabled = false;
            CH_RichTextBox.Text = "";
            CH_TextBoxAnswer1.Text = "";
            CH_TextBoxAnswer2.Text = "";
            CH_TextBoxAnswer3.Text = "";
            CH_TextBoxAnswer4.Text = "";
            CH_TextBoxAnswerTrue.Text = "";
            CH_LabelQuest.Text = "Инструкция по добавлению вопроса:";
            LabelQuest.Text = "1) Выберите тему, характеризующий вопрос;\n" +
                "2) Сформулируйте вопрос и запишите в поле;\n" +
                "3) Занесите ответы на сформулированный вопрос в каждый из полей;\n" +
                "4) Напишите цифру(1-4) в поле верного ответа;\n" +
                "5) Нажмите 'Добавить';\n\n" +
                "Примечание:\n" +
                "Кнопка 'Добавить' не появится, пока все поля не будут заполнены корректно.";
        }

        private void ButtonChange_Enter(object sender, EventArgs e)
        {
            ButtonAdd.BackColor = System.Drawing.Color.FromArgb(180, 180, 180);
            ButtonChange.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            NameAct.Text = "Изменение вопроса";
            //Delete_Text_TextBox
            ADD_ComboBoxTema.SelectedIndex = 0;
            ADD_RichTextBox.Text = "";
            ADD_answer1.Text = "";
            ADD_answer2.Text = "";
            ADD_answer3.Text = "";
            ADD_answer4.Text = "";
            ADD_answerTrue.Text = "Введите номер ответа";

            CH_RichTextBox.Text = "";
            CH_TextBoxAnswer1.Text = "";
            CH_TextBoxAnswer2.Text = "";
            CH_TextBoxAnswer3.Text = "";
            CH_TextBoxAnswer4.Text = "";
            CH_TextBoxAnswerTrue.Text = "";
            // RadioButton
            RB_Cyrcles.Enabled = true;
            RB_Arryes.Enabled = true;
            RB_Strings.Enabled = true;
            RB_Recursion.Enabled = true;
            RB_Structures.Enabled = true;
            RB_Files.Enabled = true;
            RB_AddrAndP.Enabled = true;
            RB_DymanicMemory.Enabled = true;

            RB_Cyrcles.Checked = false;
            RB_Arryes.Checked = false;
            RB_Strings.Checked = false;
            RB_Recursion.Checked = false;
            RB_Structures.Checked = false;
            RB_Files.Checked = false;
            RB_AddrAndP.Checked = false;
            RB_DymanicMemory.Checked = false;
            //List_Questions
            ListQuest.Enabled = false;
            // Change questions
            ADD_labelComboBoxTema.Visible = false;
            ADD_LabelQuest.Visible = false;
            ADD_LavelAsnwers.Visible = false;
            ADD_ComboBoxTema.Visible = false;
            ADD_RichTextBox.Visible = false;
            ADD_Label_1.Visible = false;
            ADD_Label_2.Visible = false;
            ADD_Label_3.Visible = false;
            ADD_Label_4.Visible = false;
            ADD_answer1.Visible = false;
            ADD_answer2.Visible = false;
            ADD_answer3.Visible = false;
            ADD_answer4.Visible = false;
            ADD_LabelTrue.Visible = false;
            ADD_answerTrue.Visible = false;

            CH_ChangeLabel.Visible = true;
            CH_RichTextBox.Visible = true;
            CH_LabelOtred.Visible = true;
            CH_Label1.Visible = true;
            CH_Label2.Visible = true;
            CH_Label3.Visible = true;
            CH_Label4.Visible = true;
            CH_LabelTrue.Visible = true;
            CH_TextBoxAnswer1.Visible = true;
            CH_TextBoxAnswer2.Visible = true;
            CH_TextBoxAnswer3.Visible = true;
            CH_TextBoxAnswer4.Visible = true;
            CH_TextBoxAnswerTrue.Visible = true;
           
            // Label_Quest

            CH_LabelQuest.Text = "Вопрос с вариантами ответа:";
            LabelQuest.Text = "Выберите тему и номер вопроса.";
        }
        
        private void LabelQuest_Click(object sender, EventArgs e)
        {

        }

        private void ADD_ComboBoxTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ADD_ComboBoxTema.SelectedIndex == 0)
            {
                ADD_RichTextBox.Enabled = false;
                ADD_answer1.Enabled = false;
                ADD_answer2.Enabled = false;
                ADD_answer3.Enabled = false;
                ADD_answer4.Enabled = false;
                ADD_answerTrue.Enabled = false;
            }
            else
            {
                ADD_RichTextBox.Enabled = true;
                ADD_answer1.Enabled = true;
                ADD_answer2.Enabled = true;
                ADD_answer3.Enabled = true;
                ADD_answer4.Enabled = true;
                ADD_answerTrue.Enabled = true;
                ADD_RichTextBox.Text = "";
            }
            if (ADD_ComboBoxTema.SelectedIndex != 0 && ADD_RichTextBox.Text.Length > 0 && ADD_answer1.Text.Length > 0 && ADD_answer2.Text.Length > 0 && ADD_answer3.Text.Length > 0 && ADD_answer4.Text.Length > 0 && (ADD_answerTrue.Text.Equals("1") || ADD_answerTrue.Text.Equals("2") || ADD_answerTrue.Text.Equals("3") || ADD_answerTrue.Text.Equals("4")))
                ADD_ButtonAdd.Visible = true;
            else
                ADD_ButtonAdd.Visible = false;
        }

        private void ADD_ButtonAdd_MouseMove(object sender, MouseEventArgs e)
        {
            
            
        }

        private void ADD_answerTrue_TextChanged(object sender, EventArgs e)
        {
            if (ADD_ComboBoxTema.SelectedIndex != 0 && ADD_RichTextBox.Text.Length > 0 && ADD_answer1.Text.Length > 0 && ADD_answer2.Text.Length > 0 && ADD_answer3.Text.Length > 0 && ADD_answer4.Text.Length > 0 && (ADD_answerTrue.Text.Equals("1") || ADD_answerTrue.Text.Equals("2") || ADD_answerTrue.Text.Equals("3") || ADD_answerTrue.Text.Equals("4")))
                ADD_ButtonAdd.Visible = true;
            else
                ADD_ButtonAdd.Visible = false;
        }

        private void ADD_RichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ADD_ComboBoxTema.SelectedIndex != 0 && ADD_RichTextBox.Text.Length > 0 && ADD_answer1.Text.Length > 0 && ADD_answer2.Text.Length > 0 && ADD_answer3.Text.Length > 0 && ADD_answer4.Text.Length > 0 && (ADD_answerTrue.Text.Equals("1") || ADD_answerTrue.Text.Equals("2") || ADD_answerTrue.Text.Equals("3") || ADD_answerTrue.Text.Equals("4")))
                ADD_ButtonAdd.Visible = true;
            else
                ADD_ButtonAdd.Visible = false;
        }

        private void ADD_answer1_TextChanged(object sender, EventArgs e)
        {
            if (ADD_ComboBoxTema.SelectedIndex != 0 && ADD_RichTextBox.Text.Length > 0 && ADD_answer1.Text.Length > 0 && ADD_answer2.Text.Length > 0 && ADD_answer3.Text.Length > 0 && ADD_answer4.Text.Length > 0 && (ADD_answerTrue.Text.Equals("1") || ADD_answerTrue.Text.Equals("2") || ADD_answerTrue.Text.Equals("3") || ADD_answerTrue.Text.Equals("4")))
                ADD_ButtonAdd.Visible = true;
            else
                ADD_ButtonAdd.Visible = false;
        }

        private void ADD_answer2_TextChanged(object sender, EventArgs e)
        {
            if (ADD_ComboBoxTema.SelectedIndex != 0 && ADD_RichTextBox.Text.Length > 0 && ADD_answer1.Text.Length > 0 && ADD_answer2.Text.Length > 0 && ADD_answer3.Text.Length > 0 && ADD_answer4.Text.Length > 0 && (ADD_answerTrue.Text.Equals("1") || ADD_answerTrue.Text.Equals("2") || ADD_answerTrue.Text.Equals("3") || ADD_answerTrue.Text.Equals("4")))
                ADD_ButtonAdd.Visible = true;
            else
                ADD_ButtonAdd.Visible = false;
        }

        private void ADD_answer3_TextChanged(object sender, EventArgs e)
        {
            if (ADD_ComboBoxTema.SelectedIndex != 0 && ADD_RichTextBox.Text.Length > 0 && ADD_answer1.Text.Length > 0 && ADD_answer2.Text.Length > 0 && ADD_answer3.Text.Length > 0 && ADD_answer4.Text.Length > 0 && (ADD_answerTrue.Text.Equals("1") || ADD_answerTrue.Text.Equals("2") || ADD_answerTrue.Text.Equals("3") || ADD_answerTrue.Text.Equals("4")))
                ADD_ButtonAdd.Visible = true;
            else
                ADD_ButtonAdd.Visible = false;
        }

        private void ADD_answer4_TextChanged(object sender, EventArgs e)
        {
            if (ADD_ComboBoxTema.SelectedIndex != 0 && ADD_RichTextBox.Text.Length > 0 && ADD_answer1.Text.Length > 0 && ADD_answer2.Text.Length > 0 && ADD_answer3.Text.Length > 0 && ADD_answer4.Text.Length > 0 && (ADD_answerTrue.Text.Equals("1") || ADD_answerTrue.Text.Equals("2") || ADD_answerTrue.Text.Equals("3") || ADD_answerTrue.Text.Equals("4")))
                ADD_ButtonAdd.Visible = true;
            else
                ADD_ButtonAdd.Visible = false;
        }

        private void ButtonAdd_Click_1(object sender, EventArgs e)
        {
    
        }

        private void CH_RichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CH_RichTextBox.Text.Length > 0 && CH_TextBoxAnswer1.Text.Length > 0 && CH_TextBoxAnswer2.Text.Length > 0 && CH_TextBoxAnswer3.Text.Length > 0 && CH_TextBoxAnswer4.Text.Length > 0 && (CH_TextBoxAnswerTrue.Text.Equals("1") || CH_TextBoxAnswerTrue.Text.Equals("2") || CH_TextBoxAnswerTrue.Text.Equals("3") || CH_TextBoxAnswerTrue.Text.Equals("4")))
                CH_ButtonChange.Visible = true;
            else
                CH_ButtonChange.Visible = false;
        }

        private void CH_TextBoxAnswer1_TextChanged(object sender, EventArgs e)
        {
            if (CH_RichTextBox.Text.Length > 0 && CH_TextBoxAnswer1.Text.Length > 0 && CH_TextBoxAnswer2.Text.Length > 0 && CH_TextBoxAnswer3.Text.Length > 0 && CH_TextBoxAnswer4.Text.Length > 0 && (CH_TextBoxAnswerTrue.Text.Equals("1") || CH_TextBoxAnswerTrue.Text.Equals("2") || CH_TextBoxAnswerTrue.Text.Equals("3") || CH_TextBoxAnswerTrue.Text.Equals("4")))
                CH_ButtonChange.Visible = true;
            else
                CH_ButtonChange.Visible = false;
        }

        private void CH_TextBoxAnswer2_TextChanged(object sender, EventArgs e)
        {
            if (CH_RichTextBox.Text.Length > 0 && CH_TextBoxAnswer1.Text.Length > 0 && CH_TextBoxAnswer2.Text.Length > 0 && CH_TextBoxAnswer3.Text.Length > 0 && CH_TextBoxAnswer4.Text.Length > 0 && (CH_TextBoxAnswerTrue.Text.Equals("1") || CH_TextBoxAnswerTrue.Text.Equals("2") || CH_TextBoxAnswerTrue.Text.Equals("3") || CH_TextBoxAnswerTrue.Text.Equals("4")))
                CH_ButtonChange.Visible = true;
            else
                CH_ButtonChange.Visible = false;
        }

        private void CH_TextBoxAnswer3_TextChanged(object sender, EventArgs e)
        {
            if (CH_RichTextBox.Text.Length > 0 && CH_TextBoxAnswer1.Text.Length > 0 && CH_TextBoxAnswer2.Text.Length > 0 && CH_TextBoxAnswer3.Text.Length > 0 && CH_TextBoxAnswer4.Text.Length > 0 && (CH_TextBoxAnswerTrue.Text.Equals("1") || CH_TextBoxAnswerTrue.Text.Equals("2") || CH_TextBoxAnswerTrue.Text.Equals("3") || CH_TextBoxAnswerTrue.Text.Equals("4")))
                CH_ButtonChange.Visible = true;
            else
                CH_ButtonChange.Visible = false;
        }

        private void CH_TextBoxAnswer4_TextChanged(object sender, EventArgs e)
        {
            if (CH_RichTextBox.Text.Length > 0 && CH_TextBoxAnswer1.Text.Length > 0 && CH_TextBoxAnswer2.Text.Length > 0 && CH_TextBoxAnswer3.Text.Length > 0 && CH_TextBoxAnswer4.Text.Length > 0 && (CH_TextBoxAnswerTrue.Text.Equals("1") || CH_TextBoxAnswerTrue.Text.Equals("2") || CH_TextBoxAnswerTrue.Text.Equals("3") || CH_TextBoxAnswerTrue.Text.Equals("4")))
                CH_ButtonChange.Visible = true;
            else
                CH_ButtonChange.Visible = false;
        }

        private void CH_TextBoxAnswerTrue_TextChanged(object sender, EventArgs e)
        {
            if (CH_RichTextBox.Text.Length > 0 && CH_TextBoxAnswer1.Text.Length > 0 && CH_TextBoxAnswer2.Text.Length > 0 && CH_TextBoxAnswer3.Text.Length > 0 && CH_TextBoxAnswer4.Text.Length > 0 && (CH_TextBoxAnswerTrue.Text.Equals("1") || CH_TextBoxAnswerTrue.Text.Equals("2") || CH_TextBoxAnswerTrue.Text.Equals("3") || CH_TextBoxAnswerTrue.Text.Equals("4")))
                CH_ButtonChange.Visible = true;
            else
                CH_ButtonChange.Visible = false;
        }

        private void CH_ButtonChange_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("testing.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNode xNode = xRoot, Child, Child_ml;
            Child = xNode.ChildNodes[0];
            if (RB_Arryes.Checked)
                Child = xNode.ChildNodes[1];
            else if (RB_Strings.Checked)
                Child = xNode.ChildNodes[2];
            else if (RB_Recursion.Checked)
                Child = xNode.ChildNodes[3];
            else if (RB_Structures.Checked)
                Child = xNode.ChildNodes[4];
            else if (RB_Files.Checked)
                Child = xNode.ChildNodes[5];
            else if (RB_AddrAndP.Checked)
                Child = xNode.ChildNodes[6];
            else if (RB_DymanicMemory.Checked)
                Child = xNode.ChildNodes[7];
            Child_ml = Child.ChildNodes[ListQuest.SelectedIndex];
            Child_ml.ChildNodes[0].InnerText = CH_RichTextBox.Text;
            Child_ml.ChildNodes[1].InnerText = CH_TextBoxAnswer1.Text;
            Child_ml.ChildNodes[2].InnerText = CH_TextBoxAnswer2.Text;
            Child_ml.ChildNodes[3].InnerText = CH_TextBoxAnswer3.Text;
            Child_ml.ChildNodes[4].InnerText = CH_TextBoxAnswer4.Text;   
            Child_ml.ChildNodes[5].InnerText = CH_TextBoxAnswerTrue.Text;
            xDoc.Save("testing.xml");    
            LabelQuest.Text = Child_ml.ChildNodes[0].InnerText + "\n" +
               "1)" + Child_ml.ChildNodes[1].InnerText + "\n" +
               "2)" + Child_ml.ChildNodes[2].InnerText + "\n" +
               "3)" + Child_ml.ChildNodes[3].InnerText + "\n" +
               "4)" + Child_ml.ChildNodes[4].InnerText + "\n" +
                "Верный ответ: " + Child_ml.ChildNodes[5].InnerText;
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            ButtonRemove.Visible = false;
        }
        private void ADD_ButtonAdd_Click(object sender, EventArgs e)
        {
            
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("testing.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNode xNode = xRoot, Child;
            Child = xNode.ChildNodes[0];
            switch (ADD_ComboBoxTema.SelectedIndex)
            {
                case 1:
                    break;
                case 2:
                    Child = xNode.ChildNodes[1];
                    break;
                case 3:
                    Child = xNode.ChildNodes[2];
                    break;
                case 4:
                    Child = xNode.ChildNodes[3];
                    break;
                case 5:
                    Child = xNode.ChildNodes[4];
                    break;
                case 6:
                    Child = xNode.ChildNodes[5];
                    break;
                case 7:
                    Child = xNode.ChildNodes[6];
                    break;
                case 8:
                    Child = xNode.ChildNodes[7];
                    break;

            }
            int tem = Convert.ToInt32(Child.LastChild.Attributes["id"].Value);

            XmlElement questElem = xDoc.CreateElement("question");
            XmlAttribute nameAtt = xDoc.CreateAttribute("id");
            XmlText idname = xDoc.CreateTextNode(Convert.ToString(tem+1));

            XmlElement quest = xDoc.CreateElement("quest");
            XmlText namequest = xDoc.CreateTextNode(ADD_RichTextBox.Text);

            XmlElement answer = xDoc.CreateElement("answer");
            XmlAttribute answerAtt1 = xDoc.CreateAttribute("id");
            XmlText answertext1 = xDoc.CreateTextNode(ADD_answer1.Text);

            XmlElement answer2 = xDoc.CreateElement("answer");
            XmlAttribute answerAtt2 = xDoc.CreateAttribute("id");
            XmlText answertext2 = xDoc.CreateTextNode(ADD_answer2.Text);

            XmlElement answer3 = xDoc.CreateElement("answer");
            XmlAttribute answerAtt3 = xDoc.CreateAttribute("id");
            XmlText answertext3 = xDoc.CreateTextNode(ADD_answer3.Text);

            XmlElement answer4 = xDoc.CreateElement("answer");
            XmlAttribute answerAtt4 = xDoc.CreateAttribute("id");
            XmlText answertext4 = xDoc.CreateTextNode(ADD_answer4.Text);

            XmlElement atrue = xDoc.CreateElement("true");
            XmlText answertexttrue = xDoc.CreateTextNode(ADD_answerTrue.Text);

            
            nameAtt.AppendChild(idname);
            quest.AppendChild(namequest);
            answer.AppendChild(answertext1);
            answer2.AppendChild(answertext2);
            answer3.AppendChild(answertext3);
            answer4.AppendChild(answertext4);
            atrue.AppendChild(answertexttrue);

            questElem.Attributes.Append(nameAtt);
            questElem.AppendChild(quest);
            questElem.AppendChild(answer);
            questElem.AppendChild(answer2);
            questElem.AppendChild(answer3);
            questElem.AppendChild(answer4);
            questElem.AppendChild(atrue);

            Child.AppendChild(questElem);
            xDoc.Save("testing.xml");

            ADD_RichTextBox.Text = "Вопрос успешно добавлен!";
            ADD_answer1.Text = "";
            ADD_answer2.Text = "";
            ADD_answer3.Text = "";
            ADD_answer4.Text = "";
            ADD_answerTrue.Text = "Введите номер ответа";
            ADD_ComboBoxTema.SelectedIndex = 0;
        }
    }
}