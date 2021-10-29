using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random h = new Random();
            a = h.Next(1, 5);
            if (a == 1)
            {
                this.BackgroundImage = Properties.Resources.Untitled_1;
            }
            else if (a == 2)
            {
                label1.Top = this.Top*2;
                label3.Top = this.Top * 2;
                label2.ForeColor = Color.White;
                this.BackgroundImage = Properties.Resources.Untitled_2;
            }
            else if (a == 3)
            {
                label1.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label2.Top = this.Top * 2;
                this.BackgroundImage = Properties.Resources.Blue_Sparkles_Sample_1_;
            }
            else if (a == 4)
            {
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                this.BackgroundImage = Properties.Resources.abstract_blue_hd_wallpaper_wide_1_;
            }
            else if (a == 5)
            {
                this.BackgroundImage = Properties.Resources._13_NatureWallpaper_WwW_KamYab_IR_;
            }
            timer1.Start();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent; label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
        }
        bool r1 = false, r2 = false, r3 = false; int b =26;
        private void timer1_Tick(object sender, EventArgs e)
        {
            b++;
            if (a == 1)
            {
                {
                    if (label1.Top < 96)
                        label1.Top += 1;
                    else
                        r1 = true;
                }
                {
                    if (label2.Top < 180)
                        label2.Top += 1;
                    else r2 = true;
                }
                {
                    if (label3.Top < 266)
                        label3.Top += 1;
                    else
                        r3 = true;
                }

            } if (a == 2)
            {
                {
                    if (label1.Top > 96)
                        label1.Top -= 1;
                    else
                    {
                        r1 = true;

                    }
                }
                {
                    if (label2.Top < 180)
                        label2.Top += 1;
                    else r2 = true;
                }
                {
                    if (label3.Top > 266)
                        label3.Top -= 1;
                    else
                        r3 = true;
                }

            } if (a == 3)
            {
                {
                    if (label1.Top < 96)
                        label1.Top += 1;
                    else
                        r1 = true;
                }
                {
                    if (label2.Top > 180)
                        label2.Top -= 1;
                    else r2 = true;
                }
                {
                    if (label3.Top < 266)
                        label3.Top += 1;
                    else
                        r3 = true;
                }

            } if (a == 4)
            {
                {
                    if (label1.Top < 96)
                        label1.Top += 1;
                    else
                    {
                        r1 = true;
                        label1.Font = new Font(FontFamily.GenericSansSerif, b, FontStyle.Regular);
                    }
                }
                {
                    if (label2.Top < 180)
                        label2.Top += 1;
                    else r2 = true;
                }
                {
                    if (label3.Top < 266)
                        label3.Top += 1;
                    else
                        r3 = true;
                }

            }
            if (a == 4)
            {
                {
                    if (label1.Top < 96)
                        label1.Top += 1;
                    else
                    {
                        r1 = true;
                        label1.Font = new Font(FontFamily.GenericSansSerif, b, FontStyle.Regular);
                    }
                }
                {
                    if (label2.Top < 180)
                        label2.Top += 1;
                    else r2 = true;
                }
                {
                    if (label3.Top < 266)
                        label3.Top += 1;
                    else
                        r3 = true;
                }

            }
            if (a == 5)
            {
                if (b <= 50)
                {
                    label1.Font = new Font(FontFamily.GenericSansSerif, b, FontStyle.Regular);
                }
                else r1 = true;

                if (b <= 50)
                {
                    label2.Font = new Font(FontFamily.GenericSansSerif, b - 5, FontStyle.Regular);
                }
                else r2 = true;
                r3 = true;
            }
            if (r1 == true && r2 == true && r3 == true)
            {
                Form2 k = new Form2();
                k.Show();
                timer1.Stop();
                this.Hide();
            }
        }
    }
}
