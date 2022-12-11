using System.Media;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        Form3 form3 = new Form3();

        public Form1()
        {
            InitializeComponent();
            //play background music while in form1
            SoundPlayer bgMusic = new SoundPlayer(@"C:\Users\Charles Mc\Desktop\Final Project in Programming 2\FinalProject\bin\Debug\net6.0-windows\mixkit-bootleg-1055.wav");
            bgMusic.PlayLooping();
        }
        //
        //play the game if the play button get clicked
        private void PlayButton_Click(object sender, EventArgs e)
        {
            form3.ShowDialog();
            this.Close();
        }
        //
        // program will teminate if exit button get clicked
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}