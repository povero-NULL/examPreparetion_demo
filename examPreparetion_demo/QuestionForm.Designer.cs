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
            btnBack = new Button();
            btnNext = new Button();
            lblQuestionNo = new Label();
            QuestionPanel = new Panel();
            pictureNG = new PictureBox();
            pictureOK = new PictureBox();
            lblQuestion = new Label();
            lblAns1 = new Label();
            lblAns2 = new Label();
            lblAns3 = new Label();
            lblAns4 = new Label();
            btnExit = new Button();
            btnAnswer = new Button();
            QuestionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureNG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureOK).BeginInit();
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
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 255, 128);
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("メイリオ", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(250, 460);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 25);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Visible = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(255, 255, 128);
            btnNext.Cursor = Cursors.Hand;
            btnNext.Font = new Font("メイリオ", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Location = new Point(395, 460);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 25);
            btnNext.TabIndex = 10;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Visible = false;
            btnNext.Click += btnNext_Click;
            // 
            // lblQuestionNo
            // 
            lblQuestionNo.AutoSize = true;
            lblQuestionNo.Font = new Font("メイリオ", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuestionNo.ForeColor = Color.Red;
            lblQuestionNo.Location = new Point(16, 14);
            lblQuestionNo.Name = "lblQuestionNo";
            lblQuestionNo.Size = new Size(26, 24);
            lblQuestionNo.TabIndex = 12;
            lblQuestionNo.Text = "問";
            // 
            // QuestionPanel
            // 
            QuestionPanel.BackColor = Color.AliceBlue;
            QuestionPanel.Controls.Add(pictureNG);
            QuestionPanel.Controls.Add(pictureOK);
            QuestionPanel.Controls.Add(lblQuestion);
            QuestionPanel.Location = new Point(14, 41);
            QuestionPanel.Name = "QuestionPanel";
            QuestionPanel.Size = new Size(682, 251);
            QuestionPanel.TabIndex = 13;
            // 
            // pictureNG
            // 
            pictureNG.BackColor = Color.LightCoral;
            pictureNG.Image = Properties.Resources.Alert;
            pictureNG.Location = new Point(273, 130);
            pictureNG.Name = "pictureNG";
            pictureNG.Size = new Size(129, 121);
            pictureNG.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureNG.TabIndex = 2;
            pictureNG.TabStop = false;
            pictureNG.Visible = false;
            // 
            // pictureOK
            // 
            pictureOK.BackColor = Color.GreenYellow;
            pictureOK.Image = Properties.Resources.time;
            pictureOK.Location = new Point(273, 130);
            pictureOK.Name = "pictureOK";
            pictureOK.Size = new Size(129, 121);
            pictureOK.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureOK.TabIndex = 1;
            pictureOK.TabStop = false;
            pictureOK.Visible = false;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestion.Location = new Point(18, 18);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(56, 24);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "label2";
            lblQuestion.Click += lblQuestion_Click;
            // 
            // lblAns1
            // 
            lblAns1.AutoSize = true;
            lblAns1.Font = new Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAns1.Location = new Point(53, 302);
            lblAns1.Name = "lblAns1";
            lblAns1.Size = new Size(56, 24);
            lblAns1.TabIndex = 14;
            lblAns1.Text = "label2";
            // 
            // lblAns2
            // 
            lblAns2.AutoSize = true;
            lblAns2.Font = new Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAns2.Location = new Point(53, 343);
            lblAns2.Name = "lblAns2";
            lblAns2.Size = new Size(56, 24);
            lblAns2.TabIndex = 15;
            lblAns2.Text = "label3";
            // 
            // lblAns3
            // 
            lblAns3.AutoSize = true;
            lblAns3.Font = new Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAns3.Location = new Point(53, 384);
            lblAns3.Name = "lblAns3";
            lblAns3.Size = new Size(56, 24);
            lblAns3.TabIndex = 16;
            lblAns3.Text = "label3";
            // 
            // lblAns4
            // 
            lblAns4.AutoSize = true;
            lblAns4.Font = new Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAns4.Location = new Point(53, 425);
            lblAns4.Name = "lblAns4";
            lblAns4.Size = new Size(56, 24);
            lblAns4.TabIndex = 17;
            lblAns4.Text = "label3";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Turquoise;
            btnExit.Font = new Font("メイリオ", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(617, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 18;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnAnswer
            // 
            btnAnswer.BackColor = Color.FromArgb(255, 255, 128);
            btnAnswer.Cursor = Cursors.Hand;
            btnAnswer.Font = new Font("メイリオ", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnswer.Location = new Point(395, 460);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.Size = new Size(75, 25);
            btnAnswer.TabIndex = 19;
            btnAnswer.Text = "Answer";
            btnAnswer.UseVisualStyleBackColor = false;
            btnAnswer.Click += btnAnswer_Click;
            // 
            // QuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(704, 501);
            Controls.Add(btnAnswer);
            Controls.Add(btnExit);
            Controls.Add(lblAns4);
            Controls.Add(lblAns3);
            Controls.Add(lblAns2);
            Controls.Add(lblAns1);
            Controls.Add(QuestionPanel);
            Controls.Add(lblQuestionNo);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(Button_Answer4);
            Controls.Add(Button_Answer2);
            Controls.Add(Button_Answer3);
            Controls.Add(Button_Answer1);
            Name = "QuestionForm";
            Text = "Main";
            TransparencyKey = Color.FromArgb(255, 192, 192);
            Load += Form1_Load;
            QuestionPanel.ResumeLayout(false);
            QuestionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureNG).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureOK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Button_Answer1;
        private Button Button_Answer3;
        private Button Button_Answer2;
        private Button Button_Answer4;
        private Button btnBack;
        private Button btnNext;
        private Label lblQuestionNo;
        private Panel QuestionPanel;
        protected Label lblQuestion;
        private Label lblAns1;
        private Label lblAns2;
        private Label lblAns3;
        private Label lblAns4;
        private Button btnExit;
        private PictureBox pictureNG;
        private PictureBox pictureOK;
        private Button btnAnswer;
    }
}
