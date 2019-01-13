using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello~! C#...");
        }
        private void a(object sender, EventArgs e)
        {
            MessageBox.Show("aHello~! C#...");
        }
        private void b(object sender, EventArgs e)
        {
            MessageBox.Show("bHello~! C#...");
        }

    }
}
