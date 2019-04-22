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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Filter = new System.Windows.Forms.Button();
            this.BackToMenu = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.newProgress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProgressOk = new System.Windows.Forms.Button();
            this.ProgressNo = new System.Windows.Forms.Button();
            this.SignOk = new System.Windows.Forms.Button();
            this.SignNo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.Registration.Text = "Регистрация";
            this.Registration.UseVisualStyleBackColor = false;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // DisplayList
            // 
            this.DisplayList.BackColor = System.Drawing.Color.LawnGreen;
            this.DisplayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisplayList.Location = new System.Drawing.Point(1226, 131);
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
            this.radioButton1.Location = new System.Drawing.Point(938, 55);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(139, 24);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "по всем темам";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.PaleGreen;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(938, 84);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(188, 24);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "по конктретной теме";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.Visible = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.PaleGreen;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(938, 114);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(196, 24);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "только итоговый тест";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.Visible = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.PaleGreen;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.Location = new System.Drawing.Point(938, 144);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(191, 24);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.TabStop = true;
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
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.Control;
            this.numericUpDown1.Location = new System.Drawing.Point(1140, 114);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Visible = false;
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
            "По теме динамическая память"});
            this.comboBox1.Location = new System.Drawing.Point(1140, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // newProgress
            // 
            this.newProgress.BackColor = System.Drawing.SystemColors.Control;
            this.newProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newProgress.Location = new System.Drawing.Point(938, 369);
            this.newProgress.Name = "newProgress";
            this.newProgress.Size = new System.Drawing.Size(236, 22);
            this.newProgress.TabIndex = 24;
            this.newProgress.Text = "Новый прогресс";
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
            this.ProgressOk.Location = new System.Drawing.Point(938, 411);
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
            this.ProgressNo.Location = new System.Drawing.Point(1063, 411);
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
            // StudentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.SignNo);
            this.Controls.Add(this.SignOk);
            this.Controls.Add(this.ProgressNo);
            this.Controls.Add(this.ProgressOk);
            this.Controls.Add(this.newProgress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BackToMenu);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ChangeProgress);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.Button BackToMenu;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox newProgress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ProgressOk;
        private System.Windows.Forms.Button ProgressNo;
        private System.Windows.Forms.Button SignOk;
        private System.Windows.Forms.Button SignNo;
    }
}