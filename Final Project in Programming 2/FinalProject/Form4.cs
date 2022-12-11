using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form4 : Form
    {
        public Form4(string Pname, string Pcourse, int Pscore)
        {
            InitializeComponent();
            lbresultPlayername.Text = "Player name : " + Pname;
            lbresultScore.Text = "Score : "+ Pscore;
            lbresultCourse.Text = "Course : "+ Pcourse;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            //return to from1 if exit button is clicked
            Form1 form1= new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //return to from2 is restart button clicked
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }
    }
}
