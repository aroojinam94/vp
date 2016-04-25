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
    public partial class Puzzle : Form
    {
        Button [,] Tiles =new  Button[3,3];
        public Puzzle()
        {
            InitializeComponent();
            initalize_board();
        }
        private void initalize_board()
        {
            int x = 12, y = 50;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Tiles[i, j] = new Button();
                    Tiles[i, j].Size = new Size(100, 100);
                    Tiles[i, j].Tag = i.ToString() + j.ToString();
                    Tiles[i, j].Location = new Point(x, y);
                    Tiles[i, j].Click += new EventHandler(Tile_Clicked);
                    Tiles[i, j].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    Tiles[i, j].Enabled = false;
                    this.Controls.Add( Tiles [i,j]);
                        x+=100;
                }
                y+=120;
                x=12;
   }

            }

private void Tile_Clicked(object sender, EventArgs e)
{
 	throw new NotImplementedException();
}

        
      private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void playb_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Puzzle_Load(object sender, EventArgs e)
        {

        }
    }
}




