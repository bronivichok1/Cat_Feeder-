using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class feedForm : Form
    {
        public feedForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_Form UsFor = new User_Form();
            UsFor.Show();
            this.Hide();
        }
    }
}
