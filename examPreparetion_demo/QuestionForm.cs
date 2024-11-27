using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Timers;
using System.Security.Cryptography.Xml;

namespace examPreparetion_demo
{
    public partial class QuestionForm : Form
    {
        static int questionId = 0; //��胊�X�g�pIndex
        static int questionCount = 1; //���ԍ�
        static bool answerFlg = true; //�𓚃t���O
        static int correctAns = 0; //����ԍ�
        static int ansNumber = 0; //�𓚔ԍ�

        public QuestionForm()
        {
            InitializeComponent();
            ansNumber = 0;
            lblQuestionNo.Text = "��" + questionCount;

            Question q = new Question();
            q = Process.LoadQuestion(questionId);

            lblQuestion.Text = q.questionStatement;
            lblAns1.Text = q.answer1;
            lblAns2.Text = q.answer2;
            lblAns3.Text = q.answer3;
            lblAns4.Text = q.answer4;
            correctAns = q.correctAnswer;

            //1��ڂȂ�Back���\��
            if (questionId == 0)
            {
                btnBack.Visible = false;
            }
            else
            {
                btnBack.Visible = true;
            }

            //Answer�{�^����Next�{�^���̕\��
            if (answerFlg)
            {
                btnAnswer.Visible = true;
                btnNext.Visible = false;
            }
            else
            {
                btnAnswer.Visible = false;
                btnNext.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //���̖���\��
            questionId++;
            questionCount++;
            var form = new QuestionForm();
            this.Hide();

            if (form.ShowDialog() == DialogResult.Cancel)
            {
                try
                {
                    this.Show(form);
                }
                catch
                {
                    //�����Ȃ�
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (questionId == 0)
            {

            }
            else
            {
                questionId--;
                questionCount--;

                var form = new QuestionForm();
                this.Hide();

                if (form.ShowDialog() == DialogResult.Cancel)
                {
                    try
                    {
                        this.Show(form);
                    }
                    catch
                    {
                        //�����Ȃ�
                    }
                }
            }
        }

        private void Question_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Answer1_Click(object sender, EventArgs e)
        {
            if (Button_Answer1.BackColor != Color.HotPink)
            {
                Button_Answer1.BackColor = Color.HotPink;
                Button_Answer2.BackColor = Color.WhiteSmoke;
                Button_Answer3.BackColor = Color.WhiteSmoke;
                Button_Answer4.BackColor = Color.WhiteSmoke;

                ansNumber = 1;
            }
            else
            {
                //Button_Answer1.BackColor = Color.WhiteSmoke;
            }
        }

        private void Button_Answer2_Click(object sender, EventArgs e)
        {
            if (Button_Answer2.BackColor != Color.HotPink)
            {
                Button_Answer1.BackColor = Color.WhiteSmoke;
                Button_Answer2.BackColor = Color.HotPink;
                Button_Answer3.BackColor = Color.WhiteSmoke;
                Button_Answer4.BackColor = Color.WhiteSmoke;

                ansNumber = 2;
            }
            else
            {
                //Button_Answer2.BackColor = Color.WhiteSmoke;
            }
        }

        private void Button_Answer3_Click(object sender, EventArgs e)
        {
            if (Button_Answer3.BackColor != Color.HotPink)
            {
                Button_Answer1.BackColor = Color.WhiteSmoke;
                Button_Answer2.BackColor = Color.WhiteSmoke;
                Button_Answer3.BackColor = Color.HotPink;
                Button_Answer4.BackColor = Color.WhiteSmoke;

                ansNumber = 3;
            }
            else
            {
                //Button_Answer3.BackColor = Color.WhiteSmoke;
            }
        }

        private void Button_Answer4_Click(object sender, EventArgs e)
        {
            if (Button_Answer4.BackColor != Color.HotPink)
            {
                Button_Answer1.BackColor = Color.WhiteSmoke;
                Button_Answer2.BackColor = Color.WhiteSmoke;
                Button_Answer3.BackColor = Color.WhiteSmoke;
                Button_Answer4.BackColor = Color.HotPink;

                ansNumber = 4;
            }
            else
            {
                //Button_Answer4.BackColor = Color.WhiteSmoke;
            }
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Program.ApplicationExit();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (ansNumber == 0)
            {
                
            }
            else
            {
                if (ansNumber == correctAns)
                {
                    pictureOK.Visible = true;
                    pictureNG.Visible = false;
                }
                else
                {
                    pictureOK.Visible = false;
                    pictureNG.Visible = true;
                }

                btnAnswer.Visible = false;
                btnNext.Visible = true;
            }
        }
    }
}
