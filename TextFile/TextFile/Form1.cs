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

namespace TextFile
{
    public partial class Form1 : Form
    {
        string path = @"C:\Users\Stranger\Documents\Visual Studio 2015\Projects\Text_Box\text.txt";
        public Form1()
        {
            InitializeComponent();
           textBox1.Text = File.ReadAllText(path);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addUser_Click(object sender, EventArgs e)
        {
            string temp = " ";
            if (checkBox1.Enabled == true)
            {
                temp = "is Alive";
            }
            else
            {
                temp = "is Dead";
            }
            textBox1.Text += textBox2.Text + " " + textBox3.Text + " " + "is" + " " + numericUpDown1.Value +" " + temp + "\r\n"; 
        }

        private void saveUser_Click(object sender, EventArgs e)
        {
            
            byte[] byt = Encoding.ASCII.GetBytes(textBox1.Text);
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            File.WriteAllBytes(path, byt);
            MessageBox.Show("Saved");
        }
    }
}
