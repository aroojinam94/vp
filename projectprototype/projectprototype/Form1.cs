using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectprototype
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //About ab = new About();
            //ab.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Puzzle ps = new Puzzle();
            this.Hide();
            ps.Show();
    
        }

        private void labelStart_Click(object sender, EventArgs e)
        {
            Puzzle ps = new Puzzle();
            this.Hide();
            ps.Show();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Puzzle ps = new Puzzle();
            this.Hide();
            ps.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
