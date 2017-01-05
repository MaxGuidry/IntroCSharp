using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Button> buttons = new List<Button>();
            for(int i =0;i<60;i++)
            {
                buttons.Add(new Button());
                buttons[i].Size = new Size(20, 20);
                buttons[i].Location = new Point(3+i,3+i);
                buttons[i].Show();
                
                //System.Media.SoundPlayer wrong = new System.Media.SoundPlayer();
                //wrong.SoundLocation = "C:\\Users\\max.guidry\\Documents\\Visual Studio 2015\\Projects\\IntroCSharp\\WindowsFormsApplication1\\Wrong.wav";
                //wrong.Play();
                //MessageBox.Show("Wrong");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
