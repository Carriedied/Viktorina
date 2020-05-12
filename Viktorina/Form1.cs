using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Viktorina
{
    public partial class Form1 : Form
    {
        StreamReader sr = new StreamReader(@"test.txt", System.Text.Encoding.Default);
        int i = 0;
    public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Начать")
            {
                i++;
                button1.Text = "Далее";
                label1.Visible = true;
                groupBox1.Visible = true;
                label1.Text = sr.ReadLine();
                radioButton1.Text = sr.ReadLine();
                radioButton2.Text = sr.ReadLine();
                radioButton3.Text = sr.ReadLine();
            }
            else 
            {
                if (button1.Text == "Далее")
                {
                    if ((sr.ReadLine()) != null)
                    {  
                        label1.Text = sr.ReadLine();
                        radioButton1.Text = sr.ReadLine();
                        radioButton2.Text = sr.ReadLine();
                        radioButton3.Text = sr.ReadLine();
                        if (i == 1)
                        {
                            if (radioButton1.Checked)
                            {
                                progressBar1.Value += 0;
                            }
                            if (radioButton2.Checked)
                            {
                                progressBar1.Value += 25;
                            }
                            if (radioButton3.Checked)
                            {
                                progressBar1.Value += 0;
                            }
                        }
                        if (i == 2)
                        {
                            if (radioButton1.Checked)
                            {
                                progressBar1.Value += 0;
                            }
                            if (radioButton2.Checked)
                            {
                                progressBar1.Value += 0;
                            }
                            if (radioButton3.Checked)
                            {
                                progressBar1.Value += 25;
                            }
                        }
                        if (i == 3)
                        {
                            if (radioButton1.Checked)
                            {
                                progressBar1.Value += 0;
                            }
                            if (radioButton2.Checked)
                            {
                                progressBar1.Value += 25;
                            }
                            if (radioButton3.Checked)
                            {
                                progressBar1.Value += 0;
                            }
                        }
                        i++;
                    }
                    else
                    {
                        if (i == 4)
                        {
                            if (radioButton1.Checked)
                            {
                                progressBar1.Value += 25;
                            }
                            if (radioButton2.Checked)
                            {
                                progressBar1.Value += 0;
                            }
                            if (radioButton3.Checked)
                            {
                                progressBar1.Value += 0;
                            }
                        }
                        MessageBox.Show("Вы прошли тест на " + progressBar1.Value + "%");
                        this.Close();
                    }
                }
            }
        }
    }
}
