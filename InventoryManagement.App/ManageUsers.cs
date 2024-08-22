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
using System.Xml.Linq;
namespace InventoryManagement.App
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=InventoryDB;Integrated Security=True;Connect Timeout=30");
        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Delete
        private void button3_Click(object sender, EventArgs e)
        {
            if (UphoneTb.Text == "")
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
        // Fenster Schließen
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
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Laden der Daten: " + ex.Message);
            }
        }
        // Speichern Button
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into BenutzerTbl values('" + UnameTb.Text + "','" + FnameTb.Text + "','"
                                                                                + UpasswordTb.Text + "','" + UphoneTb.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Der Benutzer wurde erfolgreich hinzufügt");
                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Hinzufügen des Benutzers: " + ex.Message);
            }
        }
        // Tabel anzeigen
        private void UsersGv_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = UsersGv.Rows[e.RowIndex];
                UnameTb.Text = row.Cells[0].Value.ToString();
                FnameTb.Text = row.Cells[1].Value.ToString();
                UpasswordTb.Text = row.Cells[2].Value.ToString();
                UphoneTb.Text = row.Cells[3].Value.ToString();
            }
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void FnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE BenutzerTbl SET [Benutzername] = @Name, [Vollständiger Name] = @FullName, [Kennwort] = @Password WHERE [Telefon] = @Phone";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", UnameTb.Text);
                cmd.Parameters.AddWithValue("@FullName", FnameTb.Text);
                cmd.Parameters.AddWithValue("@Password", UpasswordTb.Text);
                cmd.Parameters.AddWithValue("@Phone", UphoneTb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Benutzer erfolgreich aktualisiert");
                con.Close();
                populate();


                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Aktualisieren des Benutzers: " + ex.Message);
            }
        }
    }
}
