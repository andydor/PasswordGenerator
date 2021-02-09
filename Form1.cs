using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked)
            {
                int nr = Convert.ToInt32(textBox2.Text);
                string pass = string.Empty;
                string alphanum = string.Empty;
                if (checkBox1.Checked)
                {
                    alphanum += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                }
                if (checkBox2.Checked)
                {
                    alphanum += "abcdefghijklmnopqrstuvwxyz";
                }
                if (checkBox3.Checked)
                {
                    alphanum += "0123456789";
                }
                if (checkBox4.Checked)
                {
                    alphanum += ".,/?!=+&*^%$#@";
                }
                //char[] alphanum = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.,/?!=+&*^%$#@".ToCharArray();
                Random r1 = new Random();
                
                for (int i = 0; i < nr; i++)
                {
                    int curr = r1.Next(1, alphanum.Length);
                    /*const int MAXIMUM_IDENTICAL_CONSECUTIVE_CHARS = 2;
                    bool moreThanTwoIdenticalInARow =
                        (i > MAXIMUM_IDENTICAL_CONSECUTIVE_CHARS)
                        && (pass[i] == pass[i - 1])
                        && (pass[i - 1] == pass[i - 2]);

                    if (moreThanTwoIdenticalInARow)
                    {
                        i--;
                    }*/
                    /*if (pass.Contains(alphanum[curr].ToString()))
                    {
                        i--;
                    }
                    else
                    {*/
                        pass += alphanum[curr].ToString();
                    //}
                }
                textBox1.Text = pass;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
