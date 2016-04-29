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
        int moves = 0;
        Button [,] Tiles =new  Button[3,3];
        List<Image>list= new List<Image>();
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
                    Tiles[i, j].Size = new Size(150, 150);
                    Tiles[i, j].Tag = i.ToString() + j.ToString();
                    Tiles[i, j].Location = new Point(x, y);
                    Tiles[i, j].Click += new EventHandler(Tile_Clicked);
                    Tiles[i, j].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    Tiles[i, j].Enabled = false;
                    this.Controls.Add( Tiles [i,j]);
                        x+=150;
                }
                y+=150;
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
            using (OpenFileDialog dlg =new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg|png files(*.png)|*.png";
                if (dlg.ShowDialog()==DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(dlg.FileName); 
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    for( int i=0;i<3;i++)
                    {
                        for (int y = 0; y < 3; y++)
                        {
                            Rectangle r= new Rectangle( i * (pictureBox1.Image.Width /3),
                                                       y * ( pictureBox1.Image.Height /3),
                                                       pictureBox1.Image.Width /3,
                                                       pictureBox1.Image.Height /3);


                            list.Add(cropImage(pictureBox1.Image, r));   

                            
                        }


                    }
                    pictureBox1.Invalidate();

                    int Num = 1;
                    for( int i=0; i<3;i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                             LoadPicture(dlg.FileName, Num, i, j);
                            Num++;
                        }
                    }

                }

            
            }
            ShuffleB.Visible = true;
        }
       
        private static Image cropImage(Image img , Rectangle cropArea)
            {
                 Bitmap bmpImage=new Bitmap(img);
                 Bitmap bmpCrop=bmpImage.Clone( cropArea,System.Drawing.Imaging.PixelFormat.DontCare);
                 return (Image)(bmpCrop);
            }
        private void LoadPicture (string path, int Num, int i, int j )
        {
        if (Num==1)
            Tiles[i,j].BackgroundImage=list[0];
        else if(Num==2)
            Tiles[i,j].BackgroundImage=list[3];
        else if(Num==3)
            Tiles[i,j].BackgroundImage=list[6];
        else if(Num==4)
             Tiles[i,j].BackgroundImage=list[1];
        else if(Num==5)
            Tiles[i,j].BackgroundImage=list[4];
        else if(Num==6)
            Tiles[i,j].BackgroundImage=list[7];
        else if(Num==7)
            Tiles[i,j].BackgroundImage=list[2];
        else if(Num==8)
            Tiles[i,j].BackgroundImage=list[5];

            if (i==2 && j==2)
            {
            Tiles[i, j].Text="";
                Tiles[i, j].BackColor=Color.Red;
                Tiles[i,j].BackgroundImage= new Bitmap(path);
                Tiles[i, j].BackgroundImage.Tag=9;

             }
            Tiles[i, j].BackgroundImage .Tag=Num;
        }
        private void Shuffle()
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




