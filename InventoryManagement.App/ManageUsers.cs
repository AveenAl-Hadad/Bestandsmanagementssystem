using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace InventoryManagement.App
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=InventoryDB;Integrated Security=True;Connect Timeout=30");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(UphoneTb.Text == "")
            {
                MessageBox.Show("Geben Sie die Telefonnummer des Benutzers ein");
            }
            else
            {
                con.Open();
                string myquery = " delete from BenutzerTbl where Telefon ='" + UphoneTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Der Benutzer hat erfolgreich gelöscht");
                con.Close();
                populate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void populate()
        {
            try
            {
                con.Open();
                string Myquery = "select * from BenutzerTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UsersGv.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into BenutzerTbl values('" + UnameTb.Text + "','" + FnameTb.Text + "','" + UpasswordTb.Text + "','" + UphoneTb.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Der Benutzer hat erfolgreich hinzufügt");
                con.Close();
                populate() ;
            }
            catch
            {

            }
        }

        private void UsersGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnameTb.Text = UsersGv.SelectedRows[0].Cells[0].Value.ToString();
            FnameTb.Text = UsersGv.SelectedRows[0].Cells[1].Value.ToString();
            UpasswordTb.Text = UsersGv.SelectedRows[0].Cells[2].Value.ToString();
            UphoneTb.Text = UsersGv.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void FnameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
