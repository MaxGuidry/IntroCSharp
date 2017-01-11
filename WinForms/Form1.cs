using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinForms
{
    public partial class Form1 : Form
    {
        public Player Hero = new Player();
        public Form1()
        {
            InitializeComponent();

            richTextBox1.Text = "Player Level: " + Hero.Level;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hero.addEXP(30);


            if (Hero.Exp >= Hero.MaxExp)
            {
                Hero.levelUp();
                progressBar1.Value = 100;
                MessageBox.Show("LEVEL UP!");
            }

            progressBar1.Value = (int)((Hero.Exp/Hero.MaxExp)*100);
            richTextBox1.Text = "Player Level: " + Hero.Level+"\n"+"Exp: " + Hero.Exp +"/" + (int)Hero.MaxExp;
           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class Player
    {
        public Player()
        {
            m_level = 1;
            m_exp = 0;
            m_maxExp = 100;
        }

        public void addEXP(int exp)
        {
            m_exp += exp;
        }
        public void levelUp()
        {

            m_level++;
            m_exp -= (int)m_maxExp;
            
            m_maxExp = Math.Pow((double)100, (double)(m_level+2)/(double)5)+(double)100;
        }
        private int m_exp;
        private int m_level;
        public int Exp { get { return m_exp; } }
        public int Level { get { return m_level; } }
        private double m_maxExp;
        public double MaxExp { get { return m_maxExp; } }
    }

    public delegate Player test(Player hero);
    

}
