namespace Окно_практика
{
    partial class TeacherMenu
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
            this.editing = new System.Windows.Forms.Button();
            this.listStudent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(546, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите действие";
            // 
            // editing
            // 
            this.editing.BackColor = System.Drawing.Color.LawnGreen;
            this.editing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editing.Location = new System.Drawing.Point(536, 275);
            this.editing.Name = "editing";
            this.editing.Size = new System.Drawing.Size(271, 102);
            this.editing.TabIndex = 1;
            this.editing.Text = "Редактирование вопросов";
            this.editing.UseVisualStyleBackColor = false;
            this.editing.Click += new System.EventHandler(this.editing_Click);
            // 
            // listStudent
            // 
            this.listStudent.BackColor = System.Drawing.Color.LawnGreen;
            this.listStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listStudent.Location = new System.Drawing.Point(536, 414);
            this.listStudent.Name = "listStudent";
            this.listStudent.Size = new System.Drawing.Size(271, 102);
            this.listStudent.TabIndex = 2;
            this.listStudent.Text = "Работа со списком студентов";
            this.listStudent.UseVisualStyleBackColor = false;
            this.listStudent.Click += new System.EventHandler(this.listStudent_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 653);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "Назад в авторизацию";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TeacherMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listStudent);
            this.Controls.Add(this.editing);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TeacherMenu";
            this.Text = "Меню преподавателя";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editing;
        private System.Windows.Forms.Button listStudent;
        private System.Windows.Forms.Button button1;
    }
}