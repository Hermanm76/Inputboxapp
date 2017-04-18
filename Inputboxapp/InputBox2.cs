using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inputboxapp
{
    class InputBox2
    {
        public static string invoerVeldTekst = "";
        public InputBox2(Label label1, string titel)
        {
            Form2 secondForm = new Form2(label1);
            secondForm.Text = titel;
            secondForm.Visible = true;
            label1.Text = secondForm.form2_txt_input.Text;
            
        }

        public string invoerveld()
        {
            return invoerVeldTekst;
        }
    }
}
