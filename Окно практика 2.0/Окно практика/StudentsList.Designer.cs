namespace Окно_практика
{
    partial class StudentsList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.DeleteStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameStudent = new System.Windows.Forms.TextBox();
            this.SekondNameStudent = new System.Windows.Forms.TextBox();
            this.NewLogin = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.Registration = new System.Windows.Forms.Button();
            this.DisplayList = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.ChangeProgress = new System.Windows.Forms.Button();
            this.Filter = new System.Windows.Forms.Button();
            this.BackToMenu = new System.Windows.Forms.Button();
            this.newProgress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProgressOk = new System.Windows.Forms.Button();
            this.ProgressNo = new System.Windows.Forms.Button();
            this.SignOk = new System.Windows.Forms.Button();
            this.SignNo = new System.Windows.Forms.Button();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(13, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(683, 580);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_2);
            // 
            // DeleteStudent
            // 
            this.DeleteStudent.BackColor = System.Drawing.Color.LawnGreen;
            this.DeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteStudent.Location = new System.Drawing.Point(718, 267);
            this.DeleteStudent.Name = "DeleteStudent";
            this.DeleteStudent.Size = new System.Drawing.Size(203, 83);
            this.DeleteStudent.TabIndex = 2;
            this.DeleteStudent.Text = "Удалить студента";
            this.DeleteStudent.UseVisualStyleBackColor = false;
            this.DeleteStudent.Click += new System.EventHandler(this.DeleteStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список студентов с оценками";
            // 
            // NameStudent
            // 
            this.NameStudent.BackColor = System.Drawing.SystemColors.Control;
            this.NameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameStudent.Location = new System.Drawing.Point(938, 231);
            this.NameStudent.Name = "NameStudent";
            this.NameStudent.Size = new System.Drawing.Size(236, 22);
            this.NameStudent.TabIndex = 5;
            this.NameStudent.Text = "Имя";
            this.NameStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameStudent.Visible = false;
            // 
            // SekondNameStudent
            // 
            this.SekondNameStudent.BackColor = System.Drawing.SystemColors.Control;
            this.SekondNameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SekondNameStudent.Location = new System.Drawing.Point(938, 203);
            this.SekondNameStudent.Name = "SekondNameStudent";
            this.SekondNameStudent.Size = new System.Drawing.Size(236, 22);
            this.SekondNameStudent.TabIndex = 6;
            this.SekondNameStudent.Text = "Фамилия";
            this.SekondNameStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SekondNameStudent.Visible = false;
            // 
            // NewLogin
            // 
            this.NewLogin.BackColor = System.Drawing.SystemColors.Control;
            this.NewLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewLogin.Location = new System.Drawing.Point(938, 259);
            this.NewLogin.Name = "NewLogin";
            this.NewLogin.Size = new System.Drawing.Size(236, 22);
            this.NewLogin.TabIndex = 7;
            this.NewLogin.Text = "Логин";
            this.NewLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewLogin.Visible = false;
            this.NewLogin.TextChanged += new System.EventHandler(this.NewLogin_TextChanged);
            // 
            // newPassword
            // 
            this.newPassword.BackColor = System.Drawing.SystemColors.Control;
            this.newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPassword.Location = new System.Drawing.Point(938, 287);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(236, 22);
            this.newPassword.TabIndex = 8;
            this.newPassword.Text = "Пароль";
            this.newPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPassword.Visible = false;
            // 
            // Registration
            // 
            this.Registration.BackColor = System.Drawing.Color.LawnGreen;
            this.Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration.Location = new System.Drawing.Point(718, 161);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(203, 82);
            this.Registration.TabIndex = 9;
            this.Registration.Text = "Добавить студента";
            this.Registration.UseVisualStyleBackColor = false;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // DisplayList
            // 
            this.DisplayList.BackColor = System.Drawing.Color.LawnGreen;
            this.DisplayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisplayList.Location = new System.Drawing.Point(1201, 174);
            this.DisplayList.Name = "DisplayList";
            this.DisplayList.Size = new System.Drawing.Size(119, 37);
            this.DisplayList.TabIndex = 10;
            this.DisplayList.Text = "Ок";
            this.DisplayList.UseVisualStyleBackColor = false;
            this.DisplayList.Visible = false;
            this.DisplayList.Click += new System.EventHandler(this.DisplayList_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.PaleGreen;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(979, 55);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(139, 24);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.Text = "по всем темам";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.PaleGreen;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(979, 84);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(188, 24);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.Text = "по конктретной теме";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.Visible = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.PaleGreen;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(979, 115);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(196, 24);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.Text = "только итоговый тест";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.Visible = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.PaleGreen;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.Location = new System.Drawing.Point(979, 144);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(191, 24);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.Text = "только средний балл";
            this.radioButton4.UseVisualStyleBackColor = false;
            this.radioButton4.Visible = false;
            // 
            // ChangeProgress
            // 
            this.ChangeProgress.BackColor = System.Drawing.Color.LawnGreen;
            this.ChangeProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeProgress.Location = new System.Drawing.Point(718, 369);
            this.ChangeProgress.Name = "ChangeProgress";
            this.ChangeProgress.Size = new System.Drawing.Size(203, 81);
            this.ChangeProgress.TabIndex = 16;
            this.ChangeProgress.Text = "Изменить прогресс студента";
            this.ChangeProgress.UseVisualStyleBackColor = false;
            this.ChangeProgress.Click += new System.EventHandler(this.ChangeProgress_Click);
            // 
            // Filter
            // 
            this.Filter.BackColor = System.Drawing.Color.LawnGreen;
            this.Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Filter.Location = new System.Drawing.Point(718, 55);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(203, 83);
            this.Filter.TabIndex = 18;
            this.Filter.Text = "Фильтры";
            this.Filter.UseVisualStyleBackColor = false;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // BackToMenu
            // 
            this.BackToMenu.BackColor = System.Drawing.Color.LawnGreen;
            this.BackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToMenu.Location = new System.Drawing.Point(16, 660);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(202, 57);
            this.BackToMenu.TabIndex = 20;
            this.BackToMenu.Text = "Назад в меню преподавателя";
            this.BackToMenu.UseVisualStyleBackColor = false;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // newProgress
            // 
            this.newProgress.BackColor = System.Drawing.SystemColors.Control;
            this.newProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newProgress.Location = new System.Drawing.Point(1130, 371);
            this.newProgress.Name = "newProgress";
            this.newProgress.Size = new System.Drawing.Size(208, 26);
            this.newProgress.TabIndex = 24;
            this.newProgress.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(345, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 23;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ProgressOk
            // 
            this.ProgressOk.BackColor = System.Drawing.Color.LawnGreen;
            this.ProgressOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProgressOk.Location = new System.Drawing.Point(1102, 669);
            this.ProgressOk.Name = "ProgressOk";
            this.ProgressOk.Size = new System.Drawing.Size(119, 39);
            this.ProgressOk.TabIndex = 25;
            this.ProgressOk.Text = "Ок";
            this.ProgressOk.UseVisualStyleBackColor = false;
            this.ProgressOk.Visible = false;
            // 
            // ProgressNo
            // 
            this.ProgressNo.BackColor = System.Drawing.Color.LawnGreen;
            this.ProgressNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProgressNo.Location = new System.Drawing.Point(1227, 669);
            this.ProgressNo.Name = "ProgressNo";
            this.ProgressNo.Size = new System.Drawing.Size(111, 39);
            this.ProgressNo.TabIndex = 26;
            this.ProgressNo.Text = "Отмена";
            this.ProgressNo.UseVisualStyleBackColor = false;
            this.ProgressNo.Visible = false;
            this.ProgressNo.Click += new System.EventHandler(this.button2_Click);
            // 
            // SignOk
            // 
            this.SignOk.BackColor = System.Drawing.Color.LawnGreen;
            this.SignOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignOk.Location = new System.Drawing.Point(938, 315);
            this.SignOk.Name = "SignOk";
            this.SignOk.Size = new System.Drawing.Size(119, 39);
            this.SignOk.TabIndex = 27;
            this.SignOk.Text = "Ок";
            this.SignOk.UseVisualStyleBackColor = false;
            this.SignOk.Visible = false;
            // 
            // SignNo
            // 
            this.SignNo.BackColor = System.Drawing.Color.LawnGreen;
            this.SignNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignNo.Location = new System.Drawing.Point(1063, 315);
            this.SignNo.Name = "SignNo";
            this.SignNo.Size = new System.Drawing.Size(111, 39);
            this.SignNo.TabIndex = 28;
            this.SignNo.Text = "Отмена";
            this.SignNo.UseVisualStyleBackColor = false;
            this.SignNo.Visible = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton5.Location = new System.Drawing.Point(955, 55);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(77, 24);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.Text = "Циклы";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Visible = false;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton6.Location = new System.Drawing.Point(955, 85);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(94, 24);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.Text = "Массивы";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.Visible = false;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton7.Location = new System.Drawing.Point(955, 114);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(82, 24);
            this.radioButton7.TabIndex = 2;
            this.radioButton7.Text = "Строки";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.Visible = false;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton8.Location = new System.Drawing.Point(955, 144);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(96, 24);
            this.radioButton8.TabIndex = 3;
            this.radioButton8.Text = "Рекурсия";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.Visible = false;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton9.Location = new System.Drawing.Point(1086, 54);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(107, 24);
            this.radioButton9.TabIndex = 4;
            this.radioButton9.Text = "Структуры";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.Visible = false;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton10.Location = new System.Drawing.Point(1086, 84);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(81, 24);
            this.radioButton10.TabIndex = 5;
            this.radioButton10.Text = "Файлы";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.Visible = false;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton11.Location = new System.Drawing.Point(1086, 114);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(179, 24);
            this.radioButton11.TabIndex = 6;
            this.radioButton11.Text = "Адреса и указатели";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.Visible = false;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton12.Location = new System.Drawing.Point(1086, 144);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(198, 24);
            this.radioButton12.TabIndex = 7;
            this.radioButton12.Text = "Динамическая память";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.Visible = false;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.radioButton12_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(934, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Циклы";
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(934, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Массивы";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(934, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Строки";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(934, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Рекурсия";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(934, 504);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Структуры";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(934, 539);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Файлы";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(934, 571);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Адреса и указатели";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(934, 610);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "Динамическая память";
            this.label10.Visible = false;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(934, 642);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "Итоговый тест";
            this.label11.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(1130, 402);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 26);
            this.textBox1.TabIndex = 38;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(1130, 498);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 26);
            this.textBox2.TabIndex = 39;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(1130, 433);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(208, 26);
            this.textBox3.TabIndex = 40;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(1130, 565);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(208, 26);
            this.textBox4.TabIndex = 41;
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(1130, 465);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(208, 26);
            this.textBox5.TabIndex = 42;
            this.textBox5.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(1130, 636);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(208, 26);
            this.textBox6.TabIndex = 43;
            this.textBox6.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(1130, 533);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(208, 26);
            this.textBox7.TabIndex = 44;
            this.textBox7.Visible = false;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Control;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(1130, 604);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(208, 26);
            this.textBox8.TabIndex = 45;
            this.textBox8.Visible = false;
            // 
            // StudentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton12);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton11);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton10);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.SignNo);
            this.Controls.Add(this.SignOk);
            this.Controls.Add(this.ProgressNo);
            this.Controls.Add(this.ProgressOk);
            this.Controls.Add(this.newProgress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BackToMenu);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.ChangeProgress);
            this.Controls.Add(this.DisplayList);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.NewLogin);
            this.Controls.Add(this.SekondNameStudent);
            this.Controls.Add(this.NameStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteStudent);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudentsList";
            this.Text = "Работа со списком студентов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentsList_FormClosed);
            this.Load += new System.EventHandler(this.StudentsList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button DeleteStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameStudent;
        private System.Windows.Forms.TextBox SekondNameStudent;
        private System.Windows.Forms.TextBox NewLogin;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Button DisplayList;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button ChangeProgress;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.Button BackToMenu;
        private System.Windows.Forms.TextBox newProgress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ProgressOk;
        private System.Windows.Forms.Button ProgressNo;
        private System.Windows.Forms.Button SignOk;
        private System.Windows.Forms.Button SignNo;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
    }
}