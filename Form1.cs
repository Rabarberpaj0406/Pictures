using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pictures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
           openFileDialog1.ShowDialog();
           string filePath = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(filePath);
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filePath = openFileDialog1.FileName;
            pictureBox2.Image = Image.FromFile(filePath);
        }
    }
}
