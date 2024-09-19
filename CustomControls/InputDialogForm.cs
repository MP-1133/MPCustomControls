using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class InputDialogForm : Form
    {
        public InputDialogForm()
        {
            InitializeComponent();
        }

        private void mpButton1_Click(object sender, EventArgs e)
        {
            Message = mpTextBox1.Texts;
            this.Close();
        }
    }
}
