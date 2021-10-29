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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (save == true)
                if (MessageBox.Show("آیا می خواهید که متن ذخیره شود", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                {
                    saveFileDialog1.ShowDialog();
                    System.IO.File.WriteAllText(saveFileDialog1.FileName,richTextBox1.Text+rich2.Text+rich3.Text+rich4.Text+rich5.Text);
                }
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
            System.Drawing.FontFamily[] j = System.Drawing.FontFamily.Families;
            for (int a = 0; a <j.Length; a++)
            {
                comboBox1.Items.Add(j[a].Name.ToString());
            }
            for (int fonts = 10; fonts <= 73; fonts++)
            {
                if (fonts % 2 == 0)
                {
                    comboBox2.Items.Add(fonts.ToString());
                }
            }
            comboBox2.Text = "14";
            comboBox1.Text = "IranNastaliq";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "*.jpg|*.jpg|*.png|*.png|*.ico|*.ico";
                openFileDialog1.ShowDialog();
                Bitmap k = new Bitmap(openFileDialog1.FileName);
                Clipboard.SetDataObject(k);
                if (r == 0)
                    richTextBox1.Paste();
                else if (r == 1)
                    rich2.Paste();
                else if (r == 2)
                    rich3.Paste();
                else if (r == 3)
                    rich4.Paste();
                else if (r == 4)
                    rich5.Paste();
            }
            catch { }
        }
        int r = 0; RichTextBox rich2 = new RichTextBox(); RichTextBox rich3 = new RichTextBox(); RichTextBox rich4 = new RichTextBox(); RichTextBox rich5 = new RichTextBox();
        private void button13_Click(object sender, EventArgs e)
        {
            //r++;
            //if (r == 1)
            //{
            //    vScrollBar1.Maximum = 105;
            //    rich2.Location = new Point(richTextBox1.Left, richTextBox1.Top + richTextBox1.Height + 4);
            //    rich2.Height = richTextBox1.Height;
            //    rich2.Width = richTextBox1.Width;
            //    this.Controls.Add(rich2);
            //    rich2.BringToFront();
            //    rich2.ContextMenuStrip = contextMenuStrip1;
            //}
            //else if (r == 2)
            //{
            //    this.Controls.Add(rich3);
            //    vScrollBar1.Maximum = 190;
            //    rich3.Location = new Point(richTextBox1.Left, rich2.Top + rich2.Height + 4);
            //    rich3.Height = rich2.Height;
            //    rich3.Width = rich2.Width;
            //    rich3.BringToFront();
            //    rich3.ContextMenuStrip = contextMenuStrip1;
            //}
            //else if (r == 3)
            //{
            //    this.Controls.Add(rich4);
            //    vScrollBar1.Maximum = 230;
            //    rich4.Location = new Point(rich3.Left, rich3.Top + rich3.Height + 4);
            //    rich4.Width = rich3.Width;
            //    rich4.Height = rich3.Height;
            //    rich4.ContextMenuStrip = contextMenuStrip1;
            //}
            //if (r == 4)
            //{
            //    this.Controls.Add(rich5);
            //    vScrollBar1.Maximum = 350;
            //    rich5.Location = new Point(rich3.Left, rich4.Top + rich4.Height + 4);
            //    rich5.Width = rich4.Width;
            //    rich5.Height = rich4.Height;
            //    rich5.ContextMenuStrip = contextMenuStrip1;
            //}
        }
        int q = 0;
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //groupBox1.BringToFront();
            //groupBox2.BringToFront();
            //if (vScrollBar1.Value > q)
            //{
            //    richTextBox1.Top -= 10;
            //    rich2.Top -= 10;
            //    rich3.Top -= 10;
            //    rich4.Top -= 10;
            //    rich5.Top -= 10;
            //}
            //else if(vScrollBar1.Value<q)
            //{
            //    richTextBox1.Top += 10;
            //    rich2.Top += 10;
            //    rich3.Top += 10;
            //    rich4.Top += 10;
            //    rich5.Top += 10;
            //}
            //q = vScrollBar1.Value;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            timer1.Start();
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (groupBox2.Location == groupBox1.Location)
            {
                timer1.Stop();
                groupBox2.Enabled = true;
            }
            else
                groupBox2.Top -= 1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox2.Enabled = false;
            groupBox2.Top = 76;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            if (r == 0)
                richTextBox1.SelectionColor = colorDialog1.Color;
            else if (r == 1)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
                rich2.SelectionColor = colorDialog1.Color;
            }
            else if (r == 2)
            {
                rich3.SelectionColor = colorDialog1.Color;
                richTextBox1.SelectionColor = colorDialog1.Color;
                rich2.SelectionColor = colorDialog1.Color;
            }
            else if (r == 3)
            {
                rich3.SelectionColor = colorDialog1.Color;
                richTextBox1.SelectionColor = colorDialog1.Color;
                rich2.SelectionColor = colorDialog1.Color;
                rich4.SelectionColor = colorDialog1.Color;
            }
            else if (r == 4)
            {
                rich3.SelectionColor = colorDialog1.Color;
                richTextBox1.SelectionColor = colorDialog1.Color;
                rich2.SelectionColor = colorDialog1.Color;
                rich4.SelectionColor = colorDialog1.Color;
                rich5.SelectionColor = colorDialog1.Color;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            if (r == 0)
                richTextBox1.BackColor = colorDialog2.Color;
            else if (r == 1)
                rich2.BackColor = colorDialog2.Color;
            else if (r == 2)
                rich3.BackColor = colorDialog2.Color;
            else if (r == 3)
                rich4.BackColor = colorDialog2.Color;
            else if (r == 4)
                rich5.BackColor = colorDialog2.Color;
        }
        int wi;
        private void button7_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("C:\\ProgramData\\newnotepad"))
            {
                string indent = System.IO.File.ReadAllText("C:\\ProgramData\\newnotepad");
                wi = int.Parse(indent);
            }
            else
            {
                wi = 4;
            }

            if (r == 0)
            {
                richTextBox1.SelectionBullet = true;
                richTextBox1.BulletIndent = wi;
            }
            else if (r == 1)
            {
                richTextBox1.SelectionBullet = true;
                rich2.SelectionBullet = true; 
                richTextBox1.BulletIndent = wi;
                rich2.BulletIndent = wi;
            }
            else if (r == 2)
            {
                rich3.SelectionBullet = true;
                richTextBox1.SelectionBullet = true;
                rich2.SelectionBullet = true;
                richTextBox1.BulletIndent = wi;
                rich2.BulletIndent = wi;
                rich3.BulletIndent = wi;
            }
            else if (r == 3)
            {
                rich3.SelectionBullet = true;
                richTextBox1.SelectionBullet = true;
                rich2.SelectionBullet = true;
                rich4.SelectionBullet = true;
                richTextBox1.BulletIndent = wi;
                rich2.BulletIndent = wi;
                rich3.BulletIndent = wi;
                rich4.BulletIndent = wi;
            }
            else if (r == 4)
            {
                rich3.SelectionBullet = true;
                richTextBox1.SelectionBullet = true;
                rich2.SelectionBullet = true;
                rich4.SelectionBullet = true;
                rich5.SelectionBullet = true;
                richTextBox1.BulletIndent = wi;
                rich2.BulletIndent = wi;
                rich3.BulletIndent = wi;
                rich4.BulletIndent = wi;
                rich5.BulletIndent = wi;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (r == 0)
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            else if (r == 1)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                rich2.SelectionAlignment = HorizontalAlignment.Center;
            }
            else if (r == 2)
            {
                rich3.SelectionAlignment = HorizontalAlignment.Center;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                rich2.SelectionAlignment = HorizontalAlignment.Center;
            }
            else if (r == 3)
            {
                rich3.SelectionAlignment = HorizontalAlignment.Center;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                rich2.SelectionAlignment = HorizontalAlignment.Center;
                rich4.SelectionAlignment = HorizontalAlignment.Center;
            }
            else if (r == 4)
            {
                rich3.SelectionAlignment = HorizontalAlignment.Center;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                rich2.SelectionAlignment = HorizontalAlignment.Center;
                rich4.SelectionAlignment = HorizontalAlignment.Center;
                rich5.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (r == 0)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            }
            else if (r == 1)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                rich2.SelectionAlignment = HorizontalAlignment.Right;
            }
            else if (r == 2)
            {
                rich3.SelectionAlignment = HorizontalAlignment.Right;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                rich2.SelectionAlignment = HorizontalAlignment.Right;
            }
            else if (r == 3)
            {
                rich3.SelectionAlignment = HorizontalAlignment.Right;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                rich2.SelectionAlignment = HorizontalAlignment.Right;
                rich4.SelectionAlignment = HorizontalAlignment.Right;
            }
            else if (r == 4)
            {
                rich3.SelectionAlignment = HorizontalAlignment.Right;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                rich2.SelectionAlignment = HorizontalAlignment.Right;
                rich4.SelectionAlignment = HorizontalAlignment.Right;
                rich5.SelectionAlignment = HorizontalAlignment.Right;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (r == 0)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
            else if (r == 1)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                rich2.SelectionAlignment = HorizontalAlignment.Left;
            }
            else if (r == 2)
            {
                rich3.SelectionAlignment = HorizontalAlignment.Left;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                rich2.SelectionAlignment = HorizontalAlignment.Left;
            }
            else if (r == 3)
            {
                rich3.SelectionAlignment = HorizontalAlignment.Left;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                rich2.SelectionAlignment = HorizontalAlignment.Left;
                rich4.SelectionAlignment = HorizontalAlignment.Left;
            }
            else if (r == 4)
            {
                rich3.SelectionAlignment = HorizontalAlignment.Left;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                rich2.SelectionAlignment = HorizontalAlignment.Left;
                rich4.SelectionAlignment = HorizontalAlignment.Left;
                rich5.SelectionAlignment = HorizontalAlignment.Left;
            }
        }
        private void کپیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            جایگذاریToolStripMenuItem.Enabled = true;
            button14.Enabled = true;
            richTextBox1.Copy();
            rich2.Copy();
            rich3.Copy();
            rich4.Copy();
            rich5.Copy();
        }

        private void جایگذاریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (r == 0)
                richTextBox1.Paste();
            else if (r == 1)
                rich2.Paste();
            else if (r == 2)
                rich3.Paste();
            else if (r == 3)
                rich4.Paste();
            else if (r == 4)
                rich5.Paste();
        }

        private void درجعکسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "*.jpg|*.jpg|*.png|*.png|*.ico|*.ico";
                openFileDialog1.ShowDialog();
                Bitmap k = new Bitmap(openFileDialog1.FileName);
                Clipboard.SetDataObject(k);
                if (r == 0)
                    richTextBox1.Paste();
                else if (r == 1)
                    rich2.Paste();
                else if (r == 2)
                    rich3.Paste();
                else if (r == 3)
                    rich4.Paste();
                else if (r == 4)
                    rich5.Paste();
            }
            catch
            {
            }
        }

        private void تنظیماتکلیفونتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            if (r == 0)
                richTextBox1.Font = fontDialog1.Font;
            else if (r == 1)
            {
                richTextBox1.Font = fontDialog1.Font;
                rich2.Font = fontDialog1.Font;
            }
            else if (r == 2)
            {
                rich3.Font = fontDialog1.Font;
                richTextBox1.Font = fontDialog1.Font;
                rich2.Font = fontDialog1.Font;
            }
            else if (r == 3)
            {
                rich3.Font = fontDialog1.Font;
                richTextBox1.Font = fontDialog1.Font;
                rich2.Font = fontDialog1.Font;
                rich4.Font = fontDialog1.Font;
            }
            else if (r == 4)
            {
                rich3.Font = fontDialog1.Font;
                richTextBox1.Font = fontDialog1.Font;
                rich2.Font = fontDialog1.Font;
                rich4.Font = fontDialog1.Font;
                rich5.Font = fontDialog1.Font;
            }
        }

        private void ذخیرهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                save = false;
                saveFileDialog1.Filter = "*.bn|*.bn|*.txt|*.txt|*.pdf|*.pdf";
                saveFileDialog1.ShowDialog();
                System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text + rich2.Text + rich3.Text + rich4.Text + rich5.Text);
            }
            catch
            {
            }
        }
        FontFamily j;
        Font h;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            j = new FontFamily(comboBox1.SelectedItem.ToString());
            h = new Font(j,b );
            richTextBox1.SelectionFont = h;
            rich2.SelectionFont = h;
            rich3.SelectionFont = h;
            rich4.SelectionFont = h;
            rich5.SelectionFont = h;
        }
        int b;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            b = int.Parse(comboBox2.Text);
            Font h = new Font(comboBox1.Text, b);
            richTextBox1.SelectionFont = h;
            rich2.SelectionFont = h;
            rich3.SelectionFont = h;
            rich4.SelectionFont = h;
            rich5.SelectionFont = h;
        }

        private void جابهجاییToolStripMenuItem_Click(object sender, EventArgs e)
        {
            جایگذاریToolStripMenuItem.Enabled = true;
            button14.Enabled = true;
            richTextBox1.Cut();
            rich2.Cut();
            rich3.Cut();
            rich4.Cut();
            rich5.Cut();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (r == 0)
                richTextBox1.Paste();
            else if (r == 1)
                rich2.Paste();
            else if (r == 2)
                rich3.Paste();
            else if (r == 3)
                rich4.Paste();
            else if (r == 4)
                rich5.Paste();
        }
        int select = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            if (r == 0)
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Bold);
            }
            else if (r == 1)
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Bold);
                rich2.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Bold);
            }
            else if (r == 2)
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Bold);
                rich2.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Bold);
                rich3.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Bold);
            }
            else if (r == 3)
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Bold);
                rich2.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Bold);
                rich3.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Bold);
                rich4.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Bold);
            }
            else if (r == 4)
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Bold);
                rich2.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Bold);
                rich3.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Bold);
                rich4.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Bold);
                rich5.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Bold);
            }
            select++;
            if (select == 1)
            {
                button6.BackColor = Color.LightBlue;
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSansSerif, int.Parse(comboBox2.Text), FontStyle.Bold);
            }
            else
            {
                button6.BackColor = Color.Gray;
                select = 0;
            }
        }
        bool save = false;
        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            save = true;
        }

        private void بازکردنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "*.bn|*.bn|*.txt|*.txt";
                openFileDialog1.ShowDialog();
                string read = System.IO.File.ReadAllText(openFileDialog1.FileName);
                richTextBox1.Text = read;
            }
            catch
            {
            }
        }
        int qqqq = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            if (r == 0)
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Italic);
            }
            else if (r == 1)
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Italic);
                rich2.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Italic);
            }
            else if (r == 2)
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Italic);
                rich2.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Italic);
                rich3.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Italic);
            }
            else if (r == 3)
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Italic);
                rich2.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Italic);
                rich3.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Italic);
                rich4.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Italic);
            }
            else if (r == 4)
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Italic);
                rich2.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Italic);
                rich3.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Italic);
                rich4.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Italic);
                rich5.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Italic);
            }
            qqqq++;
            if (qqqq == 1)
            {
                button5.BackColor = Color.LightBlue;
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSansSerif, int.Parse(comboBox2.Text), FontStyle.Italic);
            }
            else
                button5.BackColor = Color.Gray;
        }
        int qq = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if (r == 0)
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Underline);
            }
            else if (r == 1)
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Underline);
                rich2.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Underline);
            }
            else if (r == 2)
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Underline);
                rich2.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Underline);
                rich3.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Underline);
            }
            else if (r == 3)
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Underline);
                rich2.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Underline);
                rich3.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Underline);
                rich4.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Underline);
            }
            else if (r == 4)
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Underline);
                rich2.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Underline);
                rich3.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Underline);
                rich4.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Underline);
                rich5.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Underline);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 j = new Form3();
            j.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string datetime;
        private void button16_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("C:\\ProgramData\\datetime.txt"))
            {
                datetime=System.IO.File.ReadAllText("C:\\ProgramData\\datetime.txt");
            }
            else
            {
                datetime = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;
            }
            Clipboard.SetText(datetime);
            if (r == 0)
                richTextBox1.Paste();
            else if (r == 1)
                rich2.Paste();
            else if (r == 2)
                rich3.Paste();
            else if (r == 3)
                rich4.Paste();
            else if (r == 4)
                rich5.Paste();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form4 j = new Form4();
            j.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (r == 0)
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Strikeout);
            }
            else if (r == 1)
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Strikeout);
                rich2.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Strikeout);
            }
            else if (r == 2)
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Strikeout);
                rich2.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Strikeout);
                rich3.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Strikeout);
            }
            else if (r == 3)
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Strikeout);
                rich2.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Strikeout);
                rich3.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Strikeout);
                rich4.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Strikeout);
            }
            else if (r == 4)
            {
                richTextBox1.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Strikeout);
                rich2.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Strikeout);
                rich3.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Strikeout);
                rich4.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Strikeout);
                rich5.SelectionFont = new Font(FontFamily.GenericSerif, int.Parse(comboBox2.Text), FontStyle.Strikeout);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {

     
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
        }
    }
}
