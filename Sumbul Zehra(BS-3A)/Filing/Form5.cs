using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Filing
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            this.button2.FlatStyle = FlatStyle.Popup;
            this.button2.BackColor = Color.LightSlateGray;
            this.button2.ForeColor = Color.White;
            this.button3.FlatStyle = FlatStyle.Popup;
            this.button3.BackColor = Color.LightSlateGray;
            this.button3.ForeColor = Color.White;

            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.DodgerBlue;
            this.ControlBox = false; 
            this.button1.FlatStyle = FlatStyle.Popup;
            this.button1.BackColor = Color.LightSlateGray;
            this.button1.ForeColor = Color.White;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox1.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo di in d) { comboBox2.Items.Add(di.ToString()); }
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox3.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo di in d) 
            { 
                comboBox4.Items.Add(di.ToString()); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string spath = comboBox1.Text + comboBox2.Text + "\\" + comboBox5.Text;
            string dpath = comboBox3.Text + comboBox4.Text + "\\" + comboBox5.Text;
            if (!File.Exists(dpath))
            {
                File.Move(spath, dpath);
                MessageBox.Show("File Moved!");
            }
            else
                MessageBox.Show("File Already Existed!");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fpath = comboBox1.Text + comboBox2.Text + "\\";
            DirectoryInfo f = new DirectoryInfo(fpath);
            FileInfo[] files = f.GetFiles();
            foreach (FileInfo fi in files)
            {
                comboBox5.Items.Add(fi.ToString());
            }
        }
    }
}
