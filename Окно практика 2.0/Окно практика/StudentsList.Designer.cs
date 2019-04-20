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
            this.label2 = new System.Windows.Forms.Label();
            this.NameStudent = new System.Windows.Forms.TextBox();
            this.SekondNameStudent = new System.Windows.Forms.TextBox();
            this.NewLogin = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.Registration = new System.Windows.Forms.Button();
            this.DisplayList = new System.Windows.Forms.Button();
            this.RateList = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.ChangeProgress = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Filter = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.BackToMenu = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.newProgress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Студент 1",
            "Студент 2",
            "..."});
            this.listBox1.Location = new System.Drawing.Point(13, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 559);
            this.listBox1.TabIndex = 1;
            // 
            // DeleteStudent
            // 
            this.DeleteStudent.BackColor = System.Drawing.Color.LawnGreen;
            this.DeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteStudent.Location = new System.Drawing.Point(224, 79);
            this.DeleteStudent.Name = "DeleteStudent";
            this.DeleteStudent.Size = new System.Drawing.Size(160, 37);
            this.DeleteStudent.TabIndex = 2;
            this.DeleteStudent.Text = "Удалить студента";
            this.DeleteStudent.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Удаление студентов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(539, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Регистрация студентов";
            // 
            // NameStudent
            // 
            this.NameStudent.BackColor = System.Drawing.SystemColors.Control;
            this.NameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameStudent.Location = new System.Drawing.Point(540, 87);
            this.NameStudent.Name = "NameStudent";
            this.NameStudent.Size = new System.Drawing.Size(182, 22);
            this.NameStudent.TabIndex = 5;
            this.NameStudent.Text = "Имя студента";
            this.NameStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SekondNameStudent
            // 
            this.SekondNameStudent.BackColor = System.Drawing.SystemColors.Control;
            this.SekondNameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SekondNameStudent.Location = new System.Drawing.Point(540, 145);
            this.SekondNameStudent.Name = "SekondNameStudent";
            this.SekondNameStudent.Size = new System.Drawing.Size(181, 22);
            this.SekondNameStudent.TabIndex = 6;
            this.SekondNameStudent.Text = "Фамилия студента";
            this.SekondNameStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewLogin
            // 
            this.NewLogin.BackColor = System.Drawing.SystemColors.Control;
            this.NewLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewLogin.Location = new System.Drawing.Point(543, 201);
            this.NewLogin.Name = "NewLogin";
            this.NewLogin.Size = new System.Drawing.Size(181, 22);
            this.NewLogin.TabIndex = 7;
            this.NewLogin.Text = "Логин нового студента";
            this.NewLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newPassword
            // 
            this.newPassword.BackColor = System.Drawing.SystemColors.Control;
            this.newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPassword.Location = new System.Drawing.Point(541, 263);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(183, 22);
            this.newPassword.TabIndex = 8;
            this.newPassword.Text = "Пароль нового студента";
            this.newPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Registration
            // 
            this.Registration.BackColor = System.Drawing.Color.LawnGreen;
            this.Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration.Location = new System.Drawing.Point(540, 328);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(182, 31);
            this.Registration.TabIndex = 9;
            this.Registration.Text = "Регистрация";
            this.Registration.UseVisualStyleBackColor = false;
            // 
            // DisplayList
            // 
            this.DisplayList.BackColor = System.Drawing.Color.LawnGreen;
            this.DisplayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisplayList.Location = new System.Drawing.Point(884, 31);
            this.DisplayList.Name = "DisplayList";
            this.DisplayList.Size = new System.Drawing.Size(229, 37);
            this.DisplayList.TabIndex = 10;
            this.DisplayList.Text = "Вывести список студентов с оценками";
            this.DisplayList.UseVisualStyleBackColor = false;
            this.DisplayList.Click += new System.EventHandler(this.DisplayList_Click);
            // 
            // RateList
            // 
            this.RateList.BackColor = System.Drawing.Color.PaleGreen;
            this.RateList.FormattingEnabled = true;
            this.RateList.Items.AddRange(new object[] {
            "Студент 1 - оценка",
            "Студент 2 - нет оценок",
            "..."});
            this.RateList.Location = new System.Drawing.Point(1034, 250);
            this.RateList.Name = "RateList";
            this.RateList.Size = new System.Drawing.Size(291, 459);
            this.RateList.TabIndex = 11;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.PaleGreen;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(1034, 101);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(139, 24);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "по всем темам";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.PaleGreen;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(1034, 131);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(188, 24);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "по конктретной теме";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.PaleGreen;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(1034, 161);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(196, 24);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "только итоговый тест";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.PaleGreen;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.Location = new System.Drawing.Point(1034, 191);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(191, 24);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "только средний балл";
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // ChangeProgress
            // 
            this.ChangeProgress.BackColor = System.Drawing.Color.LawnGreen;
            this.ChangeProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeProgress.Location = new System.Drawing.Point(565, 401);
            this.ChangeProgress.Name = "ChangeProgress";
            this.ChangeProgress.Size = new System.Drawing.Size(203, 45);
            this.ChangeProgress.TabIndex = 16;
            this.ChangeProgress.Text = "Изменить прогресс студентов";
            this.ChangeProgress.UseVisualStyleBackColor = false;
            this.ChangeProgress.Click += new System.EventHandler(this.ChangeProgress_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.Control;
            this.numericUpDown1.Location = new System.Drawing.Point(816, 179);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(194, 20);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Filter
            // 
            this.Filter.BackColor = System.Drawing.Color.LawnGreen;
            this.Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Filter.Location = new System.Drawing.Point(817, 101);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(193, 52);
            this.Filter.TabIndex = 18;
            this.Filter.Text = "Фильтровать вывод по оценкам";
            this.Filter.UseVisualStyleBackColor = false;
            // 
            // Sort
            // 
            this.Sort.BackColor = System.Drawing.Color.LawnGreen;
            this.Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sort.Location = new System.Drawing.Point(816, 221);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(194, 50);
            this.Sort.TabIndex = 19;
            this.Sort.Text = "Сортировка по оценкам";
            this.Sort.UseVisualStyleBackColor = false;
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
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "По теме циклы",
            "По теме массивы",
            "По теме строки",
            "По теме рекурсия",
            "По теме структуры",
            "По теме файлы",
            "По теме адреса и указатели",
            "По теме динамическая память",
            "По итоговому тесту",
            "По среднему баллу"});
            this.comboBox1.Location = new System.Drawing.Point(816, 283);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.PaleGreen;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Студент 1: оценки",
            "Студент 2: оценки",
            "..."});
            this.listBox2.Location = new System.Drawing.Point(261, 401);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(282, 316);
            this.listBox2.TabIndex = 22;
            // 
            // newProgress
            // 
            this.newProgress.BackColor = System.Drawing.SystemColors.Control;
            this.newProgress.Location = new System.Drawing.Point(565, 539);
            this.newProgress.Name = "newProgress";
            this.newProgress.Size = new System.Drawing.Size(244, 20);
            this.newProgress.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(569, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Введите новый прогресс";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // StudentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.newProgress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BackToMenu);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ChangeProgress);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.RateList);
            this.Controls.Add(this.DisplayList);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.NewLogin);
            this.Controls.Add(this.SekondNameStudent);
            this.Controls.Add(this.NameStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteStudent);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudentsList";
            this.Text = "Работа со списком студентов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentsList_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button DeleteStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameStudent;
        private System.Windows.Forms.TextBox SekondNameStudent;
        private System.Windows.Forms.TextBox NewLogin;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Button DisplayList;
        private System.Windows.Forms.ListBox RateList;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button ChangeProgress;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Button BackToMenu;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox newProgress;
        private System.Windows.Forms.Label label3;
    }
}