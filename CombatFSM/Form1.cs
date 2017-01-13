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
       System.Media.SoundPlayer fight = new System.Media.SoundPlayer();
       
        Combat test = new Combat();

        public Form1()
        {
            InitializeComponent();
            var a = new Party();
            var b = new Party();
            var c = new Player("Jim");
            var d = new Player("Pam");
            var e = new Player("Michael");
            var f = new Player("Leslie");
            var g = new Player("Ron");
            var h = new Player("Ann");
            fight.SoundLocation = "C:\\Users\\max.guidry\\Documents\\Visual Studio 2015\\Projects\\IntroCSharp\\CombatFSM\\attack.wav";
            test.AddParty(a);
            test.AddParty(b);
            test.AddPlayer(c, 1);
            test.AddPlayer(d, 1);
            test.AddPlayer(e, 1);
            test.AddPlayer(f, 2);
            test.AddPlayer(g, 2);
            test.AddPlayer(h, 2);
            richTextBox3.Text = "Player " + test.activeParty.activePlayer.Name + "'s turn.";
            richTextBox1.Text = "\n\n\n"+c.Name + "\n\n\n" + d.Name + "\n\n\n" + e.Name;
            richTextBox2.Text = "\n\n\n"+f.Name + "\n\n\n" + g.Name + "\n\n\n" + h.Name;
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            fight.Play();
            //test.incrementActivePlayer();
            test.activeParty.activePlayer.EndTurn();
            richTextBox3.Text = "Player " + test.activeParty.activePlayer.Name + "'s turn.";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //test.incrementActivePlayer();
            richTextBox3.Text = "Player " + test.activeParty.activePlayer.Name + "'s turn.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //test.incrementActivePlayer();
            richTextBox3.Text = "Player " + test.activeParty.activePlayer.Name + "'s turn.";
        }
    }
}
