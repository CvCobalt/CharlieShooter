using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form2 : Form
    {
        //game variables
        public string course;
        public string name;
        public int score = 0;
        public int lives = 5;

        public Form2()
        {
            InitializeComponent();


        }

        //GameRules is the function that will check every condition inside and perform
        public void GameRules()
        {
            //this is a condition if the bullet hits the ripe banana
            if (bullet.Bounds.IntersectsWith(BananaRipe.Bounds))
            {
                SoundPlayer hitSound = new SoundPlayer(@"C:\Users\Charles Mc\Desktop\Final Project in Programming 2\FinalProject\bin\Debug\net6.0-windows\mixkit-sword-cutting-flesh-2788.wav");
                hitSound.Play();
                BananaRipe.Top = 500;
                score += 5;            
                lbScore.Text = "Score : " + score;     
                bullet.Image = Properties.Resources.gotHit;
            }
            //this condition is for overripe banana if hits
            if (bullet.Bounds.IntersectsWith(OverRipe.Bounds))  
            {
                SoundPlayer overripehitsound = new SoundPlayer(@"C:\Users\Charles Mc\Desktop\Final Project in Programming 2\FinalProject\bin\Debug\net6.0-windows\exiting sound.wav");
                overripehitsound.Play();
                OverRipe.Top = 500;
                lives -= 1;     
                lbLives.Text = "Lives : " + lives;     
                bullet.Image = Properties.Resources.gotHit;
            }
            //
            //this is the condition if the lives runs out
            if (lives == 0)
            {
                //if lives runs out, game will over
                gameOver();
            }
            //
            //this is the condition the game's level
            if (score < 100)
            {
                //easy level
                lbGamelevel.Text = "Level : Easy";
            }
            if (score >= 100)
            {
                //medium level. speed of overripe banana increases by 2
                lbGamelevel.Text = "Level : Medium";
                OverRipe.Top +=2;
            }
            if (score >= 200)
            {
                //hard level. banana increases speed by 1 and overripe banana increases speed by 3
                lbGamelevel.Text = "Level : Hard";
                BananaRipe.Top += 1;
                OverRipe.Top += 3;
            }
            if (score >= 500)
            {
                //impossible level. banana speed increases by 2 and overripe banana increases by 5
                lbGamelevel.Text = "Level : Impossible!";
                BananaRipe.Top += 2;
                OverRipe.Top += 5;
            }


        }
        //shooting function
        public void Shoot()     
        {   
            bullet.Left += 150;     //travel time of bullet when fired
            if (bullet.Left > 1400)     
            {
                shooter.Image = Properties.Resources.shoot_idle; 
                bullet.Image = Properties.Resources.bullet;
                bullet.Top = shooter.Top + bullet.Width / 2;
            }
        }


        //timercontrol that executes a code block at a specified interval of time repeatedly
        private void gameTimer_Tick(object sender, EventArgs e) 
        {

            Shoot();
            bananaMovement();
            GameRules();
            randomSpawn();

        }

        //condtion if the key down is pressed
        private void gameKeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Up)       //upward movement
            {
                if (shooter.Top > 74) 
                {
                    shooter.Top -= 40;
                    bullet.Top = shooter.Top + bullet.Width / 2;
                }
            }
            if (e.KeyCode == Keys.Down)     //downward movement
            {
                if (shooter.Top < 336)
                {
                    shooter.Top += 40;
                    bullet.Top = shooter.Top + bullet.Width / 2;
                }
            }
            if (e.KeyCode == Keys.Space)    //shoot when spacebar is pressed
            {
                SoundPlayer laserGun = new SoundPlayer(@"C:\Users\Charles Mc\Desktop\Final Project in Programming 2\FinalProject\bin\Debug\net6.0-windows\sf_laser_18.wav");
                laserGun.Play();
                bullet.Left = shooter.Left; 
                shooter.Image = Properties.Resources.shoot;

            }

        }

        //banana movement from top to bottom
        public void bananaMovement()
        {
            OverRipe.Top += 1;
            if (BananaRipe.Top < 387) //condition for banana if hits the ground
            {
                if (BananaRipe.Bounds.IntersectsWith(ground.Bounds))
                {
                    SoundPlayer hitground = new SoundPlayer(@"C:\Users\Charles Mc\Desktop\Final Project in Programming 2\FinalProject\bin\Debug\net6.0-windows\mixkit-click-error-1110.wav");
                    hitground.Play();
                    lives -= 1;
                    lbLives.Text = "Lives : " + lives;
                }
            }

        }
        //random spawn is a function for spawning the banana and the overripe banana in the specific area
        public void randomSpawn()
        {
            Random random = new Random();
            int x, y;
            if (BananaRipe.Top > 400)
            {
                BananaRipe.Top = 65;
                x = random.Next(900, 1300);
                BananaRipe.Location = new Point(x);
            }
            if (OverRipe.Top > 400)
            {
                OverRipe.Top = 400;
                y = random.Next(900, 1300);
                OverRipe.Location = new Point(y);
            }
            else
            {
                BananaRipe.Top +=1;
                OverRipe.Top +=1;
            }

        }
        //gameover function
        public void gameOver()
        {
            //if gameover, timer will stop
            gameTimer.Stop();
            //gameover sound effect
            SoundPlayer gameoverSound = new SoundPlayer(@"C:\Users\Charles Mc\Desktop\Final Project in Programming 2\FinalProject\bin\Debug\net6.0-windows\gameover.wav");
            gameoverSound.Play();
            //if gameover goto form4 to see game details such as scores and names
            Form4 form4 = new Form4(name,course,score);
            form4.ShowDialog();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbPlayername.Text = "Player : "+name;
            lbLives.Text = "Lives : " + lives;
            lbScore.Text = "Score : " + score;

        }
    }
}
