using System;
using System.Windows.Forms;

namespace GroupAssginment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Student studentForm = new Student();
            studentForm.Show();
            this.Hide();
        }

        private void btnFaculty_Click(object sender, EventArgs e)
        {
            Faculty facultyForm = new Faculty();
            facultyForm.Show();
            this.Hide();
        }
    }
}
