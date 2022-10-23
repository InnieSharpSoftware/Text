using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            string[] l = richTextBox1.Lines;
            for (int i = 0; i < l.Length; i++)
            {
                if (l[i].StartsWith("do-text:"))
                {
                    string text = l[i].Remove(0, 8);
                    richTextBox2.Text += text;
                }
                else if (l[i] == "do-text-newline")
                {
                    richTextBox2.Text += "\n";
                }
                else if (l[i] == "do-text-clear")
                {
                    richTextBox2.Text += "";
                }
            }
            richTextBox2.Text += "\nDone";
        }
    }
}
