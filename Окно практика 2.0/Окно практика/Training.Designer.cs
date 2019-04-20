namespace Окно_практика
{
    partial class Training
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
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.Question = new System.Windows.Forms.Label();
			this.Answer1 = new System.Windows.Forms.RadioButton();
			this.Answer3 = new System.Windows.Forms.RadioButton();
			this.Answer2 = new System.Windows.Forms.RadioButton();
			this.Answer4 = new System.Windows.Forms.RadioButton();
			this.button2 = new System.Windows.Forms.Button();
			this.Cycles = new System.Windows.Forms.RadioButton();
			this.Arrays = new System.Windows.Forms.RadioButton();
			this.Strings = new System.Windows.Forms.RadioButton();
			this.Recursion = new System.Windows.Forms.RadioButton();
			this.Structs = new System.Windows.Forms.RadioButton();
			this.Files = new System.Windows.Forms.RadioButton();
			this.Pointers = new System.Windows.Forms.RadioButton();
			this.Dynamic = new System.Windows.Forms.RadioButton();
			this.BackToMenu = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(24, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(174, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Выберите тему";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Highlight;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(27, 415);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(205, 42);
			this.button1.TabIndex = 9;
			this.button1.Text = "Выбрать";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Question
			// 
			this.Question.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Question.Location = new System.Drawing.Point(398, 62);
			this.Question.Name = "Question";
			this.Question.Size = new System.Drawing.Size(930, 367);
			this.Question.TabIndex = 10;
			this.Question.Text = "Вопрос по теме";
			// 
			// Answer1
			// 
			this.Answer1.AutoSize = true;
			this.Answer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Answer1.Location = new System.Drawing.Point(591, 445);
			this.Answer1.Name = "Answer1";
			this.Answer1.Size = new System.Drawing.Size(100, 28);
			this.Answer1.TabIndex = 11;
			this.Answer1.TabStop = true;
			this.Answer1.Text = "Ответ 1";
			this.Answer1.UseVisualStyleBackColor = false;
			// 
			// Answer3
			// 
			this.Answer3.AutoSize = true;
			this.Answer3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Answer3.Location = new System.Drawing.Point(591, 537);
			this.Answer3.Name = "Answer3";
			this.Answer3.Size = new System.Drawing.Size(100, 28);
			this.Answer3.TabIndex = 12;
			this.Answer3.TabStop = true;
			this.Answer3.Text = "Ответ 3";
			this.Answer3.UseVisualStyleBackColor = false;
			// 
			// Answer2
			// 
			this.Answer2.AutoSize = true;
			this.Answer2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Answer2.Location = new System.Drawing.Point(591, 493);
			this.Answer2.Name = "Answer2";
			this.Answer2.Size = new System.Drawing.Size(100, 28);
			this.Answer2.TabIndex = 13;
			this.Answer2.TabStop = true;
			this.Answer2.Text = "Ответ 2";
			this.Answer2.UseVisualStyleBackColor = false;
			// 
			// Answer4
			// 
			this.Answer4.AutoSize = true;
			this.Answer4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Answer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Answer4.Location = new System.Drawing.Point(591, 580);
			this.Answer4.Name = "Answer4";
			this.Answer4.Size = new System.Drawing.Size(100, 28);
			this.Answer4.TabIndex = 14;
			this.Answer4.TabStop = true;
			this.Answer4.Text = "Ответ 4";
			this.Answer4.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.Highlight;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(571, 632);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(216, 58);
			this.button2.TabIndex = 15;
			this.button2.Text = "Подтвердить ответ";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Cycles
			// 
			this.Cycles.AutoSize = true;
			this.Cycles.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Cycles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Cycles.Location = new System.Drawing.Point(28, 119);
			this.Cycles.Name = "Cycles";
			this.Cycles.Size = new System.Drawing.Size(83, 28);
			this.Cycles.TabIndex = 16;
			this.Cycles.TabStop = true;
			this.Cycles.Text = "Циклы";
			this.Cycles.UseVisualStyleBackColor = false;
			// 
			// Arrays
			// 
			this.Arrays.AutoSize = true;
			this.Arrays.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Arrays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Arrays.Location = new System.Drawing.Point(28, 151);
			this.Arrays.Name = "Arrays";
			this.Arrays.Size = new System.Drawing.Size(364, 28);
			this.Arrays.TabIndex = 17;
			this.Arrays.TabStop = true;
			this.Arrays.Text = "Массивы (одномерные и двумерные)";
			this.Arrays.UseVisualStyleBackColor = false;
			// 
			// Strings
			// 
			this.Strings.AutoSize = true;
			this.Strings.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Strings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Strings.Location = new System.Drawing.Point(27, 185);
			this.Strings.Name = "Strings";
			this.Strings.Size = new System.Drawing.Size(93, 28);
			this.Strings.TabIndex = 18;
			this.Strings.TabStop = true;
			this.Strings.Text = "Строки";
			this.Strings.UseVisualStyleBackColor = false;
			// 
			// Recursion
			// 
			this.Recursion.AutoSize = true;
			this.Recursion.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Recursion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Recursion.Location = new System.Drawing.Point(28, 219);
			this.Recursion.Name = "Recursion";
			this.Recursion.Size = new System.Drawing.Size(111, 28);
			this.Recursion.TabIndex = 19;
			this.Recursion.TabStop = true;
			this.Recursion.Text = "Рекурсия";
			this.Recursion.UseVisualStyleBackColor = false;
			// 
			// Structs
			// 
			this.Structs.AutoSize = true;
			this.Structs.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Structs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Structs.Location = new System.Drawing.Point(28, 253);
			this.Structs.Name = "Structs";
			this.Structs.Size = new System.Drawing.Size(123, 28);
			this.Structs.TabIndex = 20;
			this.Structs.TabStop = true;
			this.Structs.Text = "Структуры";
			this.Structs.UseVisualStyleBackColor = false;
			// 
			// Files
			// 
			this.Files.AutoSize = true;
			this.Files.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Files.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Files.Location = new System.Drawing.Point(29, 287);
			this.Files.Name = "Files";
			this.Files.Size = new System.Drawing.Size(88, 28);
			this.Files.TabIndex = 21;
			this.Files.TabStop = true;
			this.Files.Text = "Файлы";
			this.Files.UseVisualStyleBackColor = false;
			// 
			// Pointers
			// 
			this.Pointers.AutoSize = true;
			this.Pointers.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Pointers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Pointers.Location = new System.Drawing.Point(27, 320);
			this.Pointers.Name = "Pointers";
			this.Pointers.Size = new System.Drawing.Size(206, 28);
			this.Pointers.TabIndex = 22;
			this.Pointers.TabStop = true;
			this.Pointers.Text = "Адреса и указатели";
			this.Pointers.UseVisualStyleBackColor = false;
			// 
			// Dynamic
			// 
			this.Dynamic.AutoSize = true;
			this.Dynamic.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Dynamic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Dynamic.Location = new System.Drawing.Point(27, 359);
			this.Dynamic.Name = "Dynamic";
			this.Dynamic.Size = new System.Drawing.Size(228, 28);
			this.Dynamic.TabIndex = 23;
			this.Dynamic.TabStop = true;
			this.Dynamic.Text = "Динамическая память";
			this.Dynamic.UseVisualStyleBackColor = false;
			// 
			// BackToMenu
			// 
			this.BackToMenu.BackColor = System.Drawing.SystemColors.Highlight;
			this.BackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BackToMenu.Location = new System.Drawing.Point(29, 645);
			this.BackToMenu.Name = "BackToMenu";
			this.BackToMenu.Size = new System.Drawing.Size(152, 63);
			this.BackToMenu.TabIndex = 26;
			this.BackToMenu.Text = "Назад в меню";
			this.BackToMenu.UseVisualStyleBackColor = false;
			this.BackToMenu.Click += new System.EventHandler(this.button3_Click);
			// 
			// Training
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1350, 729);
			this.Controls.Add(this.BackToMenu);
			this.Controls.Add(this.Dynamic);
			this.Controls.Add(this.Pointers);
			this.Controls.Add(this.Files);
			this.Controls.Add(this.Structs);
			this.Controls.Add(this.Recursion);
			this.Controls.Add(this.Strings);
			this.Controls.Add(this.Arrays);
			this.Controls.Add(this.Cycles);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.Answer4);
			this.Controls.Add(this.Answer2);
			this.Controls.Add(this.Answer3);
			this.Controls.Add(this.Answer1);
			this.Controls.Add(this.Question);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Training";
			this.Text = "Тренинг по теме";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Training_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.RadioButton Answer1;
        private System.Windows.Forms.RadioButton Answer3;
        private System.Windows.Forms.RadioButton Answer2;
        private System.Windows.Forms.RadioButton Answer4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton Cycles;
        private System.Windows.Forms.RadioButton Arrays;
        private System.Windows.Forms.RadioButton Strings;
        private System.Windows.Forms.RadioButton Recursion;
        private System.Windows.Forms.RadioButton Structs;
        private System.Windows.Forms.RadioButton Files;
        private System.Windows.Forms.RadioButton Pointers;
        private System.Windows.Forms.RadioButton Dynamic;
        private System.Windows.Forms.Button BackToMenu;
    }
}