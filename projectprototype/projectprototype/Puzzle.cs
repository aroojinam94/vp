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
        
        string path = System.IO.Directory.GetCurrentDirectory();// gets the current working directory of application 
        int moves = 0;
        Button [,] Tiles =new  Button[3,3];
        List<Image>list= new List<Image>();// img list //
        int timeLeft = 150;
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



        
      private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void choosepic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg =new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg|png files(*.png)|*.png";
                if (dlg.ShowDialog()==DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(dlg.FileName); //path of pictuire 
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

                        button1Shuffle.Visible = true;
                    }
                    pictureBox1.Invalidate(); // redraw picture 

                    int Num = 1;
                    for( int i=0; i<3;i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                             LoadPicture(Num, i, j);
                            Num++;
                        }
                    }

                }

            
            }
            button1Shuffle.Visible = true;
            choosepic.Visible = false;
        }
       
        private static Image cropImage(Image img , Rectangle cropArea)
            {
                 Bitmap bmpImage=new Bitmap(img);
                 Bitmap bmpCrop=bmpImage.Clone( cropArea,System.Drawing.Imaging.PixelFormat.DontCare);
                 return (Image)(bmpCrop);
            }
        private void LoadPicture (int Num, int i, int j )
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
            Tiles[i, j].Text=" ";
               
                Tiles[i,j].BackgroundImage= new Bitmap(path+"\\thinking.jpg");
                Tiles[i,j].BackgroundImage.Tag=9;

             }
            Tiles[i, j].BackgroundImage.Tag=Num;
        }
       
        private void Shuffle( )
       
        {
            try
            {
                var random = new Random();
                var intArray = Enumerable.Range(1, 8).OrderBy(t => random.Next()).ToArray();
                int Num = 0;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (i == 2 && j == 2)
                            break;
                        if (intArray[Num] == 1)
                            Tiles[i, j].BackgroundImage = list[0];
                        if (intArray[Num] == 2)
                            Tiles[i, j].BackgroundImage = list[3];
                        if (intArray[Num] == 3)
                            Tiles[i, j].BackgroundImage = list[6];
                        if (intArray[Num] == 4)
                            Tiles[i, j].BackgroundImage = list[1];
                        if (intArray[Num] == 5)
                            Tiles[i, j].BackgroundImage = list[4];
                        if (intArray[Num] == 6)
                            Tiles[i, j].BackgroundImage = list[7];
                        if (intArray[Num] == 7)
                            Tiles[i, j].BackgroundImage = list[2];
                        if (intArray[Num] == 8)
                            Tiles[i, j].BackgroundImage = list[5];

                        Num++;

                    }


                }
                Tiles[2, 2].BackgroundImage = new Bitmap(path + "\\thinking.jpg");
                Tiles[2, 2].BackgroundImage.Tag = 9;
            }

            catch(Exception )
            {
                MessageBox.Show("Select Picture first" );
            }
  
        }
        private void CheckIfComplete()
        {
            int Num = 1;
            bool ifComplete = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 2 && j == 2)
                        break;
                    if (Tiles[i, j].BackgroundImage.Tag.ToString() != Num.ToString())
                    {
                        ifComplete = false;
                        break;
                    }
                    Num++;
                }
            
            }
            if (ifComplete)
            {
                timer1.Stop();
                Tiles[2, 2].BackColor = Color.Green;
                Tiles[2, 2].BackgroundImage = list[8];
                MessageBox.Show("Puzzle Solved ");
                this.Hide();
            
            }
        
 }
        private void SeeIfThereIsAMove(Button bClicked, int i, int j)
        {
            //if Above
            string SwapTag;
            if ((i - 1) >= 0)
            {
                if (Tiles[i - 1, j].Text == " ")
                {
                    
                    SwapTag = Tiles[i - 1, j].BackgroundImage.Tag.ToString();
                    Tiles[i - 1, j].Text = "";
                    Tiles[i - 1, j].BackgroundImage = bClicked.BackgroundImage;
                    bClicked.Text = " ";
                    bClicked.BackColor = Color.Red;
                    bClicked.BackgroundImage = new Bitmap(path + "\\thinking.jpg");
                    bClicked.BackgroundImage.Tag = SwapTag;
                    Tiles[i - 1, j].Focus();
                }
            }
            if ((j + 1) < 3)//if Right
            {
                if (Tiles[i, j + 1].Text == " ")
                {
                    
                    SwapTag = Tiles[i, j + 1].BackgroundImage.Tag.ToString();
                    Tiles[i, j + 1].Text = "";
                    Tiles[i, j + 1].BackgroundImage = bClicked.BackgroundImage;
                    bClicked.Text = " ";
                    bClicked.BackColor = Color.Red;
                    bClicked.BackgroundImage = new Bitmap(path + "\\thinking.jpg");
                    bClicked.BackgroundImage.Tag = SwapTag;
                    Tiles[i, j + 1].Focus();
                }
            }
            if ((j - 1) >= 0)//if Left
            {
                if (Tiles[i, j - 1].Text == " ")
                {
                   
                    SwapTag = Tiles[i, j - 1].BackgroundImage.Tag.ToString();
                    Tiles[i, j - 1].Text = "";
                    Tiles[i, j - 1].BackgroundImage = bClicked.BackgroundImage;
                    bClicked.Text = " ";
                    bClicked.BackColor = Color.Red;
                    bClicked.BackgroundImage = new Bitmap(path + "\\thinking.jpg");
                    bClicked.BackgroundImage.Tag = SwapTag;
                    Tiles[i, j - 1].Focus();
                }
            }
            if (i + 1 < 3)//if Down
            {
                if (Tiles[i + 1, j].Text == " ")
                {
                    
                    SwapTag = Tiles[i + 1, j].BackgroundImage.Tag.ToString();
                    Tiles[i + 1, j].Text = "";
                    Tiles[i + 1, j].BackgroundImage = bClicked.BackgroundImage;
                    bClicked.Text = " ";
                    bClicked.BackColor = Color.Red;
                    bClicked.BackgroundImage = new Bitmap(path + "\\thinking.jpg");
                    bClicked.BackgroundImage.Tag = SwapTag;
                    Tiles[i + 1, j].Focus();
                }
            }
            CheckIfComplete();
            playbtn.Visible = false;
            
        }
        private void Tile_Clicked(object sender, EventArgs e)
        {
            Button bClicked = (Button)sender;
            string Location = bClicked.Tag.ToString();
            int x = Convert.ToInt32(Location[0] - 48);
            int y = Convert.ToInt32(Location[1] - 48);
            SeeIfThereIsAMove(bClicked, x, y);
            moves++;
            this.label4CMoves.Text = moves.ToString();
            //MessageBox.Show("CHECKED");
        }

      
        
        



        private void button1Shuffle_Click(   object sender, EventArgs e)
        {
            
            Shuffle();
            playbtn.Visible = true;
           button1Shuffle.Visible = false;
           
        }

        private void label1Time_Click(object sender, EventArgs e)
        {

        }

        private void label7Moves_Click(object sender, EventArgs e)
        {

        }

        private void Puzzle_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void playbtn_Click(object sender, EventArgs e)
        {
            playbtn.Visible = false;
            timer1.Start();
            for (int i = 0; i < 3; i++ )
            {
                for (int j = 0; j < 3; j++)
                {
                    Tiles[i, j].Enabled = true;
                
                
                }
            
            }
            solveB.Visible = true;
        }

        private void label4CMoves_Click(object sender, EventArgs e)
        {

        }

        private void label6timeleft_Click(object sender, EventArgs e)
        {

        }

        private void sloveB_Click(object sender, EventArgs e)
        {
            try
            {

                Tiles[0, 0].BackgroundImage = list[0];
                Tiles[0, 1].BackgroundImage = list[3];
                Tiles[0, 2].BackgroundImage = list[6];
                Tiles[1, 0].BackgroundImage = list[1];
                Tiles[1, 1].BackgroundImage = list[4];
                Tiles[1, 2].BackgroundImage = list[7];
                Tiles[2, 0].BackgroundImage = list[2];
                Tiles[2, 1].BackgroundImage = list[5];
                Tiles[2, 2].BackgroundImage = list[8];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Tiles[i, j].Enabled = false;


                    }

                }
                timer1.Stop();
                MessageBox.Show("Game Solved", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Select Picture first");
            }



         }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                label1Time.Text = timeLeft.ToString() + " sec";
            }
            else
            {
                timer1.Stop();
                label1Time.Text = "Times Up: ";
                MessageBox.Show("You didn't finish in time. SORRY!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Close();


            }
        }

        private void solveBtn_Click(object sender, EventArgs e)
        {

        }

        private void lblSolve_Click(object sender, EventArgs e)
        {

        }
    }
}




