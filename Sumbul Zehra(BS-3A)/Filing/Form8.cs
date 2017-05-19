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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox1.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo di in d)
            {
                comboBox2.Items.Add(di.ToString());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        //{
        //    string fpath = comboBox1.Text + comboBox2.Text + "\\";
        //    DirectoryInfo f = new DirectoryInfo(fpath);
        //    FileInfo[] files = f.GetFiles();
        //    foreach (FileInfo fi in files)
        //    {
        //        comboBox3.Items.Add(fi.ToString());
        //    }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string fpath = comboBox1.Text + comboBox2.Text + "/" +textBox2.Text;
            
            if (!File.Exists(fpath))
            {
                  StreamWriter sw = new StreamWriter(fpath);
            sw.Write(textBox1.Text);

            sw.Close();
                MessageBox.Show("File Created");
            }
            else
                MessageBox.Show("File Already Exists");
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
            
          
        }
    }

