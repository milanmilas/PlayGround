using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace TypeWritter
{
    public partial class Form1 : Form
    {
        private Stopwatch timer = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox2.TextLength > 0 && !this.timer.IsRunning)
            {
                timer.Start();
            }

            int currentTextLength = richTextBox2.TextLength;
            string origCurrText = richTextBox1.Text.Trim()
            if(richTextBox2)
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer.IsRunning)
            {
                this.textBox1.Text = timer.Elapsed.Minutes + " : " + timer.Elapsed.Seconds;
            }
        }
    }
}
