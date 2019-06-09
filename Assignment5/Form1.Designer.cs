namespace Quiz
{
    partial class Form1
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
            this.option2 = new System.Windows.Forms.RadioButton();
            this.option3 = new System.Windows.Forms.RadioButton();
            this.option4 = new System.Windows.Forms.RadioButton();
            this.Submit = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.Label();
            this.ques = new System.Windows.Forms.Label();
            this.Go = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pointsvalue = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.options = new System.Windows.Forms.GroupBox();
            this.explain = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dropdown = new System.Windows.Forms.ComboBox();
            this.startagain = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.options.SuspendLayout();
            this.SuspendLayout();
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.Enabled = false;
            this.option2.Location = new System.Drawing.Point(52, 46);
            this.option2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(90, 24);
            this.option2.TabIndex = 1;
            this.option2.TabStop = true;
            this.option2.Text = "Option2";
            this.option2.UseVisualStyleBackColor = true;
            this.option2.CheckedChanged += new System.EventHandler(this.option2_CheckedChanged);
            // 
            // option3
            // 
            this.option3.AutoSize = true;
            this.option3.Enabled = false;
            this.option3.Location = new System.Drawing.Point(52, 93);
            this.option3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(90, 24);
            this.option3.TabIndex = 2;
            this.option3.TabStop = true;
            this.option3.Text = "Option3";
            this.option3.UseVisualStyleBackColor = true;
            // 
            // option4
            // 
            this.option4.AutoSize = true;
            this.option4.Enabled = false;
            this.option4.Location = new System.Drawing.Point(52, 138);
            this.option4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(90, 24);
            this.option4.TabIndex = 3;
            this.option4.TabStop = true;
            this.option4.Text = "Option4";
            this.option4.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            this.Submit.Enabled = false;
            this.Submit.Location = new System.Drawing.Point(800, 522);
            this.Submit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(112, 35);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Ввод";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.Location = new System.Drawing.Point(75, 151);
            this.question.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(91, 25);
            this.question.TabIndex = 5;
            this.question.Text = "Вопрос:";
            this.question.Click += new System.EventHandler(this.question_Click);
            // 
            // ques
            // 
            this.ques.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ques.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ques.Location = new System.Drawing.Point(189, 151);
            this.ques.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ques.Name = "ques";
            this.ques.Size = new System.Drawing.Size(1111, 57);
            this.ques.TabIndex = 6;
            this.ques.Text = "Вопрос";
            this.ques.Click += new System.EventHandler(this.ques_Click);
            // 
            // Go
            // 
            this.Go.Enabled = false;
            this.Go.Location = new System.Drawing.Point(920, 58);
            this.Go.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(112, 35);
            this.Go.TabIndex = 7;
            this.Go.Text = "Поехали";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1216, 679);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Баллы:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pointsvalue
            // 
            this.pointsvalue.AutoSize = true;
            this.pointsvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsvalue.Location = new System.Drawing.Point(1383, 679);
            this.pointsvalue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pointsvalue.Name = "pointsvalue";
            this.pointsvalue.Size = new System.Drawing.Size(27, 29);
            this.pointsvalue.TabIndex = 9;
            this.pointsvalue.Text = "0";
            // 
            // Next
            // 
            this.Next.Enabled = false;
            this.Next.Location = new System.Drawing.Point(950, 522);
            this.Next.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(112, 35);
            this.Next.TabIndex = 10;
            this.Next.Text = "Следующий";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // options
            // 
            this.options.Controls.Add(this.option4);
            this.options.Controls.Add(this.option3);
            this.options.Controls.Add(this.option2);
            this.options.Location = new System.Drawing.Point(13, 213);
            this.options.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.options.Name = "options";
            this.options.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.options.Size = new System.Drawing.Size(1681, 287);
            this.options.TabIndex = 11;
            this.options.TabStop = false;
            this.options.Text = "Опции:";
            this.options.Enter += new System.EventHandler(this.options_Enter);
            // 
            // explain
            // 
            this.explain.Cursor = System.Windows.Forms.Cursors.Default;
            this.explain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explain.Location = new System.Drawing.Point(1290, 522);
            this.explain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.explain.Name = "explain";
            this.explain.Size = new System.Drawing.Size(312, 132);
            this.explain.TabIndex = 13;
            this.explain.Click += new System.EventHandler(this.explain_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Выберети тест:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dropdown
            // 
            this.dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown.FormattingEnabled = true;
            this.dropdown.Items.AddRange(new object[] {
            "Level-1",
            "Level-2"});
            this.dropdown.Location = new System.Drawing.Point(572, 62);
            this.dropdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dropdown.Name = "dropdown";
            this.dropdown.Size = new System.Drawing.Size(280, 28);
            this.dropdown.TabIndex = 15;
            this.dropdown.SelectedIndexChanged += new System.EventHandler(this.dropdown_SelectedIndexChanged);
            // 
            // startagain
            // 
            this.startagain.Location = new System.Drawing.Point(1040, 58);
            this.startagain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startagain.Name = "startagain";
            this.startagain.Size = new System.Drawing.Size(112, 35);
            this.startagain.TabIndex = 16;
            this.startagain.Text = "Новый тест";
            this.startagain.UseVisualStyleBackColor = true;
            this.startagain.Click += new System.EventHandler(this.startagain_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(75, 497);
            this.error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 25);
            this.error.TabIndex = 17;
            this.error.Visible = false;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(1160, 58);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(112, 35);
            this.Exit.TabIndex = 18;
            this.Exit.Text = "Закончить тест";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1707, 764);
            this.Controls.Add(this.options);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.error);
            this.Controls.Add(this.startagain);
            this.Controls.Add(this.dropdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.explain);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.pointsvalue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.ques);
            this.Controls.Add(this.question);
            this.Controls.Add(this.Submit);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пройди тест!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.options.ResumeLayout(false);
            this.options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton option2;
        private System.Windows.Forms.RadioButton option3;
        private System.Windows.Forms.RadioButton option4;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Label ques;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pointsvalue;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.GroupBox options;
        private System.Windows.Forms.Label explain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dropdown;
        private System.Windows.Forms.Button startagain;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button Exit;
    }
}

