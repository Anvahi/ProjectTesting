namespace Окно_практика
{
    partial class Меню_для_студента
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
            this.buttonTraining = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonFinalTest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(502, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите действие";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTraining
            // 
            this.buttonTraining.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTraining.Location = new System.Drawing.Point(496, 297);
            this.buttonTraining.Name = "buttonTraining";
            this.buttonTraining.Size = new System.Drawing.Size(348, 58);
            this.buttonTraining.TabIndex = 1;
            this.buttonTraining.Text = "Тренинг по теме";
            this.buttonTraining.UseVisualStyleBackColor = false;
            this.buttonTraining.Click += new System.EventHandler(this.Training_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTest.Location = new System.Drawing.Point(496, 388);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(348, 57);
            this.buttonTest.TabIndex = 2;
            this.buttonTest.Text = "Тестирование по теме";
            this.buttonTest.UseVisualStyleBackColor = false;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonFinalTest
            // 
            this.buttonFinalTest.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonFinalTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFinalTest.Location = new System.Drawing.Point(496, 486);
            this.buttonFinalTest.Name = "buttonFinalTest";
            this.buttonFinalTest.Size = new System.Drawing.Size(348, 57);
            this.buttonFinalTest.TabIndex = 3;
            this.buttonFinalTest.Text = "Итоговый тест";
            this.buttonFinalTest.UseVisualStyleBackColor = false;
            this.buttonFinalTest.Click += new System.EventHandler(this.buttonFinalTest_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 653);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "Назад в авторизацию";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Меню_для_студента
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonFinalTest);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonTraining);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Меню_для_студента";
            this.Text = "Меню для студента";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Меню_для_студента_FormClosed);
            this.Load += new System.EventHandler(this.Меню_для_студента_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTraining;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button buttonFinalTest;
        private System.Windows.Forms.Button button1;
    }
}