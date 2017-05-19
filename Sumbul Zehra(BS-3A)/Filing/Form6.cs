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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DirectoryInfo dir = new DirectoryInfo(comboBox1.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo di in d) { comboBox2.Items.Add(di.ToString()); }
        }
        

        private void Form6_Load(object sender, EventArgs e)
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

            comboBox1.Items.Add("C:\\");
            comboBox1.Items.Add("D:\\");
            comboBox1.Items.Add("E:\\");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dpath = comboBox1.Text + comboBox2.Text + "\\" +comboBox3.Text;
            if (File.Exists(dpath))
            {

                File.Delete(dpath);
                MessageBox.Show("File has been deleted.");
            }
            else
                MessageBox.Show("File Not Found");
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
                comboBox3.Items.Add(fi.ToString());
            }
        }
    }
}
