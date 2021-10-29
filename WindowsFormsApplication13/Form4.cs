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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(DateTime.Now.Hour+":"+DateTime.Now.Minute+":"+DateTime.Now.Second);
            listBox1.Items.Add(DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day);
            listBox1.Items.Add(DateTime.Now.Year + "," + DateTime.Now.Month + "," + DateTime.Now.Day);
            listBox1.Items.Add(DateTime.Now.Year + ":" + DateTime.Now.Month + ":" + DateTime.Now.Day + ":" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string datetime = listBox1.SelectedItem.ToString();
            System.IO.File.WriteAllText("C:\\ProgramData\\datetime.txt", datetime);
            this.Close();
        }
    }
}
