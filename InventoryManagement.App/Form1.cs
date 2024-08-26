using System.Data;
using System.Data.SqlClient;
namespace InventoryManagement.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=InventoryDB;Integrated Security=True;Connect Timeout=30");

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



        private void LoginBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from BenutzerTbl where Benutzername = '" + UnameTb.Text + "' and Kennwort = '" + PasswordTb.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                HomeForm home = new HomeForm();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Falscher Benutzername und falsches Passwort");
            }
            con.Close();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
