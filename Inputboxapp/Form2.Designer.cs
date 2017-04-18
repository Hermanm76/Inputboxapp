namespace Inputboxapp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.form2_lbl_tekstlabel = new System.Windows.Forms.Label();
            this.form2_txt_input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // form2_lbl_tekstlabel
            // 
            this.form2_lbl_tekstlabel.AutoSize = true;
            this.form2_lbl_tekstlabel.Location = new System.Drawing.Point(34, 41);
            this.form2_lbl_tekstlabel.Name = "form2_lbl_tekstlabel";
            this.form2_lbl_tekstlabel.Size = new System.Drawing.Size(97, 13);
            this.form2_lbl_tekstlabel.TabIndex = 0;
            this.form2_lbl_tekstlabel.Text = "Voer hier je tekst in";
            // 
            // form2_txt_input
            // 
            this.form2_txt_input.Location = new System.Drawing.Point(34, 92);
            this.form2_txt_input.Name = "form2_txt_input";
            this.form2_txt_input.Size = new System.Drawing.Size(165, 20);
            this.form2_txt_input.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Annuleren";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.form2_txt_input);
            this.Controls.Add(this.form2_lbl_tekstlabel);
            this.Name = "Form2";
            this.Text = "Voer in formulier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form2_lbl_tekstlabel;
        public System.Windows.Forms.TextBox form2_txt_input;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}