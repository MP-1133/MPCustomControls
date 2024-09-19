namespace CustomControls
{
    partial class InputDialogForm
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
            mpTextBox1 = new MPTextBox();
            mpButton1 = new MPButton();
            mpTextBox2 = new MPTextBox();
            SuspendLayout();
            // 
            // mpTextBox1
            // 
            mpTextBox1.BackColor = SystemColors.Window;
            mpTextBox1.BorderColor = Color.MediumSlateBlue;
            mpTextBox1.BorderFocusColor = Color.HotPink;
            mpTextBox1.BorderRadius = 0;
            mpTextBox1.BorderSize = 2;
            mpTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mpTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            mpTextBox1.Location = new Point(137, 57);
            mpTextBox1.Margin = new Padding(4);
            mpTextBox1.Multiline = false;
            mpTextBox1.Name = "mpTextBox1";
            mpTextBox1.Padding = new Padding(10, 7, 10, 7);
            mpTextBox1.PasswordChar = false;
            mpTextBox1.PlaceholderColor = Color.DarkGray;
            mpTextBox1.PlaceholderText = "";
            mpTextBox1.Size = new Size(312, 35);
            mpTextBox1.TabIndex = 0;
            mpTextBox1.Texts = "";
            mpTextBox1.UnderlinedStyle = false;
            // 
            // mpButton1
            // 
            mpButton1.BackColor = Color.MediumSlateBlue;
            mpButton1.BackgroundColor = Color.MediumSlateBlue;
            mpButton1.BorderColor = Color.Aqua;
            mpButton1.BorderRadius = 0;
            mpButton1.BorderSize = 0;
            mpButton1.FlatAppearance.BorderSize = 0;
            mpButton1.FlatStyle = FlatStyle.Flat;
            mpButton1.ForeColor = Color.White;
            mpButton1.Location = new Point(354, 127);
            mpButton1.Name = "mpButton1";
            mpButton1.Size = new Size(188, 50);
            mpButton1.TabIndex = 1;
            mpButton1.Text = "mpButton1";
            mpButton1.TextColor = Color.White;
            mpButton1.UseVisualStyleBackColor = false;
            mpButton1.Click += mpButton1_Click;
            // 
            // mpTextBox2
            // 
            mpTextBox2.BackColor = SystemColors.Window;
            mpTextBox2.BorderColor = Color.MediumSlateBlue;
            mpTextBox2.BorderFocusColor = Color.HotPink;
            mpTextBox2.BorderRadius = 0;
            mpTextBox2.BorderSize = 2;
            mpTextBox2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mpTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            mpTextBox2.Location = new Point(25, 127);
            mpTextBox2.Margin = new Padding(4);
            mpTextBox2.Multiline = false;
            mpTextBox2.Name = "mpTextBox2";
            mpTextBox2.Padding = new Padding(10, 7, 10, 7);
            mpTextBox2.PasswordChar = false;
            mpTextBox2.PlaceholderColor = Color.DarkGray;
            mpTextBox2.PlaceholderText = "";
            mpTextBox2.Size = new Size(312, 35);
            mpTextBox2.TabIndex = 2;
            mpTextBox2.Texts = "";
            mpTextBox2.UnderlinedStyle = false;
            // 
            // InputDialogForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(582, 203);
            Controls.Add(mpTextBox2);
            Controls.Add(mpButton1);
            Controls.Add(mpTextBox1);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InputDialogForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "InputDialogForm";
            ResumeLayout(false);
        }

        #endregion

        private MPTextBox mpTextBox1;
        private MPButton mpButton1;
        private MPTextBox mpTextBox2;

        public string Message { get; private set; }
    }
}