using System.Runtime.InteropServices;

namespace examPreparetion_demo
{
    public partial class QuestionForm : Form
    {
        public QuestionForm()
        {
            InitializeComponent();
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

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

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
            }
            else
            {
                Button_Answer1.BackColor = Color.WhiteSmoke;
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
            }
            else
            {
                Button_Answer2.BackColor = Color.WhiteSmoke;
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
            }
            else
            {
                Button_Answer3.BackColor = Color.WhiteSmoke;
            }
        }

        private void Button_Answer4_Click(object sender, EventArgs e)
        {
            if(Button_Answer4.BackColor != Color.HotPink)
            {
                Button_Answer1.BackColor = Color.WhiteSmoke;
                Button_Answer2.BackColor = Color.WhiteSmoke;
                Button_Answer3.BackColor = Color.WhiteSmoke;
                Button_Answer4.BackColor = Color.HotPink;
            }
            else
            {
                Button_Answer4.BackColor = Color.WhiteSmoke;
            }
        }
    }
}
