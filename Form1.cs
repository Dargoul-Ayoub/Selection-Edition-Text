using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selection_et_Edition_de_Text
{
    public partial class Form1 : Form
    {
        string SelectedText;
        int indexStar;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {

            textBox2.Text = textBox1.SelectedText;
            textBox3.Text = Convert.ToString(textBox1.SelectionStart);
            textBox4.Text = Convert.ToString(textBox1.SelectionLength);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Motivation is the experience of desire or aversion" +
                " (you want something, or want to avoid or escape something)." +
                " As such, motivation has both an objective aspect (a goal or thing you aspire to) " +
                "and an internal or subjective aspect (it is you that wants the thing or wants it to go away).";
 
            textBox1.Select(0,0);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.SelectionLength > 0)
                textBox1.SelectedText = textBox1.SelectedText.ToUpper();
            textBox1.Focus();
            textBox1.Select(Convert.ToInt32(textBox3.Text),Convert.ToInt32(textBox4.Text));


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
                textBox1.SelectedText = textBox1.SelectedText.ToLower();
        }

       // select text using the keyboread
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.Shift && e.KeyCode == Keys.Right || (e.Shift && e.KeyCode == Keys.Left))
            {
                textBox2.Text = textBox1.SelectedText;
                textBox3.Text = Convert.ToString(textBox1.SelectionStart);
                textBox4.Text = Convert.ToString(textBox1.SelectionLength);

            }
        }

      
       
    }
}
