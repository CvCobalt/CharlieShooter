namespace FinalProject
{
    partial class Form2
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
            this.shooter = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.ground = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BananaRipe = new System.Windows.Forms.PictureBox();
            this.OverRipe = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.lbPlayername = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbLives = new System.Windows.Forms.Label();
            this.lbGamelevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BananaRipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverRipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // shooter
            // 
            this.shooter.Image = global::FinalProject.Properties.Resources.shoot;
            this.shooter.Location = new System.Drawing.Point(226, 185);
            this.shooter.Name = "shooter";
            this.shooter.Size = new System.Drawing.Size(147, 103);
            this.shooter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shooter.TabIndex = 2;
            this.shooter.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.BackColor = System.Drawing.Color.SkyBlue;
            this.bullet.Image = global::FinalProject.Properties.Resources.bullet;
            this.bullet.Location = new System.Drawing.Point(368, 217);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(88, 30);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bullet.TabIndex = 3;
            this.bullet.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // ground
            // 
            this.ground.Image = global::FinalProject.Properties.Resources.grounde;
            this.ground.Location = new System.Drawing.Point(956, 434);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(453, 87);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 16;
            this.ground.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::FinalProject.Properties.Resources.grounde;
            this.pictureBox9.Location = new System.Drawing.Point(497, 434);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(674, 87);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 15;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.grounde;
            this.pictureBox1.Location = new System.Drawing.Point(3, 434);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // BananaRipe
            // 
            this.BananaRipe.Image = global::FinalProject.Properties.Resources.wholeBAnana;
            this.BananaRipe.Location = new System.Drawing.Point(1186, 65);
            this.BananaRipe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BananaRipe.Name = "BananaRipe";
            this.BananaRipe.Size = new System.Drawing.Size(51, 50);
            this.BananaRipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BananaRipe.TabIndex = 22;
            this.BananaRipe.TabStop = false;
            // 
            // OverRipe
            // 
            this.OverRipe.Image = global::FinalProject.Properties.Resources.overripe_banana;
            this.OverRipe.Location = new System.Drawing.Point(1273, 65);
            this.OverRipe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OverRipe.Name = "OverRipe";
            this.OverRipe.Size = new System.Drawing.Size(50, 50);
            this.OverRipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OverRipe.TabIndex = 23;
            this.OverRipe.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FinalProject.Properties.Resources.crate2;
            this.pictureBox2.Location = new System.Drawing.Point(34, 360);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FinalProject.Properties.Resources.crate2;
            this.pictureBox3.Location = new System.Drawing.Point(97, 360);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FinalProject.Properties.Resources.crate2;
            this.pictureBox4.Location = new System.Drawing.Point(69, 293);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(66, 70);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::FinalProject.Properties.Resources.crate2;
            this.pictureBox5.Location = new System.Drawing.Point(592, 401);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::FinalProject.Properties.Resources.crate2;
            this.pictureBox6.Location = new System.Drawing.Point(627, 369);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(66, 70);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 28;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::FinalProject.Properties.Resources.crate2;
            this.pictureBox7.Location = new System.Drawing.Point(685, 369);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(66, 70);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 29;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::FinalProject.Properties.Resources.crate2;
            this.pictureBox8.Location = new System.Drawing.Point(748, 403);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(46, 36);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 30;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Black;
            this.pictureBox10.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(1414, 60);
            this.pictureBox10.TabIndex = 31;
            this.pictureBox10.TabStop = false;
            // 
            // lbPlayername
            // 
            this.lbPlayername.AutoSize = true;
            this.lbPlayername.BackColor = System.Drawing.Color.Black;
            this.lbPlayername.Font = new System.Drawing.Font("Minecraft", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPlayername.ForeColor = System.Drawing.Color.White;
            this.lbPlayername.Location = new System.Drawing.Point(34, 17);
            this.lbPlayername.Name = "lbPlayername";
            this.lbPlayername.Size = new System.Drawing.Size(151, 32);
            this.lbPlayername.TabIndex = 32;
            this.lbPlayername.Text = "Player : ";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Black;
            this.lbScore.Font = new System.Drawing.Font("Minecraft", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbScore.ForeColor = System.Drawing.Color.White;
            this.lbScore.Location = new System.Drawing.Point(368, 17);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(142, 32);
            this.lbScore.TabIndex = 33;
            this.lbScore.Text = "Score : ";
            // 
            // lbLives
            // 
            this.lbLives.AutoSize = true;
            this.lbLives.BackColor = System.Drawing.Color.Black;
            this.lbLives.Font = new System.Drawing.Font("Minecraft", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLives.ForeColor = System.Drawing.Color.White;
            this.lbLives.Location = new System.Drawing.Point(685, 17);
            this.lbLives.Name = "lbLives";
            this.lbLives.Size = new System.Drawing.Size(121, 32);
            this.lbLives.TabIndex = 34;
            this.lbLives.Text = "Lives :";
            // 
            // lbGamelevel
            // 
            this.lbGamelevel.AutoSize = true;
            this.lbGamelevel.BackColor = System.Drawing.Color.Black;
            this.lbGamelevel.Font = new System.Drawing.Font("Minecraft", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbGamelevel.ForeColor = System.Drawing.Color.White;
            this.lbGamelevel.Location = new System.Drawing.Point(990, 17);
            this.lbGamelevel.Name = "lbGamelevel";
            this.lbGamelevel.Size = new System.Drawing.Size(123, 32);
            this.lbGamelevel.TabIndex = 35;
            this.lbGamelevel.Text = "Level :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1400, 500);
            this.Controls.Add(this.lbGamelevel);
            this.Controls.Add(this.lbLives);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbPlayername);
            this.Controls.Add(this.shooter);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BananaRipe);
            this.Controls.Add(this.OverRipe);
            this.Controls.Add(this.bullet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1400, 500);
            this.MinimumSize = new System.Drawing.Size(1400, 500);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.shooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BananaRipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverRipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox shooter;
        private PictureBox bullet;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox ground;
        private PictureBox pictureBox9;
        private PictureBox pictureBox1;
        private PictureBox BananaRipe;
        private PictureBox OverRipe;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox10;
        private Label lbScore;
        private Label lbLives;
        private Label lbGamelevel;
        protected Label lbPlayername;
    }
}