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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if(char.IsLetter((char)e.KeyCode))
            {
                e.SuppressKeyPress = true;                
            }
            if (e.KeyCode == Keys.Enter)
            {
                string z = textBox1.Text;
                System.IO.File.WriteAllText("C:\\ProgramData\\newnotepad", z);
                this.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
