namespace Окно_практика
{
    partial class Test
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
            this.Question = new System.Windows.Forms.Label();
            this.Answer1 = new System.Windows.Forms.RadioButton();
            this.Answer2 = new System.Windows.Forms.RadioButton();
            this.Answer3 = new System.Windows.Forms.RadioButton();
            this.Answer4 = new System.Windows.Forms.RadioButton();
            this.AnswerIt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Rate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CountMistake = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Numbers = new System.Windows.Forms.Label();
            this.BackToMenu = new System.Windows.Forms.Button();
            this.Dynamic = new System.Windows.Forms.RadioButton();
            this.Pointers = new System.Windows.Forms.RadioButton();
            this.Files = new System.Windows.Forms.RadioButton();
            this.Structs = new System.Windows.Forms.RadioButton();
            this.Recursion = new System.Windows.Forms.RadioButton();
            this.Strings = new System.Windows.Forms.RadioButton();
            this.Arrays = new System.Windows.Forms.RadioButton();
            this.Cycles = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question.Location = new System.Drawing.Point(16, 11);
            this.Question.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(1759, 600);
            this.Question.TabIndex = 0;
            this.Question.Click += new System.EventHandler(this.Question_Click);
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer1.Location = new System.Drawing.Point(109, 291);
            this.Answer1.Margin = new System.Windows.Forms.Padding(4);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(138, 36);
            this.Answer1.TabIndex = 1;
            this.Answer1.Text = "Ответ 1";
            this.Answer1.UseVisualStyleBackColor = false;
            this.Answer1.Visible = false;
            this.Answer1.CheckedChanged += new System.EventHandler(this.Answer1_CheckedChanged);
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer2.Location = new System.Drawing.Point(109, 416);
            this.Answer2.Margin = new System.Windows.Forms.Padding(4);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(138, 36);
            this.Answer2.TabIndex = 2;
            this.Answer2.Text = "Ответ 2";
            this.Answer2.UseVisualStyleBackColor = false;
            this.Answer2.Visible = false;
            // 
            // Answer3
            // 
            this.Answer3.AutoSize = true;
            this.Answer3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer3.Location = new System.Drawing.Point(109, 547);
            this.Answer3.Margin = new System.Windows.Forms.Padding(4);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(138, 36);
            this.Answer3.TabIndex = 3;
            this.Answer3.Text = "Ответ 3";
            this.Answer3.UseVisualStyleBackColor = false;
            this.Answer3.Visible = false;
            // 
            // Answer4
            // 
            this.Answer4.AutoSize = true;
            this.Answer4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Answer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer4.Location = new System.Drawing.Point(109, 680);
            this.Answer4.Margin = new System.Windows.Forms.Padding(4);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(138, 36);
            this.Answer4.TabIndex = 4;
            this.Answer4.Text = "Ответ 4";
            this.Answer4.UseVisualStyleBackColor = false;
            this.Answer4.Visible = false;
            // 
            // AnswerIt
            // 
            this.AnswerIt.BackColor = System.Drawing.SystemColors.Highlight;
            this.AnswerIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerIt.Location = new System.Drawing.Point(109, 889);
            this.AnswerIt.Margin = new System.Windows.Forms.Padding(4);
            this.AnswerIt.Name = "AnswerIt";
            this.AnswerIt.Size = new System.Drawing.Size(267, 78);
            this.AnswerIt.TabIndex = 5;
            this.AnswerIt.Text = "Подтвердить ответ";
            this.AnswerIt.UseVisualStyleBackColor = false;
            this.AnswerIt.Visible = false;
            this.AnswerIt.Click += new System.EventHandler(this.AnswerIt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(84, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Оценка за тест:";
            this.label2.Visible = false;
            // 
            // Rate
            // 
            this.Rate.AutoSize = true;
            this.Rate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rate.Location = new System.Drawing.Point(360, 60);
            this.Rate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(35, 38);
            this.Rate.TabIndex = 7;
            this.Rate.Text = "0";
            this.Rate.Visible = false;
            this.Rate.Click += new System.EventHandler(this.Rate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(84, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Количество ошибок:";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CountMistake
            // 
            this.CountMistake.AutoSize = true;
            this.CountMistake.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CountMistake.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountMistake.Location = new System.Drawing.Point(448, 124);
            this.CountMistake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CountMistake.Name = "CountMistake";
            this.CountMistake.Size = new System.Drawing.Size(35, 38);
            this.CountMistake.TabIndex = 9;
            this.CountMistake.Text = "0";
            this.CountMistake.Visible = false;
            this.CountMistake.Click += new System.EventHandler(this.CountMistake_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(84, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(696, 38);
            this.label5.TabIndex = 10;
            this.label5.Text = "Номера неправильно отвеченных вопросов:\r\n";
            this.label5.Visible = false;
            // 
            // Numbers
            // 
            this.Numbers.AutoSize = true;
            this.Numbers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Numbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Numbers.Location = new System.Drawing.Point(84, 248);
            this.Numbers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Numbers.MinimumSize = new System.Drawing.Size(800, 0);
            this.Numbers.Name = "Numbers";
            this.Numbers.Size = new System.Drawing.Size(800, 38);
            this.Numbers.TabIndex = 11;
            this.Numbers.Text = "0";
            this.Numbers.Visible = false;
            this.Numbers.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // BackToMenu
            // 
            this.BackToMenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackToMenu.Location = new System.Drawing.Point(1824, 885);
            this.BackToMenu.Margin = new System.Windows.Forms.Padding(4);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(193, 82);
            this.BackToMenu.TabIndex = 12;
            this.BackToMenu.Text = "Назад в меню";
            this.BackToMenu.UseVisualStyleBackColor = false;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // Dynamic
            // 
            this.Dynamic.AutoSize = true;
            this.Dynamic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dynamic.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dynamic.Location = new System.Drawing.Point(1109, 460);
            this.Dynamic.Margin = new System.Windows.Forms.Padding(4);
            this.Dynamic.Name = "Dynamic";
            this.Dynamic.Size = new System.Drawing.Size(385, 42);
            this.Dynamic.TabIndex = 33;
            this.Dynamic.Text = "Динамическая память";
            this.Dynamic.UseVisualStyleBackColor = false;
            this.Dynamic.CheckedChanged += new System.EventHandler(this.Dynamic_CheckedChanged);
            // 
            // Pointers
            // 
            this.Pointers.AutoSize = true;
            this.Pointers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pointers.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pointers.Location = new System.Drawing.Point(1109, 409);
            this.Pointers.Margin = new System.Windows.Forms.Padding(4);
            this.Pointers.Name = "Pointers";
            this.Pointers.Size = new System.Drawing.Size(343, 42);
            this.Pointers.TabIndex = 32;
            this.Pointers.Text = "Адреса и указатели";
            this.Pointers.UseVisualStyleBackColor = false;
            this.Pointers.CheckedChanged += new System.EventHandler(this.Pointers_CheckedChanged);
            // 
            // Files
            // 
            this.Files.AutoSize = true;
            this.Files.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Files.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Files.Location = new System.Drawing.Point(1109, 358);
            this.Files.Margin = new System.Windows.Forms.Padding(4);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(145, 42);
            this.Files.TabIndex = 31;
            this.Files.Text = "Файлы";
            this.Files.UseVisualStyleBackColor = false;
            this.Files.CheckedChanged += new System.EventHandler(this.Files_CheckedChanged);
            // 
            // Structs
            // 
            this.Structs.AutoSize = true;
            this.Structs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Structs.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Structs.Location = new System.Drawing.Point(1109, 307);
            this.Structs.Margin = new System.Windows.Forms.Padding(4);
            this.Structs.Name = "Structs";
            this.Structs.Size = new System.Drawing.Size(203, 42);
            this.Structs.TabIndex = 30;
            this.Structs.Text = "Структуры";
            this.Structs.UseVisualStyleBackColor = false;
            this.Structs.CheckedChanged += new System.EventHandler(this.Structs_CheckedChanged);
            // 
            // Recursion
            // 
            this.Recursion.AutoSize = true;
            this.Recursion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Recursion.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Recursion.Location = new System.Drawing.Point(1109, 256);
            this.Recursion.Margin = new System.Windows.Forms.Padding(4);
            this.Recursion.Name = "Recursion";
            this.Recursion.Size = new System.Drawing.Size(183, 42);
            this.Recursion.TabIndex = 29;
            this.Recursion.Text = "Рекурсия";
            this.Recursion.UseVisualStyleBackColor = false;
            this.Recursion.CheckedChanged += new System.EventHandler(this.Recursion_CheckedChanged);
            // 
            // Strings
            // 
            this.Strings.AutoSize = true;
            this.Strings.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Strings.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Strings.Location = new System.Drawing.Point(1109, 205);
            this.Strings.Margin = new System.Windows.Forms.Padding(4);
            this.Strings.Name = "Strings";
            this.Strings.Size = new System.Drawing.Size(148, 42);
            this.Strings.TabIndex = 28;
            this.Strings.Text = "Строки";
            this.Strings.UseVisualStyleBackColor = false;
            this.Strings.CheckedChanged += new System.EventHandler(this.Strings_CheckedChanged);
            // 
            // Arrays
            // 
            this.Arrays.AutoSize = true;
            this.Arrays.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Arrays.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Arrays.Location = new System.Drawing.Point(1109, 154);
            this.Arrays.Margin = new System.Windows.Forms.Padding(4);
            this.Arrays.Name = "Arrays";
            this.Arrays.Size = new System.Drawing.Size(611, 42);
            this.Arrays.TabIndex = 27;
            this.Arrays.Text = "Массивы (одномерные и двумерные)";
            this.Arrays.UseVisualStyleBackColor = false;
            this.Arrays.CheckedChanged += new System.EventHandler(this.Arrays_CheckedChanged);
            // 
            // Cycles
            // 
            this.Cycles.AutoSize = true;
            this.Cycles.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cycles.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cycles.Location = new System.Drawing.Point(1109, 103);
            this.Cycles.Margin = new System.Windows.Forms.Padding(4);
            this.Cycles.Name = "Cycles";
            this.Cycles.Size = new System.Drawing.Size(141, 42);
            this.Cycles.TabIndex = 26;
            this.Cycles.Text = "Циклы";
            this.Cycles.UseVisualStyleBackColor = false;
            this.Cycles.CheckedChanged += new System.EventHandler(this.Cycles_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1109, 511);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 52);
            this.button2.TabIndex = 25;
            this.button2.Text = "Выбрать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1102, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 49);
            this.label3.TabIndex = 24;
            this.label3.Text = "Темы:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1800, 1055);
            this.Controls.Add(this.Dynamic);
            this.Controls.Add(this.Pointers);
            this.Controls.Add(this.Files);
            this.Controls.Add(this.Structs);
            this.Controls.Add(this.Recursion);
            this.Controls.Add(this.Strings);
            this.Controls.Add(this.Arrays);
            this.Controls.Add(this.Cycles);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BackToMenu);
            this.Controls.Add(this.Numbers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CountMistake);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnswerIt);
            this.Controls.Add(this.Answer4);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.Answer1);
            this.Controls.Add(this.Question);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Test";
            this.Text = "Тестирование по теме";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Test_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.RadioButton Answer1;
        private System.Windows.Forms.RadioButton Answer2;
        private System.Windows.Forms.RadioButton Answer3;
        private System.Windows.Forms.RadioButton Answer4;
        private System.Windows.Forms.Button AnswerIt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Rate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CountMistake;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Numbers;
        private System.Windows.Forms.Button BackToMenu;
        private System.Windows.Forms.RadioButton Dynamic;
        private System.Windows.Forms.RadioButton Pointers;
        private System.Windows.Forms.RadioButton Files;
        private System.Windows.Forms.RadioButton Structs;
        private System.Windows.Forms.RadioButton Recursion;
        private System.Windows.Forms.RadioButton Strings;
        private System.Windows.Forms.RadioButton Arrays;
        private System.Windows.Forms.RadioButton Cycles;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}