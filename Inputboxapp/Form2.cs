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
    public partial class Form2 : Form
    {

        public Label label;
        public Form2(Label label1)
        {
            InitializeComponent();
            this.label = label1;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputBox2.invoerVeldTekst = form2_txt_input.Text;
            label.Text = form2_txt_input.Text;
            //this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
