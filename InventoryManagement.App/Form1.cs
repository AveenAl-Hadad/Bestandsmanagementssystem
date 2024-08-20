namespace InventoryManagement.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordChb_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordChb.Checked == false)
                PasswordTb.UseSystemPasswordChar = true;
            else
                PasswordTb.UseSystemPasswordChar = false;
        }

        private void ClearLb_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PasswordTb.Text = "";
        }
    }
}
