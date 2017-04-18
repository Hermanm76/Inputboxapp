using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inputboxapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_voerin_Click(object sender, EventArgs e)
        {
            // InputBox box = new InputBox("Wat wil je invoeren?", "tekst invoeren");
            // DialogResult result = box.ShowDialog();
            // if (result == DialogResult.Cancel) label1.Text = null; else label1.Text = box.Value;


            InputBox2 box = new InputBox2(label1,textBox1.Text);
            label1.Text = box.invoerveld();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
