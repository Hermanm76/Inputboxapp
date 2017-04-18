using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inputboxapp
{
    class InputBox : Form
    {

        public string Value { get { return txt_Input.Text; } }

        private Label lbl_Prompt;
        private TextBox txt_Input;
        private Button btn_Ok;
        private Button btn_Cancel;
        string defaultValue = null;

        public InputBox(string prompt, string title)
        {
            //form aanmaken en tekst opvragen
            InitializeComponent();

            if (title == null) title = Application.ProductName;
            Text = title;

            lbl_Prompt.Text = prompt;
            Graphics graphics = CreateGraphics();
            lbl_Prompt.Size = graphics.MeasureString(prompt, lbl_Prompt.Font).ToSize();
            int promptWidth = lbl_Prompt.Size.Width;
            int promptHeight = lbl_Prompt.Size.Height;

            txt_Input.Location = new Point(8, 30 + promptHeight);
            int inputWidth = promptWidth < 206 ? 206 : promptWidth;
            txt_Input.Size = new Size(inputWidth, 21);
            txt_Input.Text = defaultValue;
            txt_Input.SelectAll();
            txt_Input.Focus();

            Height = 130 + promptHeight;
            Width = inputWidth + 30;

            btn_Ok.Location = new Point(8, 60 + promptHeight);
            btn_Ok.Size = new Size(100, 26);

            btn_Cancel.Location = new Point(114, 60 + promptHeight);
            btn_Cancel.Size = new Size(100, 26);

            return;

        }
        protected void InitializeComponent()
        {
            lbl_Prompt = new Label();
            lbl_Prompt.Location = new Point(12, 9);
            lbl_Prompt.TabIndex = 0;
            lbl_Prompt.BackColor = Color.Transparent;

            txt_Input = new TextBox();
            txt_Input.Size = new Size(156, 20);
            txt_Input.TabIndex = 1;

            btn_Ok = new Button();
            btn_Ok.TabIndex = 2;
            btn_Ok.Size = new Size(75, 26);
            btn_Ok.Text = "&OK";
            btn_Ok.DialogResult = DialogResult.OK;

            btn_Cancel = new Button();
            btn_Cancel.TabIndex = 3;
            btn_Cancel.Size = new Size(75, 26);
            btn_Cancel.Text = "&Annuleren";
            btn_Cancel.DialogResult = DialogResult.Cancel;

            AcceptButton = btn_Ok;
            CancelButton = btn_Cancel;

            Controls.Add(lbl_Prompt);
            Controls.Add(txt_Input);
            Controls.Add(btn_Ok);
            Controls.Add(btn_Cancel);

            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;


            return;
        }
    }
}
