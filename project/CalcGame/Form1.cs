using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcGame
{
    public partial class Form1 : Form
    {
        int count = 0, maxCount = 10000;
        string now, nice = "+";
        Random rnd;
        List<Button> btns = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Вам нужно прибавлять только еденички\nиначе придёться начать всё с начала", "это игра на выживание!");
            textBox1.Text = count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            now = (sender as Button).Text;
            Checker(nice, now);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            now = (sender as Button).Text;
            Checker(nice, now);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            now = (sender as Button).Text;
            Checker(nice, now);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            now = (sender as Button).Text;
            Checker(nice, now);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            now = (sender as Button).Text;
            Checker(nice, now);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            now = (sender as Button).Text;
            Checker(nice, now);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            now = (sender as Button).Text;
            Checker(nice, now);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            now = (sender as Button).Text;
            Checker(nice, now);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            now = (sender as Button).Text;
            Checker(nice, now);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            now = (sender as Button).Text;
            Checker(nice, now);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            now = (sender as Button).Text;
            Checker(nice, now);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            now = (sender as Button).Text;
            Checker(nice, now);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            now = (sender as Button).Text;
            Checker(nice, now);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            now = (sender as Button).Text;
            Checker(nice, now);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            now = (sender as Button).Text;
            Checker(nice, now);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            now = (sender as Button).Text;
            Checker(nice, now);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сначало '+', а потом '1' и так до...\n10000");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            now = (sender as Button).Text;
            Checker(nice, now);
        }
        private void RandomBtns()
        {
            rnd = new Random();
            btns.Add(button1);
            btns.Add(button2);
            btns.Add(button3);
            btns.Add(button4);
            btns.Add(button5);
            btns.Add(button6);
            btns.Add(button7);
            btns.Add(button8);
            btns.Add(button9);
            btns.Add(button10);
            btns.Add(button11);
            btns.Add(button12);

            for(int i = 0; i < 12; i++)
            {
                int n = rnd.Next(btns.Count());
                btns[n].Text = i<10?i.ToString():i==11?".":"C";
                btns.Remove(btns[n]);
            }

        }
        private void Checker(string Nice, string Now)
        {
            if(Nice == Now)
            {
                if(Nice == "+")
                {
                    nice = "1";
                }
                else
                {
                    nice = "+";
                    count++;
                    textBox1.Text = count.ToString();
                    if (count == maxCount)
                    {
                        DialogResult res = MessageBox.Show("Ты выйграл))\nначать заново?", "Игра закончилась", MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                        {
                            Application.Restart();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    RandomBtns();
                }
            }
            else
            {
                DialogResult res = MessageBox.Show("Ты плохиш:)\nпромахнулся\nначать заново?", "Игра закончилась", MessageBoxButtons.YesNo);
                if(res == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
