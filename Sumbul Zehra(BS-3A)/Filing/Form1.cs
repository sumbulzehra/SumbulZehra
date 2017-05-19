using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
             groupBox5.Visible = true;
        
        }

  

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button1.FlatStyle = FlatStyle.Popup;
            this.button1.BackColor = Color.LightSlateGray;
            this.button1.ForeColor = Color.White;

            this.button3.FlatStyle = FlatStyle.Popup;
            this.button3.BackColor = Color.LightSlateGray;
            this.button3.ForeColor = Color.White;

            this.button4.FlatStyle = FlatStyle.Popup;
            this.button4.BackColor = Color.LightSlateGray;
            this.button4.ForeColor = Color.White;

            this.button5.FlatStyle = FlatStyle.Popup;
            this.button5.BackColor = Color.LightSlateGray;
            this.button5.ForeColor = Color.White;


     


            this.button7.FlatStyle = FlatStyle.Popup;
            this.button7.BackColor = Color.LightSlateGray;
            this.button7.ForeColor = Color.White;


            this.button8.FlatStyle = FlatStyle.Popup;
            this.button8.BackColor = Color.LightSlateGray;
            this.button8.ForeColor = Color.White;

        }

       
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Form7 f7= new Form7();
            f7.Show();
            this.Hide();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            this.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.groupBox2.Visible = true;
        }


        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Hide();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
