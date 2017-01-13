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
        Combat test = new Combat();

        public Form1()
        {
            InitializeComponent();
            var a = new Party();
            var b = new Party();
            var c= new Player("Jim");
            var d= new Player("Pam");
            var e = new Player("Michael");
            var f= new Player("Leslie");
            var g= new Player("Ron");
            var h = new Player("Ann");
           
            test.addParty(a);
            test.addParty(b);
            test.addPlayer(c, 1);
            test.addPlayer(d, 1);
            test.addPlayer(e, 1);
            test.addPlayer(f, 2);
            test.addPlayer(g, 2);
            test.addPlayer(h, 2);
            richTextBox3.Text = "Player " + test.activeParty.activePlayer.Name + "'s turn.";
            richTextBox1.Text = test.activeParty.activePlayer.Name+ "\n\n\n"+test.activeParty.activePlayer.Name+"\n\n\n"+test.activeParty.activePlayer.Name;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            test.incrementActivePlayer();
            richTextBox3.Text = "Player " + test.activeParty.activePlayer.Name + "'s turn.";
            
            
        }
        private void button2_Click(object sender, EventArgs e)
        {

            test.incrementActivePlayer();
            richTextBox3.Text = "Player " + test.activeParty.activePlayer.Name + "'s turn.";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            test.incrementActivePlayer();
            richTextBox3.Text = "Player " + test.activeParty.activePlayer.Name + "'s turn.";
        }

      
    }
}
