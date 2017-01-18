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
using Serializing.Classes;
namespace Serializing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            Student test = new Student(richTextBox1.Text, (int)numericUpDown1.Value, richTextBox2.Text);
            DataManager<Student>.Serialize("Student", ref test);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student temp = DataManager<Student>.Deserialize("Student");
            richTextBox1.Text = temp.NAME;
            numericUpDown1.Value = temp.AGE;
            richTextBox2.Text = temp.ID;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
