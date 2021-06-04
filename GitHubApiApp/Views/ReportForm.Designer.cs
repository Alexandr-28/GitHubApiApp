
namespace GitHubApiApp.Views
{
    partial class ReportForm
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
            this.student = new System.Windows.Forms.TextBox();
            this.lbStudent = new System.Windows.Forms.Label();
            this.lbTeacher = new System.Windows.Forms.Label();
            this.teacher = new System.Windows.Forms.TextBox();
            this.lbCathedra = new System.Windows.Forms.Label();
            this.cathedra = new System.Windows.Forms.TextBox();
            this.lbSubject = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.TextBox();
            this.lbTheme = new System.Windows.Forms.Label();
            this.theme = new System.Windows.Forms.TextBox();
            this.lbGroup = new System.Windows.Forms.Label();
            this.group = new System.Windows.Forms.TextBox();
            this.purpose = new System.Windows.Forms.RichTextBox();
            this.lbPurpose = new System.Windows.Forms.Label();
            this.lbTask = new System.Windows.Forms.Label();
            this.task = new System.Windows.Forms.RichTextBox();
            this.lbConclusion = new System.Windows.Forms.Label();
            this.conclusion = new System.Windows.Forms.RichTextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // student
            // 
            this.student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.student.ForeColor = System.Drawing.SystemColors.Window;
            this.student.Location = new System.Drawing.Point(121, 22);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(152, 20);
            this.student.TabIndex = 0;
            // 
            // lbStudent
            // 
            this.lbStudent.AutoSize = true;
            this.lbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbStudent.Location = new System.Drawing.Point(28, 22);
            this.lbStudent.Name = "lbStudent";
            this.lbStudent.Size = new System.Drawing.Size(87, 20);
            this.lbStudent.TabIndex = 1;
            this.lbStudent.Text = "Выполнил";
            // 
            // lbTeacher
            // 
            this.lbTeacher.AutoSize = true;
            this.lbTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTeacher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTeacher.Location = new System.Drawing.Point(28, 74);
            this.lbTeacher.Name = "lbTeacher";
            this.lbTeacher.Size = new System.Drawing.Size(85, 20);
            this.lbTeacher.TabIndex = 2;
            this.lbTeacher.Text = "Проверил";
            // 
            // teacher
            // 
            this.teacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.teacher.ForeColor = System.Drawing.SystemColors.Window;
            this.teacher.Location = new System.Drawing.Point(121, 74);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(152, 20);
            this.teacher.TabIndex = 3;
            // 
            // lbCathedra
            // 
            this.lbCathedra.AutoSize = true;
            this.lbCathedra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCathedra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCathedra.Location = new System.Drawing.Point(289, 22);
            this.lbCathedra.Name = "lbCathedra";
            this.lbCathedra.Size = new System.Drawing.Size(81, 20);
            this.lbCathedra.TabIndex = 4;
            this.lbCathedra.Text = "Кафедра";
            // 
            // cathedra
            // 
            this.cathedra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))));
            this.cathedra.ForeColor = System.Drawing.SystemColors.Window;
            this.cathedra.Location = new System.Drawing.Point(376, 24);
            this.cathedra.Name = "cathedra";
            this.cathedra.Size = new System.Drawing.Size(152, 20);
            this.cathedra.TabIndex = 5;
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSubject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSubject.Location = new System.Drawing.Point(291, 48);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(79, 20);
            this.lbSubject.TabIndex = 6;
            this.lbSubject.Text = "Предмет";
            // 
            // subject
            // 
            this.subject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))));
            this.subject.ForeColor = System.Drawing.SystemColors.Window;
            this.subject.Location = new System.Drawing.Point(376, 50);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(152, 20);
            this.subject.TabIndex = 7;
            // 
            // lbTheme
            // 
            this.lbTheme.AutoSize = true;
            this.lbTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTheme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTheme.Location = new System.Drawing.Point(291, 74);
            this.lbTheme.Name = "lbTheme";
            this.lbTheme.Size = new System.Drawing.Size(47, 20);
            this.lbTheme.TabIndex = 8;
            this.lbTheme.Text = "Тема";
            // 
            // theme
            // 
            this.theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))));
            this.theme.ForeColor = System.Drawing.SystemColors.Window;
            this.theme.Location = new System.Drawing.Point(376, 76);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(152, 20);
            this.theme.TabIndex = 9;
            // 
            // lbGroup
            // 
            this.lbGroup.AutoSize = true;
            this.lbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGroup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbGroup.Location = new System.Drawing.Point(28, 48);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(61, 20);
            this.lbGroup.TabIndex = 10;
            this.lbGroup.Text = "Группа";
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.group.ForeColor = System.Drawing.SystemColors.Window;
            this.group.Location = new System.Drawing.Point(121, 48);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(152, 20);
            this.group.TabIndex = 11;
            // 
            // purpose
            // 
            this.purpose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))));
            this.purpose.ForeColor = System.Drawing.SystemColors.Window;
            this.purpose.Location = new System.Drawing.Point(32, 131);
            this.purpose.Name = "purpose";
            this.purpose.Size = new System.Drawing.Size(496, 96);
            this.purpose.TabIndex = 12;
            this.purpose.Text = "";
            // 
            // lbPurpose
            // 
            this.lbPurpose.AutoSize = true;
            this.lbPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPurpose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPurpose.Location = new System.Drawing.Point(28, 108);
            this.lbPurpose.Name = "lbPurpose";
            this.lbPurpose.Size = new System.Drawing.Size(109, 20);
            this.lbPurpose.TabIndex = 13;
            this.lbPurpose.Text = "Цель работы";
            // 
            // lbTask
            // 
            this.lbTask.AutoSize = true;
            this.lbTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTask.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTask.Location = new System.Drawing.Point(28, 230);
            this.lbTask.Name = "lbTask";
            this.lbTask.Size = new System.Drawing.Size(76, 20);
            this.lbTask.TabIndex = 14;
            this.lbTask.Text = "Задание";
            // 
            // task
            // 
            this.task.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))));
            this.task.ForeColor = System.Drawing.SystemColors.Window;
            this.task.Location = new System.Drawing.Point(32, 253);
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(496, 96);
            this.task.TabIndex = 15;
            this.task.Text = "";
            // 
            // lbConclusion
            // 
            this.lbConclusion.AutoSize = true;
            this.lbConclusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbConclusion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbConclusion.Location = new System.Drawing.Point(28, 352);
            this.lbConclusion.Name = "lbConclusion";
            this.lbConclusion.Size = new System.Drawing.Size(60, 20);
            this.lbConclusion.TabIndex = 16;
            this.lbConclusion.Text = "Вывод";
            // 
            // conclusion
            // 
            this.conclusion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))));
            this.conclusion.ForeColor = System.Drawing.SystemColors.Window;
            this.conclusion.Location = new System.Drawing.Point(32, 375);
            this.conclusion.Name = "conclusion";
            this.conclusion.Size = new System.Drawing.Size(495, 96);
            this.conclusion.TabIndex = 17;
            this.conclusion.Text = "";
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.GreenYellow;
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSave.Location = new System.Drawing.Point(32, 478);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(496, 31);
            this.btSave.TabIndex = 18;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(561, 514);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.conclusion);
            this.Controls.Add(this.lbConclusion);
            this.Controls.Add(this.task);
            this.Controls.Add(this.lbTask);
            this.Controls.Add(this.lbPurpose);
            this.Controls.Add(this.purpose);
            this.Controls.Add(this.group);
            this.Controls.Add(this.lbGroup);
            this.Controls.Add(this.theme);
            this.Controls.Add(this.lbTheme);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.cathedra);
            this.Controls.Add(this.lbCathedra);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.lbTeacher);
            this.Controls.Add(this.lbStudent);
            this.Controls.Add(this.student);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox student;
        private System.Windows.Forms.Label lbStudent;
        private System.Windows.Forms.Label lbTeacher;
        private System.Windows.Forms.TextBox teacher;
        private System.Windows.Forms.Label lbCathedra;
        private System.Windows.Forms.TextBox cathedra;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.Label lbTheme;
        private System.Windows.Forms.TextBox theme;
        private System.Windows.Forms.Label lbGroup;
        private System.Windows.Forms.TextBox group;
        private System.Windows.Forms.RichTextBox purpose;
        private System.Windows.Forms.Label lbPurpose;
        private System.Windows.Forms.Label lbTask;
        private System.Windows.Forms.RichTextBox task;
        private System.Windows.Forms.Label lbConclusion;
        private System.Windows.Forms.RichTextBox conclusion;
        private System.Windows.Forms.Button btSave;
    }
}