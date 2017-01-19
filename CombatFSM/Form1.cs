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
        //System.Media.SoundPlayer fight = new System.Media.SoundPlayer();

        Combat test = new Combat();
        System.Media.SoundPlayer fight = new System.Media.SoundPlayer();
        public Form1()
        {
            //test = DataManager<Combat>.Deserialize("Player");
            InitializeComponent();
            var a = new Party();
            var b = new Party();
            var c = new Player("Jim");
            var d = new Player("Pam");
            var e = new Player("Michael");
            var f = new Player("Leslie");
            var g = new Player("Ron");
            var h = new Player("Ann");
            fight.SoundLocation = @"..\..\Sounds\attack.wav";
            test.AddParty(a);
            test.AddParty(b);
            test.AddPlayer(c, 1);
            test.AddPlayer(d, 1);
            test.AddPlayer(e, 1);
            test.AddPlayer(f, 2);
            test.AddPlayer(g, 2);
            test.AddPlayer(h, 2);
            richTextBox3.Text = "Player " + test.activeParty.activePlayer.Name + "'s turn.";
            richTextBox1.Text = "\n\n\n" + c.Name + "\n\n\n" + d.Name + "\n\n\n" + e.Name;
            richTextBox2.Text = "\n\n\n" + f.Name + "\n\n\n" + g.Name + "\n\n\n" + h.Name;
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

            test.activeParty.activePlayer.EndTurn();
            //DataManager<Player>.Serialize("Player", ref test.activeParty.activePlayer);
            richTextBox3.Text = "Player " + test.activeParty.activePlayer.Name + "'s turn.";
        }
        private void button2_Click(object sender, EventArgs e)
        {

            test.activeParty.activePlayer.EndTurn();
            richTextBox3.Text = "Player " + test.activeParty.activePlayer.Name + "'s turn.";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            test.activeParty.activePlayer.EndTurn();
            richTextBox3.Text = "Player " + test.activeParty.activePlayer.Name + "'s turn.";
        }

        private void Load_Click(object sender, EventArgs e)
        {
            test = DataManager<Combat>.Deserialize("Player");
            test.OnLoad();
            richTextBox3.Text = "Player " + test.activeParty.activePlayer.Name + "'s turn.";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DataManager<Combat>.Serialize("Player", ref test);
        }
    }
}
