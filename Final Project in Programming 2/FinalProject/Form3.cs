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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e) //this is a submit button
        {
            if (string.IsNullOrEmpty(tbname.Text)||string.IsNullOrEmpty(tbCourse.Text)) //condition if textboxes are empty
            {
                //show message if the needed inputs are not filled
                MessageBox.Show("Inputs should not be empty!","Message Info1",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                //if inputs are filled, goto form2
                Form2 form2 = new Form2();
                form2.name = tbname.Text;
                form2.course = tbCourse.Text;
                form2.ShowDialog();
                this.Close();
            }
        }

        private void exitbutton_Click(object sender, EventArgs e) //exit button
        {
            //if exit button got cliked, goto form1
            Form1 form1= new Form1();
            form1.ShowDialog();
            this.Close();
        }
    }
}
