using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joc_N_Mazare_Alexandra
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int num = 9;
        int ant = 0;
        int pas = 1;
        int ok = 1;
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label1.Text);

            if (a == ant + 1)
            {
                ant++;
                if (ant == 16)
                {
                    label17.Visible = true;
                }
                label1.Visible = false;
            }
            else
                button1_Click(this, EventArgs.Empty);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label1.Text);

            if (a == ant + 1)
            {
                ant++;
                if (ant == 16)
                {
                    label17.Visible = true;
                }
                label1.Visible = false;
            }
            else
                button1_Click(this, EventArgs.Empty);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label1.Text);

            if (a == ant + 1)
            {
                ant++;
                if (ant == 16)
                {
                    label17.Visible = true;
                }
                label1.Visible = false;
            }
            else
                button1_Click(this, EventArgs.Empty);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label1.Text);

            if (a == ant + 1)
            {
                ant++;
                if (ant == 16)
                {
                    label17.Visible = true;
                }
                label1.Visible = false;
            }
            else
                button1_Click(this, EventArgs.Empty);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label1.Text);

            if (a == ant + 1)
            {
                ant++;
                if (ant == 16)
                {
                    label17.Visible = true;
                }
                label1.Visible = false;
            }
            else
                button1_Click(this, EventArgs.Empty);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label1.Text);

            if (a == ant + 1)
            {
                ant++;
                if (ant == 16)
                {
                    label17.Visible = true;
                }
                label1.Visible = false;
            }
            else
                button1_Click(this, EventArgs.Empty);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label1.Text);

            if (a == ant + 1)
            {
                ant++;
                if (ant == 16)
                {
                    label17.Visible = true;
                }
                label1.Visible = false;
            }
            else
                button1_Click(this, EventArgs.Empty);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label1.Text);

            if (a == ant + 1)
            {
                ant++;
                if (ant == 16)
                {
                    label17.Visible = true;
                }
                label1.Visible = false;
            }
            else
                button1_Click(this, EventArgs.Empty);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label1.Text);

            if (a == ant + 1)
            {
                ant++;
                if (ant == 16)
                {
                    label17.Visible = true;
                }
                label1.Visible = false;
            }
            else
                button1_Click(this, EventArgs.Empty);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label1.Text);

            if (a == ant + 1)
            {
                ant++;
                if (ant == 16)
                {
                    label17.Visible = true;
                }
                label1.Visible = false;
            }
            else
                button1_Click(this, EventArgs.Empty);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label1.Text);

            if (a == ant + 1)
            {
                ant++;
                if (ant == 16)
                {
                    label17.Visible = true;
                }
                label1.Visible = false;
            }
            else
                button1_Click(this, EventArgs.Empty);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label1.Text);

            if (a == ant + 1)
            {
                ant++;
                if (ant == 16)
                {
                    label17.Visible = true;
                }
                label1.Visible = false;
            }
            else
                button1_Click(this, EventArgs.Empty);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label1.Text);

            if (a == ant + 1)
            {
                ant++;
                if (ant == 16)
                {
                    label17.Visible = true;
                }
                label1.Visible = false;
            }
            else
                button1_Click(this, EventArgs.Empty);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label1.Text);

            if (a == ant + 1)
            {
                ant++;
                if (ant == 16)
                {
                    label17.Visible = true;
                }
                label1.Visible = false;
            }
            else
                button1_Click(this, EventArgs.Empty);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label1.Text);

            if (a == ant + 1)
            {
                ant++;
                if (ant == 16)
                {
                    label17.Visible = true;
                }
                label1.Visible = false;
            }
            else
                button1_Click(this, EventArgs.Empty);
        }

        private void label16_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label1.Text);

            if (a == ant + 1)
            {
                ant++;
                if (ant == 16)
                {
                    label17.Visible = true;
                }
                label1.Visible = false;
            }
            else
                button1_Click(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int nr = 0;
            int[] x = new int[11];
            int i;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;

            ant = 0;
            ok = 1;
            num = 9;

            label9.Visible = true;
            while (nr != 9)
            {
                int a = r.Next(1, 10);
                if (x[a] < 1)
                {
                    x[a]++;
                    nr++;
                    switch (nr)
                    {
                        case 1:
                            label1.Text = Convert.ToString(a);
                            break;
                        case 2:
                            label2.Text = Convert.ToString(a);
                            break;
                        case 3:
                            label3.Text = Convert.ToString(a);
                            break;
                        case 4:
                            label4.Text = Convert.ToString(a);
                            break;
                        case 5:
                            label5.Text = Convert.ToString(a);
                            break;
                        case 6:
                            label6.Text = Convert.ToString(a);
                            break;
                        case 7:
                            label7.Text = Convert.ToString(a);
                            break;
                        case 8:
                            label8.Text = Convert.ToString(a);
                            break;
                        case 9:
                            label9.Text = Convert.ToString(a);
                            break;
                        case 10:
                            label10.Text = Convert.ToString(a);
                            break;
                        case 11:
                            label11.Text = Convert.ToString(a);
                            break;
                        case 12:
                            label12.Text = Convert.ToString(a);
                            break;
                        case 13:
                            label3.Text = Convert.ToString(a);
                            break;
                        case 14:
                            label14.Text = Convert.ToString(a);
                            break;
                        case 15:
                            label15.Text = Convert.ToString(a);
                            break;
                        case 16:
                            label16.Text = Convert.ToString(a);
                            break;

                    }

                }
            }
        }
    }
}
