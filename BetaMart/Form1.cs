using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaMart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.Show();
            tentangControl1.Hide();
            userControl11.BringToFront();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            tentangControl1.Hide();
            userControl11.Show();
            userControl11.BringToFront();

        }

        private void button_tentang_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            tentangControl1.Show();
            tentangControl1.BringToFront();
        }
    }
}
