namespace CustomControls
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            mpButton2 = new MPButton();
            mpButton1 = new MPButton();
            panel2 = new Panel();
            mpTextBox1 = new MPTextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(mpTextBox1);
            panel1.Controls.Add(mpButton2);
            panel1.Controls.Add(mpButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 194);
            panel1.TabIndex = 0;
            // 
            // mpButton2
            // 
            mpButton2.BackColor = Color.MediumSlateBlue;
            mpButton2.BackgroundColor = Color.MediumSlateBlue;
            mpButton2.BorderColor = Color.Aqua;
            mpButton2.BorderRadius = 10;
            mpButton2.BorderSize = 1;
            mpButton2.FlatAppearance.BorderSize = 0;
            mpButton2.FlatStyle = FlatStyle.Flat;
            mpButton2.ForeColor = Color.White;
            mpButton2.Location = new Point(693, 89);
            mpButton2.Name = "mpButton2";
            mpButton2.Size = new Size(188, 50);
            mpButton2.TabIndex = 1;
            mpButton2.Text = "mpButton2";
            mpButton2.TextColor = Color.White;
            mpButton2.UseVisualStyleBackColor = false;
            mpButton2.Click += mpButton2_Click;
            // 
            // mpButton1
            // 
            mpButton1.BackColor = Color.MediumSlateBlue;
            mpButton1.BackgroundColor = Color.MediumSlateBlue;
            mpButton1.BorderColor = Color.Aqua;
            mpButton1.BorderRadius = 25;
            mpButton1.BorderSize = 0;
            mpButton1.FlatAppearance.BorderSize = 0;
            mpButton1.FlatStyle = FlatStyle.Flat;
            mpButton1.ForeColor = Color.White;
            mpButton1.Location = new Point(390, 55);
            mpButton1.Name = "mpButton1";
            mpButton1.Size = new Size(188, 50);
            mpButton1.TabIndex = 0;
            mpButton1.Text = "mpButton1";
            mpButton1.TextColor = Color.White;
            mpButton1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(0, 190);
            panel2.Name = "panel2";
            panel2.Size = new Size(1024, 294);
            panel2.TabIndex = 1;
            // 
            // mpTextBox1
            // 
            mpTextBox1.BackColor = SystemColors.Window;
            mpTextBox1.BorderColor = Color.MediumSlateBlue;
            mpTextBox1.BorderFocusColor = Color.HotPink;
            mpTextBox1.BorderRadius = 10;
            mpTextBox1.BorderSize = 2;
            mpTextBox1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mpTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            mpTextBox1.Location = new Point(143, 126);
            mpTextBox1.Margin = new Padding(4);
            mpTextBox1.Multiline = false;
            mpTextBox1.Name = "mpTextBox1";
            mpTextBox1.Padding = new Padding(10, 7, 10, 7);
            mpTextBox1.PasswordChar = false;
            mpTextBox1.PlaceholderColor = Color.DarkGray;
            mpTextBox1.PlaceholderText = "";
            mpTextBox1.Size = new Size(366, 44);
            mpTextBox1.TabIndex = 0;
            mpTextBox1.Texts = "";
            mpTextBox1.UnderlinedStyle = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1024, 485);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private MPButton mpButton1;
        private MPButton mpButton2;
        private MPTextBox mpTextBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
