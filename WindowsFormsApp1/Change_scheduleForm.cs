using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Change_scheduleForm : Form
    {
        public Change_scheduleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_Form Us_F = new User_Form();
            Us_F.Show();
            this.Hide();
        }
    }
}
