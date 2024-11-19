namespace examPreparetion_demo
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            lblWelcome = new Label();
            lblToday = new Label();
            btnStart = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.FromArgb(255, 255, 192);
            lblWelcome.FlatStyle = FlatStyle.System;
            lblWelcome.Font = new Font("メイリオ", 72F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.Red;
            lblWelcome.Location = new Point(45, 94);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(625, 144);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome !!";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            lblWelcome.UseWaitCursor = true;
            // 
            // lblToday
            // 
            lblToday.AutoSize = true;
            lblToday.BackColor = SystemColors.Control;
            lblToday.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblToday.ForeColor = Color.Red;
            lblToday.Location = new Point(12, 9);
            lblToday.Name = "lblToday";
            lblToday.Size = new Size(0, 31);
            lblToday.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(192, 255, 192);
            btnStart.BackgroundImage = (Image)resources.GetObject("btnStart.BackgroundImage");
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("メイリオ", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.ForeColor = Color.Red;
            btnStart.Image = (Image)resources.GetObject("btnStart.Image");
            btnStart.Location = new Point(285, 371);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(101, 98);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(704, 501);
            Controls.Add(btnStart);
            Controls.Add(lblToday);
            Controls.Add(lblWelcome);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblToday;
        private Button btnStart;
    }
}