using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examPreparetion_demo
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            lblToday.Text = DateTime.Today.ToString("d");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            QuestionForm form = new QuestionForm();
            this.Hide();

            if(form.ShowDialog() == DialogResult.Cancel) 
            {
                try
                {
                    this.Show();
                }
                catch 
                {
                    //処理なし
                }
            }
        }
    }
}
