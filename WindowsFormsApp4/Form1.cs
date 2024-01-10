using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.UserControls;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UserControl1 userControl1 = new UserControl1();
            addControl(userControl1);
        }

        private void addControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UserControl1 userControl1 = new UserControl1();
            addControl(userControl1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserControl2 userControl2= new UserControl2();
            addControl(userControl2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserControl3 uc = new UserControl3();
            addControl(uc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.Show();
        }
    }
}
