using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            char[] chars = text.ToCharArray();
            int length = text.Length;
            char[] finalnipodoba = new char[length];
            int x = 0;
            foreach (char c in chars)
            {
                if ((c >= 65)&&(c <= 90))
                {
                    finalnipodoba[x] = ' ';
                }
                else
                {
                    finalnipodoba[x] = c;
                }
                x++;
            }
            string somefin = new string(finalnipodoba);
            MessageBox.Show("podoba bez velkych pismen je:" + somefin);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                string text = textBox1.Text;
                int length = text.Length;
                text = text.Replace('*', ' ');
                MessageBox.Show("text bez hvězdiček je:" + text);
           /* }catch (Exception Ex)
            {
                MessageBox.Show("error");
            }*/
        }
    }
}
