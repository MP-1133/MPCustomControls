namespace CustomControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mpButton2_Click(object sender, EventArgs e)
        {
            using (InputDialogForm inputDialogForm = new InputDialogForm())
            {
                inputDialogForm.ShowDialog();

                string result = inputDialogForm.Message;
                MessageBox.Show(result);
                // do what ever with result...
            }
        }
    }
}
