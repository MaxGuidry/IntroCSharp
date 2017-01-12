using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CombatFSM.Classes;
namespace CombatFSM
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
            Combat test = new Combat();
            test.partyOne = new Party();
            test.partyTwo = new Party();
            test.partyOne.playerOne = new Player("Jim");
            test.partyOne.playerTwo = new Player("Pam");
            test.partyOne.playerThree = new Player("Michael");
            test.partyTwo.playerOne = new Player("Leslie");
            test.partyTwo.playerTwo = new Player("Ron");
            test.partyTwo.playerThree = new Player("Ann");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


    }
}
