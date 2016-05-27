namespace projectprototype
{
    partial class Puzzle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Puzzle));
            this.choosepic = new System.Windows.Forms.Button();
            this.label4CMoves = new System.Windows.Forms.Label();
            this.button1Shuffle = new System.Windows.Forms.Button();
            this.playbtn = new System.Windows.Forms.Button();
            this.label6timeleft = new System.Windows.Forms.Label();
            this.label1Time = new System.Windows.Forms.Label();
            this.label7Moves = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.solveB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // choosepic
            // 
            this.choosepic.BackColor = System.Drawing.SystemColors.Control;
            this.choosepic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.choosepic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosepic.Location = new System.Drawing.Point(651, 8);
            this.choosepic.Name = "choosepic";
            this.choosepic.Size = new System.Drawing.Size(137, 36);
            this.choosepic.TabIndex = 9;
            this.choosepic.Text = "Choose Picture ";
            this.choosepic.UseVisualStyleBackColor = false;
            this.choosepic.Click += new System.EventHandler(this.choosepic_Click);
            // 
            // label4CMoves
            // 
            this.label4CMoves.AutoSize = true;
            this.label4CMoves.BackColor = System.Drawing.Color.Transparent;
            this.label4CMoves.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4CMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4CMoves.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4CMoves.Location = new System.Drawing.Point(585, 25);
            this.label4CMoves.Name = "label4CMoves";
            this.label4CMoves.Size = new System.Drawing.Size(19, 20);
            this.label4CMoves.TabIndex = 13;
            this.label4CMoves.Text = "0";
            this.label4CMoves.Click += new System.EventHandler(this.label4CMoves_Click);
            // 
            // button1Shuffle
            // 
            this.button1Shuffle.BackColor = System.Drawing.SystemColors.Control;
            this.button1Shuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1Shuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Shuffle.Location = new System.Drawing.Point(38, 510);
            this.button1Shuffle.Name = "button1Shuffle";
            this.button1Shuffle.Size = new System.Drawing.Size(374, 27);
            this.button1Shuffle.TabIndex = 14;
            this.button1Shuffle.Text = "Shuffle";
            this.button1Shuffle.UseVisualStyleBackColor = false;
            this.button1Shuffle.Visible = false;
            this.button1Shuffle.Click += new System.EventHandler(this.button1Shuffle_Click);
            // 
            // playbtn
            // 
            this.playbtn.BackColor = System.Drawing.SystemColors.Control;
            this.playbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playbtn.Location = new System.Drawing.Point(794, 8);
            this.playbtn.Name = "playbtn";
            this.playbtn.Size = new System.Drawing.Size(137, 36);
            this.playbtn.TabIndex = 15;
            this.playbtn.Text = "Play Game";
            this.playbtn.UseVisualStyleBackColor = false;
            this.playbtn.Visible = false;
            this.playbtn.Click += new System.EventHandler(this.playbtn_Click);
            // 
            // label6timeleft
            // 
            this.label6timeleft.AutoSize = true;
            this.label6timeleft.BackColor = System.Drawing.Color.Transparent;
            this.label6timeleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6timeleft.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6timeleft.Location = new System.Drawing.Point(490, 6);
            this.label6timeleft.MinimumSize = new System.Drawing.Size(88, 18);
            this.label6timeleft.Name = "label6timeleft";
            this.label6timeleft.Size = new System.Drawing.Size(88, 18);
            this.label6timeleft.TabIndex = 17;
            this.label6timeleft.Text = "TimeLeft:";
            this.label6timeleft.Click += new System.EventHandler(this.label6timeleft_Click);
            // 
            // label1Time
            // 
            this.label1Time.AutoSize = true;
            this.label1Time.BackColor = System.Drawing.Color.Transparent;
            this.label1Time.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1Time.Location = new System.Drawing.Point(584, 4);
            this.label1Time.MinimumSize = new System.Drawing.Size(19, 20);
            this.label1Time.Name = "label1Time";
            this.label1Time.Size = new System.Drawing.Size(19, 20);
            this.label1Time.TabIndex = 18;
            this.label1Time.Text = "0";
            this.label1Time.Click += new System.EventHandler(this.label1Time_Click);
            // 
            // label7Moves
            // 
            this.label7Moves.AutoSize = true;
            this.label7Moves.BackColor = System.Drawing.Color.Transparent;
            this.label7Moves.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7Moves.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7Moves.Location = new System.Drawing.Point(490, 26);
            this.label7Moves.MinimumSize = new System.Drawing.Size(88, 18);
            this.label7Moves.Name = "label7Moves";
            this.label7Moves.Size = new System.Drawing.Size(88, 18);
            this.label7Moves.TabIndex = 19;
            this.label7Moves.Text = "Moves:";
            this.label7Moves.Click += new System.EventHandler(this.label7Moves_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(478, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 446);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // solveB
            // 
            this.solveB.AutoSize = true;
            this.solveB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.solveB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveB.Location = new System.Drawing.Point(879, 512);
            this.solveB.Name = "solveB";
            this.solveB.Size = new System.Drawing.Size(52, 25);
            this.solveB.TabIndex = 20;
            this.solveB.Text = "Solve";
            this.solveB.UseVisualStyleBackColor = true;
            this.solveB.Visible = false;
            this.solveB.Click += new System.EventHandler(this.sloveB_Click);
            // 
            // Puzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(943, 544);
            this.Controls.Add(this.solveB);
            this.Controls.Add(this.label7Moves);
            this.Controls.Add(this.label1Time);
            this.Controls.Add(this.label6timeleft);
            this.Controls.Add(this.playbtn);
            this.Controls.Add(this.button1Shuffle);
            this.Controls.Add(this.label4CMoves);
            this.Controls.Add(this.choosepic);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Puzzle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiles puzzle";
            this.Load += new System.EventHandler(this.Puzzle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button choosepic;
        private System.Windows.Forms.Label label4CMoves;
        private System.Windows.Forms.Button button1Shuffle;
        private System.Windows.Forms.Button playbtn;
        private System.Windows.Forms.Label label6timeleft;
        private System.Windows.Forms.Label label1Time;
        private System.Windows.Forms.Label label7Moves;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button solveB;

    }
}