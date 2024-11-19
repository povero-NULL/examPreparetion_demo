namespace examPreparetion_demo
{
    partial class QuestionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button_Answer1 = new Button();
            Button_Answer3 = new Button();
            Button_Answer2 = new Button();
            Button_Answer4 = new Button();
            Answer1 = new TextBox();
            Answer2 = new TextBox();
            Answer3 = new TextBox();
            Answer4 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            Question = new TextBox();
            SuspendLayout();
            // 
            // Button_Answer1
            // 
            Button_Answer1.BackColor = Color.WhiteSmoke;
            Button_Answer1.Cursor = Cursors.Hand;
            Button_Answer1.Font = new Font("メイリオ", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Answer1.Location = new Point(12, 298);
            Button_Answer1.Name = "Button_Answer1";
            Button_Answer1.Size = new Size(35, 35);
            Button_Answer1.TabIndex = 1;
            Button_Answer1.Text = "1";
            Button_Answer1.UseVisualStyleBackColor = false;
            Button_Answer1.Click += Button_Answer1_Click;
            // 
            // Button_Answer3
            // 
            Button_Answer3.BackColor = Color.WhiteSmoke;
            Button_Answer3.Cursor = Cursors.Hand;
            Button_Answer3.Font = new Font("メイリオ", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Answer3.Location = new Point(12, 380);
            Button_Answer3.Name = "Button_Answer3";
            Button_Answer3.Size = new Size(35, 35);
            Button_Answer3.TabIndex = 2;
            Button_Answer3.Text = "3";
            Button_Answer3.UseVisualStyleBackColor = false;
            Button_Answer3.Click += Button_Answer3_Click;
            // 
            // Button_Answer2
            // 
            Button_Answer2.BackColor = Color.WhiteSmoke;
            Button_Answer2.Cursor = Cursors.Hand;
            Button_Answer2.Font = new Font("メイリオ", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Answer2.Location = new Point(12, 339);
            Button_Answer2.Name = "Button_Answer2";
            Button_Answer2.Size = new Size(35, 35);
            Button_Answer2.TabIndex = 3;
            Button_Answer2.Text = "2";
            Button_Answer2.UseVisualStyleBackColor = false;
            Button_Answer2.Click += Button_Answer2_Click;
            // 
            // Button_Answer4
            // 
            Button_Answer4.BackColor = Color.WhiteSmoke;
            Button_Answer4.Cursor = Cursors.Hand;
            Button_Answer4.Font = new Font("メイリオ", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Answer4.Location = new Point(12, 421);
            Button_Answer4.Name = "Button_Answer4";
            Button_Answer4.Size = new Size(35, 35);
            Button_Answer4.TabIndex = 4;
            Button_Answer4.Text = "4";
            Button_Answer4.UseVisualStyleBackColor = false;
            Button_Answer4.Click += Button_Answer4_Click;
            // 
            // Answer1
            // 
            Answer1.Location = new Point(68, 298);
            Answer1.Multiline = true;
            Answer1.Name = "Answer1";
            Answer1.Size = new Size(624, 35);
            Answer1.TabIndex = 5;
            Answer1.Text = "1";
            Answer1.TextChanged += textBox1_TextChanged;
            // 
            // Answer2
            // 
            Answer2.Location = new Point(68, 339);
            Answer2.Multiline = true;
            Answer2.Name = "Answer2";
            Answer2.Size = new Size(624, 35);
            Answer2.TabIndex = 6;
            Answer2.Text = "2";
            // 
            // Answer3
            // 
            Answer3.Location = new Point(68, 380);
            Answer3.Multiline = true;
            Answer3.Name = "Answer3";
            Answer3.Size = new Size(624, 35);
            Answer3.TabIndex = 7;
            Answer3.Text = "3";
            // 
            // Answer4
            // 
            Answer4.Location = new Point(68, 421);
            Answer4.Multiline = true;
            Answer4.Name = "Answer4";
            Answer4.Size = new Size(624, 35);
            Answer4.TabIndex = 8;
            Answer4.Text = "4";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 255, 128);
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("メイリオ", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(250, 460);
            button4.Name = "button4";
            button4.Size = new Size(75, 25);
            button4.TabIndex = 9;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 255, 128);
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("メイリオ", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(395, 460);
            button5.Name = "button5";
            button5.Size = new Size(75, 25);
            button5.TabIndex = 10;
            button5.Text = "Next";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Question
            // 
            Question.Location = new Point(12, 12);
            Question.Multiline = true;
            Question.Name = "Question";
            Question.Size = new Size(680, 280);
            Question.TabIndex = 11;
            Question.Text = "問1.　以下の問いに答えよ。\r\n1 + 1 = ??";
            Question.TextChanged += Question_TextChanged;
            // 
            // QuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(704, 501);
            Controls.Add(Question);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(Answer4);
            Controls.Add(Answer3);
            Controls.Add(Answer2);
            Controls.Add(Answer1);
            Controls.Add(Button_Answer4);
            Controls.Add(Button_Answer2);
            Controls.Add(Button_Answer3);
            Controls.Add(Button_Answer1);
            Name = "QuestionForm";
            Text = "Main";
            TransparencyKey = Color.FromArgb(255, 192, 192);
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Button_Answer1;
        private Button Button_Answer3;
        private Button Button_Answer2;
        private Button Button_Answer4;
        private TextBox Answer1;
        private TextBox Answer2;
        private TextBox Answer3;
        private TextBox Answer4;
        private Button button4;
        private Button button5;
        private TextBox Question;
    }
}
